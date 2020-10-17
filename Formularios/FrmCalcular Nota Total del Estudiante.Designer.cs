namespace Programación_Orientada_a_Objetos_JorgeMadrid.Formularios
{
    partial class FrmCalcular_Nota_Total_del_Estudiante
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
            this.BtnCalcularN = new System.Windows.Forms.Button();
            this.TxtAcumulativo = new System.Windows.Forms.TextBox();
            this.TxtExamen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(133, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular la Nota Total de un Estudiante:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota Acumulativa del Estudiante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota de Examen del Estudiante:";
            // 
            // BtnCalcularN
            // 
            this.BtnCalcularN.Location = new System.Drawing.Point(117, 204);
            this.BtnCalcularN.Name = "BtnCalcularN";
            this.BtnCalcularN.Size = new System.Drawing.Size(99, 48);
            this.BtnCalcularN.TabIndex = 3;
            this.BtnCalcularN.Text = "Calcular Nota";
            this.BtnCalcularN.UseVisualStyleBackColor = true;
            // 
            // TxtAcumulativo
            // 
            this.TxtAcumulativo.Location = new System.Drawing.Point(344, 99);
            this.TxtAcumulativo.Name = "TxtAcumulativo";
            this.TxtAcumulativo.Size = new System.Drawing.Size(108, 27);
            this.TxtAcumulativo.TabIndex = 4;
            // 
            // TxtExamen
            // 
            this.TxtExamen.Location = new System.Drawing.Point(344, 149);
            this.TxtExamen.Name = "TxtExamen";
            this.TxtExamen.Size = new System.Drawing.Size(108, 27);
            this.TxtExamen.TabIndex = 5;
            // 
            // FrmCalcular_Nota_Total_del_Estudiante
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(485, 279);
            this.Controls.Add(this.TxtExamen);
            this.Controls.Add(this.TxtAcumulativo);
            this.Controls.Add(this.BtnCalcularN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalcular_Nota_Total_del_Estudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nota Total del Estudiante";
            this.Load += new System.EventHandler(this.FrmCalcular_Nota_Total_del_Estudiante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCalcularN;
        private System.Windows.Forms.TextBox TxtAcumulativo;
        private System.Windows.Forms.TextBox TxtExamen;
    }
}