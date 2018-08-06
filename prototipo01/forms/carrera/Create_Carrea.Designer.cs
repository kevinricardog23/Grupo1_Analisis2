namespace prototipo01.forms.carrera
{
    partial class Create_Carrea
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
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.Btn_atras = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.CRUD = new System.Windows.Forms.TabControl();
            this.Tp_crear = new System.Windows.Forms.TabPage();
            this.Txt_jornada = new System.Windows.Forms.TextBox();
            this.Lbl_jornada = new System.Windows.Forms.Label();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Btn_crear = new System.Windows.Forms.Button();
            this.Lbl_facultad = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Pnl_titulo.SuspendLayout();
            this.CRUD.SuspendLayout();
            this.Tp_crear.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.SystemColors.Control;
            this.Pnl_titulo.Controls.Add(this.Btn_atras);
            this.Pnl_titulo.Controls.Add(this.Lbl_titulo);
            this.Pnl_titulo.Location = new System.Drawing.Point(40, 70);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(870, 50);
            this.Pnl_titulo.TabIndex = 0;
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
            this.Btn_atras.Click += new System.EventHandler(this.Btn_atras_Click);
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lbl_titulo.Location = new System.Drawing.Point(13, 20);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(109, 18);
            this.Lbl_titulo.TabIndex = 1;
            this.Lbl_titulo.Text = "Crear carrera";
            // 
            // CRUD
            // 
            this.CRUD.Controls.Add(this.Tp_crear);
            this.CRUD.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRUD.Location = new System.Drawing.Point(40, 125);
            this.CRUD.Margin = new System.Windows.Forms.Padding(2);
            this.CRUD.Name = "CRUD";
            this.CRUD.SelectedIndex = 0;
            this.CRUD.Size = new System.Drawing.Size(876, 498);
            this.CRUD.TabIndex = 10;
            // 
            // Tp_crear
            // 
            this.Tp_crear.Controls.Add(this.comboBox1);
            this.Tp_crear.Controls.Add(this.Txt_jornada);
            this.Tp_crear.Controls.Add(this.Lbl_jornada);
            this.Tp_crear.Controls.Add(this.Txt_nombre);
            this.Tp_crear.Controls.Add(this.Lbl_nombre);
            this.Tp_crear.Controls.Add(this.Btn_crear);
            this.Tp_crear.Controls.Add(this.Lbl_facultad);
            this.Tp_crear.Location = new System.Drawing.Point(4, 28);
            this.Tp_crear.Margin = new System.Windows.Forms.Padding(2);
            this.Tp_crear.Name = "Tp_crear";
            this.Tp_crear.Padding = new System.Windows.Forms.Padding(2);
            this.Tp_crear.Size = new System.Drawing.Size(868, 466);
            this.Tp_crear.TabIndex = 0;
            this.Tp_crear.UseVisualStyleBackColor = true;
            // 
            // Txt_jornada
            // 
            this.Txt_jornada.Location = new System.Drawing.Point(325, 191);
            this.Txt_jornada.Name = "Txt_jornada";
            this.Txt_jornada.Size = new System.Drawing.Size(315, 25);
            this.Txt_jornada.TabIndex = 37;
            // 
            // Lbl_jornada
            // 
            this.Lbl_jornada.AutoSize = true;
            this.Lbl_jornada.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_jornada.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lbl_jornada.Location = new System.Drawing.Point(165, 194);
            this.Lbl_jornada.Name = "Lbl_jornada";
            this.Lbl_jornada.Size = new System.Drawing.Size(154, 18);
            this.Lbl_jornada.TabIndex = 36;
            this.Lbl_jornada.Text = "Jornada de Carrera";
            this.Lbl_jornada.Click += new System.EventHandler(this.Lbl_jornada_Click);
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(325, 147);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(315, 25);
            this.Txt_nombre.TabIndex = 35;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lbl_nombre.Location = new System.Drawing.Point(165, 150);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(153, 18);
            this.Lbl_nombre.TabIndex = 34;
            this.Lbl_nombre.Text = "Nombre de Carrera";
            this.Lbl_nombre.Click += new System.EventHandler(this.Lbl_nombre_Click);
            // 
            // Btn_crear
            // 
            this.Btn_crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            this.Btn_crear.FlatAppearance.BorderSize = 0;
            this.Btn_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_crear.ForeColor = System.Drawing.Color.White;
            this.Btn_crear.Image = global::prototipo01.Properties.Resources.iconmonstr_edit_11_24;
            this.Btn_crear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_crear.Location = new System.Drawing.Point(325, 282);
            this.Btn_crear.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_crear.Name = "Btn_crear";
            this.Btn_crear.Size = new System.Drawing.Size(145, 41);
            this.Btn_crear.TabIndex = 8;
            this.Btn_crear.Text = "Crear";
            this.Btn_crear.UseVisualStyleBackColor = false;
            this.Btn_crear.Click += new System.EventHandler(this.Btn_crear_Click);
            // 
            // Lbl_facultad
            // 
            this.Lbl_facultad.AutoSize = true;
            this.Lbl_facultad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_facultad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_facultad.Location = new System.Drawing.Point(242, 233);
            this.Lbl_facultad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_facultad.Name = "Lbl_facultad";
            this.Lbl_facultad.Size = new System.Drawing.Size(78, 19);
            this.Lbl_facultad.TabIndex = 4;
            this.Lbl_facultad.Text = "Facultad";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(325, 231);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(315, 27);
            this.comboBox1.TabIndex = 38;
            // 
            // Create_Carrea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1005, 666);
            this.Controls.Add(this.CRUD);
            this.Controls.Add(this.Pnl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Create_Carrea";
            this.Text = "Create_Carrea";
            this.Load += new System.EventHandler(this.Create_Carrea_Load);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            this.CRUD.ResumeLayout(false);
            this.Tp_crear.ResumeLayout(false);
            this.Tp_crear.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Button Btn_atras;
        private System.Windows.Forms.TabControl CRUD;
        private System.Windows.Forms.TabPage Tp_crear;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.Button Btn_crear;
        private System.Windows.Forms.Label Lbl_facultad;
        private System.Windows.Forms.Label Lbl_jornada;
        private System.Windows.Forms.TextBox Txt_jornada;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}