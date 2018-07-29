namespace prototipo01.forms.curso
{
    partial class Cursos_Create
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
            this.CRUD = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbBox_Pensum = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_semestre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_Ciclo = new System.Windows.Forms.TextBox();
            this.txtBox_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_crear = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.CRUD.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CRUD
            // 
            this.CRUD.Controls.Add(this.tabPage1);
            this.CRUD.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRUD.Location = new System.Drawing.Point(36, 125);
            this.CRUD.Margin = new System.Windows.Forms.Padding(2);
            this.CRUD.Name = "CRUD";
            this.CRUD.SelectedIndex = 0;
            this.CRUD.Size = new System.Drawing.Size(876, 498);
            this.CRUD.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbBox_Pensum);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtBox_semestre);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtbox_ID);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Btn_crear);
            this.tabPage1.Controls.Add(this.txtBox_Ciclo);
            this.tabPage1.Controls.Add(this.txtBox_nombre);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(868, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cmbBox_Pensum
            // 
            this.cmbBox_Pensum.FormattingEnabled = true;
            this.cmbBox_Pensum.Location = new System.Drawing.Point(283, 292);
            this.cmbBox_Pensum.Name = "cmbBox_Pensum";
            this.cmbBox_Pensum.Size = new System.Drawing.Size(356, 27);
            this.cmbBox_Pensum.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label6.Location = new System.Drawing.Point(208, 294);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 37;
            this.label6.Text = "Pensum";
            // 
            // txtBox_semestre
            // 
            this.txtBox_semestre.Location = new System.Drawing.Point(282, 226);
            this.txtBox_semestre.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_semestre.MaxLength = 45;
            this.txtBox_semestre.Multiline = true;
            this.txtBox_semestre.Name = "txtBox_semestre";
            this.txtBox_semestre.Size = new System.Drawing.Size(357, 28);
            this.txtBox_semestre.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label5.Location = new System.Drawing.Point(200, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Semestre";
            // 
            // txtbox_ID
            // 
            this.txtbox_ID.Location = new System.Drawing.Point(282, 31);
            this.txtbox_ID.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_ID.MaxLength = 30;
            this.txtbox_ID.Multiline = true;
            this.txtbox_ID.Name = "txtbox_ID";
            this.txtbox_ID.Size = new System.Drawing.Size(357, 28);
            this.txtbox_ID.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label4.Location = new System.Drawing.Point(254, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtBox_Ciclo
            // 
            this.txtBox_Ciclo.Location = new System.Drawing.Point(282, 162);
            this.txtBox_Ciclo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Ciclo.MaxLength = 45;
            this.txtBox_Ciclo.Multiline = true;
            this.txtBox_Ciclo.Name = "txtBox_Ciclo";
            this.txtBox_Ciclo.Size = new System.Drawing.Size(357, 28);
            this.txtBox_Ciclo.TabIndex = 4;
            // 
            // txtBox_nombre
            // 
            this.txtBox_nombre.Location = new System.Drawing.Point(282, 95);
            this.txtBox_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_nombre.MaxLength = 30;
            this.txtBox_nombre.Multiline = true;
            this.txtBox_nombre.Name = "txtBox_nombre";
            this.txtBox_nombre.Size = new System.Drawing.Size(357, 28);
            this.txtBox_nombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label3.Location = new System.Drawing.Point(153, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciclo del Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(205, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(40, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 50);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Cursos";
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
            this.Btn_crear.Location = new System.Drawing.Point(282, 351);
            this.Btn_crear.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_crear.Name = "Btn_crear";
            this.Btn_crear.Size = new System.Drawing.Size(145, 41);
            this.Btn_crear.TabIndex = 32;
            this.Btn_crear.Text = "Crear";
            this.Btn_crear.UseVisualStyleBackColor = false;
            this.Btn_crear.Click += new System.EventHandler(this.Btn_crear_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackgroundImage = global::prototipo01.Properties.Resources.iconmonstr_angel_left_circle_thin_24;
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(822, 0);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(50, 50);
            this.btn_cerrar.TabIndex = 9;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Cursos_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1045, 647);
            this.Controls.Add(this.CRUD);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cursos_Create";
            this.Text = "Cursos_Create";
            this.Load += new System.EventHandler(this.Cursos_Create_Load);
            this.CRUD.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CRUD;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Btn_crear;
        private System.Windows.Forms.TextBox txtBox_Ciclo;
        private System.Windows.Forms.TextBox txtBox_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_semestre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBox_Pensum;
    }
}