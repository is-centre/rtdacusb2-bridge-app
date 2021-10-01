namespace RTDACUSB2_Basic
{
    partial class ADForm
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
            this.components = new System.ComponentModel.Container();
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Gain0 = new System.Windows.Forms.ListBox();
            this.Voltage0 = new System.Windows.Forms.TextBox();
            this.Value0 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Voltage1 = new System.Windows.Forms.TextBox();
            this.Value1 = new System.Windows.Forms.TextBox();
            this.Gain1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Voltage3 = new System.Windows.Forms.TextBox();
            this.Value3 = new System.Windows.Forms.TextBox();
            this.Gain3 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Voltage2 = new System.Windows.Forms.TextBox();
            this.Value2 = new System.Windows.Forms.TextBox();
            this.Gain2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Voltage7 = new System.Windows.Forms.TextBox();
            this.Value7 = new System.Windows.Forms.TextBox();
            this.Gain7 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Voltage6 = new System.Windows.Forms.TextBox();
            this.Value6 = new System.Windows.Forms.TextBox();
            this.Gain6 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Voltage5 = new System.Windows.Forms.TextBox();
            this.Value5 = new System.Windows.Forms.TextBox();
            this.Gain5 = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Voltage4 = new System.Windows.Forms.TextBox();
            this.Value4 = new System.Windows.Forms.TextBox();
            this.Gain4 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Voltage15 = new System.Windows.Forms.TextBox();
            this.Value15 = new System.Windows.Forms.TextBox();
            this.Gain15 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Voltage14 = new System.Windows.Forms.TextBox();
            this.Value14 = new System.Windows.Forms.TextBox();
            this.Gain14 = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Voltage13 = new System.Windows.Forms.TextBox();
            this.Value13 = new System.Windows.Forms.TextBox();
            this.Gain13 = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Voltage12 = new System.Windows.Forms.TextBox();
            this.Value12 = new System.Windows.Forms.TextBox();
            this.Gain12 = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Voltage11 = new System.Windows.Forms.TextBox();
            this.Value11 = new System.Windows.Forms.TextBox();
            this.Gain11 = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Voltage10 = new System.Windows.Forms.TextBox();
            this.Value10 = new System.Windows.Forms.TextBox();
            this.Gain10 = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Voltage9 = new System.Windows.Forms.TextBox();
            this.Value9 = new System.Windows.Forms.TextBox();
            this.Gain9 = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Voltage8 = new System.Windows.Forms.TextBox();
            this.Value8 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.Gain8 = new System.Windows.Forms.ListBox();
            this.label22 = new System.Windows.Forms.Label();
            this.ADTimer = new System.Windows.Forms.Timer(this.components);
            this.CBADStart = new System.Windows.Forms.CheckBox();
            this.CBADReady = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(539, 334);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(156, 29);
            this.Close.TabIndex = 43;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Channel 0";
            // 
            // Gain0
            // 
            this.Gain0.FormattingEnabled = true;
            this.Gain0.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x4",
            "x8",
            "x16"});
            this.Gain0.Location = new System.Drawing.Point(100, 34);
            this.Gain0.Name = "Gain0";
            this.Gain0.Size = new System.Drawing.Size(53, 30);
            this.Gain0.TabIndex = 46;
            this.Gain0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gain0_MouseDown);
            // 
            // Voltage0
            // 
            this.Voltage0.Enabled = false;
            this.Voltage0.Location = new System.Drawing.Point(265, 39);
            this.Voltage0.Name = "Voltage0";
            this.Voltage0.Size = new System.Drawing.Size(68, 20);
            this.Voltage0.TabIndex = 61;
            this.Voltage0.Text = "9.234";
            this.Voltage0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value0
            // 
            this.Value0.Enabled = false;
            this.Value0.Location = new System.Drawing.Point(177, 39);
            this.Value0.Name = "Value0";
            this.Value0.Size = new System.Drawing.Size(68, 20);
            this.Value0.TabIndex = 60;
            this.Value0.Text = "123";
            this.Value0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Voltage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Gain";
            // 
            // Voltage1
            // 
            this.Voltage1.Enabled = false;
            this.Voltage1.Location = new System.Drawing.Point(265, 75);
            this.Voltage1.Name = "Voltage1";
            this.Voltage1.Size = new System.Drawing.Size(68, 20);
            this.Voltage1.TabIndex = 66;
            this.Voltage1.Text = "9.234";
            this.Voltage1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value1
            // 
            this.Value1.Enabled = false;
            this.Value1.Location = new System.Drawing.Point(177, 75);
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(68, 20);
            this.Value1.TabIndex = 65;
            this.Value1.Text = "123";
            this.Value1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Gain1
            // 
            this.Gain1.FormattingEnabled = true;
            this.Gain1.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x4",
            "x8",
            "x16"});
            this.Gain1.Location = new System.Drawing.Point(100, 70);
            this.Gain1.Name = "Gain1";
            this.Gain1.Size = new System.Drawing.Size(53, 30);
            this.Gain1.TabIndex = 64;
            this.Gain1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gain1_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Channel 1";
            // 
            // Voltage3
            // 
            this.Voltage3.Enabled = false;
            this.Voltage3.Location = new System.Drawing.Point(265, 147);
            this.Voltage3.Name = "Voltage3";
            this.Voltage3.Size = new System.Drawing.Size(68, 20);
            this.Voltage3.TabIndex = 74;
            this.Voltage3.Text = "9.234";
            this.Voltage3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value3
            // 
            this.Value3.Enabled = false;
            this.Value3.Location = new System.Drawing.Point(177, 147);
            this.Value3.Name = "Value3";
            this.Value3.Size = new System.Drawing.Size(68, 20);
            this.Value3.TabIndex = 73;
            this.Value3.Text = "123";
            this.Value3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Gain3
            // 
            this.Gain3.FormattingEnabled = true;
            this.Gain3.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x4",
            "x8",
            "x16"});
            this.Gain3.Location = new System.Drawing.Point(100, 142);
            this.Gain3.Name = "Gain3";
            this.Gain3.Size = new System.Drawing.Size(53, 30);
            this.Gain3.TabIndex = 72;
            this.Gain3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gain3_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Channel 3";
            // 
            // Voltage2
            // 
            this.Voltage2.Enabled = false;
            this.Voltage2.Location = new System.Drawing.Point(265, 111);
            this.Voltage2.Name = "Voltage2";
            this.Voltage2.Size = new System.Drawing.Size(68, 20);
            this.Voltage2.TabIndex = 70;
            this.Voltage2.Text = "9.234";
            this.Voltage2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value2
            // 
            this.Value2.Enabled = false;
            this.Value2.Location = new System.Drawing.Point(177, 111);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(68, 20);
            this.Value2.TabIndex = 69;
            this.Value2.Text = "123";
            this.Value2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Gain2
            // 
            this.Gain2.FormattingEnabled = true;
            this.Gain2.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x4",
            "x8",
            "x16"});
            this.Gain2.Location = new System.Drawing.Point(100, 106);
            this.Gain2.Name = "Gain2";
            this.Gain2.Size = new System.Drawing.Size(53, 30);
            this.Gain2.TabIndex = 68;
            this.Gain2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gain2_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Channel 2";
            // 
            // Voltage7
            // 
            this.Voltage7.Enabled = false;
            this.Voltage7.Location = new System.Drawing.Point(265, 291);
            this.Voltage7.Name = "Voltage7";
            this.Voltage7.Size = new System.Drawing.Size(68, 20);
            this.Voltage7.TabIndex = 90;
            this.Voltage7.Text = "9.234";
            this.Voltage7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value7
            // 
            this.Value7.Enabled = false;
            this.Value7.Location = new System.Drawing.Point(177, 291);
            this.Value7.Name = "Value7";
            this.Value7.Size = new System.Drawing.Size(68, 20);
            this.Value7.TabIndex = 89;
            this.Value7.Text = "123";
            this.Value7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Gain7
            // 
            this.Gain7.FormattingEnabled = true;
            this.Gain7.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x4",
            "x8",
            "x16"});
            this.Gain7.Location = new System.Drawing.Point(100, 286);
            this.Gain7.Name = "Gain7";
            this.Gain7.Size = new System.Drawing.Size(53, 30);
            this.Gain7.TabIndex = 88;
            this.Gain7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gain7_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "Channel 7";
            // 
            // Voltage6
            // 
            this.Voltage6.Enabled = false;
            this.Voltage6.Location = new System.Drawing.Point(265, 255);
            this.Voltage6.Name = "Voltage6";
            this.Voltage6.Size = new System.Drawing.Size(68, 20);
            this.Voltage6.TabIndex = 86;
            this.Voltage6.Text = "9.234";
            this.Voltage6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value6
            // 
            this.Value6.Enabled = false;
            this.Value6.Location = new System.Drawing.Point(177, 255);
            this.Value6.Name = "Value6";
            this.Value6.Size = new System.Drawing.Size(68, 20);
            this.Value6.TabIndex = 85;
            this.Value6.Text = "123";
            this.Value6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Gain6
            // 
            this.Gain6.FormattingEnabled = true;
            this.Gain6.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x4",
            "x8",
            "x16"});
            this.Gain6.Location = new System.Drawing.Point(100, 250);
            this.Gain6.Name = "Gain6";
            this.Gain6.Size = new System.Drawing.Size(53, 30);
            this.Gain6.TabIndex = 84;
            this.Gain6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gain6_MouseDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 83;
            this.label9.Text = "Channel 6";
            // 
            // Voltage5
            // 
            this.Voltage5.Enabled = false;
            this.Voltage5.Location = new System.Drawing.Point(265, 219);
            this.Voltage5.Name = "Voltage5";
            this.Voltage5.Size = new System.Drawing.Size(68, 20);
            this.Voltage5.TabIndex = 82;
            this.Voltage5.Text = "9.234";
            this.Voltage5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value5
            // 
            this.Value5.Enabled = false;
            this.Value5.Location = new System.Drawing.Point(177, 219);
            this.Value5.Name = "Value5";
            this.Value5.Size = new System.Drawing.Size(68, 20);
            this.Value5.TabIndex = 81;
            this.Value5.Text = "123";
            this.Value5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Gain5
            // 
            this.Gain5.FormattingEnabled = true;
            this.Gain5.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x4",
            "x8",
            "x16"});
            this.Gain5.Location = new System.Drawing.Point(100, 214);
            this.Gain5.Name = "Gain5";
            this.Gain5.Size = new System.Drawing.Size(53, 30);
            this.Gain5.TabIndex = 80;
            this.Gain5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gain5_MouseDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 79;
            this.label10.Text = "Channel 5";
            // 
            // Voltage4
            // 
            this.Voltage4.Enabled = false;
            this.Voltage4.Location = new System.Drawing.Point(265, 183);
            this.Voltage4.Name = "Voltage4";
            this.Voltage4.Size = new System.Drawing.Size(68, 20);
            this.Voltage4.TabIndex = 78;
            this.Voltage4.Text = "9.234";
            this.Voltage4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value4
            // 
            this.Value4.Enabled = false;
            this.Value4.Location = new System.Drawing.Point(177, 183);
            this.Value4.Name = "Value4";
            this.Value4.Size = new System.Drawing.Size(68, 20);
            this.Value4.TabIndex = 77;
            this.Value4.Text = "123";
            this.Value4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Gain4
            // 
            this.Gain4.FormattingEnabled = true;
            this.Gain4.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x4",
            "x8",
            "x16"});
            this.Gain4.Location = new System.Drawing.Point(100, 178);
            this.Gain4.Name = "Gain4";
            this.Gain4.Size = new System.Drawing.Size(53, 30);
            this.Gain4.TabIndex = 76;
            this.Gain4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gain4_MouseDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 75;
            this.label11.Text = "Channel 4";
            // 
            // Voltage15
            // 
            this.Voltage15.Enabled = false;
            this.Voltage15.Location = new System.Drawing.Point(627, 291);
            this.Voltage15.Name = "Voltage15";
            this.Voltage15.Size = new System.Drawing.Size(68, 20);
            this.Voltage15.TabIndex = 125;
            this.Voltage15.Text = "9.234";
            this.Voltage15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value15
            // 
            this.Value15.Enabled = false;
            this.Value15.Location = new System.Drawing.Point(539, 291);
            this.Value15.Name = "Value15";
            this.Value15.Size = new System.Drawing.Size(68, 20);
            this.Value15.TabIndex = 124;
            this.Value15.Text = "123";
            this.Value15.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Gain15
            // 
            this.Gain15.FormattingEnabled = true;
            this.Gain15.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x4",
            "x8",
            "x16"});
            this.Gain15.Location = new System.Drawing.Point(462, 286);
            this.Gain15.Name = "Gain15";
            this.Gain15.Size = new System.Drawing.Size(53, 30);
            this.Gain15.TabIndex = 123;
            this.Gain15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gain15_MouseDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(396, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 122;
            this.label12.Text = "Channel 15";
            // 
            // Voltage14
            // 
            this.Voltage14.Enabled = false;
            this.Voltage14.Location = new System.Drawing.Point(627, 255);
            this.Voltage14.Name = "Voltage14";
            this.Voltage14.Size = new System.Drawing.Size(68, 20);
            this.Voltage14.TabIndex = 121;
            this.Voltage14.Text = "9.234";
            this.Voltage14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value14
            // 
            this.Value14.Enabled = false;
            this.Value14.Location = new System.Drawing.Point(539, 255);
            this.Value14.Name = "Value14";
            this.Value14.Size = new System.Drawing.Size(68, 20);
            this.Value14.TabIndex = 120;
            this.Value14.Text = "123";
            this.Value14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Gain14
            // 
            this.Gain14.FormattingEnabled = true;
            this.Gain14.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x4",
            "x8",
            "x16"});
            this.Gain14.Location = new System.Drawing.Point(462, 250);
            this.Gain14.Name = "Gain14";
            this.Gain14.Size = new System.Drawing.Size(53, 30);
            this.Gain14.TabIndex = 119;
            this.Gain14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gain14_MouseDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(396, 258);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 118;
            this.label13.Text = "Channel 14";
            // 
            // Voltage13
            // 
            this.Voltage13.Enabled = false;
            this.Voltage13.Location = new System.Drawing.Point(627, 219);
            this.Voltage13.Name = "Voltage13";
            this.Voltage13.Size = new System.Drawing.Size(68, 20);
            this.Voltage13.TabIndex = 117;
            this.Voltage13.Text = "9.234";
            this.Voltage13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value13
            // 
            this.Value13.Enabled = false;
            this.Value13.Location = new System.Drawing.Point(539, 219);
            this.Value13.Name = "Value13";
            this.Value13.Size = new System.Drawing.Size(68, 20);
            this.Value13.TabIndex = 116;
            this.Value13.Text = "123";
            this.Value13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Gain13
            // 
            this.Gain13.FormattingEnabled = true;
            this.Gain13.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x4",
            "x8",
            "x16"});
            this.Gain13.Location = new System.Drawing.Point(462, 214);
            this.Gain13.Name = "Gain13";
            this.Gain13.Size = new System.Drawing.Size(53, 30);
            this.Gain13.TabIndex = 115;
            this.Gain13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gain13_MouseDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(396, 222);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 114;
            this.label14.Text = "Channel 13";
            // 
            // Voltage12
            // 
            this.Voltage12.Enabled = false;
            this.Voltage12.Location = new System.Drawing.Point(627, 183);
            this.Voltage12.Name = "Voltage12";
            this.Voltage12.Size = new System.Drawing.Size(68, 20);
            this.Voltage12.TabIndex = 113;
            this.Voltage12.Text = "9.234";
            this.Voltage12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value12
            // 
            this.Value12.Enabled = false;
            this.Value12.Location = new System.Drawing.Point(539, 183);
            this.Value12.Name = "Value12";
            this.Value12.Size = new System.Drawing.Size(68, 20);
            this.Value12.TabIndex = 112;
            this.Value12.Text = "123";
            this.Value12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Gain12
            // 
            this.Gain12.FormattingEnabled = true;
            this.Gain12.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x4",
            "x8",
            "x16"});
            this.Gain12.Location = new System.Drawing.Point(462, 178);
            this.Gain12.Name = "Gain12";
            this.Gain12.Size = new System.Drawing.Size(53, 30);
            this.Gain12.TabIndex = 111;
            this.Gain12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gain12_MouseDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(396, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 110;
            this.label15.Text = "Channel 12";
            // 
            // Voltage11
            // 
            this.Voltage11.Enabled = false;
            this.Voltage11.Location = new System.Drawing.Point(627, 147);
            this.Voltage11.Name = "Voltage11";
            this.Voltage11.Size = new System.Drawing.Size(68, 20);
            this.Voltage11.TabIndex = 109;
            this.Voltage11.Text = "9.234";
            this.Voltage11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value11
            // 
            this.Value11.Enabled = false;
            this.Value11.Location = new System.Drawing.Point(539, 147);
            this.Value11.Name = "Value11";
            this.Value11.Size = new System.Drawing.Size(68, 20);
            this.Value11.TabIndex = 108;
            this.Value11.Text = "123";
            this.Value11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Gain11
            // 
            this.Gain11.FormattingEnabled = true;
            this.Gain11.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x4",
            "x8",
            "x16"});
            this.Gain11.Location = new System.Drawing.Point(462, 142);
            this.Gain11.Name = "Gain11";
            this.Gain11.Size = new System.Drawing.Size(53, 30);
            this.Gain11.TabIndex = 107;
            this.Gain11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gain11_MouseDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(396, 150);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 106;
            this.label16.Text = "Channel 11";
            // 
            // Voltage10
            // 
            this.Voltage10.Enabled = false;
            this.Voltage10.Location = new System.Drawing.Point(627, 111);
            this.Voltage10.Name = "Voltage10";
            this.Voltage10.Size = new System.Drawing.Size(68, 20);
            this.Voltage10.TabIndex = 105;
            this.Voltage10.Text = "9.234";
            this.Voltage10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value10
            // 
            this.Value10.Enabled = false;
            this.Value10.Location = new System.Drawing.Point(539, 111);
            this.Value10.Name = "Value10";
            this.Value10.Size = new System.Drawing.Size(68, 20);
            this.Value10.TabIndex = 104;
            this.Value10.Text = "123";
            this.Value10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Gain10
            // 
            this.Gain10.FormattingEnabled = true;
            this.Gain10.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x4",
            "x8",
            "x16"});
            this.Gain10.Location = new System.Drawing.Point(462, 106);
            this.Gain10.Name = "Gain10";
            this.Gain10.Size = new System.Drawing.Size(53, 30);
            this.Gain10.TabIndex = 103;
            this.Gain10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gain10_MouseDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(396, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 102;
            this.label17.Text = "Channel 10";
            // 
            // Voltage9
            // 
            this.Voltage9.Enabled = false;
            this.Voltage9.Location = new System.Drawing.Point(627, 75);
            this.Voltage9.Name = "Voltage9";
            this.Voltage9.Size = new System.Drawing.Size(68, 20);
            this.Voltage9.TabIndex = 101;
            this.Voltage9.Text = "9.234";
            this.Voltage9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value9
            // 
            this.Value9.Enabled = false;
            this.Value9.Location = new System.Drawing.Point(539, 75);
            this.Value9.Name = "Value9";
            this.Value9.Size = new System.Drawing.Size(68, 20);
            this.Value9.TabIndex = 100;
            this.Value9.Text = "123";
            this.Value9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Gain9
            // 
            this.Gain9.FormattingEnabled = true;
            this.Gain9.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x4",
            "x8",
            "x16"});
            this.Gain9.Location = new System.Drawing.Point(462, 70);
            this.Gain9.Name = "Gain9";
            this.Gain9.Size = new System.Drawing.Size(53, 30);
            this.Gain9.TabIndex = 99;
            this.Gain9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gain9_MouseDown);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(396, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 98;
            this.label18.Text = "Channel 9";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(473, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 97;
            this.label19.Text = "Gain";
            // 
            // Voltage8
            // 
            this.Voltage8.Enabled = false;
            this.Voltage8.Location = new System.Drawing.Point(627, 39);
            this.Voltage8.Name = "Voltage8";
            this.Voltage8.Size = new System.Drawing.Size(68, 20);
            this.Voltage8.TabIndex = 96;
            this.Voltage8.Text = "9.234";
            this.Voltage8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value8
            // 
            this.Value8.Enabled = false;
            this.Value8.Location = new System.Drawing.Point(539, 39);
            this.Value8.Name = "Value8";
            this.Value8.Size = new System.Drawing.Size(68, 20);
            this.Value8.TabIndex = 95;
            this.Value8.Text = "123";
            this.Value8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(638, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 13);
            this.label20.TabIndex = 94;
            this.label20.Text = "Voltage";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(557, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 13);
            this.label21.TabIndex = 93;
            this.label21.Text = "Value";
            // 
            // Gain8
            // 
            this.Gain8.FormattingEnabled = true;
            this.Gain8.Items.AddRange(new object[] {
            "x1",
            "x2",
            "x4",
            "x8",
            "x16"});
            this.Gain8.Location = new System.Drawing.Point(462, 34);
            this.Gain8.Name = "Gain8";
            this.Gain8.Size = new System.Drawing.Size(53, 30);
            this.Gain8.TabIndex = 92;
            this.Gain8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Gain8_MouseDown);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(396, 42);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 13);
            this.label22.TabIndex = 91;
            this.label22.Text = "Channel 8";
            // 
            // ADTimer
            // 
            this.ADTimer.Enabled = true;
            this.ADTimer.Tick += new System.EventHandler(this.ADTimer_Tick);
            // 
            // CBADStart
            // 
            this.CBADStart.AutoSize = true;
            this.CBADStart.Location = new System.Drawing.Point(100, 344);
            this.CBADStart.Name = "CBADStart";
            this.CBADStart.Size = new System.Drawing.Size(71, 17);
            this.CBADStart.TabIndex = 126;
            this.CBADStart.Text = "A/D Start";
            this.CBADStart.UseVisualStyleBackColor = true;
            // 
            // CBADReady
            // 
            this.CBADReady.AutoSize = true;
            this.CBADReady.Enabled = false;
            this.CBADReady.Location = new System.Drawing.Point(225, 346);
            this.CBADReady.Name = "CBADReady";
            this.CBADReady.Size = new System.Drawing.Size(80, 17);
            this.CBADReady.TabIndex = 127;
            this.CBADReady.Text = "A/D Ready";
            this.CBADReady.UseVisualStyleBackColor = true;
            // 
            // ADForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 383);
            this.Controls.Add(this.CBADReady);
            this.Controls.Add(this.CBADStart);
            this.Controls.Add(this.Voltage15);
            this.Controls.Add(this.Value15);
            this.Controls.Add(this.Gain15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Voltage14);
            this.Controls.Add(this.Value14);
            this.Controls.Add(this.Gain14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Voltage13);
            this.Controls.Add(this.Value13);
            this.Controls.Add(this.Gain13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Voltage12);
            this.Controls.Add(this.Value12);
            this.Controls.Add(this.Gain12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Voltage11);
            this.Controls.Add(this.Value11);
            this.Controls.Add(this.Gain11);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Voltage10);
            this.Controls.Add(this.Value10);
            this.Controls.Add(this.Gain10);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Voltage9);
            this.Controls.Add(this.Value9);
            this.Controls.Add(this.Gain9);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.Voltage8);
            this.Controls.Add(this.Value8);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.Gain8);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.Voltage7);
            this.Controls.Add(this.Value7);
            this.Controls.Add(this.Gain7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Voltage6);
            this.Controls.Add(this.Value6);
            this.Controls.Add(this.Gain6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Voltage5);
            this.Controls.Add(this.Value5);
            this.Controls.Add(this.Gain5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Voltage4);
            this.Controls.Add(this.Value4);
            this.Controls.Add(this.Gain4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Voltage3);
            this.Controls.Add(this.Value3);
            this.Controls.Add(this.Gain3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Voltage2);
            this.Controls.Add(this.Value2);
            this.Controls.Add(this.Gain2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Voltage1);
            this.Controls.Add(this.Value1);
            this.Controls.Add(this.Gain1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Voltage0);
            this.Controls.Add(this.Value0);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Gain0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Name = "ADForm";
            this.Text = "A/D Conversion";
            this.Load += new System.EventHandler(this.ADForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Gain0;
        private System.Windows.Forms.TextBox Voltage0;
        private System.Windows.Forms.TextBox Value0;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Voltage1;
        private System.Windows.Forms.TextBox Value1;
        private System.Windows.Forms.ListBox Gain1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Voltage3;
        private System.Windows.Forms.TextBox Value3;
        private System.Windows.Forms.ListBox Gain3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Voltage2;
        private System.Windows.Forms.TextBox Value2;
        private System.Windows.Forms.ListBox Gain2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Voltage7;
        private System.Windows.Forms.TextBox Value7;
        private System.Windows.Forms.ListBox Gain7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Voltage6;
        private System.Windows.Forms.TextBox Value6;
        private System.Windows.Forms.ListBox Gain6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Voltage5;
        private System.Windows.Forms.TextBox Value5;
        private System.Windows.Forms.ListBox Gain5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Voltage4;
        private System.Windows.Forms.TextBox Value4;
        private System.Windows.Forms.ListBox Gain4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Voltage15;
        private System.Windows.Forms.TextBox Value15;
        private System.Windows.Forms.ListBox Gain15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Voltage14;
        private System.Windows.Forms.TextBox Value14;
        private System.Windows.Forms.ListBox Gain14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Voltage13;
        private System.Windows.Forms.TextBox Value13;
        private System.Windows.Forms.ListBox Gain13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Voltage12;
        private System.Windows.Forms.TextBox Value12;
        private System.Windows.Forms.ListBox Gain12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Voltage11;
        private System.Windows.Forms.TextBox Value11;
        private System.Windows.Forms.ListBox Gain11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Voltage10;
        private System.Windows.Forms.TextBox Value10;
        private System.Windows.Forms.ListBox Gain10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Voltage9;
        private System.Windows.Forms.TextBox Value9;
        private System.Windows.Forms.ListBox Gain9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox Voltage8;
        private System.Windows.Forms.TextBox Value8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ListBox Gain8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Timer ADTimer;
        private System.Windows.Forms.CheckBox CBADStart;
        private System.Windows.Forms.CheckBox CBADReady;
    }
}