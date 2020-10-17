namespace Programación_Orientada_a_Objetos_JorgeMadrid.Formularios
{
    partial class FrmConvertir_Galones_a_Litros
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
            this.TxtGalones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnConvertir
            // 
            this.BtnConvertir.Location = new System.Drawing.Point(132, 181);
            this.BtnConvertir.Name = "BtnConvertir";
            this.BtnConvertir.Size = new System.Drawing.Size(104, 43);
            this.BtnConvertir.TabIndex = 15;
            this.BtnConvertir.Text = "Convertir";
            this.BtnConvertir.UseVisualStyleBackColor = true;
            this.BtnConvertir.Click += new System.EventHandler(this.BtnConvertir_Click);
            // 
            // TxtGalones
            // 
            this.TxtGalones.Location = new System.Drawing.Point(328, 136);
            this.TxtGalones.Name = "TxtGalones";
            this.TxtGalones.Size = new System.Drawing.Size(107, 27);
            this.TxtGalones.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ingresar la Cantidad de Galones:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(132, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 45);
            this.label1.TabIndex = 12;
            this.label1.Text = "Convertir Galones a Litros:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmConvertir_Galones_a_Litros
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(475, 260);
            this.Controls.Add(this.BtnConvertir);
            this.Controls.Add(this.TxtGalones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConvertir_Galones_a_Litros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galones a Litros";
            this.Load += new System.EventHandler(this.FrmConvertir_Galones_a_Litros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConvertir;
        private System.Windows.Forms.TextBox TxtGalones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}