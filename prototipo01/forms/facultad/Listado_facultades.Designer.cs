namespace prototipo01.forms.facultad
{
    partial class Listado_facultades
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
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Lbl_buscar = new System.Windows.Forms.Label();
            this.Txt_buscar = new System.Windows.Forms.TextBox();
            this.Dgv_facultades = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_crear = new System.Windows.Forms.Button();
            this.Pnl_listafacultades = new System.Windows.Forms.Panel();
            this.Lbl_listafacultades = new System.Windows.Forms.Label();
            this.Btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_facultades)).BeginInit();
            this.Pnl_listafacultades.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(82)))), ((int)(((byte)(112)))));
            this.Btn_actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold);
            this.Btn_actualizar.ForeColor = System.Drawing.Color.White;
            this.Btn_actualizar.Location = new System.Drawing.Point(687, 145);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(95, 41);
            this.Btn_actualizar.TabIndex = 12;
            this.Btn_actualizar.Text = "ACTUALIZAR";
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.Btn_eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_eliminar.Location = new System.Drawing.Point(786, 145);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(82, 41);
            this.Btn_eliminar.TabIndex = 11;
            this.Btn_eliminar.Text = "ELIMINAR";
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // Lbl_buscar
            // 
            this.Lbl_buscar.AutoSize = true;
            this.Lbl_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_buscar.Location = new System.Drawing.Point(21, 151);
            this.Lbl_buscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_buscar.Name = "Lbl_buscar";
            this.Lbl_buscar.Size = new System.Drawing.Size(61, 18);
            this.Lbl_buscar.TabIndex = 7;
            this.Lbl_buscar.Text = "Buscar";
            // 
            // Txt_buscar
            // 
            this.Txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_buscar.Location = new System.Drawing.Point(93, 145);
            this.Txt_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_buscar.Multiline = true;
            this.Txt_buscar.Name = "Txt_buscar";
            this.Txt_buscar.Size = new System.Drawing.Size(524, 39);
            this.Txt_buscar.TabIndex = 10;
            // 
            // Dgv_facultades
            // 
            this.Dgv_facultades.AllowUserToDeleteRows = false;
            this.Dgv_facultades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_facultades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_facultades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.ubicacion});
            this.Dgv_facultades.Location = new System.Drawing.Point(24, 204);
            this.Dgv_facultades.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_facultades.Name = "Dgv_facultades";
            this.Dgv_facultades.ReadOnly = true;
            this.Dgv_facultades.RowTemplate.Height = 24;
            this.Dgv_facultades.Size = new System.Drawing.Size(844, 323);
            this.Dgv_facultades.TabIndex = 9;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 330;
            // 
            // ubicacion
            // 
            this.ubicacion.HeaderText = "Ubicación";
            this.ubicacion.Name = "ubicacion";
            this.ubicacion.ReadOnly = true;
            this.ubicacion.Width = 430;
            // 
            // Btn_crear
            // 
            this.Btn_crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            this.Btn_crear.FlatAppearance.BorderSize = 0;
            this.Btn_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_crear.ForeColor = System.Drawing.Color.White;
            this.Btn_crear.Location = new System.Drawing.Point(741, 76);
            this.Btn_crear.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_crear.Name = "Btn_crear";
            this.Btn_crear.Size = new System.Drawing.Size(82, 41);
            this.Btn_crear.TabIndex = 8;
            this.Btn_crear.Text = "CREAR";
            this.Btn_crear.UseVisualStyleBackColor = false;
            this.Btn_crear.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pnl_listafacultades
            // 
            this.Pnl_listafacultades.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_listafacultades.Controls.Add(this.Lbl_listafacultades);
            this.Pnl_listafacultades.Location = new System.Drawing.Point(14, 12);
            this.Pnl_listafacultades.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_listafacultades.Name = "Pnl_listafacultades";
            this.Pnl_listafacultades.Size = new System.Drawing.Size(868, 48);
            this.Pnl_listafacultades.TabIndex = 6;
            // 
            // Lbl_listafacultades
            // 
            this.Lbl_listafacultades.AutoSize = true;
            this.Lbl_listafacultades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_listafacultades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_listafacultades.Location = new System.Drawing.Point(15, 15);
            this.Lbl_listafacultades.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_listafacultades.Name = "Lbl_listafacultades";
            this.Lbl_listafacultades.Size = new System.Drawing.Size(149, 18);
            this.Lbl_listafacultades.TabIndex = 0;
            this.Lbl_listafacultades.Text = "Lista de facultades";
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
            this.Btn_buscar.Location = new System.Drawing.Point(621, 145);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(39, 39);
            this.Btn_buscar.TabIndex = 37;
            this.Btn_buscar.UseVisualStyleBackColor = false;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Listado_facultades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 538);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Lbl_buscar);
            this.Controls.Add(this.Txt_buscar);
            this.Controls.Add(this.Dgv_facultades);
            this.Controls.Add(this.Btn_crear);
            this.Controls.Add(this.Pnl_listafacultades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listado_facultades";
            this.Text = "Listado_facultades";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_facultades)).EndInit();
            this.Pnl_listafacultades.ResumeLayout(false);
            this.Pnl_listafacultades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Label Lbl_buscar;
        private System.Windows.Forms.TextBox Txt_buscar;
        private System.Windows.Forms.DataGridView Dgv_facultades;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacion;
        private System.Windows.Forms.Button Btn_crear;
        private System.Windows.Forms.Panel Pnl_listafacultades;
        private System.Windows.Forms.Label Lbl_listafacultades;
        private System.Windows.Forms.Button Btn_buscar;
    }
}