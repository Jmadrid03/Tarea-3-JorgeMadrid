namespace Programación_Orientada_a_Objetos_JorgeMadrid.Formularios
{
    partial class FrmCalcular_Promedio_de_4_Calficaciones_de_Estudiante
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
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCal1 = new System.Windows.Forms.TextBox();
            this.TxtCal2 = new System.Windows.Forms.TextBox();
            this.TxtCal3 = new System.Windows.Forms.TextBox();
            this.TxtCal4 = new System.Windows.Forms.TextBox();
            this.BtnCalcularP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(123, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular Promedio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar Calificaión 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresar Calificaión 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingresar Calificaión 3:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ingresar Calificaión 4:";
            // 
            // TxtCal1
            // 
            this.TxtCal1.Location = new System.Drawing.Point(256, 116);
            this.TxtCal1.Name = "TxtCal1";
            this.TxtCal1.Size = new System.Drawing.Size(126, 27);
            this.TxtCal1.TabIndex = 5;
            // 
            // TxtCal2
            // 
            this.TxtCal2.Location = new System.Drawing.Point(256, 146);
            this.TxtCal2.Name = "TxtCal2";
            this.TxtCal2.Size = new System.Drawing.Size(126, 27);
            this.TxtCal2.TabIndex = 6;
            // 
            // TxtCal3
            // 
            this.TxtCal3.Location = new System.Drawing.Point(256, 177);
            this.TxtCal3.Name = "TxtCal3";
            this.TxtCal3.Size = new System.Drawing.Size(126, 27);
            this.TxtCal3.TabIndex = 7;
            this.TxtCal3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // TxtCal4
            // 
            this.TxtCal4.Location = new System.Drawing.Point(256, 208);
            this.TxtCal4.Name = "TxtCal4";
            this.TxtCal4.Size = new System.Drawing.Size(126, 27);
            this.TxtCal4.TabIndex = 8;
            // 
            // BtnCalcularP
            // 
            this.BtnCalcularP.Location = new System.Drawing.Point(137, 262);
            this.BtnCalcularP.Name = "BtnCalcularP";
            this.BtnCalcularP.Size = new System.Drawing.Size(149, 58);
            this.BtnCalcularP.TabIndex = 9;
            this.BtnCalcularP.Text = "Calcular Promedio";
            this.BtnCalcularP.UseVisualStyleBackColor = true;
            this.BtnCalcularP.Click += new System.EventHandler(this.BtnCalcularP_Click);
            // 
            // FrmCalcular_Promedio_de_4_Calficaciones_de_Estudiante
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(437, 358);
            this.Controls.Add(this.BtnCalcularP);
            this.Controls.Add(this.TxtCal4);
            this.Controls.Add(this.TxtCal3);
            this.Controls.Add(this.TxtCal2);
            this.Controls.Add(this.TxtCal1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalcular_Promedio_de_4_Calficaciones_de_Estudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Promedio de 4 Calficaciones de Estudiante";
            this.Load += new System.EventHandler(this.FrmCalcular_Promedio_de_4_Calficaciones_de_Estudiante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCal1;
        private System.Windows.Forms.TextBox TxtCal2;
        private System.Windows.Forms.TextBox TxtCal3;
        private System.Windows.Forms.TextBox TxtCal4;
        private System.Windows.Forms.Button BtnCalcularP;
    }
}