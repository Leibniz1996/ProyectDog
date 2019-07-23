namespace Proyecto_Escritorio.VISTA
{
    partial class frmRecuperarContraseña
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
            this.txtsolicitud = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escriba su direccion de correo electronico";
            // 
            // txtsolicitud
            // 
            this.txtsolicitud.Location = new System.Drawing.Point(40, 51);
            this.txtsolicitud.Name = "txtsolicitud";
            this.txtsolicitud.Size = new System.Drawing.Size(360, 20);
            this.txtsolicitud.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(325, 77);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRespuesta.Location = new System.Drawing.Point(44, 115);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(71, 13);
            this.lblRespuesta.TabIndex = 3;
            this.lblRespuesta.Text = "Respuesta:";
            // 
            // frmRecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(441, 181);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtsolicitud);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(457, 220);
            this.MinimumSize = new System.Drawing.Size(457, 220);
            this.Name = "frmRecuperarContraseña";
            this.Text = "frmRecuperarContraseña";
            this.Load += new System.EventHandler(this.FrmRecuperarContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsolicitud;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblRespuesta;
    }
}