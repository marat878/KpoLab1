namespace KpoLab.Main
{
    partial class FormMetalViscosity
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
            this.LbName = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.LbAtomicNumber = new System.Windows.Forms.Label();
            this.TbAtomicNumber = new System.Windows.Forms.TextBox();
            this.LbViscosity = new System.Windows.Forms.Label();
            this.TbViscosity = new System.Windows.Forms.TextBox();
            this.LbTemperature = new System.Windows.Forms.Label();
            this.TbTemperature = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Location = new System.Drawing.Point(23, 21);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(61, 13);
            this.LbName.TabIndex = 3;
            this.LbName.Text = "Вещество:";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(120, 18);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(212, 20);
            this.TbName.TabIndex = 2;
            // 
            // LbAtomicNumber
            // 
            this.LbAtomicNumber.AutoSize = true;
            this.LbAtomicNumber.Location = new System.Drawing.Point(23, 50);
            this.LbAtomicNumber.Name = "LbAtomicNumber";
            this.LbAtomicNumber.Size = new System.Drawing.Size(91, 13);
            this.LbAtomicNumber.TabIndex = 5;
            this.LbAtomicNumber.Text = "Атомный номер:";
            // 
            // TbAtomicNumber
            // 
            this.TbAtomicNumber.Location = new System.Drawing.Point(120, 47);
            this.TbAtomicNumber.Name = "TbAtomicNumber";
            this.TbAtomicNumber.Size = new System.Drawing.Size(212, 20);
            this.TbAtomicNumber.TabIndex = 4;
            // 
            // LbViscosity
            // 
            this.LbViscosity.AutoSize = true;
            this.LbViscosity.Location = new System.Drawing.Point(23, 104);
            this.LbViscosity.Name = "LbViscosity";
            this.LbViscosity.Size = new System.Drawing.Size(58, 13);
            this.LbViscosity.TabIndex = 7;
            this.LbViscosity.Text = "Вязкость:";
            // 
            // TbViscosity
            // 
            this.TbViscosity.Location = new System.Drawing.Point(120, 101);
            this.TbViscosity.Name = "TbViscosity";
            this.TbViscosity.Size = new System.Drawing.Size(212, 20);
            this.TbViscosity.TabIndex = 6;
            // 
            // LbTemperature
            // 
            this.LbTemperature.AutoSize = true;
            this.LbTemperature.Location = new System.Drawing.Point(23, 77);
            this.LbTemperature.Name = "LbTemperature";
            this.LbTemperature.Size = new System.Drawing.Size(77, 13);
            this.LbTemperature.TabIndex = 9;
            this.LbTemperature.Text = "Температура:";
            // 
            // TbTemperature
            // 
            this.TbTemperature.Location = new System.Drawing.Point(120, 74);
            this.TbTemperature.Name = "TbTemperature";
            this.TbTemperature.Size = new System.Drawing.Size(212, 20);
            this.TbTemperature.TabIndex = 8;
            // 
            // FormMetalViscosity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 142);
            this.Controls.Add(this.LbTemperature);
            this.Controls.Add(this.TbTemperature);
            this.Controls.Add(this.LbViscosity);
            this.Controls.Add(this.TbViscosity);
            this.Controls.Add(this.LbAtomicNumber);
            this.Controls.Add(this.TbAtomicNumber);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.TbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMetalViscosity";
            this.Text = "Вязкость металла в жидком состоянии";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMetalViscosity_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMetalViscosity_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Label LbAtomicNumber;
        private System.Windows.Forms.TextBox TbAtomicNumber;
        private System.Windows.Forms.Label LbViscosity;
        private System.Windows.Forms.TextBox TbViscosity;
        private System.Windows.Forms.Label LbTemperature;
        private System.Windows.Forms.TextBox TbTemperature;
    }
}