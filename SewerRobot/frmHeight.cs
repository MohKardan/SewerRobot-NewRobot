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
    public partial class frmHeight : Form
    {
        public frmHeight()
        {
            InitializeComponent();
            double sum = 0;
            double angTmp = 0;

            for(int i=0; i<SharingData.X.Count-1;i++)
            {
                if (i > 0)
                {
                    //sum += (SharingData.X[i] - SharingData.X[i - 1]) * ((float)(SharingData.Avg / 100.0f));
                    //sum += (float)(SharingData.Avg / 100.0f);
                    if (i == 0)
                        chartAngle.Series["Angle"].Points.AddXY(SharingData.X[i], SharingData.Y[i]);
                    else
                    {
                        if (Math.Tan(SharingData.Y[i]) == 0.0)
                            angTmp = 0;
                        else
                            angTmp = (SharingData.X[i] - SharingData.X[i - 1]) / Math.Tan(SharingData.Y[i]);
                        sum += angTmp / 100.0f;
                        chartAngle.Series["Angle"].Points.AddXY(SharingData.X[i], sum);
                    }
                }
            }
        }

        private void frmHeight_FormClosing(object sender, FormClosingEventArgs e)
        {
            string path = System.IO.Path.Combine(SharingData.ReportSubDir, (DateTime.Now.Year * 10000000000 +
                         DateTime.Now.Month * 100000000 +
                         DateTime.Now.Day * 1000000 +
                         DateTime.Now.Hour * 10000 +
                         DateTime.Now.Minute * 100 +
                         DateTime.Now.Second).ToString() + "HIE.jpg");
            chartAngle.SaveImage(path, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
