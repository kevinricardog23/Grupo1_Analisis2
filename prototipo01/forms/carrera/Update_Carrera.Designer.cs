namespace prototipo01.forms.carrera
{
    partial class Update_Carrera
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
            this.Btn_atras = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.CRUD = new System.Windows.Forms.TabControl();
            this.Tp_crear = new System.Windows.Forms.TabPage();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Txt_jornada = new System.Windows.Forms.TextBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Cbo_facultad = new System.Windows.Forms.ComboBox();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.Lbl_jornada = new System.Windows.Forms.Label();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Lbl_facultad = new System.Windows.Forms.Label();
            this.Lbl_id = new System.Windows.Forms.Label();
            this.Pnl_titulo.SuspendLayout();
            this.CRUD.SuspendLayout();
            this.Tp_crear.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_atras
            // 
            this.Btn_atras.BackgroundImage = global::prototipo01.Properties.Resources.iconmonstr_angel_left_circle_thin_24;
            this.Btn_atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_atras.FlatAppearance.BorderSize = 0;
            this.Btn_atras.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_atras.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_atras.Location = new System.Drawing.Point(820, 0);
            this.Btn_atras.Name = "Btn_atras";
            this.Btn_atras.Size = new System.Drawing.Size(50, 50);
            this.Btn_atras.TabIndex = 9;
            this.Btn_atras.UseVisualStyleBackColor = true;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lbl_titulo.Location = new System.Drawing.Point(13, 20);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(143, 18);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "Actualizar Carrera";
            this.Lbl_titulo.Click += new System.EventHandler(this.Lbl_titulo_Click);
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Pnl_titulo.Controls.Add(this.Btn_atras);
            this.Pnl_titulo.Controls.Add(this.Lbl_titulo);
            this.Pnl_titulo.Location = new System.Drawing.Point(40, 70);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(870, 50);
            this.Pnl_titulo.TabIndex = 1;
            // 
            // CRUD
            // 
            this.CRUD.Controls.Add(this.Tp_crear);
            this.CRUD.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRUD.Location = new System.Drawing.Point(34, 126);
            this.CRUD.Margin = new System.Windows.Forms.Padding(2);
            this.CRUD.Name = "CRUD";
            this.CRUD.SelectedIndex = 0;
            this.CRUD.Size = new System.Drawing.Size(876, 498);
            this.CRUD.TabIndex = 11;
            // 
            // Tp_crear
            // 
            this.Tp_crear.Controls.Add(this.Lbl_jornada);
            this.Tp_crear.Controls.Add(this.Lbl_nombre);
            this.Tp_crear.Controls.Add(this.Lbl_facultad);
            this.Tp_crear.Controls.Add(this.Lbl_id);
            this.Tp_crear.Controls.Add(this.Btn_editar);
            this.Tp_crear.Controls.Add(this.Txt_jornada);
            this.Tp_crear.Controls.Add(this.Txt_nombre);
            this.Tp_crear.Controls.Add(this.Cbo_facultad);
            this.Tp_crear.Controls.Add(this.Txt_id);
            this.Tp_crear.Location = new System.Drawing.Point(4, 28);
            this.Tp_crear.Margin = new System.Windows.Forms.Padding(2);
            this.Tp_crear.Name = "Tp_crear";
            this.Tp_crear.Padding = new System.Windows.Forms.Padding(2);
            this.Tp_crear.Size = new System.Drawing.Size(868, 466);
            this.Tp_crear.TabIndex = 0;
            this.Tp_crear.UseVisualStyleBackColor = true;
            // 
            // Btn_editar
            // 
            this.Btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(82)))), ((int)(((byte)(112)))));
            this.Btn_editar.FlatAppearance.BorderSize = 0;
            this.Btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_editar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_editar.ForeColor = System.Drawing.Color.White;
            this.Btn_editar.Image = global::prototipo01.Properties.Resources.iconmonstr_synchronization_19_24;
            this.Btn_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_editar.Location = new System.Drawing.Point(323, 302);
            this.Btn_editar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(145, 41);
            this.Btn_editar.TabIndex = 38;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = false;
            // 
            // Txt_jornada
            // 
            this.Txt_jornada.Location = new System.Drawing.Point(323, 211);
            this.Txt_jornada.Name = "Txt_jornada";
            this.Txt_jornada.Size = new System.Drawing.Size(317, 25);
            this.Txt_jornada.TabIndex = 37;
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(323, 167);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(317, 25);
            this.Txt_nombre.TabIndex = 35;
            // 
            // Cbo_facultad
            // 
            this.Cbo_facultad.FormattingEnabled = true;
            this.Cbo_facultad.Location = new System.Drawing.Point(323, 249);
            this.Cbo_facultad.Name = "Cbo_facultad";
            this.Cbo_facultad.Size = new System.Drawing.Size(317, 27);
            this.Cbo_facultad.TabIndex = 33;
            // 
            // Txt_id
            // 
            this.Txt_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_id.Location = new System.Drawing.Point(323, 116);
            this.Txt_id.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_id.MaxLength = 30;
            this.Txt_id.Multiline = true;
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(317, 28);
            this.Txt_id.TabIndex = 2;
            // 
            // Lbl_jornada
            // 
            this.Lbl_jornada.AutoSize = true;
            this.Lbl_jornada.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_jornada.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lbl_jornada.Location = new System.Drawing.Point(164, 214);
            this.Lbl_jornada.Name = "Lbl_jornada";
            this.Lbl_jornada.Size = new System.Drawing.Size(154, 18);
            this.Lbl_jornada.TabIndex = 42;
            this.Lbl_jornada.Text = "Jornada de Carrera";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lbl_nombre.Location = new System.Drawing.Point(164, 170);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(153, 18);
            this.Lbl_nombre.TabIndex = 41;
            this.Lbl_nombre.Text = "Nombre de Carrera";
            // 
            // Lbl_facultad
            // 
            this.Lbl_facultad.AutoSize = true;
            this.Lbl_facultad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_facultad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_facultad.Location = new System.Drawing.Point(241, 253);
            this.Lbl_facultad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_facultad.Name = "Lbl_facultad";
            this.Lbl_facultad.Size = new System.Drawing.Size(78, 19);
            this.Lbl_facultad.TabIndex = 40;
            this.Lbl_facultad.Text = "Facultad";
            // 
            // Lbl_id
            // 
            this.Lbl_id.AutoSize = true;
            this.Lbl_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_id.Location = new System.Drawing.Point(294, 120);
            this.Lbl_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_id.Name = "Lbl_id";
            this.Lbl_id.Size = new System.Drawing.Size(24, 19);
            this.Lbl_id.TabIndex = 39;
            this.Lbl_id.Text = "ID";
            // 
            // Update_Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(996, 632);
            this.Controls.Add(this.Pnl_titulo);
            this.Controls.Add(this.CRUD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Update_Carrera";
            this.Text = "Update_Carrera";
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            this.CRUD.ResumeLayout(false);
            this.Tp_crear.ResumeLayout(false);
            this.Tp_crear.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_atras;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.TabControl CRUD;
        private System.Windows.Forms.TabPage Tp_crear;
        private System.Windows.Forms.TextBox Txt_jornada;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.ComboBox Cbo_facultad;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Label Lbl_jornada;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.Label Lbl_facultad;
        private System.Windows.Forms.Label Lbl_id;
    }
}