namespace GUAMAN_JORDAN_FIGURAS
{
    partial class frmNonagon
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
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.grbOutputs = new System.Windows.Forms.GroupBox();
            this.lblSide = new System.Windows.Forms.Label();
            this.lblApothem = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSide = new System.Windows.Forms.TextBox();
            this.txtApothem = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.grbInputs.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.grbOutputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtApothem);
            this.grbInputs.Controls.Add(this.txtSide);
            this.grbInputs.Controls.Add(this.lblApothem);
            this.grbInputs.Controls.Add(this.lblSide);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(13, 14);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(599, 136);
            this.grbInputs.TabIndex = 0;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(13, 156);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(599, 169);
            this.grbProcess.TabIndex = 1;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            // 
            // grbOutputs
            // 
            this.grbOutputs.Controls.Add(this.txtArea);
            this.grbOutputs.Controls.Add(this.txtPerimeter);
            this.grbOutputs.Controls.Add(this.lblArea);
            this.grbOutputs.Controls.Add(this.lblPerimeter);
            this.grbOutputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOutputs.Location = new System.Drawing.Point(13, 331);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Size = new System.Drawing.Size(599, 148);
            this.grbOutputs.TabIndex = 2;
            this.grbOutputs.TabStop = false;
            this.grbOutputs.Text = "Salidas";
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(7, 41);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(124, 29);
            this.lblSide.TabIndex = 0;
            this.lblSide.Text = "Lado (L) :";
            // 
            // lblApothem
            // 
            this.lblApothem.AutoSize = true;
            this.lblApothem.Location = new System.Drawing.Point(11, 86);
            this.lblApothem.Name = "lblApothem";
            this.lblApothem.Size = new System.Drawing.Size(169, 29);
            this.lblApothem.TabIndex = 1;
            this.lblApothem.Text = "Apotema (a) :";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(11, 43);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(142, 29);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perimetro: ";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(14, 84);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(74, 29);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(19, 67);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(161, 72);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(206, 67);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(155, 72);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(377, 67);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 72);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(196, 45);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(325, 35);
            this.txtSide.TabIndex = 2;
            this.txtSide.TextChanged += new System.EventHandler(this.txtSide_TextChanged);
            // 
            // txtApothem
            // 
            this.txtApothem.Location = new System.Drawing.Point(196, 86);
            this.txtApothem.Name = "txtApothem";
            this.txtApothem.Size = new System.Drawing.Size(325, 35);
            this.txtApothem.TabIndex = 3;
            this.txtApothem.TextChanged += new System.EventHandler(this.txtApothem_TextChanged);
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(206, 37);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(315, 35);
            this.txtPerimeter.TabIndex = 2;
            this.txtPerimeter.TextChanged += new System.EventHandler(this.txtPerimeter_TextChanged);
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(206, 84);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(315, 35);
            this.txtArea.TabIndex = 3;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // frmNonagon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 485);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Name = "frmNonagon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eneagono";
            this.Load += new System.EventHandler(this.frmNonagon_Load);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtApothem;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.Label lblApothem;
        private System.Windows.Forms.Label lblSide;
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