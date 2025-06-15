namespace CURVASPIXEL
{
    partial class frmHomeLines
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aLGORITMOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bRESENHAMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pUNTOMEDIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLGORITMODERELLENOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rELLENOPORINUNDACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLGORITMOSToolStripMenuItem,
            this.aLGORITMODERELLENOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // aLGORITMOSToolStripMenuItem
            // 
            this.aLGORITMOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dDAToolStripMenuItem,
            this.bRESENHAMToolStripMenuItem,
            this.pUNTOMEDIOToolStripMenuItem});
            this.aLGORITMOSToolStripMenuItem.Name = "aLGORITMOSToolStripMenuItem";
            this.aLGORITMOSToolStripMenuItem.Size = new System.Drawing.Size(138, 29);
            this.aLGORITMOSToolStripMenuItem.Text = "ALGORITMOS";
            this.aLGORITMOSToolStripMenuItem.Click += new System.EventHandler(this.aLGORITMOSToolStripMenuItem_Click);
            // 
            // dDAToolStripMenuItem
            // 
            this.dDAToolStripMenuItem.Name = "dDAToolStripMenuItem";
            this.dDAToolStripMenuItem.Size = new System.Drawing.Size(233, 34);
            this.dDAToolStripMenuItem.Text = "DDA";
            this.dDAToolStripMenuItem.Click += new System.EventHandler(this.dDAToolStripMenuItem_Click);
            // 
            // bRESENHAMToolStripMenuItem
            // 
            this.bRESENHAMToolStripMenuItem.Name = "bRESENHAMToolStripMenuItem";
            this.bRESENHAMToolStripMenuItem.Size = new System.Drawing.Size(233, 34);
            this.bRESENHAMToolStripMenuItem.Text = "BRESENHAM";
            this.bRESENHAMToolStripMenuItem.Click += new System.EventHandler(this.bRESENHAMToolStripMenuItem_Click);
            // 
            // pUNTOMEDIOToolStripMenuItem
            // 
            this.pUNTOMEDIOToolStripMenuItem.Name = "pUNTOMEDIOToolStripMenuItem";
            this.pUNTOMEDIOToolStripMenuItem.Size = new System.Drawing.Size(233, 34);
            this.pUNTOMEDIOToolStripMenuItem.Text = "PUNTO MEDIO";
            this.pUNTOMEDIOToolStripMenuItem.Click += new System.EventHandler(this.pUNTOMEDIOToolStripMenuItem_Click);
            // 
            // aLGORITMODERELLENOToolStripMenuItem
            // 
            this.aLGORITMODERELLENOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rELLENOPORINUNDACIONToolStripMenuItem});
            this.aLGORITMODERELLENOToolStripMenuItem.Name = "aLGORITMODERELLENOToolStripMenuItem";
            this.aLGORITMODERELLENOToolStripMenuItem.Size = new System.Drawing.Size(232, 29);
            this.aLGORITMODERELLENOToolStripMenuItem.Text = "ALGORITMO DE RELLENO";
            this.aLGORITMODERELLENOToolStripMenuItem.Click += new System.EventHandler(this.aLGORITMODERELLENOToolStripMenuItem_Click);
            // 
            // rELLENOPORINUNDACIONToolStripMenuItem
            // 
            this.rELLENOPORINUNDACIONToolStripMenuItem.Name = "rELLENOPORINUNDACIONToolStripMenuItem";
            this.rELLENOPORINUNDACIONToolStripMenuItem.Size = new System.Drawing.Size(342, 34);
            this.rELLENOPORINUNDACIONToolStripMenuItem.Text = "RELLENO POR INUNDACION";
            this.rELLENOPORINUNDACIONToolStripMenuItem.Click += new System.EventHandler(this.rELLENOPORINUNDACIONToolStripMenuItem_Click);
            // 
            // frmHomeLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHomeLines";
            this.Text = "ALGORITMO DE LINEAS";
            this.Load += new System.EventHandler(this.frmHomeLines_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aLGORITMOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bRESENHAMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pUNTOMEDIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLGORITMODERELLENOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rELLENOPORINUNDACIONToolStripMenuItem;
    }
}