namespace prototipo01
{
    partial class Seccion_Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seccion_Create));
            this.CRUD = new System.Windows.Forms.TabControl();
            this.Tbp_CrearSeccion = new System.Windows.Forms.TabPage();
            this.Btn_Crear = new System.Windows.Forms.Button();
            this.Txt_Estado = new System.Windows.Forms.TextBox();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Pnl_CrearSeccion = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_CrearSeccion = new System.Windows.Forms.Label();
            this.CRUD.SuspendLayout();
            this.Tbp_CrearSeccion.SuspendLayout();
            this.Pnl_CrearSeccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CRUD
            // 
            this.CRUD.Controls.Add(this.Tbp_CrearSeccion);
            this.CRUD.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRUD.Location = new System.Drawing.Point(12, 76);
            this.CRUD.Margin = new System.Windows.Forms.Padding(2);
            this.CRUD.Name = "CRUD";
            this.CRUD.SelectedIndex = 0;
            this.CRUD.Size = new System.Drawing.Size(876, 498);
            this.CRUD.TabIndex = 3;
            // 
            // Tbp_CrearSeccion
            // 
            this.Tbp_CrearSeccion.Controls.Add(this.Btn_Crear);
            this.Tbp_CrearSeccion.Controls.Add(this.Txt_Estado);
            this.Tbp_CrearSeccion.Controls.Add(this.Txt_Nombre);
            this.Tbp_CrearSeccion.Controls.Add(this.Lbl_Estado);
            this.Tbp_CrearSeccion.Controls.Add(this.Lbl_Nombre);
            this.Tbp_CrearSeccion.Location = new System.Drawing.Point(4, 28);
            this.Tbp_CrearSeccion.Margin = new System.Windows.Forms.Padding(2);
            this.Tbp_CrearSeccion.Name = "Tbp_CrearSeccion";
            this.Tbp_CrearSeccion.Padding = new System.Windows.Forms.Padding(2);
            this.Tbp_CrearSeccion.Size = new System.Drawing.Size(868, 466);
            this.Tbp_CrearSeccion.TabIndex = 0;
            this.Tbp_CrearSeccion.UseVisualStyleBackColor = true;
            // 
            // Btn_Crear
            // 
            this.Btn_Crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            this.Btn_Crear.FlatAppearance.BorderSize = 0;
            this.Btn_Crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Crear.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Crear.ForeColor = System.Drawing.Color.White;
            this.Btn_Crear.Location = new System.Drawing.Point(441, 324);
            this.Btn_Crear.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Crear.Name = "Btn_Crear";
            this.Btn_Crear.Size = new System.Drawing.Size(101, 48);
            this.Btn_Crear.TabIndex = 6;
            this.Btn_Crear.Text = "Crear";
            this.Btn_Crear.UseVisualStyleBackColor = false;
            this.Btn_Crear.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_Estado
            // 
            this.Txt_Estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Estado.Location = new System.Drawing.Point(328, 241);
            this.Txt_Estado.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Estado.Multiline = true;
            this.Txt_Estado.Name = "Txt_Estado";
            this.Txt_Estado.Size = new System.Drawing.Size(317, 28);
            this.Txt_Estado.TabIndex = 3;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Txt_Nombre.Location = new System.Drawing.Point(328, 168);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Nombre.Multiline = true;
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(317, 28);
            this.Txt_Nombre.TabIndex = 1;
            this.Txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_Estado.Location = new System.Drawing.Point(219, 242);
            this.Lbl_Estado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(59, 19);
            this.Lbl_Estado.TabIndex = 2;
            this.Lbl_Estado.Text = "Estado";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_Nombre.Location = new System.Drawing.Point(219, 169);
            this.Lbl_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(73, 19);
            this.Lbl_Nombre.TabIndex = 0;
            this.Lbl_Nombre.Text = "Nombre";
            // 
            // Pnl_CrearSeccion
            // 
            this.Pnl_CrearSeccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_CrearSeccion.Controls.Add(this.pictureBox1);
            this.Pnl_CrearSeccion.Controls.Add(this.Lbl_CrearSeccion);
            this.Pnl_CrearSeccion.Location = new System.Drawing.Point(12, 11);
            this.Pnl_CrearSeccion.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_CrearSeccion.Name = "Pnl_CrearSeccion";
            this.Pnl_CrearSeccion.Size = new System.Drawing.Size(876, 48);
            this.Pnl_CrearSeccion.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(812, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Lbl_CrearSeccion
            // 
            this.Lbl_CrearSeccion.AutoSize = true;
            this.Lbl_CrearSeccion.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CrearSeccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_CrearSeccion.Location = new System.Drawing.Point(8, 16);
            this.Lbl_CrearSeccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_CrearSeccion.Name = "Lbl_CrearSeccion";
            this.Lbl_CrearSeccion.Size = new System.Drawing.Size(115, 18);
            this.Lbl_CrearSeccion.TabIndex = 0;
            this.Lbl_CrearSeccion.Text = "Crear Sección";
            // 
            // Seccion_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 585);
            this.Controls.Add(this.CRUD);
            this.Controls.Add(this.Pnl_CrearSeccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Seccion_Create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seccion";
            this.CRUD.ResumeLayout(false);
            this.Tbp_CrearSeccion.ResumeLayout(false);
            this.Tbp_CrearSeccion.PerformLayout();
            this.Pnl_CrearSeccion.ResumeLayout(false);
            this.Pnl_CrearSeccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CRUD;
        private System.Windows.Forms.TabPage Tbp_CrearSeccion;
        private System.Windows.Forms.Button Btn_Crear;
        private System.Windows.Forms.TextBox Txt_Estado;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.Panel Pnl_CrearSeccion;
        private System.Windows.Forms.Label Lbl_CrearSeccion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}