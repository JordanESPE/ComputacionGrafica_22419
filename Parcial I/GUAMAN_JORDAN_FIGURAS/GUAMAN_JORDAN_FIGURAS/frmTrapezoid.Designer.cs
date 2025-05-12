namespace GUAMAN_JORDAN_FIGURAS
{
    partial class frmTrapezoid
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
            this.txtSideSideRigth = new System.Windows.Forms.TextBox();
            this.txtSideSideLeft = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtMinorBase = new System.Windows.Forms.TextBox();
            this.txtMajorBase = new System.Windows.Forms.TextBox();
            this.lblSideSideRigth = new System.Windows.Forms.Label();
            this.lblSideSideLeft = new System.Windows.Forms.Label();
            this.lblHeigth = new System.Windows.Forms.Label();
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
            this.grbInputs.Controls.Add(this.txtSideSideRigth);
            this.grbInputs.Controls.Add(this.txtSideSideLeft);
            this.grbInputs.Controls.Add(this.txtHeight);
            this.grbInputs.Controls.Add(this.txtMinorBase);
            this.grbInputs.Controls.Add(this.txtMajorBase);
            this.grbInputs.Controls.Add(this.lblSideSideRigth);
            this.grbInputs.Controls.Add(this.lblSideSideLeft);
            this.grbInputs.Controls.Add(this.lblHeigth);
            this.grbInputs.Controls.Add(this.lblMinorBase);
            this.grbInputs.Controls.Add(this.lblMajorBase);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(13, 14);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(532, 283);
            this.grbInputs.TabIndex = 0;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // txtSideSideRigth
            // 
            this.txtSideSideRigth.Location = new System.Drawing.Point(305, 235);
            this.txtSideSideRigth.Name = "txtSideSideRigth";
            this.txtSideSideRigth.Size = new System.Drawing.Size(206, 35);
            this.txtSideSideRigth.TabIndex = 8;
            this.txtSideSideRigth.TextChanged += new System.EventHandler(this.txtSideSideRigth_TextChanged);
            // 
            // txtSideSideLeft
            // 
            this.txtSideSideLeft.Location = new System.Drawing.Point(305, 186);
            this.txtSideSideLeft.Name = "txtSideSideLeft";
            this.txtSideSideLeft.Size = new System.Drawing.Size(206, 35);
            this.txtSideSideLeft.TabIndex = 7;
            this.txtSideSideLeft.TextChanged += new System.EventHandler(this.txtSideSideLeft_TextChanged);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(305, 136);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(206, 35);
            this.txtHeight.TabIndex = 6;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // txtMinorBase
            // 
            this.txtMinorBase.Location = new System.Drawing.Point(305, 88);
            this.txtMinorBase.Name = "txtMinorBase";
            this.txtMinorBase.Size = new System.Drawing.Size(206, 35);
            this.txtMinorBase.TabIndex = 5;
            this.txtMinorBase.TextChanged += new System.EventHandler(this.txtMinorBase_TextChanged);
            // 
            // txtMajorBase
            // 
            this.txtMajorBase.Location = new System.Drawing.Point(305, 41);
            this.txtMajorBase.Name = "txtMajorBase";
            this.txtMajorBase.Size = new System.Drawing.Size(206, 35);
            this.txtMajorBase.TabIndex = 3;
            this.txtMajorBase.TextChanged += new System.EventHandler(this.txtMajorBase_TextChanged);
            // 
            // lblSideSideRigth
            // 
            this.lblSideSideRigth.AutoSize = true;
            this.lblSideSideRigth.Location = new System.Drawing.Point(12, 235);
            this.lblSideSideRigth.Name = "lblSideSideRigth";
            this.lblSideSideRigth.Size = new System.Drawing.Size(281, 29);
            this.lblSideSideRigth.TabIndex = 4;
            this.lblSideSideRigth.Text = "Lado Lateral Der. (L2) :";
            // 
            // lblSideSideLeft
            // 
            this.lblSideSideLeft.AutoSize = true;
            this.lblSideSideLeft.Location = new System.Drawing.Point(11, 186);
            this.lblSideSideLeft.Name = "lblSideSideLeft";
            this.lblSideSideLeft.Size = new System.Drawing.Size(273, 29);
            this.lblSideSideLeft.TabIndex = 3;
            this.lblSideSideLeft.Text = "Lado Lateral Izq. (L1) :";
            // 
            // lblHeigth
            // 
            this.lblHeigth.AutoSize = true;
            this.lblHeigth.Location = new System.Drawing.Point(12, 136);
            this.lblHeigth.Name = "lblHeigth";
            this.lblHeigth.Size = new System.Drawing.Size(133, 29);
            this.lblHeigth.TabIndex = 2;
            this.lblHeigth.Text = "Altura (h) :";
            // 
            // lblMinorBase
            // 
            this.lblMinorBase.AutoSize = true;
            this.lblMinorBase.Location = new System.Drawing.Point(10, 88);
            this.lblMinorBase.Name = "lblMinorBase";
            this.lblMinorBase.Size = new System.Drawing.Size(207, 29);
            this.lblMinorBase.TabIndex = 1;
            this.lblMinorBase.Text = "Base Menor (b) :";
            // 
            // lblMajorBase
            // 
            this.lblMajorBase.AutoSize = true;
            this.lblMajorBase.Location = new System.Drawing.Point(11, 41);
            this.lblMajorBase.Name = "lblMajorBase";
            this.lblMajorBase.Size = new System.Drawing.Size(206, 29);
            this.lblMajorBase.TabIndex = 0;
            this.lblMajorBase.Text = "Base Mayor (B) :";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(12, 303);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(532, 105);
            this.grbProcess.TabIndex = 1;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(351, 52);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(184, 52);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(151, 37);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 52);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(152, 37);
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
            this.grbOutputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOutputs.Location = new System.Drawing.Point(13, 414);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Size = new System.Drawing.Size(532, 131);
            this.grbOutputs.TabIndex = 2;
            this.grbOutputs.TabStop = false;
            this.grbOutputs.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(160, 90);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(221, 35);
            this.txtArea.TabIndex = 3;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(160, 43);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(221, 35);
            this.txtPerimeter.TabIndex = 2;
            this.txtPerimeter.TextChanged += new System.EventHandler(this.txtPerimeter_TextChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(16, 84);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(74, 29);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(12, 43);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(142, 29);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perimetro: ";
            // 
            // frmTrapezoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 550);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTrapezoid";
            this.Text = "Trapezoide";
            this.Load += new System.EventHandler(this.frmTrapezoid_Load);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtSideSideRigth;
        private System.Windows.Forms.TextBox txtSideSideLeft;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtMinorBase;
        private System.Windows.Forms.TextBox txtMajorBase;
        private System.Windows.Forms.Label lblSideSideRigth;
        private System.Windows.Forms.Label lblSideSideLeft;
        private System.Windows.Forms.Label lblHeigth;
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