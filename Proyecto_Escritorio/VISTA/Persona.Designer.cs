using System.ComponentModel;
using System.Windows.Forms;

namespace Proyecto_Escritorio.VISTA
{
    partial class frmPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersona));
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDirecc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgragarRaza = new System.Windows.Forms.Button();
            this.txtCelukar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(174, 103);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(236, 20);
            this.txtNom.TabIndex = 8;
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNom_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Apellido:";
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(174, 144);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(236, 20);
            this.txtApe.TabIndex = 10;
            this.txtApe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApe_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // txtDirecc
            // 
            this.txtDirecc.Location = new System.Drawing.Point(174, 187);
            this.txtDirecc.Name = "txtDirecc";
            this.txtDirecc.Size = new System.Drawing.Size(236, 20);
            this.txtDirecc.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Direeccion:";
            // 
            // btnAgragarRaza
            // 
            this.btnAgragarRaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgragarRaza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgragarRaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgragarRaza.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgragarRaza.Image = ((System.Drawing.Image)(resources.GetObject("btnAgragarRaza.Image")));
            this.btnAgragarRaza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgragarRaza.Location = new System.Drawing.Point(149, 312);
            this.btnAgragarRaza.Name = "btnAgragarRaza";
            this.btnAgragarRaza.Size = new System.Drawing.Size(104, 33);
            this.btnAgragarRaza.TabIndex = 13;
            this.btnAgragarRaza.Text = "Agregar";
            this.btnAgragarRaza.UseVisualStyleBackColor = false;
            this.btnAgragarRaza.Click += new System.EventHandler(this.BtnAgragarRaza_Click);
            // 
            // txtCelukar
            // 
            this.txtCelukar.Location = new System.Drawing.Point(174, 225);
            this.txtCelukar.Name = "txtCelukar";
            this.txtCelukar.Size = new System.Drawing.Size(236, 20);
            this.txtCelukar.TabIndex = 15;
            this.txtCelukar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCelukar_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Celular:";
            // 
            // txtCed
            // 
            this.txtCed.Location = new System.Drawing.Point(174, 66);
            this.txtCed.Name = "txtCed";
            this.txtCed.Size = new System.Drawing.Size(236, 20);
            this.txtCed.TabIndex = 17;
            this.txtCed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCed_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cedula:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(170, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "CLIENTE";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(174, 265);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(236, 20);
            this.txtCorreo.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(12, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Correo Electronico:";
            // 
            // frmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(422, 356);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCelukar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgragarRaza);
            this.Controls.Add(this.txtDirecc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Persona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirecc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgragarRaza;
        private System.Windows.Forms.TextBox txtCelukar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label7;

        public TextBox TxtNom { get => txtNom; set => txtNom = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public TextBox TxtApe { get => txtApe; set => txtApe = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtDirecc { get => txtDirecc; set => txtDirecc = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Button BtnAgragarRaza { get => btnAgragarRaza; set => btnAgragarRaza = value; }
        public TextBox TxtCelukar { get => txtCelukar; set => txtCelukar = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public TextBox TxtCed { get => txtCed; set => txtCed = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public TextBox TxtCorreo { get => txtCorreo; set => txtCorreo = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public IContainer Components { get => components; set => components = value; }
    }
}