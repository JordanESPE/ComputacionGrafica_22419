namespace GUAMAN_JORDAN_FIGURAS
{
    partial class frmRhombus
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
            this.txtSide = new System.Windows.Forms.TextBox();
            this.txtMinorDiagonal = new System.Windows.Forms.TextBox();
            this.txtMajorDiagonal = new System.Windows.Forms.TextBox();
            this.lblSide = new System.Windows.Forms.Label();
            this.lblMinorDiagonal = new System.Windows.Forms.Label();
            this.lblMajorDiagonal = new System.Windows.Forms.Label();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbOutputs = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.grbInputs.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.grbOutputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtSide);
            this.grbInputs.Controls.Add(this.txtMinorDiagonal);
            this.grbInputs.Controls.Add(this.txtMajorDiagonal);
            this.grbInputs.Controls.Add(this.lblSide);
            this.grbInputs.Controls.Add(this.lblMinorDiagonal);
            this.grbInputs.Controls.Add(this.lblMajorDiagonal);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(13, 14);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(573, 262);
            this.grbInputs.TabIndex = 0;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(264, 182);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(292, 35);
            this.txtSide.TabIndex = 5;
            this.txtSide.TextChanged += new System.EventHandler(this.txtSide_TextChanged);
            // 
            // txtMinorDiagonal
            // 
            this.txtMinorDiagonal.Location = new System.Drawing.Point(264, 114);
            this.txtMinorDiagonal.Name = "txtMinorDiagonal";
            this.txtMinorDiagonal.Size = new System.Drawing.Size(292, 35);
            this.txtMinorDiagonal.TabIndex = 4;
            this.txtMinorDiagonal.TextChanged += new System.EventHandler(this.txtMinorDiagonal_TextChanged);
            // 
            // txtMajorDiagonal
            // 
            this.txtMajorDiagonal.Location = new System.Drawing.Point(264, 48);
            this.txtMajorDiagonal.Name = "txtMajorDiagonal";
            this.txtMajorDiagonal.Size = new System.Drawing.Size(292, 35);
            this.txtMajorDiagonal.TabIndex = 3;
            this.txtMajorDiagonal.TextChanged += new System.EventHandler(this.txtMajorDiagonal_TextChanged);
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(6, 185);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(124, 29);
            this.lblSide.TabIndex = 2;
            this.lblSide.Text = "Lado (L) :";
            // 
            // lblMinorDiagonal
            // 
            this.lblMinorDiagonal.AutoSize = true;
            this.lblMinorDiagonal.Location = new System.Drawing.Point(6, 114);
            this.lblMinorDiagonal.Name = "lblMinorDiagonal";
            this.lblMinorDiagonal.Size = new System.Drawing.Size(252, 29);
            this.lblMinorDiagonal.TabIndex = 1;
            this.lblMinorDiagonal.Text = "Diagonal Menor (d) :";
            // 
            // lblMajorDiagonal
            // 
            this.lblMajorDiagonal.AutoSize = true;
            this.lblMajorDiagonal.Location = new System.Drawing.Point(6, 48);
            this.lblMajorDiagonal.Name = "lblMajorDiagonal";
            this.lblMajorDiagonal.Size = new System.Drawing.Size(252, 29);
            this.lblMajorDiagonal.TabIndex = 0;
            this.lblMajorDiagonal.Text = "Diagonal Mayor (D) :";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(13, 282);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(573, 168);
            this.grbProcess.TabIndex = 1;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(376, 66);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 56);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(196, 66);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(162, 56);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(25, 66);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(155, 56);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // grbOutputs
            // 
            this.grbOutputs.Controls.Add(this.txtArea);
            this.grbOutputs.Controls.Add(this.txtPerimeter);
            this.grbOutputs.Controls.Add(this.lblArea);
            this.grbOutputs.Controls.Add(this.lblPerimeter);
            this.grbOutputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOutputs.Location = new System.Drawing.Point(13, 457);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Size = new System.Drawing.Size(573, 156);
            this.grbOutputs.TabIndex = 2;
            this.grbOutputs.TabStop = false;
            this.grbOutputs.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(158, 102);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(270, 35);
            this.txtArea.TabIndex = 3;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(158, 46);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(270, 35);
            this.txtPerimeter.TabIndex = 2;
            this.txtPerimeter.TextChanged += new System.EventHandler(this.txtPerimeter_TextChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(21, 102);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(74, 29);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(21, 46);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(142, 29);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perimetro: ";
            // 
            // frmRhombus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 624);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Name = "frmRhombus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rombo";
            this.Load += new System.EventHandler(this.frmRhombus_Load);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.TextBox txtMinorDiagonal;
        private System.Windows.Forms.TextBox txtMajorDiagonal;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.Label lblMinorDiagonal;
        private System.Windows.Forms.Label lblMajorDiagonal;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbOutputs;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
    }
}