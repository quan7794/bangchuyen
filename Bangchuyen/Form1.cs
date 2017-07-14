using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Bangchuyen
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();
            // sửa 1 dòng làm ví dụ, 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void menu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void cbComp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbComp.DataSource = SerialPort.GetPortNames();
            cbRate.Items.Add(9600);
            cbRate.Items.Add(19200);
            cbRate.Items.Add(38400);
            cbRate.Items.Add(57600);
            cbRate.Items.Add(74880);
            cbRate.Items.Add(115200);
            cbRate.Items.Add(230400);
            cbRate.Items.Add(250000);
            cbRate.SelectedIndex = 3;
            cbRate.Text = serialPort.BaudRate.ToString();
            btnDisconnect.Enabled = false;

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try { 
            if (!serialPort.IsOpen)
            {
                serialPort.PortName = cbComp.SelectedItem.ToString();
                serialPort.BaudRate = int.Parse(cbRate.SelectedItem.ToString());
                serialPort.Open();
                btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;
                    btnConnect.Text = "Đã kết nối";
                    btnConnect.BackColor = Color.Coral;

            }
            }
            catch
            {
                MessageBox.Show("Cổng COMP đang bận", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
           

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            btnConnect.Text = "Kết nối";
            btnConnect.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
