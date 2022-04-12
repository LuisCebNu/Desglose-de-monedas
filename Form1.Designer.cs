namespace DescuentoARSyAFP
{
    partial class Form1
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblIntroduzcaSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescuentoARS = new System.Windows.Forms.Label();
            this.lblDescuentoAFP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(226, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(256, 31);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Descuento salarial";
            // 
            // lblIntroduzcaSalario
            // 
            this.lblIntroduzcaSalario.AutoSize = true;
            this.lblIntroduzcaSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroduzcaSalario.Location = new System.Drawing.Point(101, 60);
            this.lblIntroduzcaSalario.Name = "lblIntroduzcaSalario";
            this.lblIntroduzcaSalario.Size = new System.Drawing.Size(202, 24);
            this.lblIntroduzcaSalario.TabIndex = 1;
            this.lblIntroduzcaSalario.Text = "Introduzca su salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(371, 60);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(143, 20);
            this.txtSalario.TabIndex = 2;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDescuentoARS);
            this.panel1.Controls.Add(this.lblDescuentoAFP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(70, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 163);
            this.panel1.TabIndex = 3;
            // 
            // lblDescuentoARS
            // 
            this.lblDescuentoARS.AutoSize = true;
            this.lblDescuentoARS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuentoARS.Location = new System.Drawing.Point(408, 88);
            this.lblDescuentoARS.Name = "lblDescuentoARS";
            this.lblDescuentoARS.Size = new System.Drawing.Size(23, 18);
            this.lblDescuentoARS.TabIndex = 7;
            this.lblDescuentoARS.Text = "...";
            // 
            // lblDescuentoAFP
            // 
            this.lblDescuentoAFP.AutoSize = true;
            this.lblDescuentoAFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuentoAFP.Location = new System.Drawing.Point(408, 23);
            this.lblDescuentoAFP.Name = "lblDescuentoAFP";
            this.lblDescuentoAFP.Size = new System.Drawing.Size(23, 18);
            this.lblDescuentoAFP.TabIndex = 6;
            this.lblDescuentoAFP.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descuento de ARS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descuento de AFP";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(540, 58);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(80, 26);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 308);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblIntroduzcaSalario);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "Descuento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblIntroduzcaSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescuentoARS;
        private System.Windows.Forms.Label lblDescuentoAFP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
    }
}

