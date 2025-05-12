namespace GUAMAN_JORDAN_FIGURAS
{
    partial class frmIrregularTrapezoid
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
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtRigthSize = new System.Windows.Forms.TextBox();
            this.txtLeftSize = new System.Windows.Forms.TextBox();
            this.txtMinorBase = new System.Windows.Forms.TextBox();
            this.txtMajorBase = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblRightSize = new System.Windows.Forms.Label();
            this.lblLeftSize = new System.Windows.Forms.Label();
            this.lblMinorBase = new System.Windows.Forms.Label();
            this.lblMajorBase = new System.Windows.Forms.Label();
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
            this.grbInputs.Controls.Add(this.txtHeight);
            this.grbInputs.Controls.Add(this.txtRigthSize);
            this.grbInputs.Controls.Add(this.txtLeftSize);
            this.grbInputs.Controls.Add(this.txtMinorBase);
            this.grbInputs.Controls.Add(this.txtMajorBase);
            this.grbInputs.Controls.Add(this.lblHeight);
            this.grbInputs.Controls.Add(this.lblRightSize);
            this.grbInputs.Controls.Add(this.lblLeftSize);
            this.grbInputs.Controls.Add(this.lblMinorBase);
            this.grbInputs.Controls.Add(this.lblMajorBase);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(13, 13);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(712, 277);
            this.grbInputs.TabIndex = 0;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(281, 232);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(321, 35);
            this.txtHeight.TabIndex = 9;
            // 
            // txtRigthSize
            // 
            this.txtRigthSize.Location = new System.Drawing.Point(281, 184);
            this.txtRigthSize.Name = "txtRigthSize";
            this.txtRigthSize.Size = new System.Drawing.Size(321, 35);
            this.txtRigthSize.TabIndex = 8;
            // 
            // txtLeftSize
            // 
            this.txtLeftSize.Location = new System.Drawing.Point(281, 134);
            this.txtLeftSize.Name = "txtLeftSize";
            this.txtLeftSize.Size = new System.Drawing.Size(321, 35);
            this.txtLeftSize.TabIndex = 7;
            // 
            // txtMinorBase
            // 
            this.txtMinorBase.Location = new System.Drawing.Point(281, 88);
            this.txtMinorBase.Name = "txtMinorBase";
            this.txtMinorBase.Size = new System.Drawing.Size(321, 35);
            this.txtMinorBase.TabIndex = 6;
            // 
            // txtMajorBase
            // 
            this.txtMajorBase.Location = new System.Drawing.Point(281, 44);
            this.txtMajorBase.Name = "txtMajorBase";
            this.txtMajorBase.Size = new System.Drawing.Size(321, 35);
            this.txtMajorBase.TabIndex = 5;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(16, 232);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(133, 29);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Altura (h) :";
            // 
            // lblRightSize
            // 
            this.lblRightSize.AutoSize = true;
            this.lblRightSize.Location = new System.Drawing.Point(14, 184);
            this.lblRightSize.Name = "lblRightSize";
            this.lblRightSize.Size = new System.Drawing.Size(244, 29);
            this.lblRightSize.TabIndex = 3;
            this.lblRightSize.Text = "Lado Derecho (L2) :";
            // 
            // lblLeftSize
            // 
            this.lblLeftSize.AutoSize = true;
            this.lblLeftSize.Location = new System.Drawing.Point(11, 134);
            this.lblLeftSize.Name = "lblLeftSize";
            this.lblLeftSize.Size = new System.Drawing.Size(254, 29);
            this.lblLeftSize.TabIndex = 2;
            this.lblLeftSize.Text = "Lado Izquierdo (L1) :";
            // 
            // lblMinorBase
            // 
            this.lblMinorBase.AutoSize = true;
            this.lblMinorBase.Location = new System.Drawing.Point(11, 88);
            this.lblMinorBase.Name = "lblMinorBase";
            this.lblMinorBase.Size = new System.Drawing.Size(230, 29);
            this.lblMinorBase.TabIndex = 1;
            this.lblMinorBase.Text = "Base Menor (B2) : ";
            // 
            // lblMajorBase
            // 
            this.lblMajorBase.AutoSize = true;
            this.lblMajorBase.Location = new System.Drawing.Point(6, 44);
            this.lblMajorBase.Name = "lblMajorBase";
            this.lblMajorBase.Size = new System.Drawing.Size(220, 29);
            this.lblMajorBase.TabIndex = 0;
            this.lblMajorBase.Text = "Base Mayor (B1) :";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(13, 296);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(712, 109);
            this.grbProcess.TabIndex = 1;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(487, 51);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 41);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(281, 51);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(171, 41);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(70, 51);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(171, 41);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbOutputs
            // 
            this.grbOutputs.Controls.Add(this.txtArea);
            this.grbOutputs.Controls.Add(this.txtPerimeter);
            this.grbOutputs.Controls.Add(this.lblArea);
            this.grbOutputs.Controls.Add(this.lblPerimeter);
            this.grbOutputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOutputs.Location = new System.Drawing.Point(13, 411);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Size = new System.Drawing.Size(712, 168);
            this.grbOutputs.TabIndex = 2;
            this.grbOutputs.TabStop = false;
            this.grbOutputs.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(195, 111);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(407, 39);
            this.txtArea.TabIndex = 3;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(195, 48);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(407, 39);
            this.txtPerimeter.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(15, 114);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(95, 32);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area: ";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(15, 48);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(163, 32);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perimetro: ";
            // 
            // frmIrregularTrapezoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 583);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Name = "frmIrregularTrapezoid";
            this.Text = "Trapezoide Irregular";
            this.Load += new System.EventHandler(this.frmIrregularTrapezoid_Load);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtRigthSize;
        private System.Windows.Forms.TextBox txtLeftSize;
        private System.Windows.Forms.TextBox txtMinorBase;
        private System.Windows.Forms.TextBox txtMajorBase;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblRightSize;
        private System.Windows.Forms.Label lblLeftSize;
        private System.Windows.Forms.Label lblMinorBase;
        private System.Windows.Forms.Label lblMajorBase;
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
