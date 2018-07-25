namespace prototipo01.forms.seccion.reportes
{
    partial class AlumnosxCarrera
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
            this.Pnl_ListadoAlumnos = new System.Windows.Forms.Panel();
            this.Lbl_ListadoAlumnos = new System.Windows.Forms.Label();
            this.Txt_CodCarrera = new System.Windows.Forms.TextBox();
            this.Lbl_CodCarrera = new System.Windows.Forms.Label();
            this.Txt_CodFacu = new System.Windows.Forms.TextBox();
            this.Lbl_CodFacu = new System.Windows.Forms.Label();
            this.Lbl_Jornada = new System.Windows.Forms.Label();
            this.Dgv_ListadoAlumnos = new System.Windows.Forms.DataGridView();
            this.Carnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Lbl_NumAlumnos = new System.Windows.Forms.Label();
            this.Txt_NumAlunos = new System.Windows.Forms.TextBox();
            this.Cbo_Jornada = new System.Windows.Forms.ComboBox();
            this.Pnl_ListadoAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListadoAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_ListadoAlumnos
            // 
            this.Pnl_ListadoAlumnos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_ListadoAlumnos.Controls.Add(this.Lbl_ListadoAlumnos);
            this.Pnl_ListadoAlumnos.Location = new System.Drawing.Point(81, 22);
            this.Pnl_ListadoAlumnos.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_ListadoAlumnos.Name = "Pnl_ListadoAlumnos";
            this.Pnl_ListadoAlumnos.Size = new System.Drawing.Size(868, 48);
            this.Pnl_ListadoAlumnos.TabIndex = 22;
            // 
            // Lbl_ListadoAlumnos
            // 
            this.Lbl_ListadoAlumnos.AutoSize = true;
            this.Lbl_ListadoAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_ListadoAlumnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_ListadoAlumnos.Location = new System.Drawing.Point(51, 17);
            this.Lbl_ListadoAlumnos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ListadoAlumnos.Name = "Lbl_ListadoAlumnos";
            this.Lbl_ListadoAlumnos.Size = new System.Drawing.Size(248, 18);
            this.Lbl_ListadoAlumnos.TabIndex = 0;
            this.Lbl_ListadoAlumnos.Text = "Listado de Alumnos por Carrera";
            // 
            // Txt_CodCarrera
            // 
            this.Txt_CodCarrera.Location = new System.Drawing.Point(702, 106);
            this.Txt_CodCarrera.Name = "Txt_CodCarrera";
            this.Txt_CodCarrera.Size = new System.Drawing.Size(132, 20);
            this.Txt_CodCarrera.TabIndex = 29;
            this.Txt_CodCarrera.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.Txt_CodCarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // Lbl_CodCarrera
            // 
            this.Lbl_CodCarrera.AutoSize = true;
            this.Lbl_CodCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodCarrera.Location = new System.Drawing.Point(536, 106);
            this.Lbl_CodCarrera.Name = "Lbl_CodCarrera";
            this.Lbl_CodCarrera.Size = new System.Drawing.Size(160, 20);
            this.Lbl_CodCarrera.TabIndex = 28;
            this.Lbl_CodCarrera.Text = "Codigo de Carrera:";
            // 
            // Txt_CodFacu
            // 
            this.Txt_CodFacu.Location = new System.Drawing.Point(291, 106);
            this.Txt_CodFacu.Name = "Txt_CodFacu";
            this.Txt_CodFacu.Size = new System.Drawing.Size(132, 20);
            this.Txt_CodFacu.TabIndex = 27;
            this.Txt_CodFacu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Lbl_CodFacu
            // 
            this.Lbl_CodFacu.AutoSize = true;
            this.Lbl_CodFacu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodFacu.Location = new System.Drawing.Point(116, 106);
            this.Lbl_CodFacu.Name = "Lbl_CodFacu";
            this.Lbl_CodFacu.Size = new System.Drawing.Size(170, 20);
            this.Lbl_CodFacu.TabIndex = 26;
            this.Lbl_CodFacu.Text = "Codigo de Facultad:";
            // 
            // Lbl_Jornada
            // 
            this.Lbl_Jornada.AutoSize = true;
            this.Lbl_Jornada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Jornada.Location = new System.Drawing.Point(193, 149);
            this.Lbl_Jornada.Name = "Lbl_Jornada";
            this.Lbl_Jornada.Size = new System.Drawing.Size(79, 20);
            this.Lbl_Jornada.TabIndex = 36;
            this.Lbl_Jornada.Text = "Jornada:";
            // 
            // Dgv_ListadoAlumnos
            // 
            this.Dgv_ListadoAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ListadoAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Carnet,
            this.Nombre,
            this.Seccion,
            this.Actualizar,
            this.Eliminar});
            this.Dgv_ListadoAlumnos.Location = new System.Drawing.Point(135, 216);
            this.Dgv_ListadoAlumnos.Name = "Dgv_ListadoAlumnos";
            this.Dgv_ListadoAlumnos.Size = new System.Drawing.Size(539, 150);
            this.Dgv_ListadoAlumnos.TabIndex = 38;
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
            // Seccion
            // 
            this.Seccion.HeaderText = "Seccion";
            this.Seccion.Name = "Seccion";
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
            this.Eliminar.Width = 90;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            this.Btn_Buscar.FlatAppearance.BorderSize = 0;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.Location = new System.Drawing.Point(752, 139);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(82, 41);
            this.Btn_Buscar.TabIndex = 39;
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
            this.Btn_Actualizar.Location = new System.Drawing.Point(478, 216);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(102, 41);
            this.Btn_Actualizar.TabIndex = 40;
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
            this.Btn_Eliminar.Location = new System.Drawing.Point(584, 216);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(90, 41);
            this.Btn_Eliminar.TabIndex = 41;
            this.Btn_Eliminar.Text = "ELIMINAR";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // Lbl_NumAlumnos
            // 
            this.Lbl_NumAlumnos.AutoSize = true;
            this.Lbl_NumAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NumAlumnos.Location = new System.Drawing.Point(505, 411);
            this.Lbl_NumAlumnos.Name = "Lbl_NumAlumnos";
            this.Lbl_NumAlumnos.Size = new System.Drawing.Size(246, 24);
            this.Lbl_NumAlumnos.TabIndex = 42;
            this.Lbl_NumAlumnos.Text = "NUMERO DE ALUMNOS:";
            // 
            // Txt_NumAlunos
            // 
            this.Txt_NumAlunos.Location = new System.Drawing.Point(768, 415);
            this.Txt_NumAlunos.Name = "Txt_NumAlunos";
            this.Txt_NumAlunos.Size = new System.Drawing.Size(99, 20);
            this.Txt_NumAlunos.TabIndex = 43;
            this.Txt_NumAlunos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // Cbo_Jornada
            // 
            this.Cbo_Jornada.FormattingEnabled = true;
            this.Cbo_Jornada.Items.AddRange(new object[] {
            "Matutina",
            "Vespertina",
            "Sabados"});
            this.Cbo_Jornada.Location = new System.Drawing.Point(291, 147);
            this.Cbo_Jornada.Name = "Cbo_Jornada";
            this.Cbo_Jornada.Size = new System.Drawing.Size(132, 21);
            this.Cbo_Jornada.TabIndex = 44;
            // 
            // AlumnosxCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 539);
            this.Controls.Add(this.Cbo_Jornada);
            this.Controls.Add(this.Txt_NumAlunos);
            this.Controls.Add(this.Lbl_NumAlumnos);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Dgv_ListadoAlumnos);
            this.Controls.Add(this.Lbl_Jornada);
            this.Controls.Add(this.Txt_CodCarrera);
            this.Controls.Add(this.Lbl_CodCarrera);
            this.Controls.Add(this.Txt_CodFacu);
            this.Controls.Add(this.Lbl_CodFacu);
            this.Controls.Add(this.Pnl_ListadoAlumnos);
            this.Name = "AlumnosxCarrera";
            this.Text = "AlumnosxCarrera";
            this.Pnl_ListadoAlumnos.ResumeLayout(false);
            this.Pnl_ListadoAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListadoAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_ListadoAlumnos;
        private System.Windows.Forms.Label Lbl_ListadoAlumnos;
        private System.Windows.Forms.TextBox Txt_CodCarrera;
        private System.Windows.Forms.Label Lbl_CodCarrera;
        private System.Windows.Forms.TextBox Txt_CodFacu;
        private System.Windows.Forms.Label Lbl_CodFacu;
        private System.Windows.Forms.Label Lbl_Jornada;
        private System.Windows.Forms.DataGridView Dgv_ListadoAlumnos;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seccion;
        private System.Windows.Forms.DataGridViewButtonColumn Actualizar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Label Lbl_NumAlumnos;
        private System.Windows.Forms.TextBox Txt_NumAlunos;
        private System.Windows.Forms.ComboBox Cbo_Jornada;
    }
}