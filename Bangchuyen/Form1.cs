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
using System.Threading;

namespace Bangchuyen
{
    public   partial class Form1 : Form
    {
        private SerialPort serialPort;
        private String recievedData;


        //public void ThreadForFunction()
        //{
        //    //MessageBox.Show("Da chay thread!");
        //    while (serialPort.IsOpen==true)
        //    {
        //        try {
        //            data = serialPort.ReadLine();
        //            String[] substrings = data.Split(' ');
        //            substrings[1] = substrings[1].Substring(0, substrings[1].Length - 1);
        //            switch (substrings[0])
        //            {
        //                case "servo1":
        //                    btnServo1.Invoke(new Action(() => btnServo1.Text = substrings[1]));
        //                    break;
        //                case "servo2":
        //                    btnServo2.Invoke(new Action(() => btnServo2.Text = substrings[1]));
        //                    break;
        //                case "tiemcan1":
        //                    btnTiemcan1.Invoke(new Action(() => btnTiemcan1.Text = substrings[1]));
        //                    break;
        //                case "weight":
        //                    tbSensorWeight.Invoke(new Action(() => tbSensorWeight.Text = substrings[1]));
        //                    break;
        //                case "tiemcan2":
        //                    btnTiemcan2.Invoke(new Action(() => btnTiemcan2.Text = substrings[1]));
        //                    break;
        //                case "color":
        //                    btnColorValue.Invoke(new Action(() => btnColorValue.Text = substrings[1]));
        //                    break;
        //                case "flashsensor":
        //                    btnFlashColorSensor.Invoke(new Action(() => btnFlashColorSensor.Text = substrings[1]));
        //                    break;
        //                case "servo3":
        //                    btnServo3.Invoke(new Action(() => btnServo3.Text = substrings[1]));
        //                    break;
                        
                            
        //            }
        //        } catch
        //        {

        //        }

        //}
        //}
        public Form1()
        {
            InitializeComponent();
            

        }
        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        

        public void Form1_Load(object sender, EventArgs e)
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
            cbRate.SelectedIndex = 0;
            //cbRate.Text = serialPort.BaudRate.ToString();
            btnDisconnect.Enabled = false;

           // startThread = new Thread(new ThreadStart(ThreadForFunction));

        }
        #region Recieve data
        private void btnConnect_Click(object sender, EventArgs e)
        {

            serialPort = new SerialPort();
            serialPort.PortName = cbComp.SelectedItem.ToString();
            serialPort.BaudRate = int.Parse(cbRate.SelectedItem.ToString());
            serialPort.DataReceived += SerialPort_DataReceived;
            try
            {
                serialPort.Open();
                if(serialPort.IsOpen)
                {
                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;
                    btnConnect.Text = "Đã kết nối";
                    btnConnect.BackColor = Color.Coral;
                    //btnServo1.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
                {
                    recievedData = serialPort.ReadLine();
                    this.Invoke(new EventHandler(displaydata_event));
                }
                catch {}
        }

        private void displaydata_event(object sender, EventArgs e)
        {
            //btnServo1.Text = recievedData;
            String[] substrings = recievedData.Split(' ');
            substrings[1] = substrings[1].Substring(0, substrings[1].Length - 1);
            switch (substrings[0])
            {
                case "servo1":
                    btnServo1.Text = substrings[1]+" độ";
                    break;
                case "servo2":
                    btnServo2.Text = substrings[1];
                    break;
                case "tiemcan1":
                    btnTiemcan1.Text = substrings[1];
                    break;
                case "weight":
                    tbSensorWeight.Text = substrings[1];
                    break;
                case "tiemcan2":
                    btnTiemcan2.Text = substrings[1];
                    break;
                case "color":
                   btnColorValue.Text = substrings[1];
                    break;
                case "flashsensor":
                    btnFlashColorSensor.Text = substrings[1];
                    break;
                case "servo3":
                    btnServo3.Text = substrings[1];
                    break;


            }

        }
        #endregion
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            btnConnect.Text = "Kết nối";
            btnConnect.BackColor = Color.White;
        }
        


        private void Refresh_Click(object sender, EventArgs e)
        {
            cbComp.DataSource = SerialPort.GetPortNames();
            cbRate.SelectedIndex = 3;
            //cbRate.Text = serialPort.BaudRate.ToString();
            btnDisconnect.Enabled = false;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try {
            serialPort.Close();
            }
            catch { }
        }
    }
}
