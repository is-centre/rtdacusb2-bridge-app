namespace RTDACUSB2_Basic
{
    partial class TmrCntForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TmrCntForm));
            this.Close = new System.Windows.Forms.Button();
            this.ChanNo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Mode = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Counter = new System.Windows.Forms.TextBox();
            this.TmrCntTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ChanNo)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(99, 199);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(100, 29);
            this.Close.TabIndex = 0;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // ChanNo
            // 
            this.ChanNo.Location = new System.Drawing.Point(140, 26);
            this.ChanNo.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChanNo.Name = "ChanNo";
            this.ChanNo.Size = new System.Drawing.Size(59, 20);
            this.ChanNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tmr/Cnt Channel";
            // 
            // Reset
            // 
            this.Reset.FormattingEnabled = true;
            this.Reset.Items.AddRange(new object[] {
            "Off",
            "On"});
            this.Reset.Location = new System.Drawing.Point(140, 88);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(59, 30);
            this.Reset.TabIndex = 3;
            this.Reset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Reset_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mode";
            // 
            // Mode
            // 
            this.Mode.FormattingEnabled = true;
            this.Mode.Items.AddRange(new object[] {
            "Conter",
            "Timer"});
            this.Mode.Location = new System.Drawing.Point(140, 52);
            this.Mode.Name = "Mode";
            this.Mode.Size = new System.Drawing.Size(59, 30);
            this.Mode.TabIndex = 5;
            this.Mode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mode_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Counter";
            // 
            // Counter
            // 
            this.Counter.Location = new System.Drawing.Point(93, 158);
            this.Counter.Name = "Counter";
            this.Counter.ReadOnly = true;
            this.Counter.Size = new System.Drawing.Size(106, 20);
            this.Counter.TabIndex = 8;
            this.Counter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TmrCntTimer
            // 
            this.TmrCntTimer.Enabled = true;
            this.TmrCntTimer.Tick += new System.EventHandler(this.TmrCntTimer_Tick);
            // 
            // TmrCntForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 253);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Mode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChanNo);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TmrCntForm";
            this.Text = "TmrCntForm";
            ((System.ComponentModel.ISupportInitialize)(this.ChanNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.NumericUpDown ChanNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Mode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Counter;
        private System.Windows.Forms.Timer TmrCntTimer;
    }
}