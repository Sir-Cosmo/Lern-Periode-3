namespace LP3_Taschenrechner
{
    partial class Form2
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
            this.Blue_BTN = new System.Windows.Forms.Button();
            this.Btn_red = new System.Windows.Forms.Button();
            this.White_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Blue_BTN
            // 
            this.Blue_BTN.BackColor = System.Drawing.SystemColors.Highlight;
            this.Blue_BTN.Enabled = false;
            this.Blue_BTN.Location = new System.Drawing.Point(208, 185);
            this.Blue_BTN.Name = "Blue_BTN";
            this.Blue_BTN.Size = new System.Drawing.Size(98, 68);
            this.Blue_BTN.TabIndex = 0;
            this.Blue_BTN.Text = "Blue";
            this.Blue_BTN.UseVisualStyleBackColor = false;
            this.Blue_BTN.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Btn_red
            // 
            this.Btn_red.BackColor = System.Drawing.Color.Red;
            this.Btn_red.Location = new System.Drawing.Point(524, 184);
            this.Btn_red.Name = "Btn_red";
            this.Btn_red.Size = new System.Drawing.Size(88, 69);
            this.Btn_red.TabIndex = 1;
            this.Btn_red.Text = "Red";
            this.Btn_red.UseVisualStyleBackColor = false;
            this.Btn_red.Click += new System.EventHandler(this.Red_BTN);
            // 
            // White_BTN
            // 
            this.White_BTN.BackColor = System.Drawing.SystemColors.GrayText;
            this.White_BTN.Location = new System.Drawing.Point(367, 184);
            this.White_BTN.Name = "White_BTN";
            this.White_BTN.Size = new System.Drawing.Size(97, 69);
            this.White_BTN.TabIndex = 2;
            this.White_BTN.Text = "Reset";
            this.White_BTN.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Settings";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Save_Btn
            // 
            this.Save_Btn.BackColor = System.Drawing.SystemColors.GrayText;
            this.Save_Btn.Location = new System.Drawing.Point(367, 322);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(97, 69);
            this.Save_Btn.TabIndex = 4;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.UseVisualStyleBackColor = false;
            this.Save_Btn.Click += new System.EventHandler(this.Save_BTN);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.White_BTN);
            this.Controls.Add(this.Btn_red);
            this.Controls.Add(this.Blue_BTN);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Blue_BTN;
        private System.Windows.Forms.Button Btn_red;
        private System.Windows.Forms.Button White_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save_Btn;
    }
}