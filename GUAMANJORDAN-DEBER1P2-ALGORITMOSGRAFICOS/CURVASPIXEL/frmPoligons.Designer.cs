namespace CURVASPIXEL
{
    partial class frmPoligons
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnFillOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.grbPicCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvasPoligon = new System.Windows.Forms.PictureBox();
            this.grbPixelData = new System.Windows.Forms.GroupBox();
            this.dgvPixels = new System.Windows.Forms.DataGridView();
            this.lblPixelCount = new System.Windows.Forms.Label();
            this.grbProcess.SuspendLayout();
            this.grbPicCanvas.SuspendLayout();
            this.grbPixelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvasPoligon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPixels)).BeginInit();
            this.SuspendLayout();
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnFillOut);
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnDraw);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(12, 30);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(366, 365);
            this.grbProcess.TabIndex = 1;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "PROCESOS";
            // 
            // btnFillOut
            // 
            this.btnFillOut.Location = new System.Drawing.Point(21, 123);
            this.btnFillOut.Name = "btnFillOut";
            this.btnFillOut.Size = new System.Drawing.Size(326, 62);
            this.btnFillOut.TabIndex = 3;
            this.btnFillOut.Text = "Rellenar";
            this.btnFillOut.UseVisualStyleBackColor = true;
            this.btnFillOut.Click += new System.EventHandler(this.btnFillOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(21, 284);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(326, 58);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(21, 206);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(326, 55);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Limpiar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(21, 47);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(326, 57);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Dibujar";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // grbPicCanvas
            // 
            this.grbPicCanvas.Controls.Add(this.picCanvasPoligon);
            this.grbPicCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPicCanvas.Location = new System.Drawing.Point(396, 30);
            this.grbPicCanvas.Name = "grbPicCanvas";
            this.grbPicCanvas.Size = new System.Drawing.Size(661, 751);
            this.grbPicCanvas.TabIndex = 2;
            this.grbPicCanvas.TabStop = false;
            this.grbPicCanvas.Text = "POLIGONOS";
            // 
            // picCanvasPoligon
            // 
            this.picCanvasPoligon.Location = new System.Drawing.Point(6, 26);
            this.picCanvasPoligon.Name = "picCanvasPoligon";
            this.picCanvasPoligon.Size = new System.Drawing.Size(635, 719);
            this.picCanvasPoligon.TabIndex = 0;
            this.picCanvasPoligon.TabStop = false;
            this.picCanvasPoligon.Click += new System.EventHandler(this.picCanvasPoligon_Click);
            // 
            // grbPixelData
            // 
            this.grbPixelData.Controls.Add(this.lblPixelCount);
            this.grbPixelData.Controls.Add(this.dgvPixels);
            this.grbPixelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPixelData.Location = new System.Drawing.Point(12, 415);
            this.grbPixelData.Name = "grbPixelData";
            this.grbPixelData.Size = new System.Drawing.Size(366, 366);
            this.grbPixelData.TabIndex = 3;
            this.grbPixelData.TabStop = false;
            this.grbPixelData.Text = "PIXELES ENCENDIDOS";
            // 
            // dgvPixels
            // 
            this.dgvPixels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPixels.Location = new System.Drawing.Point(6, 58);
            this.dgvPixels.Name = "dgvPixels";
            this.dgvPixels.RowHeadersWidth = 62;
            this.dgvPixels.RowTemplate.Height = 28;
            this.dgvPixels.Size = new System.Drawing.Size(354, 280);
            this.dgvPixels.TabIndex = 0;
            // 
            // lblPixelCount
            // 
            this.lblPixelCount.AutoSize = true;
            this.lblPixelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPixelCount.Location = new System.Drawing.Point(6, 28);
            this.lblPixelCount.Name = "lblPixelCount";
            this.lblPixelCount.Size = new System.Drawing.Size(163, 25);
            this.lblPixelCount.TabIndex = 1;
            this.lblPixelCount.Text = "Total Píxeles: 0";
            // 
            // frmPoligons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 793);
            this.Controls.Add(this.grbPixelData);
            this.Controls.Add(this.grbPicCanvas);
            this.Controls.Add(this.grbProcess);
            this.Name = "frmPoligons";
            this.Text = "POLIGONOS";
            this.Load += new System.EventHandler(this.frmPoligons_Load);
            this.grbProcess.ResumeLayout(false);
            this.grbPicCanvas.ResumeLayout(false);
            this.grbPixelData.ResumeLayout(false);
            this.grbPixelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvasPoligon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPixels)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.GroupBox grbPicCanvas;
        private System.Windows.Forms.PictureBox picCanvasPoligon;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFillOut;
        private System.Windows.Forms.GroupBox grbPixelData;
        private System.Windows.Forms.DataGridView dgvPixels;
        private System.Windows.Forms.Label lblPixelCount;
    }
}