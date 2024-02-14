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
            for(int i=0; i<SharingData.Y.Count-1;i++)
            {
                //if (Math.Abs(SharingData.Y[i] - SharingData.Y[i + 1]) < 20)
                    //chartAngle.Series["Angle"].Points.AddXY((SharingData.X[i] == 0 ? 0.001 : SharingData.X[i]), SharingData.Y[i]);
                chartAngle.Series["Angle"].Points.AddXY(SharingData.X[i], SharingData.Y[i]);
                //sum += SharingData.Y[i];
                if (SharingData.Y[i] > max)
                    max = SharingData.Y[i];
                else if (SharingData.Y[i] < min)
                    min = SharingData.Y[i];
            }
            if(SharingData.X.Count>0)
            SharingData.Avg = (max-min)/SharingData.X.Last();
            double p = SharingData.Avg;// *100 / 90;
            tssLblAvgAngle.Text = "متوسط شیب: " + p.ToString() + "%";
            chartAngle.SaveImage(SharingData.ReportSubDir + "\\nemodar.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
