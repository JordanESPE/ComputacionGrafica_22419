namespace CURVASPIXEL
{
    partial class frmBresenham
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
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.txtYf = new System.Windows.Forms.TextBox();
            this.txtXf = new System.Windows.Forms.TextBox();
            this.txtYo = new System.Windows.Forms.TextBox();
            this.txtXo = new System.Windows.Forms.TextBox();
            this.lblYf = new System.Windows.Forms.Label();
            this.lblXf = new System.Windows.Forms.Label();
            this.lblYo = new System.Windows.Forms.Label();
            this.lblXo = new System.Windows.Forms.Label();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbPicCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvasBresenham = new System.Windows.Forms.PictureBox();
            this.grbPixelTable = new System.Windows.Forms.GroupBox();
            this.dgvPixels = new System.Windows.Forms.DataGridView();
            this.grbInputs.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.grbPicCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvasBresenham)).BeginInit();
            this.grbPixelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPixels)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtYf);
            this.grbInputs.Controls.Add(this.txtXf);
            this.grbInputs.Controls.Add(this.txtYo);
            this.grbInputs.Controls.Add(this.txtXo);
            this.grbInputs.Controls.Add(this.lblYf);
            this.grbInputs.Controls.Add(this.lblXf);
            this.grbInputs.Controls.Add(this.lblYo);
            this.grbInputs.Controls.Add(this.lblXo);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(12, 12);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(253, 292);
            this.grbInputs.TabIndex = 1;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "ENTRADAS";
            // 
            // txtYf
            // 
            this.txtYf.Location = new System.Drawing.Point(119, 204);
            this.txtYf.Name = "txtYf";
            this.txtYf.Size = new System.Drawing.Size(100, 35);
            this.txtYf.TabIndex = 7;
            this.txtYf.TextChanged += new System.EventHandler(this.txtYf_TextChanged);
            // 
            // txtXf
            // 
            this.txtXf.Location = new System.Drawing.Point(119, 154);
            this.txtXf.Name = "txtXf";
            this.txtXf.Size = new System.Drawing.Size(100, 35);
            this.txtXf.TabIndex = 6;
            this.txtXf.TextChanged += new System.EventHandler(this.txtXf_TextChanged);
            // 
            // txtYo
            // 
            this.txtYo.Location = new System.Drawing.Point(119, 110);
            this.txtYo.Name = "txtYo";
            this.txtYo.Size = new System.Drawing.Size(100, 35);
            this.txtYo.TabIndex = 5;
            this.txtYo.TextChanged += new System.EventHandler(this.txtYo_TextChanged);
            // 
            // txtXo
            // 
            this.txtXo.Location = new System.Drawing.Point(119, 61);
            this.txtXo.Name = "txtXo";
            this.txtXo.Size = new System.Drawing.Size(100, 35);
            this.txtXo.TabIndex = 4;
            this.txtXo.TextChanged += new System.EventHandler(this.txtXo_TextChanged);
            // 
            // lblYf
            // 
            this.lblYf.AutoSize = true;
            this.lblYf.Location = new System.Drawing.Point(15, 204);
            this.lblYf.Name = "lblYf";
            this.lblYf.Size = new System.Drawing.Size(44, 29);
            this.lblYf.TabIndex = 3;
            this.lblYf.Text = "Yf:";
            // 
            // lblXf
            // 
            this.lblXf.AutoSize = true;
            this.lblXf.Location = new System.Drawing.Point(15, 157);
            this.lblXf.Name = "lblXf";
            this.lblXf.Size = new System.Drawing.Size(45, 29);
            this.lblXf.TabIndex = 2;
            this.lblXf.Text = "Xf:";
            // 
            // lblYo
            // 
            this.lblYo.AutoSize = true;
            this.lblYo.Location = new System.Drawing.Point(15, 110);
            this.lblYo.Name = "lblYo";
            this.lblYo.Size = new System.Drawing.Size(52, 29);
            this.lblYo.TabIndex = 1;
            this.lblYo.Text = "Yo:";
            // 
            // lblXo
            // 
            this.lblXo.AutoSize = true;
            this.lblXo.Location = new System.Drawing.Point(15, 61);
            this.lblXo.Name = "lblXo";
            this.lblXo.Size = new System.Drawing.Size(53, 29);
            this.lblXo.TabIndex = 0;
            this.lblXo.Text = "Xo:";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(12, 312);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(253, 243);
            this.grbProcess.TabIndex = 2;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "PROCESOS";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(32, 155);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(187, 39);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(32, 94);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(187, 46);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Limpiar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(32, 46);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(187, 42);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbPicCanvas
            // 
            this.grbPicCanvas.Controls.Add(this.picCanvasBresenham);
            this.grbPicCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPicCanvas.Location = new System.Drawing.Point(287, 21);
            this.grbPicCanvas.Name = "grbPicCanvas";
            this.grbPicCanvas.Size = new System.Drawing.Size(880, 580);
            this.grbPicCanvas.TabIndex = 3;
            this.grbPicCanvas.TabStop = false;
            this.grbPicCanvas.Text = "LINEAS";
            // 
            // picCanvasBresenham
            // 
            this.picCanvasBresenham.BackColor = System.Drawing.Color.White;
            this.picCanvasBresenham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCanvasBresenham.Location = new System.Drawing.Point(6, 28);
            this.picCanvasBresenham.Name = "picCanvasBresenham";
            this.picCanvasBresenham.Size = new System.Drawing.Size(868, 546);
            this.picCanvasBresenham.TabIndex = 0;
            this.picCanvasBresenham.TabStop = false;
            this.picCanvasBresenham.Click += new System.EventHandler(this.picCanvasBresenham_Click);
            // 
            // grbPixelTable
            // 
            this.grbPixelTable.Controls.Add(this.dgvPixels);
            this.grbPixelTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPixelTable.Location = new System.Drawing.Point(1173, 21);
            this.grbPixelTable.Name = "grbPixelTable";
            this.grbPixelTable.Size = new System.Drawing.Size(596, 580);
            this.grbPixelTable.TabIndex = 4;
            this.grbPixelTable.TabStop = false;
            this.grbPixelTable.Text = "PÍXELES Y PARÁMETROS";
            // 
            // dgvPixels
            // 
            this.dgvPixels.AllowUserToAddRows = false;
            this.dgvPixels.AllowUserToDeleteRows = false;
            this.dgvPixels.BackgroundColor = System.Drawing.Color.White;
            this.dgvPixels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPixels.Location = new System.Drawing.Point(6, 31);
            this.dgvPixels.Name = "dgvPixels";
            this.dgvPixels.ReadOnly = true;
            this.dgvPixels.RowHeadersWidth = 62;
            this.dgvPixels.RowTemplate.Height = 28;
            this.dgvPixels.Size = new System.Drawing.Size(583, 543);
            this.dgvPixels.TabIndex = 0;
            // 
            // frmBresenham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 613);
            this.Controls.Add(this.grbPixelTable);
            this.Controls.Add(this.grbPicCanvas);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Name = "frmBresenham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmo Bresenham - Líneas (-20 a +20)";
            this.Load += new System.EventHandler(this.frmBresenham_Load);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbPicCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvasBresenham)).EndInit();
            this.grbPixelTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPixels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtYf;
        private System.Windows.Forms.TextBox txtXf;
        private System.Windows.Forms.TextBox txtYo;
        private System.Windows.Forms.TextBox txtXo;
        private System.Windows.Forms.Label lblYf;
        private System.Windows.Forms.Label lblXf;
        private System.Windows.Forms.Label lblYo;
        private System.Windows.Forms.Label lblXo;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbPicCanvas;
        private System.Windows.Forms.PictureBox picCanvasBresenham;
        private System.Windows.Forms.GroupBox grbPixelTable;
        private System.Windows.Forms.DataGridView dgvPixels;
    }
}