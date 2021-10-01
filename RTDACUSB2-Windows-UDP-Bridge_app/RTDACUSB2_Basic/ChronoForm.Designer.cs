namespace RTDACUSB2_Basic
{
    partial class ChronoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ChanNo = new System.Windows.Forms.NumericUpDown();
            this.Close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EnableBlock = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EnableGate = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InvertStartStop = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.InvertStop = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.InvertGate = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Arm = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BlockStatus = new System.Windows.Forms.TextBox();
            this.PrescalerTB = new System.Windows.Forms.TextBox();
            this.PrescalerScroll = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ChronoTimer = new System.Windows.Forms.Timer(this.components);
            this.CountingMode = new System.Windows.Forms.ListBox();
            this.Counter = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChanNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrescalerScroll)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Chrono Channel";
            // 
            // ChanNo
            // 
            this.ChanNo.Location = new System.Drawing.Point(157, 30);
            this.ChanNo.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.ChanNo.Name = "ChanNo";
            this.ChanNo.Size = new System.Drawing.Size(59, 20);
            this.ChanNo.TabIndex = 13;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(375, 301);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(160, 29);
            this.Close.TabIndex = 12;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Enable block";
            // 
            // EnableBlock
            // 
            this.EnableBlock.FormattingEnabled = true;
            this.EnableBlock.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.EnableBlock.Location = new System.Drawing.Point(157, 56);
            this.EnableBlock.Name = "EnableBlock";
            this.EnableBlock.Size = new System.Drawing.Size(59, 30);
            this.EnableBlock.TabIndex = 16;
            this.EnableBlock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EnableBlock_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Counting mode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Enable gate";
            // 
            // EnableGate
            // 
            this.EnableGate.FormattingEnabled = true;
            this.EnableGate.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.EnableGate.Location = new System.Drawing.Point(157, 92);
            this.EnableGate.Name = "EnableGate";
            this.EnableGate.Size = new System.Drawing.Size(59, 30);
            this.EnableGate.TabIndex = 20;
            this.EnableGate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EnableGate_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Invert StartStop";
            // 
            // InvertStartStop
            // 
            this.InvertStartStop.FormattingEnabled = true;
            this.InvertStartStop.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.InvertStartStop.Location = new System.Drawing.Point(157, 128);
            this.InvertStartStop.Name = "InvertStartStop";
            this.InvertStartStop.Size = new System.Drawing.Size(59, 30);
            this.InvertStartStop.TabIndex = 22;
            this.InvertStartStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InvertStartStop_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Invert Stop";
            // 
            // InvertStop
            // 
            this.InvertStop.FormattingEnabled = true;
            this.InvertStop.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.InvertStop.Location = new System.Drawing.Point(157, 164);
            this.InvertStop.Name = "InvertStop";
            this.InvertStop.Size = new System.Drawing.Size(59, 30);
            this.InvertStop.TabIndex = 24;
            this.InvertStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InvertStop_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Invert Gate";
            // 
            // InvertGate
            // 
            this.InvertGate.FormattingEnabled = true;
            this.InvertGate.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.InvertGate.Location = new System.Drawing.Point(157, 200);
            this.InvertGate.Name = "InvertGate";
            this.InvertGate.Size = new System.Drawing.Size(59, 30);
            this.InvertGate.TabIndex = 26;
            this.InvertGate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InvertGate_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Arm";
            // 
            // Arm
            // 
            this.Arm.FormattingEnabled = true;
            this.Arm.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.Arm.Location = new System.Drawing.Point(157, 272);
            this.Arm.Name = "Arm";
            this.Arm.Size = new System.Drawing.Size(59, 30);
            this.Arm.TabIndex = 28;
            this.Arm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Arm_MouseDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Block status";
            // 
            // BlockStatus
            // 
            this.BlockStatus.Enabled = false;
            this.BlockStatus.Location = new System.Drawing.Point(416, 77);
            this.BlockStatus.Name = "BlockStatus";
            this.BlockStatus.Size = new System.Drawing.Size(119, 20);
            this.BlockStatus.TabIndex = 31;
            this.BlockStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PrescalerTB
            // 
            this.PrescalerTB.Location = new System.Drawing.Point(416, 111);
            this.PrescalerTB.Name = "PrescalerTB";
            this.PrescalerTB.Size = new System.Drawing.Size(119, 20);
            this.PrescalerTB.TabIndex = 34;
            this.PrescalerTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PrescalerTB.Leave += new System.EventHandler(this.PrescalerTB_Leave);
            this.PrescalerTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrescalerTB_KeyPress);
            this.PrescalerTB.Enter += new System.EventHandler(this.PrescalerTB_Enter);
            // 
            // PrescalerScroll
            // 
            this.PrescalerScroll.LargeChange = 1000;
            this.PrescalerScroll.Location = new System.Drawing.Point(261, 148);
            this.PrescalerScroll.Maximum = 65535;
            this.PrescalerScroll.Name = "PrescalerScroll";
            this.PrescalerScroll.Size = new System.Drawing.Size(274, 45);
            this.PrescalerScroll.SmallChange = 100;
            this.PrescalerScroll.TabIndex = 33;
            this.PrescalerScroll.TickFrequency = 1000;
            this.PrescalerScroll.Scroll += new System.EventHandler(this.PrescalerScroll_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Prescaler";
            // 
            // Result
            // 
            this.Result.Enabled = false;
            this.Result.Location = new System.Drawing.Point(416, 236);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(119, 20);
            this.Result.TabIndex = 36;
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(258, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Result";
            // 
            // ChronoTimer
            // 
            this.ChronoTimer.Enabled = true;
            this.ChronoTimer.Tick += new System.EventHandler(this.ChronoTimer_Tick);
            // 
            // CountingMode
            // 
            this.CountingMode.FormattingEnabled = true;
            this.CountingMode.Items.AddRange(new object[] {
            "StartStop is H",
            "StartStop rising edges",
            "StartStop starts, Stop terminates"});
            this.CountingMode.Location = new System.Drawing.Point(375, 19);
            this.CountingMode.Name = "CountingMode";
            this.CountingMode.Size = new System.Drawing.Size(160, 43);
            this.CountingMode.TabIndex = 37;
            this.CountingMode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CountingMode_MouseDown);
            // 
            // Counter
            // 
            this.Counter.Enabled = false;
            this.Counter.Location = new System.Drawing.Point(416, 199);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(119, 20);
            this.Counter.TabIndex = 39;
            this.Counter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(258, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Counter";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Next measurement";
            // 
            // Next
            // 
            this.Next.FormattingEnabled = true;
            this.Next.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.Next.Location = new System.Drawing.Point(157, 236);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(59, 30);
            this.Next.TabIndex = 40;
            this.Next.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Next_MouseDown);
            // 
            // ChronoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 342);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CountingMode);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PrescalerTB);
            this.Controls.Add(this.PrescalerScroll);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BlockStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Arm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.InvertGate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InvertStop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InvertStartStop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EnableGate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EnableBlock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChanNo);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChronoForm";
            this.Text = "Chronometer";
            ((System.ComponentModel.ISupportInitialize)(this.ChanNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrescalerScroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ChanNo;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox EnableBlock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox EnableGate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox InvertStartStop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox InvertStop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox InvertGate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox Arm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BlockStatus;
        private System.Windows.Forms.TextBox PrescalerTB;
        private System.Windows.Forms.TrackBar PrescalerScroll;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer ChronoTimer;
        private System.Windows.Forms.ListBox CountingMode;
        private System.Windows.Forms.TextBox Counter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox Next;
    }
}