using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SewerRobot
{
    public partial class frmAngle : Form
    {
        public frmAngle()
        {
            InitializeComponent();
            double sum = 0;
            double min = 0, max=0;
            double angTmp = 0;
            for(int i=0; i<SharingData.Y.Count-1;i++)
            {
                //if (Math.Abs(SharingData.Y[i] - SharingData.Y[i + 1]) < 20)
                    //chartAngle.Series["Angle"].Points.AddXY((SharingData.X[i] == 0 ? 0.001 : SharingData.X[i]), SharingData.Y[i]);
                if(i==0)
                chartAngle.Series["Angle"].Points.AddXY(SharingData.X[i], SharingData.Y[i]);
                else
                {
                    if (Math.Tan(SharingData.Y[i]) == 0.0)
                        angTmp = 0;
                    else
                        angTmp =  (SharingData.X[i]-SharingData.X[i-1])/Math.Tan(SharingData.Y[i]);
                
                    chartAngle.Series["Angle"].Points.AddXY(SharingData.X[i], angTmp);
                }
                sum += angTmp;
                if (SharingData.Y[i] > max)
                    max = SharingData.Y[i];
                else if (SharingData.Y[i] < min)
                    min = SharingData.Y[i];
            }
            if (SharingData.X.Count > 0)
                SharingData.Avg = sum / SharingData.X[SharingData.X.Count - 1]; //(max-min)/SharingData.X.Last();
            double p = SharingData.Avg;// *100 / 90;
            tssLblAvgAngle.Text = p.ToString("#.##");
            //chartAngle.SaveImage(SharingData.ReportSubDir + "\\AVG.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void frmAngle_FormClosing(object sender, FormClosingEventArgs e)
        {
            string path = System.IO.Path.Combine(SharingData.ReportSubDir, (DateTime.Now.Year * 10000000000 +
                         DateTime.Now.Month * 100000000 +
                         DateTime.Now.Day * 1000000 +
                         DateTime.Now.Hour * 10000 +
                         DateTime.Now.Minute * 100 +
                         DateTime.Now.Second).ToString() + "AVG.jpg");
            chartAngle.SaveImage(path, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
