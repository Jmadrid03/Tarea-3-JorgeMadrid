namespace Programación_Orientada_a_Objetos_JorgeMadrid.Formularios
{
    partial class FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_un_Aumento
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
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtAumento = new System.Windows.Forms.TextBox();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(147, 199);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(124, 48);
            this.BtnCalcular.TabIndex = 12;
            this.BtnCalcular.Text = "Calcular el Total";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtAumento
            // 
            this.TxtAumento.Location = new System.Drawing.Point(331, 152);
            this.TxtAumento.Name = "TxtAumento";
            this.TxtAumento.Size = new System.Drawing.Size(141, 27);
            this.TxtAumento.TabIndex = 11;
            // 
            // TxtSalario
            // 
            this.TxtSalario.Location = new System.Drawing.Point(331, 108);
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.Size = new System.Drawing.Size(141, 27);
            this.TxtSalario.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ingresar el Porcentaje del Aumento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingresar el Salario del Empleado:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(98, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 57);
            this.label1.TabIndex = 7;
            this.label1.Text = "Calcular el Salario a Pagar Tomando en Cuenta un Aumento:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_un_Aumento
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(497, 280);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtAumento);
            this.Controls.Add(this.TxtSalario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_un_Aumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salario del Empleado Tomando en Cuenta un Aumento";
            this.Load += new System.EventHandler(this.FrmCalcular_el_Salario_de_un_Empleado_Tomando_en_Cuenta_un_Aumento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtAumento;
        private System.Windows.Forms.TextBox TxtSalario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}