namespace HelloWordWithWindows
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
            this.lblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnHello = new System.Windows.Forms.Button();
            this.lblhello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter Your Text :";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(118, 12);
            this.TxtName.Multiline = true;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(445, 20);
            this.TxtName.TabIndex = 1;
            // 
            // BtnHello
            // 
            this.BtnHello.Location = new System.Drawing.Point(118, 48);
            this.BtnHello.Name = "BtnHello";
            this.BtnHello.Size = new System.Drawing.Size(75, 23);
            this.BtnHello.TabIndex = 2;
            this.BtnHello.Text = "Say Hello";
            this.BtnHello.UseVisualStyleBackColor = true;
            this.BtnHello.Click += new System.EventHandler(this.BtnHello_Click);
            // 
            // lblhello
            // 
            this.lblhello.AutoSize = true;
            this.lblhello.Location = new System.Drawing.Point(289, 230);
            this.lblhello.Name = "lblhello";
            this.lblhello.Size = new System.Drawing.Size(0, 13);
            this.lblhello.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 261);
            this.Controls.Add(this.lblhello);
            this.Controls.Add(this.BtnHello);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnHello;
        private System.Windows.Forms.Label lblhello;
    }
}

