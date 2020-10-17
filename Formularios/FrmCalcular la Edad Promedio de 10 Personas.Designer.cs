namespace Programación_Orientada_a_Objetos_JorgeMadrid.Formularios
{
    partial class FrmCalcular_la_Edad_Promedio_de_10_Personas
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
            this.LsbEdad = new System.Windows.Forms.ListBox();
            this.LsbPersona = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.TxtEdadP = new System.Windows.Forms.TextBox();
            this.TxtNombreP = new System.Windows.Forms.TextBox();
            this.LblEdadPr = new System.Windows.Forms.Label();
            this.LblNombreP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCalcularP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LsbEdad
            // 
            this.LsbEdad.FormattingEnabled = true;
            this.LsbEdad.ItemHeight = 19;
            this.LsbEdad.Location = new System.Drawing.Point(351, 316);
            this.LsbEdad.Name = "LsbEdad";
            this.LsbEdad.Size = new System.Drawing.Size(149, 156);
            this.LsbEdad.TabIndex = 38;
            // 
            // LsbPersona
            // 
            this.LsbPersona.FormattingEnabled = true;
            this.LsbPersona.ItemHeight = 19;
            this.LsbPersona.Location = new System.Drawing.Point(92, 316);
            this.LsbPersona.Name = "LsbPersona";
            this.LsbPersona.Size = new System.Drawing.Size(254, 156);
            this.LsbPersona.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(352, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 37);
            this.label5.TabIndex = 36;
            this.label5.Text = "EDAD";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(92, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 37);
            this.label4.TabIndex = 35;
            this.label4.Text = "NOMBRE DE LA PERSONA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnIngresar.Location = new System.Drawing.Point(454, 168);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(124, 44);
            this.BtnIngresar.TabIndex = 34;
            this.BtnIngresar.Text = "INGRESAR";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // TxtEdadP
            // 
            this.TxtEdadP.Location = new System.Drawing.Point(320, 177);
            this.TxtEdadP.Name = "TxtEdadP";
            this.TxtEdadP.Size = new System.Drawing.Size(120, 27);
            this.TxtEdadP.TabIndex = 33;
            // 
            // TxtNombreP
            // 
            this.TxtNombreP.Location = new System.Drawing.Point(320, 132);
            this.TxtNombreP.Name = "TxtNombreP";
            this.TxtNombreP.Size = new System.Drawing.Size(258, 27);
            this.TxtNombreP.TabIndex = 32;
            // 
            // LblEdadPr
            // 
            this.LblEdadPr.AutoSize = true;
            this.LblEdadPr.Location = new System.Drawing.Point(18, 180);
            this.LblEdadPr.Name = "LblEdadPr";
            this.LblEdadPr.Size = new System.Drawing.Size(273, 19);
            this.LblEdadPr.TabIndex = 31;
            this.LblEdadPr.Text = "Ingresar la Edad de la Persona:";
            // 
            // LblNombreP
            // 
            this.LblNombreP.AutoSize = true;
            this.LblNombreP.Location = new System.Drawing.Point(18, 135);
            this.LblNombreP.Name = "LblNombreP";
            this.LblNombreP.Size = new System.Drawing.Size(296, 19);
            this.LblNombreP.TabIndex = 30;
            this.LblNombreP.Text = "Ingresar Nombre de la Persona #1:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(168, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 58);
            this.label1.TabIndex = 29;
            this.label1.Text = "Calcular la Edad Promedio de 10 Personas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCalcularP
            // 
            this.BtnCalcularP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnCalcularP.Location = new System.Drawing.Point(92, 219);
            this.BtnCalcularP.Name = "BtnCalcularP";
            this.BtnCalcularP.Size = new System.Drawing.Size(175, 44);
            this.BtnCalcularP.TabIndex = 39;
            this.BtnCalcularP.Text = "Calcular Promedio";
            this.BtnCalcularP.UseVisualStyleBackColor = false;
            this.BtnCalcularP.Click += new System.EventHandler(this.BtnCalcularP_Click);
            // 
            // FrmCalcular_la_Edad_Promedio_de_10_Personas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(603, 493);
            this.Controls.Add(this.BtnCalcularP);
            this.Controls.Add(this.LsbEdad);
            this.Controls.Add(this.LsbPersona);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.TxtEdadP);
            this.Controls.Add(this.TxtNombreP);
            this.Controls.Add(this.LblEdadPr);
            this.Controls.Add(this.LblNombreP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalcular_la_Edad_Promedio_de_10_Personas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edad Promedio de 10 Personas";
            this.Load += new System.EventHandler(this.FrmCalcular_la_Edad_Promedio_de_10_Personas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox LsbEdad;
        private System.Windows.Forms.ListBox LsbPersona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.TextBox TxtEdadP;
        private System.Windows.Forms.TextBox TxtNombreP;
        private System.Windows.Forms.Label LblEdadPr;
        private System.Windows.Forms.Label LblNombreP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCalcularP;
    }
}