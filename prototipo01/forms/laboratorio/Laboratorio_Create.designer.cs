namespace prototipo01
{
    partial class Laboratorio_Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laboratorio_Create));
            this.CRUD = new System.Windows.Forms.TabControl();
            this.tbp_pagina = new System.Windows.Forms.TabPage();
            this.Btn_crear = new System.Windows.Forms.Button();
            this.cbo_salon = new System.Windows.Forms.ComboBox();
            this.Cbo_catedratico = new System.Windows.Forms.ComboBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_dpi = new System.Windows.Forms.Label();
            this.Lbl_salon = new System.Windows.Forms.Label();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.pic_regresar = new System.Windows.Forms.PictureBox();
            this.Lbl_laboratorio = new System.Windows.Forms.Label();
            this.CRUD.SuspendLayout();
            this.tbp_pagina.SuspendLayout();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_regresar)).BeginInit();
            this.SuspendLayout();
            // 
            // CRUD
            // 
            this.CRUD.Controls.Add(this.tbp_pagina);
            this.CRUD.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRUD.Location = new System.Drawing.Point(12, 76);
            this.CRUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CRUD.Name = "CRUD";
            this.CRUD.SelectedIndex = 0;
            this.CRUD.Size = new System.Drawing.Size(876, 498);
            this.CRUD.TabIndex = 3;
            // 
            // tbp_pagina
            // 
            this.tbp_pagina.Controls.Add(this.Btn_crear);
            this.tbp_pagina.Controls.Add(this.cbo_salon);
            this.tbp_pagina.Controls.Add(this.Cbo_catedratico);
            this.tbp_pagina.Controls.Add(this.Txt_nombre);
            this.tbp_pagina.Controls.Add(this.Lbl_dpi);
            this.tbp_pagina.Controls.Add(this.Lbl_salon);
            this.tbp_pagina.Controls.Add(this.Lbl_nombre);
            this.tbp_pagina.Location = new System.Drawing.Point(4, 28);
            this.tbp_pagina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbp_pagina.Name = "tbp_pagina";
            this.tbp_pagina.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbp_pagina.Size = new System.Drawing.Size(868, 466);
            this.tbp_pagina.TabIndex = 0;
            this.tbp_pagina.UseVisualStyleBackColor = true;
            // 
            // Btn_crear
            // 
            this.Btn_crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            this.Btn_crear.FlatAppearance.BorderSize = 0;
            this.Btn_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_crear.ForeColor = System.Drawing.Color.White;
            this.Btn_crear.Location = new System.Drawing.Point(465, 346);
            this.Btn_crear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_crear.Name = "Btn_crear";
            this.Btn_crear.Size = new System.Drawing.Size(82, 41);
            this.Btn_crear.TabIndex = 32;
            this.Btn_crear.Text = "CREAR";
            this.Btn_crear.UseVisualStyleBackColor = false;
            this.Btn_crear.Click += new System.EventHandler(this.Btn_crear_Click);
            // 
            // cbo_salon
            // 
            this.cbo_salon.FormattingEnabled = true;
            this.cbo_salon.Location = new System.Drawing.Point(354, 264);
            this.cbo_salon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbo_salon.Name = "cbo_salon";
            this.cbo_salon.Size = new System.Drawing.Size(194, 27);
            this.cbo_salon.TabIndex = 14;
            // 
            // Cbo_catedratico
            // 
            this.Cbo_catedratico.FormattingEnabled = true;
            this.Cbo_catedratico.Location = new System.Drawing.Point(354, 187);
            this.Cbo_catedratico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cbo_catedratico.Name = "Cbo_catedratico";
            this.Cbo_catedratico.Size = new System.Drawing.Size(194, 27);
            this.Cbo_catedratico.TabIndex = 13;
            this.Cbo_catedratico.SelectedIndexChanged += new System.EventHandler(this.Cbo_edificio_SelectedIndexChanged);
            this.Cbo_catedratico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_nombre.Location = new System.Drawing.Point(354, 112);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_nombre.Multiline = true;
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(317, 28);
            this.Txt_nombre.TabIndex = 9;
            this.Txt_nombre.TextChanged += new System.EventHandler(this.Txt_nombre_TextChanged);
            this.Txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Lbl_dpi
            // 
            this.Lbl_dpi.AutoSize = true;
            this.Lbl_dpi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_dpi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_dpi.Location = new System.Drawing.Point(140, 192);
            this.Lbl_dpi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_dpi.Name = "Lbl_dpi";
            this.Lbl_dpi.Size = new System.Drawing.Size(129, 19);
            this.Lbl_dpi.TabIndex = 12;
            this.Lbl_dpi.Text = "Dpi catedratico";
            // 
            // Lbl_salon
            // 
            this.Lbl_salon.AutoSize = true;
            this.Lbl_salon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_salon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_salon.Location = new System.Drawing.Point(140, 264);
            this.Lbl_salon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_salon.Name = "Lbl_salon";
            this.Lbl_salon.Size = new System.Drawing.Size(69, 19);
            this.Lbl_salon.TabIndex = 10;
            this.Lbl_salon.Text = "ID salon";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_nombre.Location = new System.Drawing.Point(140, 113);
            this.Lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(73, 19);
            this.Lbl_nombre.TabIndex = 8;
            this.Lbl_nombre.Text = "Nombre";
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_titulo.Controls.Add(this.pic_regresar);
            this.Pnl_titulo.Controls.Add(this.Lbl_laboratorio);
            this.Pnl_titulo.Location = new System.Drawing.Point(12, 11);
            this.Pnl_titulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(876, 48);
            this.Pnl_titulo.TabIndex = 2;
            // 
            // pic_regresar
            // 
            this.pic_regresar.Image = ((System.Drawing.Image)(resources.GetObject("pic_regresar.Image")));
            this.pic_regresar.Location = new System.Drawing.Point(819, 9);
            this.pic_regresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_regresar.Name = "pic_regresar";
            this.pic_regresar.Size = new System.Drawing.Size(29, 29);
            this.pic_regresar.TabIndex = 4;
            this.pic_regresar.TabStop = false;
            this.pic_regresar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Lbl_laboratorio
            // 
            this.Lbl_laboratorio.AutoSize = true;
            this.Lbl_laboratorio.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_laboratorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_laboratorio.Location = new System.Drawing.Point(8, 16);
            this.Lbl_laboratorio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_laboratorio.Name = "Lbl_laboratorio";
            this.Lbl_laboratorio.Size = new System.Drawing.Size(139, 18);
            this.Lbl_laboratorio.TabIndex = 0;
            this.Lbl_laboratorio.Text = "Crear Laboratorio";
            // 
            // Laboratorio_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 585);
            this.Controls.Add(this.CRUD);
            this.Controls.Add(this.Pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Laboratorio_Create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio";
            this.Load += new System.EventHandler(this.Laboratorio_Create_Load);
            this.CRUD.ResumeLayout(false);
            this.tbp_pagina.ResumeLayout(false);
            this.tbp_pagina.PerformLayout();
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_regresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CRUD;
        private System.Windows.Forms.TabPage tbp_pagina;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Label Lbl_laboratorio;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label Lbl_dpi;
        private System.Windows.Forms.Label Lbl_salon;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.ComboBox Cbo_catedratico;
        private System.Windows.Forms.PictureBox pic_regresar;
        private System.Windows.Forms.ComboBox cbo_salon;
        private System.Windows.Forms.Button Btn_crear;
    }
}