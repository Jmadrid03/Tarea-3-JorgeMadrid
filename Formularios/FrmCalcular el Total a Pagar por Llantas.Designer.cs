namespace Programación_Orientada_a_Objetos_JorgeMadrid.Formularios
{
    partial class FrmCalcular_el_Total_a_Pagar_por_Llantas
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
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(123, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular el Total a Pagar por la Compra de Llantas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar la Cantidad de Llantas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresar el Precio de las Llantas:";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(326, 115);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(141, 27);
            this.TxtCantidad.TabIndex = 4;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(326, 159);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(141, 27);
            this.TxtPrecio.TabIndex = 5;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(152, 206);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(124, 48);
            this.BtnCalcular.TabIndex = 6;
            this.BtnCalcular.Text = "Calcular el Total";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // FrmCalcular_el_Total_a_Pagar_por_Llantas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(491, 278);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalcular_el_Total_a_Pagar_por_Llantas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total a Pagar por Llantas";
            this.Load += new System.EventHandler(this.FrmCalcular_el_Total_a_Pagar_por_Llantas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Button BtnCalcular;
    }
}