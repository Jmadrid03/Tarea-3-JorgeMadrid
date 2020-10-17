namespace Programación_Orientada_a_Objetos_JorgeMadrid.Formularios
{
    partial class FrmCalcular_el_Total_a_Pagar_de_un_Constructor
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
            this.TxtPrecm2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtMetro2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtPrecm2
            // 
            this.TxtPrecm2.Location = new System.Drawing.Point(371, 146);
            this.TxtPrecm2.Name = "TxtPrecm2";
            this.TxtPrecm2.Size = new System.Drawing.Size(92, 27);
            this.TxtPrecm2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ingresar el Precio por Metro Cuadrado:";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(128, 212);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(105, 36);
            this.BtnCalcular.TabIndex = 9;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtMetro2
            // 
            this.TxtMetro2.Location = new System.Drawing.Point(371, 104);
            this.TxtMetro2.Name = "TxtMetro2";
            this.TxtMetro2.Size = new System.Drawing.Size(92, 27);
            this.TxtMetro2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingresar los Metros Cuadrados:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(126, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "Calcular el Total a Pagar a un Constructor:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCalcular_el_Total_a_Pagar_de_un_Constructor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(488, 277);
            this.Controls.Add(this.TxtPrecm2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtMetro2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalcular_el_Total_a_Pagar_de_un_Constructor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total a Pagar de un Constructor";
            this.Load += new System.EventHandler(this.FrmCalcular_el_Total_a_Pagar_de_un_Constructor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPrecm2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtMetro2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}