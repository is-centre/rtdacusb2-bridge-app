namespace RTDACUSB2_Basic
{
    partial class EncoderIForm
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
            this.Counter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IndexActive = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChanNo = new System.Windows.Forms.NumericUpDown();
            this.Close = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.IndexInvert = new System.Windows.Forms.ListBox();
            this.EncoderITimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ChanNo)).BeginInit();
            this.SuspendLayout();
            // 
            // Counter
            // 
            this.Counter.Location = new System.Drawing.Point(108, 199);
            this.Counter.Name = "Counter";
            this.Counter.ReadOnly = true;
            this.Counter.Size = new System.Drawing.Size(106, 20);
            this.Counter.TabIndex = 17;
            this.Counter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Counter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Index Active";
            // 
            // IndexActive
            // 
            this.IndexActive.FormattingEnabled = true;
            this.IndexActive.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.IndexActive.Location = new System.Drawing.Point(155, 95);
            this.IndexActive.Name = "IndexActive";
            this.IndexActive.Size = new System.Drawing.Size(59, 30);
            this.IndexActive.TabIndex = 14;
            this.IndexActive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IndexActive_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Reset";
            // 
            // Reset
            // 
            this.Reset.FormattingEnabled = true;
            this.Reset.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.Reset.Location = new System.Drawing.Point(155, 50);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(59, 30);
            this.Reset.TabIndex = 12;
            this.Reset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Reset_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "EncoderI Channel";
            // 
            // ChanNo
            // 
            this.ChanNo.Location = new System.Drawing.Point(155, 18);
            this.ChanNo.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.ChanNo.Name = "ChanNo";
            this.ChanNo.Size = new System.Drawing.Size(59, 20);
            this.ChanNo.TabIndex = 10;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(114, 240);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(100, 29);
            this.Close.TabIndex = 9;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Index Invert";
            // 
            // IndexInvert
            // 
            this.IndexInvert.FormattingEnabled = true;
            this.IndexInvert.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.IndexInvert.Location = new System.Drawing.Point(155, 140);
            this.IndexInvert.Name = "IndexInvert";
            this.IndexInvert.Size = new System.Drawing.Size(59, 30);
            this.IndexInvert.TabIndex = 18;
            this.IndexInvert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IndexInvert_MouseDown);
            // 
            // EncoderITimer
            // 
            this.EncoderITimer.Enabled = true;
            this.EncoderITimer.Tick += new System.EventHandler(this.EncoderITimer_Tick);
            // 
            // EncoderIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 292);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IndexInvert);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IndexActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChanNo);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EncoderIForm";
            this.Text = "Encoder with Index";
            ((System.ComponentModel.ISupportInitialize)(this.ChanNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Counter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox IndexActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ChanNo;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox IndexInvert;
        private System.Windows.Forms.Timer EncoderITimer;
    }
}