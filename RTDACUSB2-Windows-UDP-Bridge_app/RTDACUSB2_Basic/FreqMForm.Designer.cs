namespace RTDACUSB2_Basic
{
    partial class FreqMForm
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
            this.label13 = new System.Windows.Forms.Label();
            this.SwHwGateStart = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.InvertGate = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SwGate = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.InvertStart = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SwStart = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InfiniteFlag = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Mode = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChanNo = new System.Windows.Forms.NumericUpDown();
            this.Close = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TimerTB = new System.Windows.Forms.TextBox();
            this.TimerScroll = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.FreqMTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.GateMode = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.InvertInput = new System.Windows.Forms.ListBox();
            this.ReadyTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.EnableBlocklabel = new System.Windows.Forms.Label();
            this.EnableBlock = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChanNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerScroll)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 275);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "Gate/Start source";
            // 
            // SwHwGateStart
            // 
            this.SwHwGateStart.FormattingEnabled = true;
            this.SwHwGateStart.Items.AddRange(new object[] {
            "Software",
            "Hardware"});
            this.SwHwGateStart.Location = new System.Drawing.Point(148, 268);
            this.SwHwGateStart.Name = "SwHwGateStart";
            this.SwHwGateStart.Size = new System.Drawing.Size(67, 30);
            this.SwHwGateStart.TabIndex = 57;
            this.SwHwGateStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SwHwGateStart_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Invert Gate";
            // 
            // InvertGate
            // 
            this.InvertGate.FormattingEnabled = true;
            this.InvertGate.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.InvertGate.Location = new System.Drawing.Point(148, 304);
            this.InvertGate.Name = "InvertGate";
            this.InvertGate.Size = new System.Drawing.Size(67, 30);
            this.InvertGate.TabIndex = 55;
            this.InvertGate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InvertGate_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Software Gate";
            // 
            // SwGate
            // 
            this.SwGate.FormattingEnabled = true;
            this.SwGate.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.SwGate.Location = new System.Drawing.Point(148, 232);
            this.SwGate.Name = "SwGate";
            this.SwGate.Size = new System.Drawing.Size(67, 30);
            this.SwGate.TabIndex = 53;
            this.SwGate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SwGate_MouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Invert Start";
            // 
            // InvertStart
            // 
            this.InvertStart.FormattingEnabled = true;
            this.InvertStart.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.InvertStart.Location = new System.Drawing.Point(148, 196);
            this.InvertStart.Name = "InvertStart";
            this.InvertStart.Size = new System.Drawing.Size(67, 30);
            this.InvertStart.TabIndex = 51;
            this.InvertStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InvertStart_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Software start";
            // 
            // SwStart
            // 
            this.SwStart.FormattingEnabled = true;
            this.SwStart.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.SwStart.Location = new System.Drawing.Point(148, 160);
            this.SwStart.Name = "SwStart";
            this.SwStart.Size = new System.Drawing.Size(67, 30);
            this.SwStart.TabIndex = 49;
            this.SwStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SwStart_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Infinite meas.";
            // 
            // InfiniteFlag
            // 
            this.InfiniteFlag.FormattingEnabled = true;
            this.InfiniteFlag.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.InfiniteFlag.Location = new System.Drawing.Point(148, 124);
            this.InfiniteFlag.Name = "InfiniteFlag";
            this.InfiniteFlag.Size = new System.Drawing.Size(67, 30);
            this.InfiniteFlag.TabIndex = 47;
            this.InfiniteFlag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InfiniteFlag_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Mode (not impl.)";
            // 
            // Mode
            // 
            this.Mode.FormattingEnabled = true;
            this.Mode.Items.AddRange(new object[] {
            "Single",
            "Continous"});
            this.Mode.Location = new System.Drawing.Point(148, 88);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(67, 30);
            this.Mode.TabIndex = 45;
            this.Mode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mode_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Chrono Channel";
            // 
            // ChanNo
            // 
            this.ChanNo.Location = new System.Drawing.Point(148, 23);
            this.ChanNo.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.ChanNo.Name = "ChanNo";
            this.ChanNo.Size = new System.Drawing.Size(67, 20);
            this.ChanNo.TabIndex = 43;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(366, 375);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(160, 29);
            this.Close.TabIndex = 42;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Result
            // 
            this.Result.Enabled = false;
            this.Result.Location = new System.Drawing.Point(407, 193);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(119, 20);
            this.Result.TabIndex = 63;
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(249, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Result";
            // 
            // TimerTB
            // 
            this.TimerTB.Location = new System.Drawing.Point(407, 85);
            this.TimerTB.Name = "TimerTB";
            this.TimerTB.Size = new System.Drawing.Size(119, 20);
            this.TimerTB.TabIndex = 61;
            this.TimerTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TimerTB.Leave += new System.EventHandler(this.TimerTB_Leave);
            this.TimerTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimerTB_KeyPress);
            this.TimerTB.Enter += new System.EventHandler(this.TimerTB_Enter);
            // 
            // TimerScroll
            // 
            this.TimerScroll.LargeChange = 1000;
            this.TimerScroll.Location = new System.Drawing.Point(252, 122);
            this.TimerScroll.Maximum = 65535;
            this.TimerScroll.Name = "TimerScroll";
            this.TimerScroll.Size = new System.Drawing.Size(274, 45);
            this.TimerScroll.SmallChange = 100;
            this.TimerScroll.TabIndex = 60;
            this.TimerScroll.TickFrequency = 1000;
            this.TimerScroll.Scroll += new System.EventHandler(this.TimerScroll_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Timer";
            // 
            // FreqMTimer
            // 
            this.FreqMTimer.Enabled = true;
            this.FreqMTimer.Tick += new System.EventHandler(this.FreqMTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Gate mode";
            // 
            // GateMode
            // 
            this.GateMode.FormattingEnabled = true;
            this.GateMode.Items.AddRange(new object[] {
            "Input",
            "Time&Input"});
            this.GateMode.Location = new System.Drawing.Point(148, 340);
            this.GateMode.Name = "GateMode";
            this.GateMode.Size = new System.Drawing.Size(67, 30);
            this.GateMode.TabIndex = 66;
            this.GateMode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GateMode_MouseDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Invert Input";
            // 
            // InvertInput
            // 
            this.InvertInput.FormattingEnabled = true;
            this.InvertInput.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.InvertInput.Location = new System.Drawing.Point(148, 376);
            this.InvertInput.Name = "InvertInput";
            this.InvertInput.Size = new System.Drawing.Size(67, 30);
            this.InvertInput.TabIndex = 64;
            this.InvertInput.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InvertInput_MouseDown);
            // 
            // ReadyTB
            // 
            this.ReadyTB.Enabled = false;
            this.ReadyTB.Location = new System.Drawing.Point(407, 23);
            this.ReadyTB.Name = "ReadyTB";
            this.ReadyTB.Size = new System.Drawing.Size(119, 20);
            this.ReadyTB.TabIndex = 69;
            this.ReadyTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(249, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 68;
            this.label12.Text = "Ready";
            // 
            // EnableBlocklabel
            // 
            this.EnableBlocklabel.AutoSize = true;
            this.EnableBlocklabel.Location = new System.Drawing.Point(31, 56);
            this.EnableBlocklabel.Name = "EnableBlocklabel";
            this.EnableBlocklabel.Size = new System.Drawing.Size(40, 13);
            this.EnableBlocklabel.TabIndex = 71;
            this.EnableBlocklabel.Text = "Enable";
            // 
            // EnableBlock
            // 
            this.EnableBlock.FormattingEnabled = true;
            this.EnableBlock.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.EnableBlock.Location = new System.Drawing.Point(148, 49);
            this.EnableBlock.Name = "EnableBlock";
            this.EnableBlock.Size = new System.Drawing.Size(67, 30);
            this.EnableBlock.TabIndex = 70;
            this.EnableBlock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EnableBlock_MouseDown);
            // 
            // FreqMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 422);
            this.Controls.Add(this.EnableBlocklabel);
            this.Controls.Add(this.EnableBlock);
            this.Controls.Add(this.ReadyTB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GateMode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.InvertInput);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TimerTB);
            this.Controls.Add(this.TimerScroll);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SwHwGateStart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.InvertGate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SwGate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InvertStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SwStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InfiniteFlag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChanNo);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FreqMForm";
            this.Text = "Frequencymeter";
            ((System.ComponentModel.ISupportInitialize)(this.ChanNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerScroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox SwHwGateStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox InvertGate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox SwGate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox InvertStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox SwStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox InfiniteFlag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Mode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ChanNo;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TimerTB;
        private System.Windows.Forms.TrackBar TimerScroll;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer FreqMTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox GateMode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox InvertInput;
        private System.Windows.Forms.TextBox ReadyTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label EnableBlocklabel;
        private System.Windows.Forms.ListBox EnableBlock;
    }
}