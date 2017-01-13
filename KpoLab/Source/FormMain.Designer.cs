namespace KpoLab.Main
{
    partial class FormMain
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
            this.MsMain = new System.Windows.Forms.MenuStrip();
            this.MsiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.SsStatus = new System.Windows.Forms.StatusStrip();
            this.DgvMetalViscosity = new System.Windows.Forms.DataGridView();
            this.MsiMetalViscosity = new System.Windows.Forms.ToolStripMenuItem();
            this.MsiMetalViscosityShowInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMetalViscosity)).BeginInit();
            this.SuspendLayout();
            // 
            // MsMain
            // 
            this.MsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsiFile,
            this.MsiMetalViscosity});
            this.MsMain.Location = new System.Drawing.Point(0, 0);
            this.MsMain.Name = "MsMain";
            this.MsMain.Size = new System.Drawing.Size(976, 24);
            this.MsMain.TabIndex = 0;
            this.MsMain.Text = "menuStrip1";
            // 
            // MsiFile
            // 
            this.MsiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsiFileQuit,
            this.MsiFileOpen});
            this.MsiFile.Name = "MsiFile";
            this.MsiFile.Size = new System.Drawing.Size(60, 20);
            this.MsiFile.Text = "&1. Файл";
            // 
            // MsiFileQuit
            // 
            this.MsiFileQuit.Name = "MsiFileQuit";
            this.MsiFileQuit.Size = new System.Drawing.Size(152, 22);
            this.MsiFileQuit.Text = "Выход";
            this.MsiFileQuit.Click += new System.EventHandler(this.MsiFileQuit_Click);
            // 
            // MsiFileOpen
            // 
            this.MsiFileOpen.Name = "MsiFileOpen";
            this.MsiFileOpen.Size = new System.Drawing.Size(152, 22);
            this.MsiFileOpen.Text = "Открыть";
            this.MsiFileOpen.Click += new System.EventHandler(this.MsiFileOpen_Click);
            // 
            // SsStatus
            // 
            this.SsStatus.Location = new System.Drawing.Point(0, 532);
            this.SsStatus.Name = "SsStatus";
            this.SsStatus.Size = new System.Drawing.Size(976, 22);
            this.SsStatus.TabIndex = 1;
            this.SsStatus.Text = "statusStrip1";
            // 
            // DgvMetalViscosity
            // 
            this.DgvMetalViscosity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMetalViscosity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMetalViscosity.Location = new System.Drawing.Point(0, 24);
            this.DgvMetalViscosity.Name = "DgvMetalViscosity";
            this.DgvMetalViscosity.Size = new System.Drawing.Size(976, 508);
            this.DgvMetalViscosity.TabIndex = 2;
            // 
            // MsiMetalViscosity
            // 
            this.MsiMetalViscosity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MsiMetalViscosityShowInfo});
            this.MsiMetalViscosity.Name = "MsiMetalViscosity";
            this.MsiMetalViscosity.Size = new System.Drawing.Size(135, 20);
            this.MsiMetalViscosity.Text = "&2. Вязкость металлов";
            // 
            // MsiMetalViscosityShowInfo
            // 
            this.MsiMetalViscosityShowInfo.Name = "MsiMetalViscosityShowInfo";
            this.MsiMetalViscosityShowInfo.Size = new System.Drawing.Size(251, 22);
            this.MsiMetalViscosityShowInfo.Text = "Открыть информацию о записи";
            this.MsiMetalViscosityShowInfo.Click += new System.EventHandler(this.MsiMetalViscosityShowInfo_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 554);
            this.Controls.Add(this.DgvMetalViscosity);
            this.Controls.Add(this.SsStatus);
            this.Controls.Add(this.MsMain);
            this.MainMenuStrip = this.MsMain;
            this.Name = "FormMain";
            this.Text = "КПО: 4281 Погойдаш";
            this.MsMain.ResumeLayout(false);
            this.MsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMetalViscosity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MsMain;
        private System.Windows.Forms.ToolStripMenuItem MsiFile;
        private System.Windows.Forms.ToolStripMenuItem MsiFileQuit;
        private System.Windows.Forms.ToolStripMenuItem MsiFileOpen;
        private System.Windows.Forms.StatusStrip SsStatus;
        private System.Windows.Forms.DataGridView DgvMetalViscosity;
        private System.Windows.Forms.ToolStripMenuItem MsiMetalViscosity;
        private System.Windows.Forms.ToolStripMenuItem MsiMetalViscosityShowInfo;
    }
}

