namespace GUAMAN_JORDAN_FIGURAS
{
    partial class frmHeptagon
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
            this.txtApotem = new System.Windows.Forms.TextBox();
            this.lblApothem = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.grbOutputs = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grbInputs.SuspendLayout();
            this.grbOutputs.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtApotem);
            this.grbInputs.Controls.Add(this.lblApothem);
            this.grbInputs.Controls.Add(this.txtSize);
            this.grbInputs.Controls.Add(this.lblSize);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(12, 25);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(549, 156);
            this.grbInputs.TabIndex = 0;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // txtApotem
            // 
            this.txtApotem.Location = new System.Drawing.Point(227, 113);
            this.txtApotem.Name = "txtApotem";
            this.txtApotem.Size = new System.Drawing.Size(235, 39);
            this.txtApotem.TabIndex = 3;
            this.txtApotem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblApothem
            // 
            this.lblApothem.AutoSize = true;
            this.lblApothem.Location = new System.Drawing.Point(10, 108);
            this.lblApothem.Name = "lblApothem";
            this.lblApothem.Size = new System.Drawing.Size(197, 32);
            this.lblApothem.TabIndex = 2;
            this.lblApothem.Text = "Apotema (a) :";
            this.lblApothem.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(227, 44);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(235, 39);
            this.txtSize.TabIndex = 1;
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(7, 47);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(144, 32);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Lado (L) :";
            // 
            // grbOutputs
            // 
            this.grbOutputs.Controls.Add(this.txtArea);
            this.grbOutputs.Controls.Add(this.txtPerimeter);
            this.grbOutputs.Controls.Add(this.lblArea);
            this.grbOutputs.Controls.Add(this.lblPerimeter);
            this.grbOutputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOutputs.Location = new System.Drawing.Point(12, 347);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Size = new System.Drawing.Size(548, 141);
            this.grbOutputs.TabIndex = 2;
            this.grbOutputs.TabStop = false;
            this.grbOutputs.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(186, 76);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(235, 39);
            this.txtArea.TabIndex = 3;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(186, 38);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(235, 39);
            this.txtPerimeter.TabIndex = 2;
            this.txtPerimeter.TextChanged += new System.EventHandler(this.txtPerimeter_TextChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(10, 83);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(95, 32);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area: ";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(10, 40);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(163, 32);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perimetro: ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 60);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(143, 60);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(11, 187);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(549, 139);
            this.grbProcess.TabIndex = 1;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(347, 60);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 60);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(178, 60);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 60);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmHeptagon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 489);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Name = "frmHeptagon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heptagono";
            this.Load += new System.EventHandler(this.frmHeptagon_Load);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.GroupBox grbOutputs;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblApothem;
        private System.Windows.Forms.TextBox txtApotem;
    }
}