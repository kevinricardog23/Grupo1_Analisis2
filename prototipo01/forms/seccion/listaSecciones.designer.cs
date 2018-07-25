namespace prototipo01
{
    partial class listaSecciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listaSecciones));
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            this.Txt_Buscar = new System.Windows.Forms.TextBox();
            this.Dgv_ListaSecciones = new System.Windows.Forms.DataGridView();
            this.Btn_Crear = new System.Windows.Forms.Button();
            this.Pnl_ListaSeccion = new System.Windows.Forms.Panel();
            this.Lbl_ListaSeccion = new System.Windows.Forms.Label();
            this.pic_refrezcar = new System.Windows.Forms.PictureBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListaSecciones)).BeginInit();
            this.Pnl_ListaSeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_refrezcar)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(82)))), ((int)(((byte)(112)))));
            this.Btn_Actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Actualizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.ForeColor = System.Drawing.Color.White;
            this.Btn_Actualizar.Location = new System.Drawing.Point(738, 253);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(81, 41);
            this.Btn_Actualizar.TabIndex = 12;
            this.Btn_Actualizar.Text = "ACTUALIZAR";
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            this.Btn_Actualizar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Location = new System.Drawing.Point(823, 253);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(82, 41);
            this.Btn_Eliminar.TabIndex = 11;
            this.Btn_Eliminar.Text = "ELIMINAR";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lbl_Buscar
            // 
            this.Lbl_Buscar.AutoSize = true;
            this.Lbl_Buscar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_Buscar.Location = new System.Drawing.Point(57, 200);
            this.Lbl_Buscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Buscar.Name = "Lbl_Buscar";
            this.Lbl_Buscar.Size = new System.Drawing.Size(57, 18);
            this.Lbl_Buscar.TabIndex = 7;
            this.Lbl_Buscar.Text = "Buscar";
            this.Lbl_Buscar.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Buscar.Location = new System.Drawing.Point(129, 193);
            this.Txt_Buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Buscar.Multiline = true;
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.Size = new System.Drawing.Size(524, 39);
            this.Txt_Buscar.TabIndex = 10;
            this.Txt_Buscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Txt_Buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Dgv_ListaSecciones
            // 
            this.Dgv_ListaSecciones.AllowUserToDeleteRows = false;
            this.Dgv_ListaSecciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_ListaSecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ListaSecciones.Location = new System.Drawing.Point(60, 253);
            this.Dgv_ListaSecciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dgv_ListaSecciones.Name = "Dgv_ListaSecciones";
            this.Dgv_ListaSecciones.ReadOnly = true;
            this.Dgv_ListaSecciones.RowTemplate.Height = 24;
            this.Dgv_ListaSecciones.Size = new System.Drawing.Size(844, 323);
            this.Dgv_ListaSecciones.TabIndex = 9;
            this.Dgv_ListaSecciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.Dgv_ListaSecciones.SelectionChanged += new System.EventHandler(this.Dgv_ListaSecciones_SelectionChanged);
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            this.Btn_Crear.FlatAppearance.BorderSize = 0;
            this.Btn_Crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Crear.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Crear.ForeColor = System.Drawing.Color.White;
            this.Btn_Crear.Location = new System.Drawing.Point(766, 134);
            this.Btn_Crear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(82, 41);
            this.Btn_Crear.TabIndex = 8;
            this.Btn_Crear.Text = "CREAR";
            this.Btn_Crear.UseVisualStyleBackColor = false;
            this.Btn_Crear.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pnl_ListaSeccion
            // 
            this.Pnl_ListaSeccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_ListaSeccion.Controls.Add(this.Lbl_ListaSeccion);
            this.Pnl_ListaSeccion.Location = new System.Drawing.Point(50, 69);
            this.Pnl_ListaSeccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pnl_ListaSeccion.Name = "Pnl_ListaSeccion";
            this.Pnl_ListaSeccion.Size = new System.Drawing.Size(868, 38);
            this.Pnl_ListaSeccion.TabIndex = 6;
            this.Pnl_ListaSeccion.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Lbl_ListaSeccion
            // 
            this.Lbl_ListaSeccion.AutoSize = true;
            this.Lbl_ListaSeccion.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_ListaSeccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_ListaSeccion.Location = new System.Drawing.Point(8, 10);
            this.Lbl_ListaSeccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ListaSeccion.Name = "Lbl_ListaSeccion";
            this.Lbl_ListaSeccion.Size = new System.Drawing.Size(142, 18);
            this.Lbl_ListaSeccion.TabIndex = 0;
            this.Lbl_ListaSeccion.Text = "Lista de secciones";
            // 
            // pic_refrezcar
            // 
            this.pic_refrezcar.Image = ((System.Drawing.Image)(resources.GetObject("pic_refrezcar.Image")));
            this.pic_refrezcar.Location = new System.Drawing.Point(862, 134);
            this.pic_refrezcar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_refrezcar.Name = "pic_refrezcar";
            this.pic_refrezcar.Size = new System.Drawing.Size(37, 41);
            this.pic_refrezcar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_refrezcar.TabIndex = 13;
            this.pic_refrezcar.TabStop = false;
            this.pic_refrezcar.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.Btn_buscar.Location = new System.Drawing.Point(656, 193);
            this.Btn_buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(39, 39);
            this.Btn_buscar.TabIndex = 15;
            this.Btn_buscar.UseVisualStyleBackColor = false;
            // 
            // listaSecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 585);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.pic_refrezcar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Lbl_Buscar);
            this.Controls.Add(this.Txt_Buscar);
            this.Controls.Add(this.Dgv_ListaSecciones);
            this.Controls.Add(this.Btn_Crear);
            this.Controls.Add(this.Pnl_ListaSeccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "listaSecciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listaSecciones";
            this.Load += new System.EventHandler(this.listaSecciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListaSecciones)).EndInit();
            this.Pnl_ListaSeccion.ResumeLayout(false);
            this.Pnl_ListaSeccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_refrezcar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Label Lbl_Buscar;
        private System.Windows.Forms.TextBox Txt_Buscar;
        private System.Windows.Forms.DataGridView Dgv_ListaSecciones;
        private System.Windows.Forms.Button Btn_Crear;
        private System.Windows.Forms.Panel Pnl_ListaSeccion;
        private System.Windows.Forms.Label Lbl_ListaSeccion;
        private System.Windows.Forms.PictureBox pic_refrezcar;
        private System.Windows.Forms.Button Btn_buscar;
    }
}