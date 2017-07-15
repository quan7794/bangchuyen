namespace Bangchuyen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbComp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cbRate = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.DtPicker = new System.Windows.Forms.DateTimePicker();
            this.button7 = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tbAbout = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnExportWord = new System.Windows.Forms.Button();
            this.preview = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbStability = new System.Windows.Forms.TextBox();
            this.tbFailedRate = new System.Windows.Forms.TextBox();
            this.tbFailedWeight = new System.Windows.Forms.TextBox();
            this.tbFailedLocation = new System.Windows.Forms.TextBox();
            this.tbComment = new System.Windows.Forms.RichTextBox();
            this.tbAdvice = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbColorCode = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnServo1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.tbPepsiLight = new System.Windows.Forms.TextBox();
            this.tbPepsiNormal = new System.Windows.Forms.TextBox();
            this.tbFail = new System.Windows.Forms.TextBox();
            this.tbFailedlRate = new System.Windows.Forms.TextBox();
            this.tbPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tabPage6.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbComp
            // 
            this.cbComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComp.FormattingEnabled = true;
            this.cbComp.Location = new System.Drawing.Point(162, 3);
            this.cbComp.Name = "cbComp";
            this.cbComp.Size = new System.Drawing.Size(120, 24);
            this.cbComp.TabIndex = 1;
            this.cbComp.SelectedIndexChanged += new System.EventHandler(this.cbComp_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cổng";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(82, 35);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 17);
            this.label22.TabIndex = 3;
            this.label22.Text = "Baud rate:";
            // 
            // cbRate
            // 
            this.cbRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRate.FormattingEnabled = true;
            this.cbRate.Location = new System.Drawing.Point(162, 32);
            this.cbRate.Name = "cbRate";
            this.cbRate.Size = new System.Drawing.Size(120, 24);
            this.cbRate.TabIndex = 4;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(316, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(121, 53);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(471, 2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(132, 53);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Ngắt kết nối";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // DtPicker
            // 
            this.DtPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtPicker.Location = new System.Drawing.Point(755, 5);
            this.DtPicker.Name = "DtPicker";
            this.DtPicker.Size = new System.Drawing.Size(199, 22);
            this.DtPicker.TabIndex = 17;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(4, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(58, 53);
            this.button7.TabIndex = 18;
            this.button7.Text = "F5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.AllowDrop = true;
            this.tabPage6.Controls.Add(this.tbAbout);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(973, 456);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "About";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tbAbout
            // 
            this.tbAbout.Location = new System.Drawing.Point(28, 19);
            this.tbAbout.Name = "tbAbout";
            this.tbAbout.ReadOnly = true;
            this.tbAbout.Size = new System.Drawing.Size(914, 414);
            this.tbAbout.TabIndex = 0;
            this.tbAbout.Text = "";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.preview);
            this.tabPage5.Controls.Add(this.btnExportWord);
            this.tabPage5.Controls.Add(this.btnExportExcel);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(973, 430);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Xuất";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(34, 106);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(112, 61);
            this.btnExportExcel.TabIndex = 0;
            this.btnExportExcel.Text = "Xuất ra excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnExportWord
            // 
            this.btnExportWord.Location = new System.Drawing.Point(34, 183);
            this.btnExportWord.Name = "btnExportWord";
            this.btnExportWord.Size = new System.Drawing.Size(112, 59);
            this.btnExportWord.TabIndex = 1;
            this.btnExportWord.Text = "Xuất ra Word";
            this.btnExportWord.UseVisualStyleBackColor = true;
            // 
            // preview
            // 
            this.preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preview.BackColor = System.Drawing.Color.Silver;
            this.preview.Location = new System.Drawing.Point(190, 41);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(695, 332);
            this.preview.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(187, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 17);
            this.label21.TabIndex = 4;
            this.label21.Text = "Preview";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(973, 456);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Biểu đồ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbAdvice);
            this.tabPage3.Controls.Add(this.tbComment);
            this.tabPage3.Controls.Add(this.tbFailedLocation);
            this.tabPage3.Controls.Add(this.tbFailedWeight);
            this.tabPage3.Controls.Add(this.tbFailedRate);
            this.tabPage3.Controls.Add(this.tbStability);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(973, 456);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Phân tích";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(63, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(168, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Độ ổn định của hệ thống:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(63, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(213, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Tần suất xuất hiện sản phẩm lỗi:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(63, 198);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(258, 17);
            this.label17.TabIndex = 2;
            this.label17.Text = "Khối lượng trung bình của sản phẩm lỗi:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(63, 249);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(190, 17);
            this.label18.TabIndex = 3;
            this.label18.Text = "Vị trí xuất hiện lỗi nhiều nhất:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(63, 303);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 17);
            this.label19.TabIndex = 4;
            this.label19.Text = "Nhận xét:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(63, 362);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 17);
            this.label20.TabIndex = 5;
            this.label20.Text = "Lời khuyên:";
            // 
            // tbStability
            // 
            this.tbStability.Location = new System.Drawing.Point(323, 93);
            this.tbStability.Name = "tbStability";
            this.tbStability.Size = new System.Drawing.Size(275, 22);
            this.tbStability.TabIndex = 10;
            // 
            // tbFailedRate
            // 
            this.tbFailedRate.Location = new System.Drawing.Point(323, 140);
            this.tbFailedRate.Name = "tbFailedRate";
            this.tbFailedRate.Size = new System.Drawing.Size(275, 22);
            this.tbFailedRate.TabIndex = 10;
            // 
            // tbFailedWeight
            // 
            this.tbFailedWeight.Location = new System.Drawing.Point(323, 193);
            this.tbFailedWeight.Name = "tbFailedWeight";
            this.tbFailedWeight.Size = new System.Drawing.Size(275, 22);
            this.tbFailedWeight.TabIndex = 10;
            // 
            // tbFailedLocation
            // 
            this.tbFailedLocation.Location = new System.Drawing.Point(323, 244);
            this.tbFailedLocation.Name = "tbFailedLocation";
            this.tbFailedLocation.Size = new System.Drawing.Size(616, 22);
            this.tbFailedLocation.TabIndex = 10;
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(323, 272);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(616, 63);
            this.tbComment.TabIndex = 11;
            this.tbComment.Text = "";
            // 
            // tbAdvice
            // 
            this.tbAdvice.Location = new System.Drawing.Point(323, 341);
            this.tbAdvice.Name = "tbAdvice";
            this.tbAdvice.Size = new System.Drawing.Size(616, 63);
            this.tbAdvice.TabIndex = 11;
            this.tbAdvice.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.tabPage2.Controls.Add(this.btnServo1);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.tbColorCode);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage2.Size = new System.Drawing.Size(973, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chức năng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 50);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Servo 1:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 142);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Sensor tiệm cận 1:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 186);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(134, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cảm biến cân nặng:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 99);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Servo 2:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 269);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(128, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Cảm biến màu sắc:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 308);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label12.Size = new System.Drawing.Size(156, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Đèn cảm biến màu sắc:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 227);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(140, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Cảm biến tiệm cận 2:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 348);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(61, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "Servo 3:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(75, 22);
            this.textBox1.TabIndex = 11;
            // 
            // tbColorCode
            // 
            this.tbColorCode.Location = new System.Drawing.Point(296, 260);
            this.tbColorCode.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.tbColorCode.Multiline = true;
            this.tbColorCode.Name = "tbColorCode";
            this.tbColorCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbColorCode.Size = new System.Drawing.Size(100, 34);
            this.tbColorCode.TabIndex = 13;
            this.tbColorCode.Text = "Mã màu";
            this.tbColorCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(215, 299);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 34);
            this.button8.TabIndex = 15;
            this.button8.Text = "ON";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(215, 260);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 34);
            this.button4.TabIndex = 15;
            this.button4.Text = "ON";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(215, 218);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 34);
            this.button6.TabIndex = 15;
            this.button6.Text = "ON";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "ON";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "ON";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(215, 133);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 34);
            this.button5.TabIndex = 15;
            this.button5.Text = "ON";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnServo1
            // 
            this.btnServo1.Location = new System.Drawing.Point(215, 41);
            this.btnServo1.Name = "btnServo1";
            this.btnServo1.Size = new System.Drawing.Size(193, 34);
            this.btnServo1.TabIndex = 15;
            this.btnServo1.Text = "ON";
            this.btnServo1.UseVisualStyleBackColor = true;
            this.btnServo1.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(973, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbPanel);
            this.panel2.Controls.Add(this.tbFailedlRate);
            this.panel2.Controls.Add(this.tbFail);
            this.panel2.Controls.Add(this.tbPepsiNormal);
            this.panel2.Controls.Add(this.tbPepsiLight);
            this.panel2.Controls.Add(this.tbSum);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(39, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 369);
            this.panel2.TabIndex = 16;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tổng số lon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pepsi Light:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pepsi thường";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Số lon bị lỗi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tần suất xuất hiện lỗi:";
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(167, 10);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(100, 22);
            this.tbSum.TabIndex = 17;
            // 
            // tbPepsiLight
            // 
            this.tbPepsiLight.Location = new System.Drawing.Point(447, 11);
            this.tbPepsiLight.Name = "tbPepsiLight";
            this.tbPepsiLight.Size = new System.Drawing.Size(100, 22);
            this.tbPepsiLight.TabIndex = 18;
            // 
            // tbPepsiNormal
            // 
            this.tbPepsiNormal.Location = new System.Drawing.Point(706, 11);
            this.tbPepsiNormal.Name = "tbPepsiNormal";
            this.tbPepsiNormal.Size = new System.Drawing.Size(100, 22);
            this.tbPepsiNormal.TabIndex = 19;
            // 
            // tbFail
            // 
            this.tbFail.Location = new System.Drawing.Point(167, 47);
            this.tbFail.Name = "tbFail";
            this.tbFail.Size = new System.Drawing.Size(100, 22);
            this.tbFail.TabIndex = 20;
            // 
            // tbFailedlRate
            // 
            this.tbFailedlRate.Location = new System.Drawing.Point(447, 52);
            this.tbFailedlRate.Name = "tbFailedlRate";
            this.tbFailedlRate.Size = new System.Drawing.Size(100, 22);
            this.tbFailedlRate.TabIndex = 21;
            // 
            // tbPanel
            // 
            this.tbPanel.ColumnCount = 2;
            this.tbPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbPanel.Location = new System.Drawing.Point(0, 95);
            this.tbPanel.Name = "tbPanel";
            this.tbPanel.RowCount = 2;
            this.tbPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbPanel.Size = new System.Drawing.Size(893, 273);
            this.tbPanel.TabIndex = 22;
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(0, 59);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(981, 459);
            this.tabControl1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(755, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(630, 35);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(121, 17);
            this.label23.TabIndex = 20;
            this.label23.Text = "Thời gian kết thúc";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(630, 10);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(119, 17);
            this.label24.TabIndex = 21;
            this.label24.Text = "Thời gian bắt đầu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 512);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.DtPicker);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cbRate);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbComp);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(997, 559);
            this.MinimumSize = new System.Drawing.Size(997, 559);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage6.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbComp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbRate;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.DateTimePicker DtPicker;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.RichTextBox tbAbout;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel preview;
        private System.Windows.Forms.Button btnExportWord;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox tbAdvice;
        private System.Windows.Forms.RichTextBox tbComment;
        private System.Windows.Forms.TextBox tbFailedLocation;
        private System.Windows.Forms.TextBox tbFailedWeight;
        private System.Windows.Forms.TextBox tbFailedRate;
        private System.Windows.Forms.TextBox tbStability;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnServo1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox tbColorCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tbPanel;
        private System.Windows.Forms.TextBox tbFailedlRate;
        private System.Windows.Forms.TextBox tbFail;
        private System.Windows.Forms.TextBox tbPepsiNormal;
        private System.Windows.Forms.TextBox tbPepsiLight;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
    }
}

