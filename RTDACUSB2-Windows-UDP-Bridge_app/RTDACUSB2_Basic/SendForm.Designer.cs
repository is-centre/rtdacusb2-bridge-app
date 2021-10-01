namespace RTDACUSB2_Basic
{
    partial class SendForm
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
            this.CloseSendForm = new System.Windows.Forms.Button();
            this.SendBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseSendForm
            // 
            this.CloseSendForm.Location = new System.Drawing.Point(248, 94);
            this.CloseSendForm.Name = "CloseSendForm";
            this.CloseSendForm.Size = new System.Drawing.Size(95, 29);
            this.CloseSendForm.TabIndex = 1;
            this.CloseSendForm.Text = "Close";
            this.CloseSendForm.UseVisualStyleBackColor = true;
            this.CloseSendForm.Click += new System.EventHandler(this.CloseReadForm_Click);
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(126, 94);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(95, 29);
            this.SendBtn.TabIndex = 2;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // SendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 148);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.CloseSendForm);
            this.Name = "SendForm";
            this.Text = "Send RT-DAC/USB Buffer";
            this.Load += new System.EventHandler(this.SendForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseSendForm;
        private System.Windows.Forms.Button SendBtn;
    }
}