namespace GUAMAN_JORDAN_FIGURAS
{
    partial class frmEllipse
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
            this.txtSemiMinorAxis = new System.Windows.Forms.TextBox();
            this.txtSemiMajorAxis = new System.Windows.Forms.TextBox();
            this.lblSemiMinorAxis = new System.Windows.Forms.Label();
            this.lblSemiMajorAxis = new System.Windows.Forms.Label();
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
            this.grbInputs.Controls.Add(this.txtSemiMinorAxis);
            this.grbInputs.Controls.Add(this.txtSemiMajorAxis);
            this.grbInputs.Controls.Add(this.lblSemiMinorAxis);
            this.grbInputs.Controls.Add(this.lblSemiMajorAxis);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(12, 26);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(580, 172);
            this.grbInputs.TabIndex = 0;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // txtSemiMinorAxis
            // 
            this.txtSemiMinorAxis.Location = new System.Drawing.Point(310, 99);
            this.txtSemiMinorAxis.Name = "txtSemiMinorAxis";
            this.txtSemiMinorAxis.Size = new System.Drawing.Size(221, 39);
            this.txtSemiMinorAxis.TabIndex = 3;
            // 
            // txtSemiMajorAxis
            // 
            this.txtSemiMajorAxis.Location = new System.Drawing.Point(310, 54);
            this.txtSemiMajorAxis.Name = "txtSemiMajorAxis";
            this.txtSemiMajorAxis.Size = new System.Drawing.Size(221, 39);
            this.txtSemiMajorAxis.TabIndex = 2;
            // 
            // lblSemiMinorAxis
            // 
            this.lblSemiMinorAxis.AutoSize = true;
            this.lblSemiMinorAxis.Location = new System.Drawing.Point(11, 101);
            this.lblSemiMinorAxis.Name = "lblSemiMinorAxis";
            this.lblSemiMinorAxis.Size = new System.Drawing.Size(293, 32);
            this.lblSemiMinorAxis.TabIndex = 1;
            this.lblSemiMinorAxis.Text = "Semi-Eje Menor (b) :";
            // 
            // lblSemiMajorAxis
            // 
            this.lblSemiMajorAxis.AutoSize = true;
            this.lblSemiMajorAxis.Location = new System.Drawing.Point(7, 54);
            this.lblSemiMajorAxis.Name = "lblSemiMajorAxis";
            this.lblSemiMajorAxis.Size = new System.Drawing.Size(291, 32);
            this.lblSemiMajorAxis.TabIndex = 0;
            this.lblSemiMajorAxis.Text = "Semi-Eje Mayor (a) :";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(13, 214);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(579, 194);
            this.grbProcess.TabIndex = 1;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(393, 86);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 63);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(214, 86);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(154, 63);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(35, 86);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(158, 63);
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
            this.grbOutputs.Location = new System.Drawing.Point(13, 427);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Size = new System.Drawing.Size(579, 188);
            this.grbOutputs.TabIndex = 2;
            this.grbOutputs.TabStop = false;
            this.grbOutputs.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(183, 89);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(335, 39);
            this.txtArea.TabIndex = 3;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(183, 44);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(335, 39);
            this.txtPerimeter.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(14, 96);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(87, 32);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(14, 47);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(163, 32);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perimetro: ";
            // 
            // frmEllipse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 637);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Name = "frmEllipse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elipse";
            this.Load += new System.EventHandler(this.frmEllipse_Load);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.GroupBox grbOutputs;
        private System.Windows.Forms.Label lblSemiMajorAxis;
        private System.Windows.Forms.Label lblSemiMinorAxis;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtSemiMajorAxis;
        private System.Windows.Forms.TextBox txtSemiMinorAxis;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}
