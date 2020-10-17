namespace Programación_Orientada_a_Objetos_JorgeMadrid.Formularios
{
    partial class FrmCalcular_el_Cuadrado_de_un_Número
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
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(82, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular el Cuadrado de un Número:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar un Número:";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(231, 124);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(100, 27);
            this.TxtNumero.TabIndex = 2;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(72, 186);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(122, 46);
            this.BtnCalcular.TabIndex = 3;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // FrmCalcular_el_Cuadrado_de_un_Número
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(362, 265);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalcular_el_Cuadrado_de_un_Número";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "El Cuadrado de un Número";
            this.Load += new System.EventHandler(this.FrmCalcular_el_Cuadrado_de_un_Número_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Button BtnCalcular;
    }
}