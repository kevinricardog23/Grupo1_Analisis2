namespace prototipo01.forms.estudiante
{
    partial class Listado_estudiante
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
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Dgb_estudiantes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.Lbl_buscar = new System.Windows.Forms.Label();
            this.Btn_crear = new System.Windows.Forms.Button();
            this.Pnl_estudiantes = new System.Windows.Forms.Panel();
            this.Lbl_estudiantes = new System.Windows.Forms.Label();
            this.Btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgb_estudiantes)).BeginInit();
            this.Pnl_estudiantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.Btn_eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_eliminar.Location = new System.Drawing.Point(922, 183);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(82, 41);
            this.Btn_eliminar.TabIndex = 35;
            this.Btn_eliminar.Text = "ELIMINAR";
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(82)))), ((int)(((byte)(112)))));
            this.Btn_actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.ForeColor = System.Drawing.Color.White;
            this.Btn_actualizar.Location = new System.Drawing.Point(818, 183);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(100, 41);
            this.Btn_actualizar.TabIndex = 34;
            this.Btn_actualizar.Text = "ACTUALIZAR";
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Dgb_estudiantes
            // 
            this.Dgb_estudiantes.AllowUserToDeleteRows = false;
            this.Dgb_estudiantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgb_estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgb_estudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombres,
            this.Apellidos,
            this.Contraseña,
            this.Correo,
            this.Telefono,
            this.Direccion});
            this.Dgb_estudiantes.Location = new System.Drawing.Point(-7, 244);
            this.Dgb_estudiantes.Margin = new System.Windows.Forms.Padding(2);
            this.Dgb_estudiantes.Name = "Dgb_estudiantes";
            this.Dgb_estudiantes.ReadOnly = true;
            this.Dgb_estudiantes.RowTemplate.Height = 24;
            this.Dgb_estudiantes.Size = new System.Drawing.Size(1027, 323);
            this.Dgb_estudiantes.TabIndex = 33;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            this.Nombres.Width = 200;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 200;
            // 
            // Contraseña
            // 
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 150;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 150;
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Location = new System.Drawing.Point(143, 171);
            this.Txt_buscar.Multiline = true;
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(524, 39);
            this.Txt_buscar.TabIndex = 32;
            // 
            // Lbl_buscar
            // 
            this.Lbl_buscar.AutoSize = true;
            this.Lbl_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_buscar.Location = new System.Drawing.Point(51, 183);
            this.Lbl_buscar.Name = "Lbl_buscar";
            this.Lbl_buscar.Size = new System.Drawing.Size(61, 18);
            this.Lbl_buscar.TabIndex = 31;
            this.Lbl_buscar.Text = "Buscar";
            // 
            // Btn_crear
            // 
            this.Btn_crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            this.Btn_crear.FlatAppearance.BorderSize = 0;
            this.Btn_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_crear.ForeColor = System.Drawing.Color.White;
            this.Btn_crear.Location = new System.Drawing.Point(908, 110);
            this.Btn_crear.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_crear.Name = "Btn_crear";
            this.Btn_crear.Size = new System.Drawing.Size(82, 41);
            this.Btn_crear.TabIndex = 30;
            this.Btn_crear.Text = "CREAR";
            this.Btn_crear.UseVisualStyleBackColor = false;
            this.Btn_crear.Click += new System.EventHandler(this.Btn_crear_Click);
            // 
            // Pnl_estudiantes
            // 
            this.Pnl_estudiantes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_estudiantes.Controls.Add(this.Lbl_estudiantes);
            this.Pnl_estudiantes.Location = new System.Drawing.Point(23, 28);
            this.Pnl_estudiantes.Name = "Pnl_estudiantes";
            this.Pnl_estudiantes.Size = new System.Drawing.Size(967, 50);
            this.Pnl_estudiantes.TabIndex = 29;
            // 
            // Lbl_estudiantes
            // 
            this.Lbl_estudiantes.AutoSize = true;
            this.Lbl_estudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estudiantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_estudiantes.Location = new System.Drawing.Point(28, 18);
            this.Lbl_estudiantes.Name = "Lbl_estudiantes";
            this.Lbl_estudiantes.Size = new System.Drawing.Size(160, 18);
            this.Lbl_estudiantes.TabIndex = 0;
            this.Lbl_estudiantes.Text = "Lista de Estudiantes";
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            this.Btn_buscar.BackgroundImage = global::prototipo01.Properties.Resources.iconmonstr_magnifier_1_32;
            this.Btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_buscar.FlatAppearance.BorderSize = 0;
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_buscar.Location = new System.Drawing.Point(672, 171);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(39, 39);
            this.Btn_buscar.TabIndex = 36;
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Listado_estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 578);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Dgb_estudiantes);
            this.Controls.Add(this.Txt_buscar);
            this.Controls.Add(this.Lbl_buscar);
            this.Controls.Add(this.Btn_crear);
            this.Controls.Add(this.Pnl_estudiantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listado_estudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado_estudiante";
            ((System.ComponentModel.ISupportInitialize)(this.Dgb_estudiantes)).EndInit();
            this.Pnl_estudiantes.ResumeLayout(false);
            this.Pnl_estudiantes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.DataGridView Dgb_estudiantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.Label Lbl_buscar;
        private System.Windows.Forms.Button Btn_crear;
        private System.Windows.Forms.Panel Pnl_estudiantes;
        private System.Windows.Forms.Label Lbl_estudiantes;
        private System.Windows.Forms.Button Btn_buscar;
    }
}