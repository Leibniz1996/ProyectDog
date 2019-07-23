using System.Windows.Forms;

namespace Proyecto_Escritorio.VISTA
{
    partial class frmVacunacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVacunacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.txtNomVacuna = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVacunas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAgragarVacuna = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpFechaV = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVacunarPerro = new System.Windows.Forms.Button();
            this.cmbVacuna = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPerro = new System.Windows.Forms.DataGridView();
            this.txtPerro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacunas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1134, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 37);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Tag = "";
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // txtNomVacuna
            // 
            this.txtNomVacuna.Location = new System.Drawing.Point(211, 28);
            this.txtNomVacuna.Name = "txtNomVacuna";
            this.txtNomVacuna.Size = new System.Drawing.Size(158, 20);
            this.txtNomVacuna.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(88, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Descripcion:";
            // 
            // dgvVacunas
            // 
            this.dgvVacunas.AllowUserToAddRows = false;
            this.dgvVacunas.AllowUserToDeleteRows = false;
            this.dgvVacunas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVacunas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVacunas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvVacunas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVacunas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVacunas.ColumnHeadersHeight = 30;
            this.dgvVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVacunas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVacunas.Location = new System.Drawing.Point(92, 110);
            this.dgvVacunas.Name = "dgvVacunas";
            this.dgvVacunas.Size = new System.Drawing.Size(277, 182);
            this.dgvVacunas.TabIndex = 23;
            this.dgvVacunas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVacunas_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAgragarVacuna);
            this.panel1.Controls.Add(this.dgvVacunas);
            this.panel1.Controls.Add(this.txtNomVacuna);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(86, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 338);
            this.panel1.TabIndex = 24;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(256, 66);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 33);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAgragarVacuna
            // 
            this.btnAgragarVacuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAgragarVacuna.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgragarVacuna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgragarVacuna.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgragarVacuna.Image = ((System.Drawing.Image)(resources.GetObject("btnAgragarVacuna.Image")));
            this.btnAgragarVacuna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgragarVacuna.Location = new System.Drawing.Point(123, 66);
            this.btnAgragarVacuna.Name = "btnAgragarVacuna";
            this.btnAgragarVacuna.Size = new System.Drawing.Size(104, 33);
            this.btnAgragarVacuna.TabIndex = 24;
            this.btnAgragarVacuna.Text = "Agregar";
            this.btnAgragarVacuna.UseVisualStyleBackColor = false;
            this.btnAgragarVacuna.Click += new System.EventHandler(this.BtnAgragarRaza_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dtpFechaV);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnVacunarPerro);
            this.panel2.Controls.Add(this.cmbVacuna);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dgvPerro);
            this.panel2.Controls.Add(this.txtPerro);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(582, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 338);
            this.panel2.TabIndex = 25;
            // 
            // dtpFechaV
            // 
            this.dtpFechaV.Location = new System.Drawing.Point(158, 37);
            this.dtpFechaV.Name = "dtpFechaV";
            this.dtpFechaV.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaV.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(58, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Fecha:";
            // 
            // btnVacunarPerro
            // 
            this.btnVacunarPerro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVacunarPerro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVacunarPerro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVacunarPerro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVacunarPerro.Image = ((System.Drawing.Image)(resources.GetObject("btnVacunarPerro.Image")));
            this.btnVacunarPerro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVacunarPerro.Location = new System.Drawing.Point(428, 66);
            this.btnVacunarPerro.Name = "btnVacunarPerro";
            this.btnVacunarPerro.Size = new System.Drawing.Size(104, 33);
            this.btnVacunarPerro.TabIndex = 26;
            this.btnVacunarPerro.Text = "Agregar";
            this.btnVacunarPerro.UseVisualStyleBackColor = false;
            this.btnVacunarPerro.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cmbVacuna
            // 
            this.cmbVacuna.FormattingEnabled = true;
            this.cmbVacuna.Location = new System.Drawing.Point(158, 78);
            this.cmbVacuna.Name = "cmbVacuna";
            this.cmbVacuna.Size = new System.Drawing.Size(200, 21);
            this.cmbVacuna.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(58, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Vacuna:";
            // 
            // dgvPerro
            // 
            this.dgvPerro.AllowUserToAddRows = false;
            this.dgvPerro.AllowUserToDeleteRows = false;
            this.dgvPerro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvPerro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPerro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPerro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPerro.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPerro.Location = new System.Drawing.Point(33, 148);
            this.dgvPerro.Name = "dgvPerro";
            this.dgvPerro.Size = new System.Drawing.Size(499, 165);
            this.dgvPerro.TabIndex = 23;
            this.dgvPerro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPerro_CellClick);
            // 
            // txtPerro
            // 
            this.txtPerro.Location = new System.Drawing.Point(158, 122);
            this.txtPerro.Name = "txtPerro";
            this.txtPerro.Size = new System.Drawing.Size(200, 20);
            this.txtPerro.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(58, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Perro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(222, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Gestionar Vacunas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(809, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Vacunar Perro";
            // 
            // frmVacunacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1169, 452);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVacunacion";
            this.Text = "frmVacunacion";
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacunas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.TextBox txtNomVacuna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVacunas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbVacuna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPerro;
        private System.Windows.Forms.TextBox txtPerro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgragarVacuna;
        private System.Windows.Forms.Button btnVacunarPerro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Button btnDelete;
        private DateTimePicker dtpFechaV;
        private Label label6;

        public PictureBox BtnCerrar { get => btnCerrar; set => btnCerrar = value; }
        public TextBox TxtNomVacuna { get => txtNomVacuna; set => txtNomVacuna = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public DataGridView DgvVacunas { get => dgvVacunas; set => dgvVacunas = value; }
        public Panel Panel1 { get => panel1; set => panel1 = value; }
        public Panel Panel2 { get => panel2; set => panel2 = value; }
        public ComboBox CmbVacuna { get => cmbVacuna; set => cmbVacuna = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public DataGridView DgvPerro { get => dgvPerro; set => dgvPerro = value; }
        public TextBox TxtPerro { get => txtPerro; set => txtPerro = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Button BtnAgragarRaza { get => btnAgragarVacuna; set => btnAgragarVacuna = value; }
        public Button Button1 { get => btnVacunarPerro; set => btnVacunarPerro = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Button BtnDelete { get => btnDelete; set => btnDelete = value; }
        public DateTimePicker DtpFechaV { get => dtpFechaV; set => dtpFechaV = value; }
    }
}