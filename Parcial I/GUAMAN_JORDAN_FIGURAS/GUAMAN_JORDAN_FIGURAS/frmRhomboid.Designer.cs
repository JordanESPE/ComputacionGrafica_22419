namespace GUAMAN_JORDAN_FIGURAS
{
    partial class frmRhomboid
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
            this.txtSideSide = new System.Windows.Forms.TextBox();
            this.txtHeigth = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblSideSide = new System.Windows.Forms.Label();
            this.lblHeigth = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
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
            this.grbInputs.Controls.Add(this.txtSideSide);
            this.grbInputs.Controls.Add(this.txtHeigth);
            this.grbInputs.Controls.Add(this.txtWidth);
            this.grbInputs.Controls.Add(this.lblSideSide);
            this.grbInputs.Controls.Add(this.lblHeigth);
            this.grbInputs.Controls.Add(this.lblWidth);
            this.grbInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(13, 13);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(527, 252);
            this.grbInputs.TabIndex = 0;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // txtSideSide
            // 
            this.txtSideSide.Location = new System.Drawing.Point(229, 169);
            this.txtSideSide.Name = "txtSideSide";
            this.txtSideSide.Size = new System.Drawing.Size(277, 35);
            this.txtSideSide.TabIndex = 5;
            this.txtSideSide.TextChanged += new System.EventHandler(this.txtSideSide_TextChanged);
            // 
            // txtHeigth
            // 
            this.txtHeigth.Location = new System.Drawing.Point(229, 106);
            this.txtHeigth.Name = "txtHeigth";
            this.txtHeigth.Size = new System.Drawing.Size(277, 35);
            this.txtHeigth.TabIndex = 4;
            this.txtHeigth.TextChanged += new System.EventHandler(this.txtHeigth_TextChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(229, 50);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(277, 35);
            this.txtWidth.TabIndex = 3;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // lblSideSide
            // 
            this.lblSideSide.AutoSize = true;
            this.lblSideSide.Location = new System.Drawing.Point(11, 175);
            this.lblSideSide.Name = "lblSideSide";
            this.lblSideSide.Size = new System.Drawing.Size(204, 29);
            this.lblSideSide.TabIndex = 2;
            this.lblSideSide.Text = "Lado Lateral (I) :";
            // 
            // lblHeigth
            // 
            this.lblHeigth.AutoSize = true;
            this.lblHeigth.Location = new System.Drawing.Point(11, 109);
            this.lblHeigth.Name = "lblHeigth";
            this.lblHeigth.Size = new System.Drawing.Size(134, 29);
            this.lblHeigth.TabIndex = 1;
            this.lblHeigth.Text = "Largo (b) :";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(11, 50);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(138, 29);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Ancho (a) :";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbProcess.Location = new System.Drawing.Point(13, 283);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(527, 149);
            this.grbProcess.TabIndex = 1;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(350, 50);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 71);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(182, 50);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(153, 71);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(16, 50);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 71);
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
            this.grbOutputs.Location = new System.Drawing.Point(13, 438);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Size = new System.Drawing.Size(571, 135);
            this.grbOutputs.TabIndex = 2;
            this.grbOutputs.TabStop = false;
            this.grbOutputs.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(147, 76);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(278, 35);
            this.txtArea.TabIndex = 3;
            this.txtArea.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(147, 31);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(278, 35);
            this.txtPerimeter.TabIndex = 2;
            this.txtPerimeter.TextChanged += new System.EventHandler(this.txtPerimeter_TextChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(11, 79);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(74, 29);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(11, 37);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(142, 29);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perimetro: ";
            // 
            // frmRhomboid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 587);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbInputs);
            this.Name = "frmRhomboid";
            this.Text = "Romboide";
            this.Load += new System.EventHandler(this.frmRhomboid_Load);
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtSideSide;
        private System.Windows.Forms.TextBox txtHeigth;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblSideSide;
        private System.Windows.Forms.Label lblHeigth;
        private System.Windows.Forms.Label lblWidth;
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