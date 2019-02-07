using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
//using WebCamLib;
//using Touchless.Vision.Camera;

namespace TCPServer01
{
   public class Utility
    {
        public byte[] ObjectToByteArray(object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        //PictureBox pictureBoxDisplay = new PictureBox();
        //Camera webCamDefault;
        //private CameraFrameSource FrameSource;
        //private static Bitmap LatestFrame;
        //private Camera CurrentCamera
        //{
        //    get
        //    {
        //        return webCamDefault;
        //    }
        //}

        //public void LoadWebCam()
        //{
        //    if(CameraService.AvailableCameras.Count == 1)
        //    {
        //        webCamDefault = CameraService.AvailableCameras[0];
        //    }
        //}

        //private void SetFrameSource(CameraFrameSource cameraFrameSource)
        //{
        //    if (FrameSource == cameraFrameSource)
        //        return;

        //    FrameSource = cameraFrameSource;
        //}

        //public void OnImageCaptured(Touchless.Vision.Contracts.IFrameSource frameSource, Touchless.Vision.Contracts.Frame frame, double fps)
        //{
        //    LatestFrame = frame.Image;
        //    pictureBoxDisplay.Invalidate();
        //}

        //private void ThrashOldCamera()
        //{
        //    // Trash the old camera
        //    if (FrameSource != null)
        //    {
        //        FrameSource.NewFrame -= OnImageCaptured;
        //        FrameSource.Camera.Dispose();
        //        SetFrameSource(null);
        //        pictureBoxDisplay.Paint -= new PaintEventHandler(DrawLatestImage);
        //    }
        //}

        //private void DrawLatestImage(object sender, PaintEventArgs e)
        //{
        //    if (LatestFrame != null)
        //    {
        //        // Draw the latest image from the active camera
        //        e.Graphics.DrawImage(LatestFrame, 0, 0, LatestFrame.Width, LatestFrame.Height);
        //    }
        //}

        //private void StartCapturing()
        //{
        //    try
        //    {
        //        SetFrameSource(new CameraFrameSource(webCamDefault));
        //        FrameSource.Camera.CaptureWidth = 640;
        //        FrameSource.Camera.CaptureHeight = 480;
        //        FrameSource.Camera.Fps = 50;
        //        FrameSource.NewFrame += OnImageCaptured;

        //        pictureBoxDisplay.Paint += new PaintEventHandler(DrawLatestImage);
        //        FrameSource.StartFrameCapture();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void StartCaptureWebCam()
        //{
        //    if (FrameSource != null && FrameSource.Camera == webCamDefault)
        //        return;

        //    ThrashOldCamera();
        //    StartCapturing();
        //}

        //public void StopCapureWebcam()
        //{
        //    ThrashOldCamera();
        //}

        //public Image CaptureWebCam()
        //{
        //    if (FrameSource == null)
        //        return null;

        //    Bitmap current = (Bitmap)LatestFrame.Clone();

        //    return current;
        //}

        public Image CaptureScreen()
        {
            bool errore = false;
            Rectangle screenSize = Screen.PrimaryScreen.Bounds;
            Bitmap target = new Bitmap(screenSize.Width, screenSize.Height);
            
            try
            {
                using (Graphics g = Graphics.FromImage(target))
                {
                    g.CopyFromScreen(0, 0, 0, 0, new Size(screenSize.Width, screenSize.Height));
                }
                //Image screenshot = (Image)target;
            }
            catch (Exception ecc)
            {
                errore = true;
                MessageBox.Show(ecc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (errore)
                    CaptureScreen();
            }
            return target;
        }
    }
}
