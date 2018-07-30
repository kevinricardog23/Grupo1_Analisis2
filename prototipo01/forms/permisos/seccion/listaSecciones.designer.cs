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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Lbl_Buscar = new System.Windows.Forms.Label();
            this.Txt_Buscar = new System.Windows.Forms.TextBox();
            this.Dgv_ListaSecciones = new System.Windows.Forms.DataGridView();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Pnl_ListaSeccion = new System.Windows.Forms.Panel();
            this.Lbl_ListaSeccion = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListaSecciones)).BeginInit();
            this.Pnl_ListaSeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(82)))), ((int)(((byte)(112)))));
            this.Btn_Actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Actualizar.ForeColor = System.Drawing.Color.White;
            this.Btn_Actualizar.Image = global::prototipo01.Properties.Resources.iconmonstr_synchronization_19_24;
            this.Btn_Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Actualizar.Location = new System.Drawing.Point(269, 171);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(145, 41);
            this.Btn_Actualizar.TabIndex = 12;
            this.Btn_Actualizar.Text = "Editar";
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            this.Btn_Actualizar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(58)))), ((int)(((byte)(81)))));
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Image = global::prototipo01.Properties.Resources.iconmonstr_x_mark_13_24;
            this.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Eliminar.Location = new System.Drawing.Point(418, 171);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(145, 41);
            this.Btn_Eliminar.TabIndex = 11;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lbl_Buscar
            // 
            this.Lbl_Buscar.AutoSize = true;
            this.Lbl_Buscar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_Buscar.Location = new System.Drawing.Point(48, 136);
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
            this.Txt_Buscar.Location = new System.Drawing.Point(120, 128);
            this.Txt_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Buscar.MaxLength = 11;
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
            this.Dgv_ListaSecciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_ListaSecciones.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dgv_ListaSecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_ListaSecciones.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_ListaSecciones.EnableHeadersVisualStyles = false;
            this.Dgv_ListaSecciones.Location = new System.Drawing.Point(51, 233);
            this.Dgv_ListaSecciones.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_ListaSecciones.Name = "Dgv_ListaSecciones";
            this.Dgv_ListaSecciones.ReadOnly = true;
            this.Dgv_ListaSecciones.RowHeadersVisible = false;
            this.Dgv_ListaSecciones.RowTemplate.Height = 24;
            this.Dgv_ListaSecciones.Size = new System.Drawing.Size(844, 323);
            this.Dgv_ListaSecciones.TabIndex = 9;
            this.Dgv_ListaSecciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.Dgv_ListaSecciones.SelectionChanged += new System.EventHandler(this.Dgv_ListaSecciones_SelectionChanged);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            this.Btn_Buscar.FlatAppearance.BorderSize = 0;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.Image = global::prototipo01.Properties.Resources.iconmonstr_edit_11_24;
            this.Btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Buscar.Location = new System.Drawing.Point(120, 171);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(145, 41);
            this.Btn_Buscar.TabIndex = 8;
            this.Btn_Buscar.Text = "Crear";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            this.Btn_Buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pnl_ListaSeccion
            // 
            this.Pnl_ListaSeccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_ListaSeccion.Controls.Add(this.Lbl_ListaSeccion);
            this.Pnl_ListaSeccion.Location = new System.Drawing.Point(40, 70);
            this.Pnl_ListaSeccion.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_ListaSeccion.Name = "Pnl_ListaSeccion";
            this.Pnl_ListaSeccion.Size = new System.Drawing.Size(870, 50);
            this.Pnl_ListaSeccion.TabIndex = 6;
            this.Pnl_ListaSeccion.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Lbl_ListaSeccion
            // 
            this.Lbl_ListaSeccion.AutoSize = true;
            this.Lbl_ListaSeccion.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_ListaSeccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_ListaSeccion.Location = new System.Drawing.Point(15, 15);
            this.Lbl_ListaSeccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ListaSeccion.Name = "Lbl_ListaSeccion";
            this.Lbl_ListaSeccion.Size = new System.Drawing.Size(142, 18);
            this.Lbl_ListaSeccion.TabIndex = 0;
            this.Lbl_ListaSeccion.Text = "Lista de secciones";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(873, 136);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            this.button4.BackgroundImage = global::prototipo01.Properties.Resources.iconmonstr_magnifier_1_32;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(646, 128);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(39, 39);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // listaSecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 578);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Lbl_Buscar);
            this.Controls.Add(this.Txt_Buscar);
            this.Controls.Add(this.Dgv_ListaSecciones);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Pnl_ListaSeccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "listaSecciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listaSecciones";
            this.Load += new System.EventHandler(this.listaSecciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ListaSecciones)).EndInit();
            this.Pnl_ListaSeccion.ResumeLayout(false);
            this.Pnl_ListaSeccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Label Lbl_Buscar;
        private System.Windows.Forms.TextBox Txt_Buscar;
        private System.Windows.Forms.DataGridView Dgv_ListaSecciones;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Panel Pnl_ListaSeccion;
        private System.Windows.Forms.Label Lbl_ListaSeccion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
    }
}