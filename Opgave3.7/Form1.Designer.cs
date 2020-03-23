namespace Opgave3._7
{
    partial class Form1
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
            this.maskedTextBoxInput = new System.Windows.Forms.MaskedTextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedTextBoxInput
            // 
            this.maskedTextBoxInput.Location = new System.Drawing.Point(408, 78);
            this.maskedTextBoxInput.Mask = "00-00-0000";
            this.maskedTextBoxInput.Name = "maskedTextBoxInput";
            this.maskedTextBoxInput.Size = new System.Drawing.Size(299, 31);
            this.maskedTextBoxInput.TabIndex = 0;
            this.maskedTextBoxInput.ValidatingType = typeof(System.DateTime);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(12, 81);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(275, 25);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Type the date in the format:";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(408, 181);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(156, 53);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(17, 298);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(0, 25);
            this.labelDate.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.maskedTextBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxInput;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelDate;
    }
}

