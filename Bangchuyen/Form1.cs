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
using System.Data.SqlClient;
namespace Bangchuyen
{
    public   partial class Form1 : Form
    {
        private SerialPort serialPort;
        private String recievedData;
        SqlConnection myConnection = new SqlConnection("user id = sa;" +
                                        "password=123456;server=QUANMTSE61192\\SQLEXPRESS;" +
                                       "Trusted_Connection=yes;" +
                                       "database=bangchuyen; " +
                                       "connection timeout=5");
        SqlCommand cmd; SqlDataAdapter adapt;
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
            // TODO: This line of code loads data into the 'bangchuyenDataSet.Data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.bangchuyenDataSet.Data);
            dtPicker2.MinDate = DtPicker.Value;

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
            btnDisconnect.Enabled = false;
            try
            {
                myConnection.Open();
                 MessageBox.Show("Kết nối thành công!");
                cmd = new SqlCommand("insert into Data(Name, Weight, ColorR, ColorG, ColorB, okLight,okNormal) " +
                    "values(@name, @weight, @colorr, @colorg, @colorb,@oklight,@oknormal)", myConnection);

                cmd.Parameters.AddWithValue("@name", DateTime.Parse("2017-01-01 00:00:00"));
                cmd.Parameters.AddWithValue("@weight", 350);
                cmd.Parameters.AddWithValue("@colorr", 230);
                cmd.Parameters.AddWithValue("@colorg", 123);
                cmd.Parameters.AddWithValue("@colorb", 123);
                cmd.Parameters.AddWithValue("@oklight", 1);
                cmd.Parameters.AddWithValue("@oknormal", 0);
                cmd.ExecuteNonQuery();
                myConnection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
            var a = myConnection.Database.ToList();
            #region load data from db
            using (BangchuyenDataSet db = new BangchuyenDataSet())
            {

                ChartOverview.DataSource = db.Data.ToList();
                ChartOverview.Series["Đạt"].XValueMember = "Số lượng";
                ChartOverview.Series["Đạt"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                ChartOverview.Series["Lỗi"].YValueMembers = "Năm";
                ChartOverview.Series["Lỗi"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            }
            #endregion

            //#region chart
            //ChartAll.Series["Đạt"].Points.AddXY("Tháng 1", 12);
            //ChartAll.Series["Đạt"].Points.AddXY("Tháng 2", 23);
            //ChartAll.Series["Lỗi"].Points.AddXY("Tháng 1", 34);
            //ChartAll.Series["Lỗi"].Points.AddXY("Tháng 1", 45);
            //ChartAll.Series["Đạt"].Points.AddXY("Tháng 2", 56);
            //ChartAll.Series["Đạt"].Points.AddXY("Tháng 2", 34);
            //ChartAll.Series["Lỗi"].Points.AddXY("Tháng 2", 67);
            //#endregion


        }
        #region Recieve data
        private void btnConnect_Click(object sender, EventArgs e)
        {
            
            serialPort = new SerialPort();
            
            try
            {
                serialPort.PortName = cbComp.SelectedItem.ToString();
                serialPort.BaudRate = int.Parse(cbRate.SelectedItem.ToString());
                serialPort.DataReceived += SerialPort_DataReceived;
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
            if(substrings.Length ==2) substrings[1] = substrings[1].Substring(0, substrings[1].Length - 1);
            switch (substrings[0])
            {
                case "servo1":
                    btnServo1.Text = substrings[1];
                    break;
                case "servo2":
                    btnServo2.Text = substrings[1];
                    break;
                case "tiemcan1":
                    btnTiemcan1.Text = substrings[1].Equals("0")?"Phát hiện vật thể":"Không phát hiện vật thể";
                    break;
                case "weight":
                    tbSensorWeight.Text = substrings[1];
                    break;
                case "tiemcan2":
                    btnTiemcan2.Text = substrings[1].Equals("0") ? "Phát hiện vật thể" : "Không phát hiện vật thể";
                    break;
                case "color":
                    substrings[3] = substrings[3].Substring(0, substrings[3].Length - 1);
                    btnColorValue.BackColor = Color.FromArgb(int.Parse(substrings[1]), 
                                                             int.Parse(substrings[2]), 
                                                             int.Parse(substrings[3]));
                    tbHex.Text = "#"+int.Parse(substrings[1]).ToString("X2")
                        + int.Parse(substrings[2]).ToString("X2")
                        + int.Parse(substrings[3]).ToString("X2");
                    tbRGB.Text = "R:" + substrings[1] + " G:" + substrings[2] + " B:" + substrings[3];
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
            btnDisconnect.Enabled = false;
        }
        


        private void Refresh_Click(object sender, EventArgs e)
        {
            cbComp.DataSource = SerialPort.GetPortNames();
            cbRate.SelectedIndex = 0;
            btnDisconnect.Enabled = false;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //    if(serialPort.IsOpen)
            //    serialPort.Close();
            Application.Exit();
            
        }

        private void DtPicker_ValueChanged(object sender, EventArgs e)
        {
            dtPicker2.MinDate = DtPicker.Value;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch(tabControl1.SelectedIndex)
            {
                case 0:    //for information tab
                    MessageBox.Show("hhi");
                    break;
                case 1: // function tab
                    break;
                case 2: //phan tich tab
                    break;
                case 3: // chart tab
                    //try
                    //{
                    //    myConnection.Open();
                    //    // MessageBox.Show("Kết nối thành công!");
                    //    cmd = new SqlCommand("insert into Data(Name, Weight, ColorR, ColorG, ColorB, okLight,okNormal) " +
                    //        "values(@name, @weight, @colorr, @colorg, @colorb,@oklight,@oknormal)", myConnection);

                    //    cmd.Parameters.AddWithValue("@name", DateTime.Parse("2017-01-01 00:00:00"));
                    //    cmd.Parameters.AddWithValue("@weight", 350);
                    //    cmd.Parameters.AddWithValue("@colorr", 230);
                    //    cmd.Parameters.AddWithValue("@colorg", 123);
                    //    cmd.Parameters.AddWithValue("@colorb", 123);
                    //    cmd.Parameters.AddWithValue("@oklight", 1);
                    //    cmd.Parameters.AddWithValue("@oknormal", 0);
                    //    cmd.ExecuteNonQuery();
                    //    myConnection.Close();


                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(ex.Message, "Lỗi");
                    //}
                    //var a = myConnection.Database.ToList();
                    //#region load data from db
                    //using (BangchuyenDataSet db = new BangchuyenDataSet())
                    //{

                    //    ChartOverview.DataSource = db.Data.ToList();
                    //    ChartOverview.Series["Đạt"].XValueMember = "Số lượng";
                    //    ChartOverview.Series["Đạt"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                    //    ChartOverview.Series["Lỗi"].YValueMembers = "Năm";
                    //    ChartOverview.Series["Lỗi"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                    //}
                    //#endregion
                    break;
                case 4: // export tab
                    break;
                case 5: //tabAbout tab
                    break;

            }
        }
    }
}
