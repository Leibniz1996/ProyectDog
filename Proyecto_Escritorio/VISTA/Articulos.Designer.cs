using System.Windows.Forms;

namespace Proyecto_Escritorio.VISTA
{
    partial class frmArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulos));
            this.txtDescArt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadArt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioArt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCategoriaArt = new System.Windows.Forms.ComboBox();
            this.btnAddCategoriaArt = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnAddArt = new System.Windows.Forms.Button();
            this.btnUpdateArt = new System.Windows.Forms.Button();
            this.btnDeleteArt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescArt
            // 
            this.txtDescArt.Location = new System.Drawing.Point(523, 49);
            this.txtDescArt.Name = "txtDescArt";
            this.txtDescArt.Size = new System.Drawing.Size(236, 20);
            this.txtDescArt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(379, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descripción:";
            // 
            // txtCantidadArt
            // 
            this.txtCantidadArt.Location = new System.Drawing.Point(523, 88);
            this.txtCantidadArt.Name = "txtCantidadArt";
            this.txtCantidadArt.Size = new System.Drawing.Size(236, 20);
            this.txtCantidadArt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(379, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cantidad:";
            // 
            // txtPrecioArt
            // 
            this.txtPrecioArt.Location = new System.Drawing.Point(523, 127);
            this.txtPrecioArt.Name = "txtPrecioArt";
            this.txtPrecioArt.Size = new System.Drawing.Size(236, 20);
            this.txtPrecioArt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(379, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(379, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Categoria:";
            // 
            // cmbCategoriaArt
            // 
            this.cmbCategoriaArt.FormattingEnabled = true;
            this.cmbCategoriaArt.Location = new System.Drawing.Point(523, 164);
            this.cmbCategoriaArt.Name = "cmbCategoriaArt";
            this.cmbCategoriaArt.Size = new System.Drawing.Size(188, 21);
            this.cmbCategoriaArt.TabIndex = 12;
            // 
            // btnAddCategoriaArt
            // 
            this.btnAddCategoriaArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnAddCategoriaArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategoriaArt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddCategoriaArt.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategoriaArt.Image")));
            this.btnAddCategoriaArt.Location = new System.Drawing.Point(726, 162);
            this.btnAddCategoriaArt.Name = "btnAddCategoriaArt";
            this.btnAddCategoriaArt.Size = new System.Drawing.Size(33, 23);
            this.btnAddCategoriaArt.TabIndex = 13;
            this.btnAddCategoriaArt.UseVisualStyleBackColor = false;
            this.btnAddCategoriaArt.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(265, 205);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(707, 248);
            this.dgvArticulos.TabIndex = 14;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(940, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 37);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Tag = "";
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnAddArt
            // 
            this.btnAddArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnAddArt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddArt.Image = ((System.Drawing.Image)(resources.GetObject("btnAddArt.Image")));
            this.btnAddArt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddArt.Location = new System.Drawing.Point(797, 49);
            this.btnAddArt.Name = "btnAddArt";
            this.btnAddArt.Size = new System.Drawing.Size(104, 33);
            this.btnAddArt.TabIndex = 28;
            this.btnAddArt.Text = "    Agregar";
            this.btnAddArt.UseVisualStyleBackColor = false;
            // 
            // btnUpdateArt
            // 
            this.btnUpdateArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnUpdateArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateArt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateArt.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateArt.Image")));
            this.btnUpdateArt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateArt.Location = new System.Drawing.Point(797, 99);
            this.btnUpdateArt.Name = "btnUpdateArt";
            this.btnUpdateArt.Size = new System.Drawing.Size(104, 38);
            this.btnUpdateArt.TabIndex = 26;
            this.btnUpdateArt.Text = "    Modificar";
            this.btnUpdateArt.UseVisualStyleBackColor = false;
            // 
            // btnDeleteArt
            // 
            this.btnDeleteArt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnDeleteArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteArt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteArt.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteArt.Image")));
            this.btnDeleteArt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteArt.Location = new System.Drawing.Point(797, 158);
            this.btnDeleteArt.Name = "btnDeleteArt";
            this.btnDeleteArt.Size = new System.Drawing.Size(104, 38);
            this.btnDeleteArt.TabIndex = 27;
            this.btnDeleteArt.Text = "Eliminar";
            this.btnDeleteArt.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(505, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Gestion Articulos";
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(979, 599);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddArt);
            this.Controls.Add(this.btnUpdateArt);
            this.Controls.Add(this.btnDeleteArt);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnAddCategoriaArt);
            this.Controls.Add(this.cmbCategoriaArt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecioArt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidadArt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescArt);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmArticulos";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescArt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidadArt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioArt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCategoriaArt;
        private System.Windows.Forms.Button btnAddCategoriaArt;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnAddArt;
        private System.Windows.Forms.Button btnUpdateArt;
        private System.Windows.Forms.Button btnDeleteArt;
        private System.Windows.Forms.Label label5;

        public TextBox TxtDescArt { get => txtDescArt; set => txtDescArt = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public TextBox TxtCantidadArt { get => txtCantidadArt; set => txtCantidadArt = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtPrecioArt { get => txtPrecioArt; set => txtPrecioArt = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public ComboBox CmbCategoriaArt { get => cmbCategoriaArt; set => cmbCategoriaArt = value; }
        public Button BtnAddCategoriaArt { get => btnAddCategoriaArt; set => btnAddCategoriaArt = value; }
        public DataGridView DgvArticulos { get => dgvArticulos; set => dgvArticulos = value; }
        public PictureBox BtnCerrar { get => btnCerrar; set => btnCerrar = value; }
        public Button BtnAddArt { get => btnAddArt; set => btnAddArt = value; }
        public Button BtnUpdateArt { get => btnUpdateArt; set => btnUpdateArt = value; }
        public Button BtnDeleteArt { get => btnDeleteArt; set => btnDeleteArt = value; }
        public Label Label5 { get => label5; set => label5 = value; }
    }
}