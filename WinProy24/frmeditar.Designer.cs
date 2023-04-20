namespace WinProy24
{
    partial class frmeditar
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
            this.medduracion = new System.Windows.Forms.MaskedTextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btneditar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidcurso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // medduracion
            // 
            this.medduracion.Location = new System.Drawing.Point(206, 176);
            this.medduracion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.medduracion.Mask = "99999";
            this.medduracion.Name = "medduracion";
            this.medduracion.Size = new System.Drawing.Size(196, 31);
            this.medduracion.TabIndex = 11;
            this.medduracion.ValidatingType = typeof(int);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(206, 243);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(392, 102);
            this.txtdescripcion.TabIndex = 10;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(206, 111);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(464, 31);
            this.txtnombre.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Duración";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(276, 389);
            this.btneditar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(150, 44);
            this.btneditar.TabIndex = 12;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "IdCurso";
            // 
            // txtidcurso
            // 
            this.txtidcurso.Enabled = false;
            this.txtidcurso.Location = new System.Drawing.Point(206, 34);
            this.txtidcurso.Name = "txtidcurso";
            this.txtidcurso.Size = new System.Drawing.Size(100, 31);
            this.txtidcurso.TabIndex = 14;
            // 
            // frmeditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 479);
            this.Controls.Add(this.txtidcurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.medduracion);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmeditar";
            this.Text = "frmeditar";
            this.Load += new System.EventHandler(this.frmeditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox medduracion;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtidcurso;
    }
}