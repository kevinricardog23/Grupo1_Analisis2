namespace prototipo01.forms.seccion.reportes
{
    partial class AlumnosxCatedratico
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
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_Seccion = new System.Windows.Forms.TextBox();
            this.Lbl_Seccion = new System.Windows.Forms.Label();
            this.Txt_CodCurso = new System.Windows.Forms.TextBox();
            this.Lbl_CodCurso = new System.Windows.Forms.Label();
            this.Txt_CodCat = new System.Windows.Forms.TextBox();
            this.Lbl_CodCate = new System.Windows.Forms.Label();
            this.Dgv_ListadoxCatedratico = new System.Windows.Forms.DataGridView();
            this.Carnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Lbl_NumAlumnos = new System.Windows.Forms.Label();
            this.Txt_NumAlumnos = new System.Windows.Forms.TextBox();
            this.Pnl_ListadoAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListadoxCatedratico)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_ListadoAlumnos
            // 
            this.Pnl_ListadoAlumnos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_ListadoAlumnos.Controls.Add(this.Lbl_ListadoAlumnos);
            this.Pnl_ListadoAlumnos.Location = new System.Drawing.Point(78, 23);
            this.Pnl_ListadoAlumnos.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_ListadoAlumnos.Name = "Pnl_ListadoAlumnos";
            this.Pnl_ListadoAlumnos.Size = new System.Drawing.Size(868, 48);
            this.Pnl_ListadoAlumnos.TabIndex = 23;
            // 
            // Lbl_ListadoAlumnos
            // 
            this.Lbl_ListadoAlumnos.AutoSize = true;
            this.Lbl_ListadoAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_ListadoAlumnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_ListadoAlumnos.Location = new System.Drawing.Point(26, 15);
            this.Lbl_ListadoAlumnos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ListadoAlumnos.Name = "Lbl_ListadoAlumnos";
            this.Lbl_ListadoAlumnos.Size = new System.Drawing.Size(278, 18);
            this.Lbl_ListadoAlumnos.TabIndex = 0;
            this.Lbl_ListadoAlumnos.Text = "Listado de Alumnos por Catedratico";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            this.Btn_Buscar.FlatAppearance.BorderSize = 0;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.Location = new System.Drawing.Point(728, 154);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(82, 41);
            this.Btn_Buscar.TabIndex = 46;
            this.Btn_Buscar.Text = "BUSCAR";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_Seccion
            // 
            this.Txt_Seccion.Location = new System.Drawing.Point(291, 154);
            this.Txt_Seccion.MaxLength = 1;
            this.Txt_Seccion.Name = "Txt_Seccion";
            this.Txt_Seccion.Size = new System.Drawing.Size(132, 20);
            this.Txt_Seccion.TabIndex = 45;
            this.Txt_Seccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // Lbl_Seccion
            // 
            this.Lbl_Seccion.AutoSize = true;
            this.Lbl_Seccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Seccion.Location = new System.Drawing.Point(169, 154);
            this.Lbl_Seccion.Name = "Lbl_Seccion";
            this.Lbl_Seccion.Size = new System.Drawing.Size(78, 20);
            this.Lbl_Seccion.TabIndex = 44;
            this.Lbl_Seccion.Text = "Seccion:";
            // 
            // Txt_CodCurso
            // 
            this.Txt_CodCurso.Location = new System.Drawing.Point(678, 111);
            this.Txt_CodCurso.MaxLength = 11;
            this.Txt_CodCurso.Name = "Txt_CodCurso";
            this.Txt_CodCurso.Size = new System.Drawing.Size(132, 20);
            this.Txt_CodCurso.TabIndex = 43;
            this.Txt_CodCurso.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.Txt_CodCurso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // Lbl_CodCurso
            // 
            this.Lbl_CodCurso.AutoSize = true;
            this.Lbl_CodCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodCurso.Location = new System.Drawing.Point(512, 111);
            this.Lbl_CodCurso.Name = "Lbl_CodCurso";
            this.Lbl_CodCurso.Size = new System.Drawing.Size(147, 20);
            this.Lbl_CodCurso.TabIndex = 42;
            this.Lbl_CodCurso.Text = "Codigo de Curso:";
            // 
            // Txt_CodCat
            // 
            this.Txt_CodCat.Location = new System.Drawing.Point(291, 111);
            this.Txt_CodCat.MaxLength = 11;
            this.Txt_CodCat.Name = "Txt_CodCat";
            this.Txt_CodCat.Size = new System.Drawing.Size(132, 20);
            this.Txt_CodCat.TabIndex = 41;
            this.Txt_CodCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Lbl_CodCate
            // 
            this.Lbl_CodCate.AutoSize = true;
            this.Lbl_CodCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodCate.Location = new System.Drawing.Point(92, 111);
            this.Lbl_CodCate.Name = "Lbl_CodCate";
            this.Lbl_CodCate.Size = new System.Drawing.Size(193, 20);
            this.Lbl_CodCate.TabIndex = 40;
            this.Lbl_CodCate.Text = "Codigo de Catedratico:";
            // 
            // Dgv_ListadoxCatedratico
            // 
            this.Dgv_ListadoxCatedratico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ListadoxCatedratico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Carnet,
            this.Nombre,
            this.Curso,
            this.Salon,
            this.Actualizar,
            this.Eliminar});
            this.Dgv_ListadoxCatedratico.Location = new System.Drawing.Point(132, 238);
            this.Dgv_ListadoxCatedratico.Name = "Dgv_ListadoxCatedratico";
            this.Dgv_ListadoxCatedratico.Size = new System.Drawing.Size(623, 150);
            this.Dgv_ListadoxCatedratico.TabIndex = 47;
            // 
            // Carnet
            // 
            this.Carnet.HeaderText = "Carnet";
            this.Carnet.Name = "Carnet";
            this.Carnet.Width = 90;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            // 
            // Salon
            // 
            this.Salon.HeaderText = "Salon";
            this.Salon.Name = "Salon";
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
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(82)))), ((int)(((byte)(112)))));
            this.Btn_Actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.ForeColor = System.Drawing.Color.White;
            this.Btn_Actualizar.Location = new System.Drawing.Point(559, 238);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(102, 41);
            this.Btn_Actualizar.TabIndex = 48;
            this.Btn_Actualizar.Text = "ACTUALIZAR";
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            this.Btn_Actualizar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Location = new System.Drawing.Point(665, 238);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(90, 41);
            this.Btn_Eliminar.TabIndex = 49;
            this.Btn_Eliminar.Text = "ELIMINAR";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // Lbl_NumAlumnos
            // 
            this.Lbl_NumAlumnos.AutoSize = true;
            this.Lbl_NumAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NumAlumnos.Location = new System.Drawing.Point(490, 470);
            this.Lbl_NumAlumnos.Name = "Lbl_NumAlumnos";
            this.Lbl_NumAlumnos.Size = new System.Drawing.Size(246, 24);
            this.Lbl_NumAlumnos.TabIndex = 50;
            this.Lbl_NumAlumnos.Text = "NUMERO DE ALUMNOS:";
            // 
            // Txt_NumAlumnos
            // 
            this.Txt_NumAlumnos.Location = new System.Drawing.Point(751, 474);
            this.Txt_NumAlumnos.Name = "Txt_NumAlumnos";
            this.Txt_NumAlumnos.Size = new System.Drawing.Size(99, 20);
            this.Txt_NumAlumnos.TabIndex = 51;
            this.Txt_NumAlumnos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // AlumnosxCatedratico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 539);
            this.Controls.Add(this.Txt_NumAlumnos);
            this.Controls.Add(this.Lbl_NumAlumnos);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Dgv_ListadoxCatedratico);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Txt_Seccion);
            this.Controls.Add(this.Lbl_Seccion);
            this.Controls.Add(this.Txt_CodCurso);
            this.Controls.Add(this.Lbl_CodCurso);
            this.Controls.Add(this.Txt_CodCat);
            this.Controls.Add(this.Lbl_CodCate);
            this.Controls.Add(this.Pnl_ListadoAlumnos);
            this.Name = "AlumnosxCatedratico";
            this.Text = "AlumnosxCatedratico";
            this.Pnl_ListadoAlumnos.ResumeLayout(false);
            this.Pnl_ListadoAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListadoxCatedratico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_ListadoAlumnos;
        private System.Windows.Forms.Label Lbl_ListadoAlumnos;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txt_Seccion;
        private System.Windows.Forms.Label Lbl_Seccion;
        private System.Windows.Forms.TextBox Txt_CodCurso;
        private System.Windows.Forms.Label Lbl_CodCurso;
        private System.Windows.Forms.TextBox Txt_CodCat;
        private System.Windows.Forms.Label Lbl_CodCate;
        private System.Windows.Forms.DataGridView Dgv_ListadoxCatedratico;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salon;
        private System.Windows.Forms.DataGridViewButtonColumn Actualizar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Label Lbl_NumAlumnos;
        private System.Windows.Forms.TextBox Txt_NumAlumnos;
    }
}