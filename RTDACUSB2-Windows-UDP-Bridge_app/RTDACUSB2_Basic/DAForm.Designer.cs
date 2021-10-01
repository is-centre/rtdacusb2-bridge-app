namespace RTDACUSB2_Basic
{
    partial class DAForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DA0Scroll = new System.Windows.Forms.TrackBar();
            this.DATimer = new System.Windows.Forms.Timer(this.components);
            this.DA1Scroll = new System.Windows.Forms.TrackBar();
            this.DA2Scroll = new System.Windows.Forms.TrackBar();
            this.DA3Scroll = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DA0Value = new System.Windows.Forms.TextBox();
            this.DA0Voltage = new System.Windows.Forms.TextBox();
            this.DA3Value = new System.Windows.Forms.TextBox();
            this.DA2Value = new System.Windows.Forms.TextBox();
            this.DA1Value = new System.Windows.Forms.TextBox();
            this.DA3Voltage = new System.Windows.Forms.TextBox();
            this.DA2Voltage = new System.Windows.Forms.TextBox();
            this.DA1Voltage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DA0Scroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DA1Scroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DA2Scroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DA3Scroll)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(347, 248);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(119, 29);
            this.Close.TabIndex = 43;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Channel 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Channel 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Channel 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Channel 1";
            // 
            // DA0Scroll
            // 
            this.DA0Scroll.Location = new System.Drawing.Point(111, 43);
            this.DA0Scroll.Maximum = 16383;
            this.DA0Scroll.Name = "DA0Scroll";
            this.DA0Scroll.Size = new System.Drawing.Size(173, 45);
            this.DA0Scroll.TabIndex = 48;
            this.DA0Scroll.TickFrequency = 512;
            this.DA0Scroll.Value = 8192;
            this.DA0Scroll.Scroll += new System.EventHandler(this.DA0Scroll_Scroll);
            // 
            // DATimer
            // 
            this.DATimer.Enabled = true;
            this.DATimer.Tick += new System.EventHandler(this.DATimer_Tick);
            // 
            // DA1Scroll
            // 
            this.DA1Scroll.Location = new System.Drawing.Point(111, 86);
            this.DA1Scroll.Maximum = 16383;
            this.DA1Scroll.Name = "DA1Scroll";
            this.DA1Scroll.Size = new System.Drawing.Size(173, 45);
            this.DA1Scroll.TabIndex = 49;
            this.DA1Scroll.TickFrequency = 512;
            this.DA1Scroll.Value = 8192;
            this.DA1Scroll.Scroll += new System.EventHandler(this.DA1Scroll_Scroll);
            // 
            // DA2Scroll
            // 
            this.DA2Scroll.Location = new System.Drawing.Point(111, 136);
            this.DA2Scroll.Maximum = 16383;
            this.DA2Scroll.Name = "DA2Scroll";
            this.DA2Scroll.Size = new System.Drawing.Size(173, 45);
            this.DA2Scroll.TabIndex = 50;
            this.DA2Scroll.TickFrequency = 512;
            this.DA2Scroll.Value = 8192;
            this.DA2Scroll.Scroll += new System.EventHandler(this.DA2Scroll_Scroll);
            // 
            // DA3Scroll
            // 
            this.DA3Scroll.Location = new System.Drawing.Point(111, 186);
            this.DA3Scroll.Maximum = 16383;
            this.DA3Scroll.Name = "DA3Scroll";
            this.DA3Scroll.Size = new System.Drawing.Size(173, 45);
            this.DA3Scroll.TabIndex = 51;
            this.DA3Scroll.TickFrequency = 512;
            this.DA3Scroll.Value = 8192;
            this.DA3Scroll.Scroll += new System.EventHandler(this.DA3Scroll_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "-10.0 V";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "+ 10.0 V";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Voltage";
            // 
            // DA0Value
            // 
            this.DA0Value.Enabled = false;
            this.DA0Value.Location = new System.Drawing.Point(310, 43);
            this.DA0Value.Name = "DA0Value";
            this.DA0Value.Size = new System.Drawing.Size(68, 20);
            this.DA0Value.TabIndex = 56;
            this.DA0Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DA0Voltage
            // 
            this.DA0Voltage.Enabled = false;
            this.DA0Voltage.Location = new System.Drawing.Point(398, 43);
            this.DA0Voltage.Name = "DA0Voltage";
            this.DA0Voltage.Size = new System.Drawing.Size(68, 20);
            this.DA0Voltage.TabIndex = 57;
            this.DA0Voltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DA3Value
            // 
            this.DA3Value.Enabled = false;
            this.DA3Value.Location = new System.Drawing.Point(310, 186);
            this.DA3Value.Name = "DA3Value";
            this.DA3Value.Size = new System.Drawing.Size(68, 20);
            this.DA3Value.TabIndex = 58;
            this.DA3Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DA2Value
            // 
            this.DA2Value.Enabled = false;
            this.DA2Value.Location = new System.Drawing.Point(310, 136);
            this.DA2Value.Name = "DA2Value";
            this.DA2Value.Size = new System.Drawing.Size(68, 20);
            this.DA2Value.TabIndex = 59;
            this.DA2Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DA1Value
            // 
            this.DA1Value.Enabled = false;
            this.DA1Value.Location = new System.Drawing.Point(310, 86);
            this.DA1Value.Name = "DA1Value";
            this.DA1Value.Size = new System.Drawing.Size(68, 20);
            this.DA1Value.TabIndex = 60;
            this.DA1Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DA3Voltage
            // 
            this.DA3Voltage.Enabled = false;
            this.DA3Voltage.Location = new System.Drawing.Point(398, 186);
            this.DA3Voltage.Name = "DA3Voltage";
            this.DA3Voltage.Size = new System.Drawing.Size(68, 20);
            this.DA3Voltage.TabIndex = 61;
            this.DA3Voltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DA2Voltage
            // 
            this.DA2Voltage.Enabled = false;
            this.DA2Voltage.Location = new System.Drawing.Point(398, 136);
            this.DA2Voltage.Name = "DA2Voltage";
            this.DA2Voltage.Size = new System.Drawing.Size(68, 20);
            this.DA2Voltage.TabIndex = 62;
            this.DA2Voltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DA1Voltage
            // 
            this.DA1Voltage.Enabled = false;
            this.DA1Voltage.Location = new System.Drawing.Point(398, 86);
            this.DA1Voltage.Name = "DA1Voltage";
            this.DA1Voltage.Size = new System.Drawing.Size(68, 20);
            this.DA1Voltage.TabIndex = 63;
            this.DA1Voltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 294);
            this.Controls.Add(this.DA1Voltage);
            this.Controls.Add(this.DA2Voltage);
            this.Controls.Add(this.DA3Voltage);
            this.Controls.Add(this.DA1Value);
            this.Controls.Add(this.DA2Value);
            this.Controls.Add(this.DA3Value);
            this.Controls.Add(this.DA0Voltage);
            this.Controls.Add(this.DA0Value);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DA3Scroll);
            this.Controls.Add(this.DA2Scroll);
            this.Controls.Add(this.DA1Scroll);
            this.Controls.Add(this.DA0Scroll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DAForm";
            this.Text = "D/A Conversion";
            ((System.ComponentModel.ISupportInitialize)(this.DA0Scroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DA1Scroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DA2Scroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DA3Scroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar DA0Scroll;
        private System.Windows.Forms.Timer DATimer;
        private System.Windows.Forms.TrackBar DA1Scroll;
        private System.Windows.Forms.TrackBar DA2Scroll;
        private System.Windows.Forms.TrackBar DA3Scroll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DA0Value;
        private System.Windows.Forms.TextBox DA0Voltage;
        private System.Windows.Forms.TextBox DA3Value;
        private System.Windows.Forms.TextBox DA2Value;
        private System.Windows.Forms.TextBox DA1Value;
        private System.Windows.Forms.TextBox DA3Voltage;
        private System.Windows.Forms.TextBox DA2Voltage;
        private System.Windows.Forms.TextBox DA1Voltage;
    }
}