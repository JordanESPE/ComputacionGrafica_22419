namespace GUAMAN_JORDAN_FIGURAS
{
    partial class frmIsoscelesTrapezoid
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
            this.txtSideSide = new System.Windows.Forms.TextBox();
            this.txtMinorBase = new System.Windows.Forms.TextBox();
            this.txtMajorBase = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblSideSide = new System.Windows.Forms.Label();
            this.lblMinorBase = new System.Windows.Forms.Label();
            this.lblMajorBase = new System.Windows.Forms.Label();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnrReset = new System.Windows.Forms.Button();
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
            this.grbInputs.Controls.Add(this.txtSideSide);
            this.grbInputs.Controls.Add(this.txtMinorBase);
            this.grbInputs.Controls.Add(this.txtMajorBase);
            this.grbInputs.Controls.Add(this.lblHeight);
            this.grbInputs.Controls.Add(this.lblSideSide);
            this.grbInputs.Controls.Add(this.lblMinorBase);
            this.grbInputs.Controls.Add(this.lblMajorBase);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(24, 32);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(634, 236);
            this.grbInputs.TabIndex = 0;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(233, 161);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(207, 35);
            this.txtHeight.TabIndex = 7;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // txtSideSide
            // 
            this.txtSideSide.Location = new System.Drawing.Point(233, 120);
            this.txtSideSide.Name = "txtSideSide";
            this.txtSideSide.Size = new System.Drawing.Size(207, 35);
            this.txtSideSide.TabIndex = 6;
            this.txtSideSide.TextChanged += new System.EventHandler(this.txtSideSide_TextChanged);
            // 
            // txtMinorBase
            // 
            this.txtMinorBase.Location = new System.Drawing.Point(233, 79);
            this.txtMinorBase.Name = "txtMinorBase";
            this.txtMinorBase.Size = new System.Drawing.Size(207, 35);
            this.txtMinorBase.TabIndex = 5;
            this.txtMinorBase.TextChanged += new System.EventHandler(this.txtMinorBase_TextChanged);
            // 
            // txtMajorBase
            // 
            this.txtMajorBase.Location = new System.Drawing.Point(233, 35);
            this.txtMajorBase.Name = "txtMajorBase";
            this.txtMajorBase.Size = new System.Drawing.Size(207, 35);
            this.txtMajorBase.TabIndex = 4;
            this.txtMajorBase.TextChanged += new System.EventHandler(this.txtMajorBase_TextChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(10, 167);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(133, 29);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "Altura (h) :";
            // 
            // lblSideSide
            // 
            this.lblSideSide.AutoSize = true;
            this.lblSideSide.Location = new System.Drawing.Point(6, 126);
            this.lblSideSide.Name = "lblSideSide";
            this.lblSideSide.Size = new System.Drawing.Size(211, 29);
            this.lblSideSide.TabIndex = 2;
            this.lblSideSide.Text = "Lado Lateral (L) :";
            // 
            // lblMinorBase
            // 
            this.lblMinorBase.AutoSize = true;
            this.lblMinorBase.Location = new System.Drawing.Point(7, 79);
            this.lblMinorBase.Name = "lblMinorBase";
            this.lblMinorBase.Size = new System.Drawing.Size(223, 29);
            this.lblMinorBase.TabIndex = 1;
            this.lblMinorBase.Text = "Base Menor (B2) :";
            // 
            // lblMajorBase
            // 
            this.lblMajorBase.AutoSize = true;
            this.lblMajorBase.Location = new System.Drawing.Point(7, 35);
            this.lblMajorBase.Name = "lblMajorBase";
            this.lblMajorBase.Size = new System.Drawing.Size(220, 29);
            this.lblMajorBase.TabIndex = 0;
            this.lblMajorBase.Text = "Base Mayor (B1) :";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnrReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(24, 299);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(634, 183);
            this.grbProcess.TabIndex = 1;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(389, 59);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(157, 68);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnrReset
            // 
            this.btnrReset.Location = new System.Drawing.Point(205, 59);
            this.btnrReset.Name = "btnrReset";
            this.btnrReset.Size = new System.Drawing.Size(161, 68);
            this.btnrReset.TabIndex = 1;
            this.btnrReset.Text = "Resetear";
            this.btnrReset.UseVisualStyleBackColor = true;
            this.btnrReset.Click += new System.EventHandler(this.btnrReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 59);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(167, 68);
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
            this.grbOutputs.Location = new System.Drawing.Point(24, 505);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Size = new System.Drawing.Size(634, 228);
            this.grbOutputs.TabIndex = 2;
            this.grbOutputs.TabStop = false;
            this.grbOutputs.Text = "Salidas";
            this.grbOutputs.Enter += new System.EventHandler(this.grbOutputs_Enter);
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(178, 130);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(262, 35);
            this.txtArea.TabIndex = 3;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(178, 67);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(262, 35);
            this.txtPerimeter.TabIndex = 2;
            this.txtPerimeter.TextChanged += new System.EventHandler(this.txtPerimeter_TextChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(24, 133);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(74, 29);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(24, 67);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(135, 29);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perimetro:";
            // 
            // frmIsoscelesTrapezoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 778);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Name = "frmIsoscelesTrapezoid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trapezoide Isosceles";
            this.Load += new System.EventHandler(this.frmIsoscelesTrapezoid_Load);
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
        private System.Windows.Forms.TextBox txtSideSide;
        private System.Windows.Forms.TextBox txtMinorBase;
        private System.Windows.Forms.TextBox txtMajorBase;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblSideSide;
        private System.Windows.Forms.Label lblMinorBase;
        private System.Windows.Forms.Label lblMajorBase;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnrReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbOutputs;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.TextBox txtArea;
    }
}