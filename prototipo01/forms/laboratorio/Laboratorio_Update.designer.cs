namespace prototipo01
{
    partial class Laboratorio_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laboratorio_Update));
            this.CRUD = new System.Windows.Forms.TabControl();
            this.Tbp_pagina = new System.Windows.Forms.TabPage();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Cbo_salon = new System.Windows.Forms.ComboBox();
            this.Cbo_catedratico = new System.Windows.Forms.ComboBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_dpi = new System.Windows.Forms.Label();
            this.Lbl_salon = new System.Windows.Forms.Label();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.pic_regresar = new System.Windows.Forms.PictureBox();
            this.Lbl_laboratorios = new System.Windows.Forms.Label();
            this.CRUD.SuspendLayout();
            this.Tbp_pagina.SuspendLayout();
            this.Pnl_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_regresar)).BeginInit();
            this.SuspendLayout();
            // 
            // CRUD
            // 
            this.CRUD.Controls.Add(this.Tbp_pagina);
            this.CRUD.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRUD.Location = new System.Drawing.Point(12, 76);
            this.CRUD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CRUD.Name = "CRUD";
            this.CRUD.SelectedIndex = 0;
            this.CRUD.Size = new System.Drawing.Size(876, 498);
            this.CRUD.TabIndex = 5;
            // 
            // Tbp_pagina
            // 
            this.Tbp_pagina.Controls.Add(this.Btn_actualizar);
            this.Tbp_pagina.Controls.Add(this.Cbo_salon);
            this.Tbp_pagina.Controls.Add(this.Cbo_catedratico);
            this.Tbp_pagina.Controls.Add(this.Txt_nombre);
            this.Tbp_pagina.Controls.Add(this.Lbl_dpi);
            this.Tbp_pagina.Controls.Add(this.Lbl_salon);
            this.Tbp_pagina.Controls.Add(this.Lbl_nombre);
            this.Tbp_pagina.Location = new System.Drawing.Point(4, 28);
            this.Tbp_pagina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tbp_pagina.Name = "Tbp_pagina";
            this.Tbp_pagina.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tbp_pagina.Size = new System.Drawing.Size(868, 466);
            this.Tbp_pagina.TabIndex = 0;
            this.Tbp_pagina.UseVisualStyleBackColor = true;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(70)))), ((int)(((byte)(96)))));
            this.Btn_actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.ForeColor = System.Drawing.Color.White;
            this.Btn_actualizar.Location = new System.Drawing.Point(442, 359);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(101, 48);
            this.Btn_actualizar.TabIndex = 21;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click_1);
            // 
            // Cbo_salon
            // 
            this.Cbo_salon.FormattingEnabled = true;
            this.Cbo_salon.Location = new System.Drawing.Point(363, 259);
            this.Cbo_salon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cbo_salon.Name = "Cbo_salon";
            this.Cbo_salon.Size = new System.Drawing.Size(194, 27);
            this.Cbo_salon.TabIndex = 20;
            // 
            // Cbo_catedratico
            // 
            this.Cbo_catedratico.FormattingEnabled = true;
            this.Cbo_catedratico.Location = new System.Drawing.Point(363, 187);
            this.Cbo_catedratico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cbo_catedratico.Name = "Cbo_catedratico";
            this.Cbo_catedratico.Size = new System.Drawing.Size(194, 27);
            this.Cbo_catedratico.TabIndex = 19;
            this.Cbo_catedratico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbo_edificio_KeyPress);
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_nombre.Location = new System.Drawing.Point(363, 112);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_nombre.Multiline = true;
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(317, 28);
            this.Txt_nombre.TabIndex = 16;
            this.Txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_nombre_KeyPress);
            // 
            // Lbl_dpi
            // 
            this.Lbl_dpi.AutoSize = true;
            this.Lbl_dpi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_dpi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_dpi.Location = new System.Drawing.Point(149, 192);
            this.Lbl_dpi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_dpi.Name = "Lbl_dpi";
            this.Lbl_dpi.Size = new System.Drawing.Size(127, 19);
            this.Lbl_dpi.TabIndex = 18;
            this.Lbl_dpi.Text = "DPI catedratico";
            // 
            // Lbl_salon
            // 
            this.Lbl_salon.AutoSize = true;
            this.Lbl_salon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_salon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_salon.Location = new System.Drawing.Point(149, 264);
            this.Lbl_salon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_salon.Name = "Lbl_salon";
            this.Lbl_salon.Size = new System.Drawing.Size(69, 19);
            this.Lbl_salon.TabIndex = 17;
            this.Lbl_salon.Text = "ID salon";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_nombre.Location = new System.Drawing.Point(149, 113);
            this.Lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(73, 19);
            this.Lbl_nombre.TabIndex = 15;
            this.Lbl_nombre.Text = "Nombre";
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_titulo.Controls.Add(this.pic_regresar);
            this.Pnl_titulo.Controls.Add(this.Lbl_laboratorios);
            this.Pnl_titulo.Location = new System.Drawing.Point(12, 11);
            this.Pnl_titulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(876, 48);
            this.Pnl_titulo.TabIndex = 4;
            // 
            // pic_regresar
            // 
            this.pic_regresar.Image = ((System.Drawing.Image)(resources.GetObject("pic_regresar.Image")));
            this.pic_regresar.Location = new System.Drawing.Point(815, 10);
            this.pic_regresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_regresar.Name = "pic_regresar";
            this.pic_regresar.Size = new System.Drawing.Size(29, 29);
            this.pic_regresar.TabIndex = 6;
            this.pic_regresar.TabStop = false;
            this.pic_regresar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Lbl_laboratorios
            // 
            this.Lbl_laboratorios.AutoSize = true;
            this.Lbl_laboratorios.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_laboratorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_laboratorios.Location = new System.Drawing.Point(8, 16);
            this.Lbl_laboratorios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_laboratorios.Name = "Lbl_laboratorios";
            this.Lbl_laboratorios.Size = new System.Drawing.Size(171, 18);
            this.Lbl_laboratorios.TabIndex = 0;
            this.Lbl_laboratorios.Text = "Actualizar Laboratorio";
            // 
            // Laboratorio_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 585);
            this.Controls.Add(this.CRUD);
            this.Controls.Add(this.Pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Laboratorio_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratorio_Update";
            this.Load += new System.EventHandler(this.Laboratorio_Update_Load);
            this.CRUD.ResumeLayout(false);
            this.Tbp_pagina.ResumeLayout(false);
            this.Tbp_pagina.PerformLayout();
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_regresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CRUD;
        private System.Windows.Forms.TabPage Tbp_pagina;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Label Lbl_laboratorios;
        private System.Windows.Forms.ComboBox Cbo_catedratico;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label Lbl_dpi;
        private System.Windows.Forms.Label Lbl_salon;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.PictureBox pic_regresar;
        private System.Windows.Forms.ComboBox Cbo_salon;
        private System.Windows.Forms.Button Btn_actualizar;
    }
}