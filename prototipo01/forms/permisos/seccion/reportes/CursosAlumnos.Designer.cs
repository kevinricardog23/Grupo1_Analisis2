namespace prototipo01.forms.seccion.reportes
{
    partial class CursosAlumnos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_ListadoCursosHab = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_CodAlumno = new System.Windows.Forms.TextBox();
            this.Lbl_CodAlumno = new System.Windows.Forms.Label();
            this.Txt_CodCarrera = new System.Windows.Forms.TextBox();
            this.Lbl_CodCarrera = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lbl_CodFacu = new System.Windows.Forms.Label();
            this.Lbl_Jornada = new System.Windows.Forms.Label();
            this.Dgv_ListadoCursoHab = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pensum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catedratico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Cbo_Jornada = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListadoCursoHab)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.Lbl_ListadoCursosHab);
            this.panel1.Location = new System.Drawing.Point(16, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 48);
            this.panel1.TabIndex = 24;
            // 
            // Lbl_ListadoCursosHab
            // 
            this.Lbl_ListadoCursosHab.AutoSize = true;
            this.Lbl_ListadoCursosHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_ListadoCursosHab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_ListadoCursosHab.Location = new System.Drawing.Point(28, 19);
            this.Lbl_ListadoCursosHab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ListadoCursosHab.Name = "Lbl_ListadoCursosHab";
            this.Lbl_ListadoCursosHab.Size = new System.Drawing.Size(340, 18);
            this.Lbl_ListadoCursosHab.TabIndex = 0;
            this.Lbl_ListadoCursosHab.Text = "Listado de Cursos habilitados para Alumnos";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            this.Btn_Buscar.FlatAppearance.BorderSize = 0;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.Location = new System.Drawing.Point(675, 180);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(82, 41);
            this.Btn_Buscar.TabIndex = 46;
            this.Btn_Buscar.Text = "BUSCAR";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_CodAlumno
            // 
            this.Txt_CodAlumno.Location = new System.Drawing.Point(213, 134);
            this.Txt_CodAlumno.MaxLength = 11;
            this.Txt_CodAlumno.Name = "Txt_CodAlumno";
            this.Txt_CodAlumno.Size = new System.Drawing.Size(132, 20);
            this.Txt_CodAlumno.TabIndex = 45;
            // 
            // Lbl_CodAlumno
            // 
            this.Lbl_CodAlumno.AutoSize = true;
            this.Lbl_CodAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodAlumno.Location = new System.Drawing.Point(43, 132);
            this.Lbl_CodAlumno.Name = "Lbl_CodAlumno";
            this.Lbl_CodAlumno.Size = new System.Drawing.Size(158, 20);
            this.Lbl_CodAlumno.TabIndex = 44;
            this.Lbl_CodAlumno.Text = "Carnet de Alumno:";
            // 
            // Txt_CodCarrera
            // 
            this.Txt_CodCarrera.Location = new System.Drawing.Point(625, 91);
            this.Txt_CodCarrera.MaxLength = 11;
            this.Txt_CodCarrera.Name = "Txt_CodCarrera";
            this.Txt_CodCarrera.Size = new System.Drawing.Size(132, 20);
            this.Txt_CodCarrera.TabIndex = 43;
            this.Txt_CodCarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // Lbl_CodCarrera
            // 
            this.Lbl_CodCarrera.AutoSize = true;
            this.Lbl_CodCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodCarrera.Location = new System.Drawing.Point(459, 91);
            this.Lbl_CodCarrera.Name = "Lbl_CodCarrera";
            this.Lbl_CodCarrera.Size = new System.Drawing.Size(160, 20);
            this.Lbl_CodCarrera.TabIndex = 42;
            this.Lbl_CodCarrera.Text = "Codigo de Carrera:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 91);
            this.textBox1.MaxLength = 11;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 41;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Lbl_CodFacu
            // 
            this.Lbl_CodFacu.AutoSize = true;
            this.Lbl_CodFacu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodFacu.Location = new System.Drawing.Point(39, 91);
            this.Lbl_CodFacu.Name = "Lbl_CodFacu";
            this.Lbl_CodFacu.Size = new System.Drawing.Size(170, 20);
            this.Lbl_CodFacu.TabIndex = 40;
            this.Lbl_CodFacu.Text = "Codigo de Facultad:";
            // 
            // Lbl_Jornada
            // 
            this.Lbl_Jornada.AutoSize = true;
            this.Lbl_Jornada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Jornada.Location = new System.Drawing.Point(459, 134);
            this.Lbl_Jornada.Name = "Lbl_Jornada";
            this.Lbl_Jornada.Size = new System.Drawing.Size(79, 20);
            this.Lbl_Jornada.TabIndex = 47;
            this.Lbl_Jornada.Text = "Jornada:";
            // 
            // Dgv_ListadoCursoHab
            // 
            this.Dgv_ListadoCursoHab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ListadoCursoHab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Nombre,
            this.Pensum,
            this.Horario,
            this.Salon,
            this.Creditos,
            this.Catedratico,
            this.Actualizar,
            this.Eliminar});
            this.Dgv_ListadoCursoHab.Location = new System.Drawing.Point(36, 277);
            this.Dgv_ListadoCursoHab.Name = "Dgv_ListadoCursoHab";
            this.Dgv_ListadoCursoHab.Size = new System.Drawing.Size(953, 150);
            this.Dgv_ListadoCursoHab.TabIndex = 49;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo de Curso";
            this.codigo.Name = "codigo";
            this.codigo.Width = 110;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre de Curso";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 115;
            // 
            // Pensum
            // 
            this.Pensum.HeaderText = "Pensum";
            this.Pensum.Name = "Pensum";
            // 
            // Horario
            // 
            this.Horario.HeaderText = "Horario";
            this.Horario.Name = "Horario";
            // 
            // Salon
            // 
            this.Salon.HeaderText = "Salon";
            this.Salon.Name = "Salon";
            // 
            // Creditos
            // 
            this.Creditos.HeaderText = "Creditos";
            this.Creditos.Name = "Creditos";
            // 
            // Catedratico
            // 
            this.Catedratico.HeaderText = "Catedratico";
            this.Catedratico.Name = "Catedratico";
            // 
            // Actualizar
            // 
            this.Actualizar.HeaderText = "";
            this.Actualizar.Name = "Actualizar";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 88;
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(82)))), ((int)(((byte)(112)))));
            this.Btn_Actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.ForeColor = System.Drawing.Color.White;
            this.Btn_Actualizar.Location = new System.Drawing.Point(802, 277);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(102, 41);
            this.Btn_Actualizar.TabIndex = 50;
            this.Btn_Actualizar.Text = "ACTUALIZAR";
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Location = new System.Drawing.Point(899, 277);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(90, 41);
            this.Btn_Eliminar.TabIndex = 51;
            this.Btn_Eliminar.Text = "ELIMINAR";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // Cbo_Jornada
            // 
            this.Cbo_Jornada.FormattingEnabled = true;
            this.Cbo_Jornada.Items.AddRange(new object[] {
            "Matutina",
            "Vespertina",
            "Sabados"});
            this.Cbo_Jornada.Location = new System.Drawing.Point(625, 132);
            this.Cbo_Jornada.Name = "Cbo_Jornada";
            this.Cbo_Jornada.Size = new System.Drawing.Size(132, 21);
            this.Cbo_Jornada.TabIndex = 52;
            // 
            // CursosAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 539);
            this.Controls.Add(this.Cbo_Jornada);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Dgv_ListadoCursoHab);
            this.Controls.Add(this.Lbl_Jornada);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Txt_CodAlumno);
            this.Controls.Add(this.Lbl_CodAlumno);
            this.Controls.Add(this.Txt_CodCarrera);
            this.Controls.Add(this.Lbl_CodCarrera);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lbl_CodFacu);
            this.Controls.Add(this.panel1);
            this.Name = "CursosAlumnos";
            this.Text = "CursosAlumnos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListadoCursoHab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_ListadoCursosHab;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txt_CodAlumno;
        private System.Windows.Forms.Label Lbl_CodAlumno;
        private System.Windows.Forms.TextBox Txt_CodCarrera;
        private System.Windows.Forms.Label Lbl_CodCarrera;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lbl_CodFacu;
        private System.Windows.Forms.Label Lbl_Jornada;
        private System.Windows.Forms.DataGridView Dgv_ListadoCursoHab;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pensum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catedratico;
        private System.Windows.Forms.DataGridViewButtonColumn Actualizar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.ComboBox Cbo_Jornada;
    }
}