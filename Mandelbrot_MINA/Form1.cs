using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbrot_MINA
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    const int pixelWidth = 128, pixelHeight = 32;
    const float centerXreset = 1.5f, centerYreset = 1.0f,
      zoomXreset = 1, zoomYreset = 1;

    float centerX = 0, centerY = 0;
    float zoomX = 1, zoomY = 1;

    // https://rbteam.wordpress.com/2011/09/11/arduino-math-test-show-me-a-mandelbrot/
    void CalculateMandel()
    {
      Color[] col = new Color[10]{
        Color.Cyan,Color.Cyan,Color.Cyan,Color.Cyan,Color.Cyan,
        Color.Blue,Color.Red,Color.Green,Color.Yellow,Color.Orange };

      int tholdBW = (int)updnTreshold.Value;
      int tholdCenter = (int)updnCenter.Value;

      pbRealSize.SuspendLayout();
      pbZoomed.SuspendLayout();

      Stopwatch sw = new Stopwatch();
      sw.Start();

      for (int yy = 0; yy < pixelHeight; yy++)
      {
        for (int xx = 0; xx < pixelWidth; xx++)
        {
          float x0 = xx;
          float y0 = yy;
          x0 = x0 / (pixelWidth / 2 * zoomX) - centerX;
          y0 = y0 / (pixelHeight / 2 * zoomY) - centerY;
          // z = z * z + c

          float x = 0f;
          float y = 0f;
          float xtemp = 0f;

          int iter = 0;

          while (((x * x + y * y) < 4) && (iter < 9))
          {
            xtemp = x * x - y * y + x0;
            y = 2 * x * y + y0;
            x = xtemp;
            iter++;
          }

          float z = x * x + y * y;

          // !!! for B/W LCD use only else part !!!
          if (chkColor.Checked)
          {
            if (z < tholdCenter)
              bmp.SetPixel(xx, yy, Color.Black);
            else
              bmp.SetPixel(xx, yy, col[iter]);
          }
          else
          {
            if(z < tholdCenter)
              bmp.SetPixel(xx, yy, Color.DarkGray);
            else
              bmp.SetPixel(xx, yy, (iter > tholdBW) ? Color.Black : Color.White);
          }
        }
      }

      sw.Stop();

      pbZoomed.ResumeLayout();
      pbZoomed.Invalidate();
      pbRealSize.ResumeLayout();
      pbRealSize.Invalidate();

      lblTime.Text = "Time: " + sw.ElapsedMilliseconds + " [ms]";
      lblValues.Text = String.Format("CX: {0} CY: {1}\r\nZX: {2} ZY: {3}\r\nTreshhold: {4}", 
        centerX, centerY, zoomX, zoomY, tholdBW);
    }

    private void chkColor_CheckedChanged(object sender, EventArgs e)
    {
      CalculateMandel();
    }

    private void updnTreshold_ValueChanged(object sender, EventArgs e)
    {
      CalculateMandel();
    }

    private void updnCenter_ValueChanged(object sender, EventArgs e)
    {
      CalculateMandel();
    }

    Bitmap bmp = new Bitmap(pixelWidth, pixelHeight);

    private void btnJoystick_Click(object sender, EventArgs e)
    {
      Button btn = sender as Button;
      if (btn == null)
        return;

      if (btn == btnLeft)
        centerX -= 0.1f / zoomX;
      if (btn == btnRight)
        centerX += 0.1f / zoomX;
      if (btn == btnUp)
        centerY -= 0.1f / zoomY;
      if (btn == btnDown)
        centerY += 0.1f / zoomY;
      if (btn == btnZoomIn)
      {
        zoomX *= 1.5f;
        zoomY *= 1.5f;
      }
      if (btn == btnZoomOut)
      {
        zoomX /= 1.5f;
        zoomY /= 1.5f;
      }
      if (btn == btnReset)
      {
        centerX = centerXreset;
        centerY = centerYreset;
        zoomX = zoomXreset;
        zoomY = zoomYreset;
      }

      CalculateMandel();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      using (Graphics gr = Graphics.FromImage(bmp))
      {
        gr.FillRectangle(Brushes.Aqua, 0, 0, bmp.Width, bmp.Height);
        //        gr.DrawLine(Pens.YellowGreen, 0, 0, bmp.Width - 1, bmp.Height - 1);
      }

      pbRealSize.Image = bmp;
      pbZoomed.Image = bmp;

      updnTreshold.Value = 5;
      updnCenter.Value = 4;
      btnJoystick_Click(btnReset, null);
    }
  }
}
