namespace prototipo01.forms.seccion.reportes
{
    partial class AlumnosSeccion
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
            this.Lbl_listado = new System.Windows.Forms.Label();
            this.Lbl_CodCarrera = new System.Windows.Forms.Label();
            this.Txt_CodCarrera = new System.Windows.Forms.TextBox();
            this.Lbl_Semestre = new System.Windows.Forms.Label();
            this.Txt_Semestre = new System.Windows.Forms.TextBox();
            this.Lbl_Seccion = new System.Windows.Forms.Label();
            this.Txt_Seccion = new System.Windows.Forms.TextBox();
            this.Dgv_ListadoxSeccion = new System.Windows.Forms.DataGridView();
            this.Carnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Lbl_NumAlumnos = new System.Windows.Forms.Label();
            this.Txt_NumAlumnos = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Lbl_Jornada = new System.Windows.Forms.Label();
            this.Cbo_Jornada = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListadoxSeccion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.Lbl_listado);
            this.panel1.Location = new System.Drawing.Point(74, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 48);
            this.panel1.TabIndex = 21;
            // 
            // Lbl_listado
            // 
            this.Lbl_listado.AutoSize = true;
            this.Lbl_listado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_listado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_listado.Location = new System.Drawing.Point(24, 14);
            this.Lbl_listado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_listado.Name = "Lbl_listado";
            this.Lbl_listado.Size = new System.Drawing.Size(252, 18);
            this.Lbl_listado.TabIndex = 0;
            this.Lbl_listado.Text = "Listado de Alumnos por Seccion";
            // 
            // Lbl_CodCarrera
            // 
            this.Lbl_CodCarrera.AutoSize = true;
            this.Lbl_CodCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodCarrera.Location = new System.Drawing.Point(176, 114);
            this.Lbl_CodCarrera.Name = "Lbl_CodCarrera";
            this.Lbl_CodCarrera.Size = new System.Drawing.Size(160, 20);
            this.Lbl_CodCarrera.TabIndex = 22;
            this.Lbl_CodCarrera.Text = "Codigo de Carrera:";
            // 
            // Txt_CodCarrera
            // 
            this.Txt_CodCarrera.Location = new System.Drawing.Point(351, 114);
            this.Txt_CodCarrera.MaxLength = 11;
            this.Txt_CodCarrera.Name = "Txt_CodCarrera";
            this.Txt_CodCarrera.Size = new System.Drawing.Size(132, 20);
            this.Txt_CodCarrera.TabIndex = 23;
            this.Txt_CodCarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Lbl_Semestre
            // 
            this.Lbl_Semestre.AutoSize = true;
            this.Lbl_Semestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Semestre.Location = new System.Drawing.Point(596, 114);
            this.Lbl_Semestre.Name = "Lbl_Semestre";
            this.Lbl_Semestre.Size = new System.Drawing.Size(91, 20);
            this.Lbl_Semestre.TabIndex = 24;
            this.Lbl_Semestre.Text = "Semestre:";
            // 
            // Txt_Semestre
            // 
            this.Txt_Semestre.Location = new System.Drawing.Point(693, 114);
            this.Txt_Semestre.MaxLength = 2;
            this.Txt_Semestre.Name = "Txt_Semestre";
            this.Txt_Semestre.Size = new System.Drawing.Size(132, 20);
            this.Txt_Semestre.TabIndex = 25;
            this.Txt_Semestre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // Lbl_Seccion
            // 
            this.Lbl_Seccion.AutoSize = true;
            this.Lbl_Seccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Seccion.Location = new System.Drawing.Point(176, 160);
            this.Lbl_Seccion.Name = "Lbl_Seccion";
            this.Lbl_Seccion.Size = new System.Drawing.Size(78, 20);
            this.Lbl_Seccion.TabIndex = 26;
            this.Lbl_Seccion.Text = "Seccion:";
            // 
            // Txt_Seccion
            // 
            this.Txt_Seccion.Location = new System.Drawing.Point(351, 160);
            this.Txt_Seccion.MaxLength = 1;
            this.Txt_Seccion.Name = "Txt_Seccion";
            this.Txt_Seccion.Size = new System.Drawing.Size(132, 20);
            this.Txt_Seccion.TabIndex = 27;
            this.Txt_Seccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // Dgv_ListadoxSeccion
            // 
            this.Dgv_ListadoxSeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ListadoxSeccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Carnet,
            this.Nombre,
            this.Actualizar,
            this.Eliminar});
            this.Dgv_ListadoxSeccion.Location = new System.Drawing.Point(180, 234);
            this.Dgv_ListadoxSeccion.Name = "Dgv_ListadoxSeccion";
            this.Dgv_ListadoxSeccion.Size = new System.Drawing.Size(432, 193);
            this.Dgv_ListadoxSeccion.TabIndex = 28;
            // 
            // Carnet
            // 
            this.Carnet.HeaderText = "Carnet";
            this.Carnet.Name = "Carnet";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
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
            this.Eliminar.Width = 91;
            // 
            // Lbl_NumAlumnos
            // 
            this.Lbl_NumAlumnos.AutoSize = true;
            this.Lbl_NumAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NumAlumnos.Location = new System.Drawing.Point(518, 451);
            this.Lbl_NumAlumnos.Name = "Lbl_NumAlumnos";
            this.Lbl_NumAlumnos.Size = new System.Drawing.Size(246, 24);
            this.Lbl_NumAlumnos.TabIndex = 29;
            this.Lbl_NumAlumnos.Text = "NUMERO DE ALUMNOS:";
            // 
            // Txt_NumAlumnos
            // 
            this.Txt_NumAlumnos.Location = new System.Drawing.Point(781, 455);
            this.Txt_NumAlumnos.Name = "Txt_NumAlumnos";
            this.Txt_NumAlumnos.Size = new System.Drawing.Size(99, 20);
            this.Txt_NumAlumnos.TabIndex = 30;
            this.Txt_NumAlumnos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            this.Btn_Buscar.FlatAppearance.BorderSize = 0;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.Location = new System.Drawing.Point(743, 183);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(82, 41);
            this.Btn_Buscar.TabIndex = 31;
            this.Btn_Buscar.Text = "BUSCAR";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(82)))), ((int)(((byte)(112)))));
            this.Btn_Actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.ForeColor = System.Drawing.Color.White;
            this.Btn_Actualizar.Location = new System.Drawing.Point(420, 234);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(102, 41);
            this.Btn_Actualizar.TabIndex = 32;
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
            this.Btn_Eliminar.Location = new System.Drawing.Point(522, 234);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(90, 41);
            this.Btn_Eliminar.TabIndex = 33;
            this.Btn_Eliminar.Text = "ELIMINAR";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // Lbl_Jornada
            // 
            this.Lbl_Jornada.AutoSize = true;
            this.Lbl_Jornada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Jornada.Location = new System.Drawing.Point(596, 158);
            this.Lbl_Jornada.Name = "Lbl_Jornada";
            this.Lbl_Jornada.Size = new System.Drawing.Size(79, 20);
            this.Lbl_Jornada.TabIndex = 34;
            this.Lbl_Jornada.Text = "Jornada:";
            // 
            // Cbo_Jornada
            // 
            this.Cbo_Jornada.FormattingEnabled = true;
            this.Cbo_Jornada.Items.AddRange(new object[] {
            "Matutina",
            "Vespertina",
            "Sabados"});
            this.Cbo_Jornada.Location = new System.Drawing.Point(693, 159);
            this.Cbo_Jornada.Name = "Cbo_Jornada";
            this.Cbo_Jornada.Size = new System.Drawing.Size(132, 21);
            this.Cbo_Jornada.TabIndex = 36;
            // 
            // AlumnosSeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1045, 539);
            this.Controls.Add(this.Cbo_Jornada);
            this.Controls.Add(this.Lbl_Jornada);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Txt_NumAlumnos);
            this.Controls.Add(this.Lbl_NumAlumnos);
            this.Controls.Add(this.Dgv_ListadoxSeccion);
            this.Controls.Add(this.Txt_Seccion);
            this.Controls.Add(this.Lbl_Seccion);
            this.Controls.Add(this.Txt_Semestre);
            this.Controls.Add(this.Lbl_Semestre);
            this.Controls.Add(this.Txt_CodCarrera);
            this.Controls.Add(this.Lbl_CodCarrera);
            this.Controls.Add(this.panel1);
            this.Name = "AlumnosSeccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlumnosSeccion";
            this.Load += new System.EventHandler(this.AlumnosSeccion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListadoxSeccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_listado;
        private System.Windows.Forms.Label Lbl_CodCarrera;
        private System.Windows.Forms.TextBox Txt_CodCarrera;
        private System.Windows.Forms.Label Lbl_Semestre;
        private System.Windows.Forms.TextBox Txt_Semestre;
        private System.Windows.Forms.Label Lbl_Seccion;
        private System.Windows.Forms.TextBox Txt_Seccion;
        private System.Windows.Forms.DataGridView Dgv_ListadoxSeccion;
        private System.Windows.Forms.Label Lbl_NumAlumnos;
        private System.Windows.Forms.TextBox Txt_NumAlumnos;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn Actualizar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Label Lbl_Jornada;
        private System.Windows.Forms.ComboBox Cbo_Jornada;
    }
}