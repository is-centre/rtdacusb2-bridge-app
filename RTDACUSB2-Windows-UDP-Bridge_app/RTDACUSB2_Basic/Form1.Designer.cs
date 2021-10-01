namespace RTDACUSB2_Basic
{
    partial class BasicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicForm));
            this.Close = new System.Windows.Forms.Button();
            this.BoardList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ReadBuffer = new System.Windows.Forms.Button();
            this.DeviceTreeView = new System.Windows.Forms.TreeView();
            this.Descr = new System.Windows.Forms.Label();
            this.SendBuffer = new System.Windows.Forms.Button();
            this.TmrCntShow = new System.Windows.Forms.Button();
            this.DigitalIOShow = new System.Windows.Forms.Button();
            this.PWMShow = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.Button();
            this.MainFormTimer = new System.Windows.Forms.Timer(this.components);
            this.ChronoShow = new System.Windows.Forms.Button();
            this.FreqMShow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FPGAVersion = new System.Windows.Forms.TextBox();
            this.FPGAName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SynthesisDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NoOfPWMEncEncI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NoOfTmrCntTmcCnt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NoOfGenFreqMChrono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ADShow = new System.Windows.Forms.Button();
            this.DAShow = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtOutPort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStartRealTime = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtInPort = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(367, 476);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(100, 29);
            this.Close.TabIndex = 0;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // BoardList
            // 
            this.BoardList.FormattingEnabled = true;
            this.BoardList.Location = new System.Drawing.Point(22, 38);
            this.BoardList.Name = "BoardList";
            this.BoardList.Size = new System.Drawing.Size(456, 21);
            this.BoardList.TabIndex = 1;
            this.BoardList.SelectedIndexChanged += new System.EventHandler(this.BoardList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Read/Send Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReadBuffer
            // 
            this.ReadBuffer.Location = new System.Drawing.Point(26, 476);
            this.ReadBuffer.Name = "ReadBuffer";
            this.ReadBuffer.Size = new System.Drawing.Size(100, 29);
            this.ReadBuffer.TabIndex = 3;
            this.ReadBuffer.Text = "Read Buffer";
            this.ReadBuffer.UseVisualStyleBackColor = true;
            this.ReadBuffer.Click += new System.EventHandler(this.ReadBuffer_Click);
            // 
            // DeviceTreeView
            // 
            this.DeviceTreeView.Location = new System.Drawing.Point(22, 74);
            this.DeviceTreeView.Name = "DeviceTreeView";
            this.DeviceTreeView.Size = new System.Drawing.Size(238, 154);
            this.DeviceTreeView.TabIndex = 4;
            // 
            // Descr
            // 
            this.Descr.AutoSize = true;
            this.Descr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Descr.Location = new System.Drawing.Point(28, 10);
            this.Descr.Name = "Descr";
            this.Descr.Size = new System.Drawing.Size(60, 13);
            this.Descr.TabIndex = 5;
            this.Descr.Text = "Description";
            // 
            // SendBuffer
            // 
            this.SendBuffer.Location = new System.Drawing.Point(26, 441);
            this.SendBuffer.Name = "SendBuffer";
            this.SendBuffer.Size = new System.Drawing.Size(100, 29);
            this.SendBuffer.TabIndex = 6;
            this.SendBuffer.Text = "Send Buffer";
            this.SendBuffer.UseVisualStyleBackColor = true;
            this.SendBuffer.Click += new System.EventHandler(this.SendBuffer_Click);
            // 
            // TmrCntShow
            // 
            this.TmrCntShow.Location = new System.Drawing.Point(24, 305);
            this.TmrCntShow.Name = "TmrCntShow";
            this.TmrCntShow.Size = new System.Drawing.Size(100, 29);
            this.TmrCntShow.TabIndex = 7;
            this.TmrCntShow.Text = "Tmr / Cnt";
            this.TmrCntShow.UseVisualStyleBackColor = true;
            this.TmrCntShow.Click += new System.EventHandler(this.TmrCntShow_Click);
            // 
            // DigitalIOShow
            // 
            this.DigitalIOShow.Location = new System.Drawing.Point(24, 270);
            this.DigitalIOShow.Name = "DigitalIOShow";
            this.DigitalIOShow.Size = new System.Drawing.Size(100, 29);
            this.DigitalIOShow.TabIndex = 8;
            this.DigitalIOShow.Text = "Digital I/O";
            this.DigitalIOShow.UseVisualStyleBackColor = true;
            this.DigitalIOShow.Click += new System.EventHandler(this.DigitalIOShow_Click);
            // 
            // PWMShow
            // 
            this.PWMShow.Location = new System.Drawing.Point(141, 270);
            this.PWMShow.Name = "PWMShow";
            this.PWMShow.Size = new System.Drawing.Size(100, 29);
            this.PWMShow.TabIndex = 9;
            this.PWMShow.Text = "PWM";
            this.PWMShow.UseVisualStyleBackColor = true;
            this.PWMShow.Click += new System.EventHandler(this.PWMShow_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "EncoderI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(141, 476);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(100, 29);
            this.Test.TabIndex = 11;
            this.Test.Text = "Misc Tests";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // MainFormTimer
            // 
            this.MainFormTimer.Tick += new System.EventHandler(this.MainFormTimer_Tick);
            // 
            // ChronoShow
            // 
            this.ChronoShow.Location = new System.Drawing.Point(24, 340);
            this.ChronoShow.Name = "ChronoShow";
            this.ChronoShow.Size = new System.Drawing.Size(100, 29);
            this.ChronoShow.TabIndex = 12;
            this.ChronoShow.Text = "Chrono";
            this.ChronoShow.UseVisualStyleBackColor = true;
            this.ChronoShow.Click += new System.EventHandler(this.ChronoShow_Click);
            // 
            // FreqMShow
            // 
            this.FreqMShow.Location = new System.Drawing.Point(141, 340);
            this.FreqMShow.Name = "FreqMShow";
            this.FreqMShow.Size = new System.Drawing.Size(100, 29);
            this.FreqMShow.TabIndex = 13;
            this.FreqMShow.Text = "FreqM";
            this.FreqMShow.UseVisualStyleBackColor = true;
            this.FreqMShow.Click += new System.EventHandler(this.FreqMShow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(292, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Version";
            // 
            // FPGAVersion
            // 
            this.FPGAVersion.Enabled = false;
            this.FPGAVersion.Location = new System.Drawing.Point(394, 75);
            this.FPGAVersion.Name = "FPGAVersion";
            this.FPGAVersion.Size = new System.Drawing.Size(84, 20);
            this.FPGAVersion.TabIndex = 64;
            this.FPGAVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FPGAName
            // 
            this.FPGAName.Enabled = false;
            this.FPGAName.Location = new System.Drawing.Point(394, 101);
            this.FPGAName.Name = "FPGAName";
            this.FPGAName.Size = new System.Drawing.Size(84, 20);
            this.FPGAName.TabIndex = 66;
            this.FPGAName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(292, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Name";
            // 
            // SynthesisDate
            // 
            this.SynthesisDate.Enabled = false;
            this.SynthesisDate.Location = new System.Drawing.Point(394, 127);
            this.SynthesisDate.Name = "SynthesisDate";
            this.SynthesisDate.Size = new System.Drawing.Size(84, 20);
            this.SynthesisDate.TabIndex = 68;
            this.SynthesisDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(292, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Synthesis date";
            // 
            // NoOfPWMEncEncI
            // 
            this.NoOfPWMEncEncI.Enabled = false;
            this.NoOfPWMEncEncI.Location = new System.Drawing.Point(415, 153);
            this.NoOfPWMEncEncI.Name = "NoOfPWMEncEncI";
            this.NoOfPWMEncEncI.Size = new System.Drawing.Size(63, 20);
            this.NoOfPWMEncEncI.TabIndex = 70;
            this.NoOfPWMEncEncI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(292, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "No of PWM/Enc/EncI";
            // 
            // NoOfTmrCntTmcCnt
            // 
            this.NoOfTmrCntTmcCnt.Enabled = false;
            this.NoOfTmrCntTmcCnt.Location = new System.Drawing.Point(415, 179);
            this.NoOfTmrCntTmcCnt.Name = "NoOfTmrCntTmcCnt";
            this.NoOfTmrCntTmcCnt.Size = new System.Drawing.Size(63, 20);
            this.NoOfTmrCntTmcCnt.TabIndex = 72;
            this.NoOfTmrCntTmcCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(292, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 71;
            this.label5.Text = "No of Tmr/Cnt/TmrCnt";
            // 
            // NoOfGenFreqMChrono
            // 
            this.NoOfGenFreqMChrono.Enabled = false;
            this.NoOfGenFreqMChrono.Location = new System.Drawing.Point(415, 205);
            this.NoOfGenFreqMChrono.Name = "NoOfGenFreqMChrono";
            this.NoOfGenFreqMChrono.Size = new System.Drawing.Size(63, 20);
            this.NoOfGenFreqMChrono.TabIndex = 74;
            this.NoOfGenFreqMChrono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(292, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "No of Gen/Freq/Chrono";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ADShow);
            this.groupBox1.Controls.Add(this.DAShow);
            this.groupBox1.Location = new System.Drawing.Point(12, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 183);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RT-DAC/USB2 I/O";
            // 
            // ADShow
            // 
            this.ADShow.Location = new System.Drawing.Point(12, 132);
            this.ADShow.Name = "ADShow";
            this.ADShow.Size = new System.Drawing.Size(100, 29);
            this.ADShow.TabIndex = 77;
            this.ADShow.Text = "A / D";
            this.ADShow.UseVisualStyleBackColor = true;
            this.ADShow.Click += new System.EventHandler(this.ADShow_Click);
            // 
            // DAShow
            // 
            this.DAShow.Location = new System.Drawing.Point(129, 133);
            this.DAShow.Name = "DAShow";
            this.DAShow.Size = new System.Drawing.Size(100, 29);
            this.DAShow.TabIndex = 76;
            this.DAShow.Text = "D / A";
            this.DAShow.UseVisualStyleBackColor = true;
            this.DAShow.Click += new System.EventHandler(this.DAShow_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtInPort);
            this.groupBox2.Controls.Add(this.lblInfo);
            this.groupBox2.Controls.Add(this.txtOutPort);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnStartRealTime);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(278, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 204);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simulink RT connection via UDP";
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(16, 98);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(172, 64);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "When RT comms are running, the\r\nreadings from 4 first analog inputs\r\nare sent to " +
    "MATLAB *when* an \r\ninput packet is received with values\r\nto be written into the " +
    "DAQ\'s 4 outputs.";
            // 
            // txtOutPort
            // 
            this.txtOutPort.Location = new System.Drawing.Point(72, 67);
            this.txtOutPort.Name = "txtOutPort";
            this.txtOutPort.Size = new System.Drawing.Size(117, 20);
            this.txtOutPort.TabIndex = 5;
            this.txtOutPort.Text = "6555";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Out Port";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnStartRealTime
            // 
            this.btnStartRealTime.Enabled = false;
            this.btnStartRealTime.Location = new System.Drawing.Point(11, 165);
            this.btnStartRealTime.Name = "btnStartRealTime";
            this.btnStartRealTime.Size = new System.Drawing.Size(177, 29);
            this.btnStartRealTime.TabIndex = 2;
            this.btnStartRealTime.Text = "Start Real-Time Comms";
            this.btnStartRealTime.UseVisualStyleBackColor = true;
            this.btnStartRealTime.Click += new System.EventHandler(this.btnStartRealTime_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "In Port";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 517);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(492, 22);
            this.statusStrip1.TabIndex = 77;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtStatus
            // 
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(59, 17);
            this.txtStatus.Text = "Not ready";
            // 
            // txtInPort
            // 
            this.txtInPort.Location = new System.Drawing.Point(71, 32);
            this.txtInPort.Name = "txtInPort";
            this.txtInPort.Size = new System.Drawing.Size(117, 20);
            this.txtInPort.TabIndex = 7;
            this.txtInPort.Text = "5666";
            this.txtInPort.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // BasicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 539);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SendBuffer);
            this.Controls.Add(this.NoOfGenFreqMChrono);
            this.Controls.Add(this.ReadBuffer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NoOfTmrCntTmcCnt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NoOfPWMEncEncI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SynthesisDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FPGAName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FPGAVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FreqMShow);
            this.Controls.Add(this.ChronoShow);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PWMShow);
            this.Controls.Add(this.DigitalIOShow);
            this.Controls.Add(this.TmrCntShow);
            this.Controls.Add(this.Descr);
            this.Controls.Add(this.DeviceTreeView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BoardList);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BasicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RT-DAC/USB2 Basic";
            this.Load += new System.EventHandler(this.BasicForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtOutPort;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Label lblInfo;

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ComboBox BoardList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ReadBuffer;
        private System.Windows.Forms.TreeView DeviceTreeView;
        private System.Windows.Forms.Label Descr;
        private System.Windows.Forms.Button SendBuffer;
        private System.Windows.Forms.Button TmrCntShow;
        private System.Windows.Forms.Button DigitalIOShow;
        private System.Windows.Forms.Button PWMShow;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.Timer MainFormTimer;
        private System.Windows.Forms.Button ChronoShow;
        private System.Windows.Forms.Button FreqMShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FPGAVersion;
        private System.Windows.Forms.TextBox FPGAName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SynthesisDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NoOfPWMEncEncI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NoOfTmrCntTmcCnt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NoOfGenFreqMChrono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ADShow;
        private System.Windows.Forms.Button DAShow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnStartRealTime;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtStatus;
        private System.Windows.Forms.TextBox txtInPort;
    }
}

