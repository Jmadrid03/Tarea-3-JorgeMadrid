namespace Programación_Orientada_a_Objetos_JorgeMadrid.Formularios
{
    partial class FrmConvertir_Dias_a_Minutos
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
            this.BtnConvertir = new System.Windows.Forms.Button();
            this.TxtDias = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConvertir
            // 
            this.BtnConvertir.Location = new System.Drawing.Point(129, 172);
            this.BtnConvertir.Name = "BtnConvertir";
            this.BtnConvertir.Size = new System.Drawing.Size(104, 43);
            this.BtnConvertir.TabIndex = 27;
            this.BtnConvertir.Text = "Convertir";
            this.BtnConvertir.UseVisualStyleBackColor = true;
            this.BtnConvertir.Click += new System.EventHandler(this.BtnConvertir_Click);
            // 
            // TxtDias
            // 
            this.TxtDias.Location = new System.Drawing.Point(284, 127);
            this.TxtDias.Name = "TxtDias";
            this.TxtDias.Size = new System.Drawing.Size(107, 27);
            this.TxtDias.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ingresar la Cantidad de  Dias:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(112, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 45);
            this.label1.TabIndex = 24;
            this.label1.Text = "Convertir Dias a Minutos:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmConvertir_Dias_a_Minutos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(424, 255);
            this.Controls.Add(this.BtnConvertir);
            this.Controls.Add(this.TxtDias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConvertir_Dias_a_Minutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dias a Minutos";
            this.Load += new System.EventHandler(this.FrmConvertir_Dias_a_Minutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConvertir;
        private System.Windows.Forms.TextBox TxtDias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}