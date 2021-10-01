namespace RTDACUSB2_Basic
{
    partial class ReadForm
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
            this.CloseReadForm = new System.Windows.Forms.Button();
            this.ReadTimer = new System.Windows.Forms.Timer(this.components);
            this.DecHex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseReadForm
            // 
            this.CloseReadForm.Location = new System.Drawing.Point(235, 54);
            this.CloseReadForm.Name = "CloseReadForm";
            this.CloseReadForm.Size = new System.Drawing.Size(95, 29);
            this.CloseReadForm.TabIndex = 0;
            this.CloseReadForm.Text = "Close";
            this.CloseReadForm.UseVisualStyleBackColor = true;
            this.CloseReadForm.Click += new System.EventHandler(this.CloseReadForm_Click);
            // 
            // ReadTimer
            // 
            this.ReadTimer.Enabled = true;
            this.ReadTimer.Tick += new System.EventHandler(this.ReadTimer_Tick);
            // 
            // DecHex
            // 
            this.DecHex.Location = new System.Drawing.Point(93, 54);
            this.DecHex.Name = "DecHex";
            this.DecHex.Size = new System.Drawing.Size(95, 29);
            this.DecHex.TabIndex = 1;
            this.DecHex.Text = "Dec";
            this.DecHex.UseVisualStyleBackColor = true;
            this.DecHex.Click += new System.EventHandler(this.DecHex_Click);
            // 
            // ReadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 118);
            this.Controls.Add(this.DecHex);
            this.Controls.Add(this.CloseReadForm);
            this.Name = "ReadForm";
            this.Text = "Read RTDAC/USB2 Buffer";
            this.Load += new System.EventHandler(this.ReadForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseReadForm;
        private System.Windows.Forms.Timer ReadTimer;
        private System.Windows.Forms.Button DecHex;
    }
}