using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SewerRobot
{
    public partial class frmConnect : Form
    {
        private frmMain mainForm = null;

        public frmConnect(Form callingForm)
        {
            mainForm = callingForm as frmMain;
            InitializeComponent();
            BindSerialPorts();
            cmbBaudRate.SelectedIndex = 0;
        }
        
        private void BindSerialPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                this.cmbPorts.Items.Add(port);
            }

            //if (this.cmbPorts.Items.Count == 0)
            //{
            //    MessageBox.Show(".اتصال یو اس بی یافت نشد");
            //}

            //else
            {
                this.cmbPorts.SelectedIndex = 0;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            mainForm.comPortConnect(cmbBaudRate.Text, cmbPorts.Text);
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
