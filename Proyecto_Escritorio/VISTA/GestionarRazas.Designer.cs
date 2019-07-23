using System.Windows.Forms;

namespace Proyecto_Escritorio.VISTA
{
    partial class frmGestionarRazas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarRazas));
            this.btnAgragarRaza = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgragarRaza
            // 
            this.btnAgragarRaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgragarRaza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgragarRaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgragarRaza.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgragarRaza.Image = ((System.Drawing.Image)(resources.GetObject("btnAgragarRaza.Image")));
            this.btnAgragarRaza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgragarRaza.Location = new System.Drawing.Point(403, 60);
            this.btnAgragarRaza.Name = "btnAgragarRaza";
            this.btnAgragarRaza.Size = new System.Drawing.Size(96, 33);
            this.btnAgragarRaza.TabIndex = 0;
            this.btnAgragarRaza.Text = "   Agregar";
            this.btnAgragarRaza.UseVisualStyleBackColor = false;
            this.btnAgragarRaza.Click += new System.EventHandler(this.BtnAgragarRaza_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(60, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Raza:";
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(146, 67);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(236, 20);
            this.txtRaza.TabIndex = 4;
            this.txtRaza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRaza_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Gestion Razas";
            // 
            // frmGestionarRazas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(515, 119);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRaza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgragarRaza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGestionarRazas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionarRazas";
            this.Load += new System.EventHandler(this.FrmGestionarRazas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgragarRaza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.Label label1;

        public Button BtnAgragarRaza { get => btnAgragarRaza; set => btnAgragarRaza = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public TextBox TxtRaza { get => txtRaza; set => txtRaza = value; }
       // public PictureBox BtnCerrar { get => btnCerrar; set => btnCerrar = value; }
        public Label Label1 { get => label1; set => label1 = value; }
    }
}