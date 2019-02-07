using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TCPServer01
{
    public class FuncRemote
    {
        Principale ObjFrm1;
        public FuncRemote(Principale _frm1)
        {
            ObjFrm1 = _frm1;
        }
        
        public string GetProcessi()
        {
            string listaProcessi = "";

            foreach (Process processo in Process.GetProcesses())
            {
                if (processo != null)
                    listaProcessi = listaProcessi + processo.ProcessName + "|" + processo.Id + "|" + processo.MachineName + "|" + processo.BasePriority + '\n';
            }

            string[] ottieniProc = listaProcessi.Split('\n');
            Array.Sort(ottieniProc);
            string[] ordinaProc = new string[ottieniProc.Length-1];
            Array.Copy(ottieniProc,1, ordinaProc,0, ottieniProc.Length - 1);
            listaProcessi = "";
            for (int i = 0; i < ordinaProc.Length; i++)
            {
                listaProcessi = ((ordinaProc[i] != null) && (i < ordinaProc.Length - 1)) ? listaProcessi = listaProcessi + ordinaProc[i] + Environment.NewLine : listaProcessi = listaProcessi + ordinaProc[i];
            }
            return listaProcessi;
        }

        public void ChiudiProcesso(string _procKill)
        {            //da verificare se il processo esiste realmente
            if (_procKill[_procKill.Length - 1] == '\n')
                _procKill = _procKill.Substring(0, (_procKill.Length - 1));

            foreach (Process processo in Process.GetProcessesByName(_procKill))
            {
                processo.Kill();
            }
            ObjFrm1.TrasmettiMex2(_procKill + " terminato!" + Environment.NewLine);
        }

        public void AvviaCmd(string _comando)
        {            //fixare bug che l'invio delle " le codifica così: \"
            //_comando.Replace('\',' ');
            //string appo = "";
            string[] cmdSenzaQuoteMarks = _comando.Split('"');
            //forse conviene usare il match
            //if (_comando.Contains('"'))
            //{
                //for(int i = 0; i < _comando.Length; i++)
                //{
                //    if((i == _comando.Length) && (_comando[i] != '"'))
                //    {
                //        appo = appo + _comando[i];
                //    }
                //    if((_comando[i] == '"') && (i<_comando.Length))
                //    {
                //        if(_comando[++i] != '"')
                //        {
                //            appo = appo + _comando[++i];
                //        }
                //    }
                //}
            //}
            Process.Start("cmd", _comando);
        }

        public void GetScreen(string _comando, Timer _tmr1, ref bool _imgRic, ref bool _prmAvvio)
        {//start, stop e intervallo
            string[] appo = _comando.Split(' ');

            if (appo[0] == "start")
            {
                //TrasmettiImmagine(CaptureScreen());
                _tmr1.Interval = Convert.ToInt32(appo[1]);
                _tmr1.Start();
                ////TrasmettiMex2("Condivisione iniziata!");
            }
            else
            {
                _tmr1.Stop();
                _imgRic = false;
                _prmAvvio = true;
                //TrasmettiMex2("Condivisione terminata!");
            }
        }

        public void GetWebcam(string _comando, Timer _tmr, ref bool _imgWebRic, ref bool _prmWebAvvio, WebCam _objWebCam)
        {//start, stop e intervallo
            string[] appo = _comando.Split(' ');

            if (appo[0] == "start")
            {
                _tmr.Interval = Convert.ToInt32(appo[1]);
                _objWebCam.StartCaptureWebCam();
                _tmr.Start();
            }
            else
            {
                _objWebCam.StopCapureWebcam();
                _tmr.Stop();
                _imgWebRic = false;
                _prmWebAvvio = true;
            }
        }

        public void SetCoordCursore(string _comando/*, Cursor _crs*/)
        {
            try
            {
                string[] appoCoord = _comando.Split(';');
                //_crs = new Cursor(Cursor.Current.Handle);
                Cursor.Position = new Point(Convert.ToInt32(appoCoord[0]), Convert.ToInt32(appoCoord[1]));
            }
            catch { }

        }

        public void SetKeyStroke(string _comando)
        {
            char keyStroke = Convert.ToChar(Convert.ToInt64(_comando));
            SendKeys.Send(keyStroke.ToString());
            //SendMessage(FindWindowEx,_comando,)
        }

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        //This simulates a left mouse click
        public void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }
    }
}
