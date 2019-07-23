using System.Windows.Forms;

namespace Proyecto_Escritorio.VISTA
{
    partial class frmPerros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerros));
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRaza = new System.Windows.Forms.ComboBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaNacDog = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnAddDog = new System.Windows.Forms.Button();
            this.btnAddRaza = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(547, 86);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(195, 20);
            this.txtNombreP.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(383, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(489, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Gestion Perros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(383, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Raza:";
            // 
            // cmbRaza
            // 
            this.cmbRaza.FormattingEnabled = true;
            this.cmbRaza.Location = new System.Drawing.Point(547, 127);
            this.cmbRaza.Name = "cmbRaza";
            this.cmbRaza.Size = new System.Drawing.Size(195, 21);
            this.cmbRaza.TabIndex = 15;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(547, 166);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(195, 20);
            this.txtColor.TabIndex = 17;
            this.txtColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtColor_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(383, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Color:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(547, 207);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(195, 20);
            this.txtPrecio.TabIndex = 19;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(383, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Precio:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "<Seleccionar>",
            "Macho",
            "Hembra"});
            this.cmbSexo.Location = new System.Drawing.Point(547, 281);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(195, 21);
            this.cmbSexo.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(383, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Sexo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(383, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Fecha Nacimiento:";
            // 
            // dtpFechaNacDog
            // 
            this.dtpFechaNacDog.Location = new System.Drawing.Point(547, 343);
            this.dtpFechaNacDog.Name = "dtpFechaNacDog";
            this.dtpFechaNacDog.Size = new System.Drawing.Size(195, 20);
            this.dtpFechaNacDog.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(115, 415);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(938, 195);
            this.dataGridView1.TabIndex = 24;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1040, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 37);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Tag = "";
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnAddDog
            // 
            this.btnAddDog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddDog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDog.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddDog.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDog.Image")));
            this.btnAddDog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDog.Location = new System.Drawing.Point(503, 377);
            this.btnAddDog.Name = "btnAddDog";
            this.btnAddDog.Size = new System.Drawing.Size(104, 33);
            this.btnAddDog.TabIndex = 26;
            this.btnAddDog.Text = "Agregar";
            this.btnAddDog.UseVisualStyleBackColor = false;
            this.btnAddDog.Click += new System.EventHandler(this.BtnAddDog_Click);
            // 
            // btnAddRaza
            // 
            this.btnAddRaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddRaza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRaza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRaza.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddRaza.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRaza.Image")));
            this.btnAddRaza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRaza.Location = new System.Drawing.Point(748, 127);
            this.btnAddRaza.Name = "btnAddRaza";
            this.btnAddRaza.Size = new System.Drawing.Size(29, 21);
            this.btnAddRaza.TabIndex = 27;
            this.btnAddRaza.UseVisualStyleBackColor = false;
            this.btnAddRaza.Click += new System.EventHandler(this.BtnAddRaza_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(383, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Pedigree:";
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbSi.Location = new System.Drawing.Point(547, 310);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(35, 17);
            this.rbSi.TabIndex = 29;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "SI";
            this.rbSi.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbNo.Location = new System.Drawing.Point(613, 310);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(41, 17);
            this.rbNo.TabIndex = 30;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "NO";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(383, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Origen:";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(547, 242);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(195, 20);
            this.txtOrigen.TabIndex = 32;
            this.txtOrigen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOrigen_KeyPress);
            // 
            // frmPerros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1075, 613);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbSi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddRaza);
            this.Controls.Add(this.btnAddDog);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpFechaNacDog);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbRaza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPerros";
            this.Text = "frmPerros";
            this.Load += new System.EventHandler(this.FrmPerros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRaza;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaNacDog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnAddDog;
        private System.Windows.Forms.Button btnAddRaza;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOrigen;

      
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public ComboBox CmbRaza { get => cmbRaza; set => cmbRaza = value; }
        public TextBox TxtColor { get => txtColor; set => txtColor = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public ComboBox CmbSexo { get => cmbSexo; set => cmbSexo = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public DateTimePicker DtpFechaNacDog { get => dtpFechaNacDog; set => dtpFechaNacDog = value; }
        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
        public PictureBox BtnCerrar { get => btnCerrar; set => btnCerrar = value; }
        public Button BtnAddDog { get => btnAddDog; set => btnAddDog = value; }
        public Button BtnAddRaza { get => btnAddRaza; set => btnAddRaza = value; }
        public Label Label8 { get => label8; set => label8 = value; }
        public RadioButton RbSi { get => rbSi; set => rbSi = value; }
        public RadioButton RbNo { get => rbNo; set => rbNo = value; }
        public Label Label9 { get => label9; set => label9 = value; }
        public TextBox TxtOrigen { get => txtOrigen; set => txtOrigen = value; }
        public TextBox TxtNombreP { get => txtNombreP; set => txtNombreP = value; }
        public TextBox TxtPrecio { get => txtPrecio; set => txtPrecio = value; }
    }
}