namespace Programación_Orientada_a_Objetos_JorgeMadrid.Formularios
{
    partial class FrmCalcular_el_Salario_de_Empleado_Dias_y_Horas_Extras_Trabajdas
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
            this.TxtPrecioD = new System.Windows.Forms.TextBox();
            this.TxtDias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPrecioH = new System.Windows.Forms.TextBox();
            this.TxtHorasE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(200, 277);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(124, 48);
            this.BtnCalcular.TabIndex = 18;
            this.BtnCalcular.Text = "Calcular el Salario";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtPrecioD
            // 
            this.TxtPrecioD.Location = new System.Drawing.Point(399, 135);
            this.TxtPrecioD.Name = "TxtPrecioD";
            this.TxtPrecioD.Size = new System.Drawing.Size(141, 27);
            this.TxtPrecioD.TabIndex = 17;
            // 
            // TxtDias
            // 
            this.TxtDias.Location = new System.Drawing.Point(399, 91);
            this.TxtDias.Name = "TxtDias";
            this.TxtDias.Size = new System.Drawing.Size(141, 27);
            this.TxtDias.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ingresar el Precio por Dia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ingresar los Dias Trabajados:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(183, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "Calcular el Salario a Pagar de un Empleado:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtPrecioH
            // 
            this.TxtPrecioH.Location = new System.Drawing.Point(400, 223);
            this.TxtPrecioH.Name = "TxtPrecioH";
            this.TxtPrecioH.Size = new System.Drawing.Size(141, 27);
            this.TxtPrecioH.TabIndex = 22;
            // 
            // TxtHorasE
            // 
            this.TxtHorasE.Location = new System.Drawing.Point(400, 179);
            this.TxtHorasE.Name = "TxtHorasE";
            this.TxtHorasE.Size = new System.Drawing.Size(141, 27);
            this.TxtHorasE.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ingresar el Precio de las Horas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(328, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ingresar las Horas Extras Trabajados:";
            // 
            // FrmCalcular_el_Salario_de_Empleado_Dias_y_Horas_Extras_Trabajdas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(607, 360);
            this.Controls.Add(this.TxtPrecioH);
            this.Controls.Add(this.TxtHorasE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtPrecioD);
            this.Controls.Add(this.TxtDias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalcular_el_Salario_de_Empleado_Dias_y_Horas_Extras_Trabajdas";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salario de Empleados Dias y Horas";
            this.Load += new System.EventHandler(this.FrmCalcular_el_Salario_de_Empleado_Dias_y_Horas_Extras_Trabajdas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtPrecioD;
        private System.Windows.Forms.TextBox TxtDias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPrecioH;
        private System.Windows.Forms.TextBox TxtHorasE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}