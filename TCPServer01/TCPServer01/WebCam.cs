using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Touchless.Vision.Camera;

namespace TCPServer01
{
    public class WebCam
    {
        PictureBox pictureBoxDisplay = new PictureBox();
        Camera webCamDefault;
        private CameraFrameSource FrameSource;
        private static Bitmap LatestFrame;

        public WebCam()
        {
            LoadWebCam();
        }

        private Camera CurrentCamera
        {
            get
            {
                return webCamDefault;
            }
        }

        public void LoadWebCam()
        {
            if (CameraService.AvailableCameras.Count == 1)
            {
                webCamDefault = CameraService.AvailableCameras[0];
            }
        }

        private void SetFrameSource(CameraFrameSource cameraFrameSource)
        {
            if (FrameSource == cameraFrameSource)
                return;

            FrameSource = cameraFrameSource;
        }

        public void OnImageCaptured(Touchless.Vision.Contracts.IFrameSource frameSource, Touchless.Vision.Contracts.Frame frame, double fps)
        {
            LatestFrame = frame.Image;
            pictureBoxDisplay.Invalidate();
        }

        private void ThrashOldCamera()
        {
            // Trash the old camera
            if (FrameSource != null)
            {
                FrameSource.NewFrame -= OnImageCaptured;
                FrameSource.Camera.Dispose();
                SetFrameSource(null);
                pictureBoxDisplay.Paint -= new PaintEventHandler(DrawLatestImage);
            }
        }

        private void DrawLatestImage(object sender, PaintEventArgs e)
        {
            if (LatestFrame != null)
            {
                // Draw the latest image from the active camera
                e.Graphics.DrawImage(LatestFrame, 0, 0, LatestFrame.Width, LatestFrame.Height);
            }
        }

        private void StartCapturing()
        {
            try
            {
                SetFrameSource(new CameraFrameSource(webCamDefault));
                FrameSource.Camera.CaptureWidth = 640;
                FrameSource.Camera.CaptureHeight = 480;
                FrameSource.Camera.Fps = 50;
                FrameSource.NewFrame += OnImageCaptured;

                pictureBoxDisplay.Paint += new PaintEventHandler(DrawLatestImage);
                FrameSource.StartFrameCapture();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void StartCaptureWebCam()
        {
            if (FrameSource != null && FrameSource.Camera == webCamDefault)
                return;

            ThrashOldCamera();
            StartCapturing();
        }

        public void StopCapureWebcam()
        {
            ThrashOldCamera();
        }

        public Image CaptureWebCam()
        {
            if (FrameSource == null)
                return null;

            Bitmap current = (Bitmap)LatestFrame.Clone();

            return current;
        }
    }
}
