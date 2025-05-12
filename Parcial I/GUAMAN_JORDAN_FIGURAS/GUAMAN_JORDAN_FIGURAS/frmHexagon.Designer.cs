namespace GUAMAN_JORDAN_FIGURAS
{
    partial class frmHexagon
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
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.txtApotema = new System.Windows.Forms.TextBox();
            this.lblApothem = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblSide = new System.Windows.Forms.Label();
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
            this.grbInputs.Controls.Add(this.txtApotema);
            this.grbInputs.Controls.Add(this.lblApothem);
            this.grbInputs.Controls.Add(this.txtSize);
            this.grbInputs.Controls.Add(this.lblSide);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.grbInputs.Location = new System.Drawing.Point(23, 29);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(476, 175);
            this.grbInputs.TabIndex = 0;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // txtApotema
            // 
            this.txtApotema.Location = new System.Drawing.Point(213, 118);
            this.txtApotema.Name = "txtApotema";
            this.txtApotema.Size = new System.Drawing.Size(219, 39);
            this.txtApotema.TabIndex = 3;
            this.txtApotema.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblApothem
            // 
            this.lblApothem.AutoSize = true;
            this.lblApothem.Location = new System.Drawing.Point(10, 121);
            this.lblApothem.Name = "lblApothem";
            this.lblApothem.Size = new System.Drawing.Size(197, 32);
            this.lblApothem.TabIndex = 2;
            this.lblApothem.Text = "Apotema (a) :";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(213, 44);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(219, 39);
            this.txtSize.TabIndex = 1;
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(6, 47);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(144, 32);
            this.lblSide.TabIndex = 0;
            this.lblSide.Text = "Lado (L) :";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.grbProcess.Location = new System.Drawing.Point(23, 210);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(476, 143);
            this.grbProcess.TabIndex = 1;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(324, 59);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(146, 56);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(166, 59);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 56);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(10, 59);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 56);
            this.btnCalculate.TabIndex = 1;
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
            this.grbOutputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.grbOutputs.Location = new System.Drawing.Point(23, 359);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Size = new System.Drawing.Size(476, 160);
            this.grbOutputs.TabIndex = 2;
            this.grbOutputs.TabStop = false;
            this.grbOutputs.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(185, 86);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(219, 39);
            this.txtArea.TabIndex = 3;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(185, 48);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(219, 39);
            this.txtPerimeter.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(27, 89);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(87, 32);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(27, 51);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(155, 32);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perimetro:";
            // 
            // frmHexagon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 531);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Name = "frmHexagon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hexagono";
            this.Load += new System.EventHandler(this.frmHexagon_Load);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtSize;
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
        private System.Windows.Forms.TextBox txtApotema;
        private System.Windows.Forms.Label lblApothem;
    }
}