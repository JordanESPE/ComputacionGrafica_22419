namespace CURVASPIXEL
{
    partial class frmMiddlePoint
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblRatio = new System.Windows.Forms.Label();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnPaint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbPicCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvasMiddlePoint = new System.Windows.Forms.PictureBox();
            this.grbTable = new System.Windows.Forms.GroupBox();
            this.dataGridViewPixels = new System.Windows.Forms.DataGridView();
            this.grbInputs.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.grbPicCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvasMiddlePoint)).BeginInit();
            this.grbTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPixels)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.textBox3);
            this.grbInputs.Controls.Add(this.lblRatio);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(12, 12);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(337, 80);
            this.grbInputs.TabIndex = 0;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "ENTRADAS";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(143, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 35);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblRatio
            // 
            this.lblRatio.AutoSize = true;
            this.lblRatio.Location = new System.Drawing.Point(6, 38);
            this.lblRatio.Name = "lblRatio";
            this.lblRatio.Size = new System.Drawing.Size(89, 29);
            this.lblRatio.TabIndex = 2;
            this.lblRatio.Text = "Radio:";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnPaint);
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(12, 98);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(337, 280);
            this.grbProcess.TabIndex = 2;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "PROCESOS";
            // 
            // btnPaint
            // 
            this.btnPaint.BackColor = System.Drawing.Color.LightGreen;
            this.btnPaint.Location = new System.Drawing.Point(66, 139);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(187, 42);
            this.btnPaint.TabIndex = 3;
            this.btnPaint.Text = "Activar Pintar";
            this.btnPaint.UseVisualStyleBackColor = false;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(66, 223);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(187, 42);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(66, 181);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(187, 42);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Limpiar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(66, 78);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(187, 42);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbPicCanvas
            // 
            this.grbPicCanvas.Controls.Add(this.picCanvasMiddlePoint);
            this.grbPicCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPicCanvas.Location = new System.Drawing.Point(367, 12);
            this.grbPicCanvas.Name = "grbPicCanvas";
            this.grbPicCanvas.Size = new System.Drawing.Size(600, 520);
            this.grbPicCanvas.TabIndex = 3;
            this.grbPicCanvas.TabStop = false;
            this.grbPicCanvas.Text = "CÍRCULO - ALGORITMO PUNTO MEDIO";
            // 
            // picCanvasMiddlePoint
            // 
            this.picCanvasMiddlePoint.BackColor = System.Drawing.Color.White;
            this.picCanvasMiddlePoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCanvasMiddlePoint.Location = new System.Drawing.Point(6, 28);
            this.picCanvasMiddlePoint.Name = "picCanvasMiddlePoint";
            this.picCanvasMiddlePoint.Size = new System.Drawing.Size(588, 486);
            this.picCanvasMiddlePoint.TabIndex = 0;
            this.picCanvasMiddlePoint.TabStop = false;
            this.picCanvasMiddlePoint.Click += new System.EventHandler(this.picCanvasMiddlePoint_Click);
            // 
            // grbTable
            // 
            this.grbTable.Controls.Add(this.dataGridViewPixels);
            this.grbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTable.Location = new System.Drawing.Point(985, 12);
            this.grbTable.Name = "grbTable";
            this.grbTable.Size = new System.Drawing.Size(480, 520);
            this.grbTable.TabIndex = 4;
            this.grbTable.TabStop = false;
            this.grbTable.Text = "PÍXELES ENCENDIDOS";
            // 
            // dataGridViewPixels
            // 
            this.dataGridViewPixels.AllowUserToAddRows = false;
            this.dataGridViewPixels.AllowUserToDeleteRows = false;
            this.dataGridViewPixels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPixels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPixels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPixels.Location = new System.Drawing.Point(3, 31);
            this.dataGridViewPixels.Name = "dataGridViewPixels";
            this.dataGridViewPixels.ReadOnly = true;
            this.dataGridViewPixels.RowHeadersWidth = 62;
            this.dataGridViewPixels.RowTemplate.Height = 28;
            this.dataGridViewPixels.Size = new System.Drawing.Size(474, 486);
            this.dataGridViewPixels.TabIndex = 0;
            // 
            // frmMiddlePoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 544);
            this.Controls.Add(this.grbTable);
            this.Controls.Add(this.grbPicCanvas);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Name = "frmMiddlePoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\\";
            this.Load += new System.EventHandler(this.frmMiddlePointcs_Load);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbPicCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvasMiddlePoint)).EndInit();
            this.grbTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPixels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblRatio;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbPicCanvas;
        private System.Windows.Forms.PictureBox picCanvasMiddlePoint;
        private System.Windows.Forms.GroupBox grbTable;
        private System.Windows.Forms.DataGridView dataGridViewPixels;
    }
}