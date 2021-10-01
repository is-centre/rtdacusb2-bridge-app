namespace RTDACUSB2_Basic
{
    partial class PWMForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Mode = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChanNo = new System.Windows.Forms.NumericUpDown();
            this.Close = new System.Windows.Forms.Button();
            this.PWMScroll = new System.Windows.Forms.TrackBar();
            this.PrescalerTB = new System.Windows.Forms.TextBox();
            this.WidthTB = new System.Windows.Forms.TextBox();
            this.PWMTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ChanNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PWMScroll)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mode";
            // 
            // Mode
            // 
            this.Mode.FormattingEnabled = true;
            this.Mode.Items.AddRange(new object[] {
            "8-bit",
            "12-bit"});
            this.Mode.Location = new System.Drawing.Point(151, 48);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(59, 30);
            this.Mode.TabIndex = 14;
            this.Mode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mode_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Prescaler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "PWM Channel";
            // 
            // ChanNo
            // 
            this.ChanNo.Location = new System.Drawing.Point(151, 22);
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
            this.Close.Location = new System.Drawing.Point(110, 225);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(100, 29);
            this.Close.TabIndex = 9;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // PWMScroll
            // 
            this.PWMScroll.Location = new System.Drawing.Point(37, 159);
            this.PWMScroll.Maximum = 1023;
            this.PWMScroll.Name = "PWMScroll";
            this.PWMScroll.Size = new System.Drawing.Size(173, 45);
            this.PWMScroll.TabIndex = 17;
            this.PWMScroll.Scroll += new System.EventHandler(this.PWMScroll_Scroll);
            // 
            // PrescalerTB
            // 
            this.PrescalerTB.Location = new System.Drawing.Point(151, 94);
            this.PrescalerTB.Name = "PrescalerTB";
            this.PrescalerTB.Size = new System.Drawing.Size(58, 20);
            this.PrescalerTB.TabIndex = 18;
            this.PrescalerTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PrescalerTB.Leave += new System.EventHandler(this.PrescalerTB_Leave);
            this.PrescalerTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrescalerTB_KeyPress);
            this.PrescalerTB.Enter += new System.EventHandler(this.PrescalerTB_Enter);
            // 
            // WidthTB
            // 
            this.WidthTB.Location = new System.Drawing.Point(151, 126);
            this.WidthTB.Name = "WidthTB";
            this.WidthTB.Size = new System.Drawing.Size(58, 20);
            this.WidthTB.TabIndex = 19;
            this.WidthTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WidthTB.Leave += new System.EventHandler(this.WidthTB_Leave);
            this.WidthTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WidthTB_KeyPress);
            this.WidthTB.Enter += new System.EventHandler(this.WidthTB_Enter);
            // 
            // PWMTimer
            // 
            this.PWMTimer.Enabled = true;
            this.PWMTimer.Tick += new System.EventHandler(this.PWMTimer_Tick);
            // 
            // PWMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 284);
            this.Controls.Add(this.WidthTB);
            this.Controls.Add(this.PrescalerTB);
            this.Controls.Add(this.PWMScroll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChanNo);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChronoForm";
            this.Text = "PWMForm";
            ((System.ComponentModel.ISupportInitialize)(this.ChanNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PWMScroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Mode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ChanNo;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.TrackBar PWMScroll;
        private System.Windows.Forms.TextBox PrescalerTB;
        private System.Windows.Forms.TextBox WidthTB;
        private System.Windows.Forms.Timer PWMTimer;
    }
}