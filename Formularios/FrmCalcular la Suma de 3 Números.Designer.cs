namespace Programación_Orientada_a_Objetos_JorgeMadrid.Formularios
{
    partial class FrmCalcular_la_Suma_de_3_Números
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrimerV = new System.Windows.Forms.TextBox();
            this.TxtSegundoV = new System.Windows.Forms.TextBox();
            this.TxtTercerV = new System.Windows.Forms.TextBox();
            this.BtnSumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(98, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suma de 3 Números";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar el Primer Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresar el Segundo Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingresar el Tercer Valor:";
            // 
            // TxtPrimerV
            // 
            this.TxtPrimerV.Location = new System.Drawing.Point(276, 99);
            this.TxtPrimerV.Name = "TxtPrimerV";
            this.TxtPrimerV.Size = new System.Drawing.Size(119, 27);
            this.TxtPrimerV.TabIndex = 4;
            // 
            // TxtSegundoV
            // 
            this.TxtSegundoV.Location = new System.Drawing.Point(276, 130);
            this.TxtSegundoV.Name = "TxtSegundoV";
            this.TxtSegundoV.Size = new System.Drawing.Size(119, 27);
            this.TxtSegundoV.TabIndex = 5;
            // 
            // TxtTercerV
            // 
            this.TxtTercerV.Location = new System.Drawing.Point(276, 163);
            this.TxtTercerV.Name = "TxtTercerV";
            this.TxtTercerV.Size = new System.Drawing.Size(119, 27);
            this.TxtTercerV.TabIndex = 6;
            // 
            // BtnSumar
            // 
            this.BtnSumar.Location = new System.Drawing.Point(65, 224);
            this.BtnSumar.Name = "BtnSumar";
            this.BtnSumar.Size = new System.Drawing.Size(112, 36);
            this.BtnSumar.TabIndex = 7;
            this.BtnSumar.Text = "Sumar";
            this.BtnSumar.UseVisualStyleBackColor = true;
            this.BtnSumar.Click += new System.EventHandler(this.BtnSumar_Click);
            // 
            // FrmCalcular_la_Suma_de_3_Números
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(423, 310);
            this.Controls.Add(this.BtnSumar);
            this.Controls.Add(this.TxtTercerV);
            this.Controls.Add(this.TxtSegundoV);
            this.Controls.Add(this.TxtPrimerV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalcular_la_Suma_de_3_Números";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular la Suma de 3 Números";
            this.Load += new System.EventHandler(this.FrmCalcular_la_Suma_de_3_Números_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPrimerV;
        private System.Windows.Forms.TextBox TxtSegundoV;
        private System.Windows.Forms.TextBox TxtTercerV;
        private System.Windows.Forms.Button BtnSumar;
    }
}