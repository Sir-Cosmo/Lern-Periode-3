namespace LP3_Taschenrechner
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
            this.Output = new System.Windows.Forms.TextBox();
            this.Nr0 = new System.Windows.Forms.Button();
            this.Nr1 = new System.Windows.Forms.Button();
            this.Nr2 = new System.Windows.Forms.Button();
            this.Nr3 = new System.Windows.Forms.Button();
            this.Nr4 = new System.Windows.Forms.Button();
            this.Nr5 = new System.Windows.Forms.Button();
            this.Nr6 = new System.Windows.Forms.Button();
            this.Nr7 = new System.Windows.Forms.Button();
            this.Nr8 = new System.Windows.Forms.Button();
            this.Nr9 = new System.Windows.Forms.Button();
            this.Set_Button = new System.Windows.Forms.Button();
            this.Enter_BTN = new System.Windows.Forms.Button();
            this.Plus_BTN = new System.Windows.Forms.Button();
            this.Minus_BTN = new System.Windows.Forms.Button();
            this.Output2 = new System.Windows.Forms.Label();
            this.CE_BTN = new System.Windows.Forms.Button();
            this.Lable_Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(62, 164);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(306, 31);
            this.Output.TabIndex = 0;
            this.Output.Text = "0";
            this.Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Nr0
            // 
            this.Nr0.Location = new System.Drawing.Point(166, 396);
            this.Nr0.Name = "Nr0";
            this.Nr0.Size = new System.Drawing.Size(98, 59);
            this.Nr0.TabIndex = 1;
            this.Nr0.Text = "0";
            this.Nr0.UseVisualStyleBackColor = true;
            this.Nr0.Click += new System.EventHandler(this.BTN_Click);
            // 
            // Nr1
            // 
            this.Nr1.Location = new System.Drawing.Point(62, 331);
            this.Nr1.Name = "Nr1";
            this.Nr1.Size = new System.Drawing.Size(98, 59);
            this.Nr1.TabIndex = 2;
            this.Nr1.Text = "1";
            this.Nr1.UseVisualStyleBackColor = true;
            this.Nr1.Click += new System.EventHandler(this.BTN_Click);
            // 
            // Nr2
            // 
            this.Nr2.Location = new System.Drawing.Point(166, 331);
            this.Nr2.Name = "Nr2";
            this.Nr2.Size = new System.Drawing.Size(98, 59);
            this.Nr2.TabIndex = 3;
            this.Nr2.Text = "2";
            this.Nr2.UseVisualStyleBackColor = true;
            this.Nr2.Click += new System.EventHandler(this.BTN_Click);
            // 
            // Nr3
            // 
            this.Nr3.Location = new System.Drawing.Point(270, 331);
            this.Nr3.Name = "Nr3";
            this.Nr3.Size = new System.Drawing.Size(98, 59);
            this.Nr3.TabIndex = 4;
            this.Nr3.Text = "3";
            this.Nr3.UseVisualStyleBackColor = true;
            this.Nr3.Click += new System.EventHandler(this.BTN_Click);
            // 
            // Nr4
            // 
            this.Nr4.Location = new System.Drawing.Point(62, 266);
            this.Nr4.Name = "Nr4";
            this.Nr4.Size = new System.Drawing.Size(98, 59);
            this.Nr4.TabIndex = 5;
            this.Nr4.Text = "4";
            this.Nr4.UseVisualStyleBackColor = true;
            this.Nr4.Click += new System.EventHandler(this.BTN_Click);
            // 
            // Nr5
            // 
            this.Nr5.Location = new System.Drawing.Point(166, 266);
            this.Nr5.Name = "Nr5";
            this.Nr5.Size = new System.Drawing.Size(98, 59);
            this.Nr5.TabIndex = 6;
            this.Nr5.Text = "5";
            this.Nr5.UseVisualStyleBackColor = true;
            this.Nr5.Click += new System.EventHandler(this.BTN_Click);
            // 
            // Nr6
            // 
            this.Nr6.Location = new System.Drawing.Point(270, 266);
            this.Nr6.Name = "Nr6";
            this.Nr6.Size = new System.Drawing.Size(98, 59);
            this.Nr6.TabIndex = 7;
            this.Nr6.Text = "6";
            this.Nr6.UseVisualStyleBackColor = true;
            this.Nr6.Click += new System.EventHandler(this.BTN_Click);
            // 
            // Nr7
            // 
            this.Nr7.Location = new System.Drawing.Point(62, 201);
            this.Nr7.Name = "Nr7";
            this.Nr7.Size = new System.Drawing.Size(98, 59);
            this.Nr7.TabIndex = 8;
            this.Nr7.Text = "7";
            this.Nr7.UseVisualStyleBackColor = true;
            this.Nr7.Click += new System.EventHandler(this.BTN_Click);
            // 
            // Nr8
            // 
            this.Nr8.Location = new System.Drawing.Point(166, 201);
            this.Nr8.Name = "Nr8";
            this.Nr8.Size = new System.Drawing.Size(98, 59);
            this.Nr8.TabIndex = 9;
            this.Nr8.Text = "8";
            this.Nr8.UseVisualStyleBackColor = true;
            this.Nr8.Click += new System.EventHandler(this.BTN_Click);
            // 
            // Nr9
            // 
            this.Nr9.Location = new System.Drawing.Point(270, 201);
            this.Nr9.Name = "Nr9";
            this.Nr9.Size = new System.Drawing.Size(98, 59);
            this.Nr9.TabIndex = 10;
            this.Nr9.Text = "9";
            this.Nr9.UseVisualStyleBackColor = true;
            this.Nr9.Click += new System.EventHandler(this.BTN_Click);
            // 
            // Set_Button
            // 
            this.Set_Button.Location = new System.Drawing.Point(62, 396);
            this.Set_Button.Name = "Set_Button";
            this.Set_Button.Size = new System.Drawing.Size(98, 59);
            this.Set_Button.TabIndex = 11;
            this.Set_Button.Text = "Set";
            this.Set_Button.UseVisualStyleBackColor = true;
            // 
            // Enter_BTN
            // 
            this.Enter_BTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Enter_BTN.ForeColor = System.Drawing.Color.Cyan;
            this.Enter_BTN.Location = new System.Drawing.Point(270, 396);
            this.Enter_BTN.Name = "Enter_BTN";
            this.Enter_BTN.Size = new System.Drawing.Size(98, 59);
            this.Enter_BTN.TabIndex = 12;
            this.Enter_BTN.Text = "=";
            this.Enter_BTN.UseVisualStyleBackColor = false;
            this.Enter_BTN.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Plus_BTN
            // 
            this.Plus_BTN.Location = new System.Drawing.Point(374, 201);
            this.Plus_BTN.Name = "Plus_BTN";
            this.Plus_BTN.Size = new System.Drawing.Size(65, 91);
            this.Plus_BTN.TabIndex = 13;
            this.Plus_BTN.Text = "+";
            this.Plus_BTN.UseVisualStyleBackColor = true;
            this.Plus_BTN.Click += new System.EventHandler(this.operator_click);
            // 
            // Minus_BTN
            // 
            this.Minus_BTN.Location = new System.Drawing.Point(374, 298);
            this.Minus_BTN.Name = "Minus_BTN";
            this.Minus_BTN.Size = new System.Drawing.Size(65, 92);
            this.Minus_BTN.TabIndex = 14;
            this.Minus_BTN.Text = "-";
            this.Minus_BTN.UseVisualStyleBackColor = true;
            this.Minus_BTN.Click += new System.EventHandler(this.operator_click);
            // 
            // Output2
            // 
            this.Output2.AutoSize = true;
            this.Output2.Location = new System.Drawing.Point(57, 136);
            this.Output2.Name = "Output2";
            this.Output2.Size = new System.Drawing.Size(0, 25);
            this.Output2.TabIndex = 15;
            this.Output2.Click += new System.EventHandler(this.label1_Click);
            // 
            // CE_BTN
            // 
            this.CE_BTN.Location = new System.Drawing.Point(374, 396);
            this.CE_BTN.Name = "CE_BTN";
            this.CE_BTN.Size = new System.Drawing.Size(65, 59);
            this.CE_BTN.TabIndex = 16;
            this.CE_BTN.Text = "CE";
            this.CE_BTN.UseVisualStyleBackColor = true;
            this.CE_BTN.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Lable_Output
            // 
            this.Lable_Output.AutoSize = true;
            this.Lable_Output.Location = new System.Drawing.Point(63, 136);
            this.Lable_Output.Name = "Lable_Output";
            this.Lable_Output.Size = new System.Drawing.Size(0, 25);
            this.Lable_Output.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 517);
            this.Controls.Add(this.Lable_Output);
            this.Controls.Add(this.CE_BTN);
            this.Controls.Add(this.Output2);
            this.Controls.Add(this.Minus_BTN);
            this.Controls.Add(this.Plus_BTN);
            this.Controls.Add(this.Enter_BTN);
            this.Controls.Add(this.Set_Button);
            this.Controls.Add(this.Nr9);
            this.Controls.Add(this.Nr8);
            this.Controls.Add(this.Nr7);
            this.Controls.Add(this.Nr6);
            this.Controls.Add(this.Nr5);
            this.Controls.Add(this.Nr4);
            this.Controls.Add(this.Nr3);
            this.Controls.Add(this.Nr2);
            this.Controls.Add(this.Nr1);
            this.Controls.Add(this.Nr0);
            this.Controls.Add(this.Output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button Nr0;
        private System.Windows.Forms.Button Nr1;
        private System.Windows.Forms.Button Nr2;
        private System.Windows.Forms.Button Nr3;
        private System.Windows.Forms.Button Nr4;
        private System.Windows.Forms.Button Nr5;
        private System.Windows.Forms.Button Nr6;
        private System.Windows.Forms.Button Nr7;
        private System.Windows.Forms.Button Nr8;
        private System.Windows.Forms.Button Nr9;
        private System.Windows.Forms.Button Set_Button;
        private System.Windows.Forms.Button Enter_BTN;
        private System.Windows.Forms.Button Plus_BTN;
        private System.Windows.Forms.Button Minus_BTN;
        private System.Windows.Forms.Label Output2;
        private System.Windows.Forms.Button CE_BTN;
        private System.Windows.Forms.Label Lable_Output;
    }
}

