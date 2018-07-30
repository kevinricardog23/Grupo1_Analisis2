namespace prototipo01.forms.curso
{
    partial class Cursos_Update
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBox_Pensum = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_semestre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbox_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_update = new System.Windows.Forms.Button();
            this.txtBox_Creditos = new System.Windows.Forms.TextBox();
            this.txtBox_nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CRUD.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CRUD
            // 
            this.CRUD.Controls.Add(this.tabPage1);
            this.CRUD.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRUD.Location = new System.Drawing.Point(40, 125);
            this.CRUD.Margin = new System.Windows.Forms.Padding(2);
            this.CRUD.Name = "CRUD";
            this.CRUD.SelectedIndex = 0;
            this.CRUD.Size = new System.Drawing.Size(876, 498);
            this.CRUD.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbBox_Pensum);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtBox_semestre);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtbox_ID);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Btn_update);
            this.tabPage1.Controls.Add(this.txtBox_Creditos);
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
            this.panel1.TabIndex = 4;
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
            // cmbBox_Pensum
            // 
            this.cmbBox_Pensum.FormattingEnabled = true;
            this.cmbBox_Pensum.Location = new System.Drawing.Point(298, 314);
            this.cmbBox_Pensum.Name = "cmbBox_Pensum";
            this.cmbBox_Pensum.Size = new System.Drawing.Size(356, 27);
            this.cmbBox_Pensum.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label6.Location = new System.Drawing.Point(223, 316);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 48;
            this.label6.Text = "Pensum";
            // 
            // txtBox_semestre
            // 
            this.txtBox_semestre.Location = new System.Drawing.Point(297, 248);
            this.txtBox_semestre.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_semestre.MaxLength = 45;
            this.txtBox_semestre.Multiline = true;
            this.txtBox_semestre.Name = "txtBox_semestre";
            this.txtBox_semestre.Size = new System.Drawing.Size(357, 28);
            this.txtBox_semestre.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label5.Location = new System.Drawing.Point(215, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 46;
            this.label5.Text = "Semestre";
            // 
            // txtbox_ID
            // 
            this.txtbox_ID.Location = new System.Drawing.Point(297, 53);
            this.txtbox_ID.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_ID.MaxLength = 30;
            this.txtbox_ID.Multiline = true;
            this.txtbox_ID.Name = "txtbox_ID";
            this.txtbox_ID.Size = new System.Drawing.Size(357, 28);
            this.txtbox_ID.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label4.Location = new System.Drawing.Point(269, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 19);
            this.label4.TabIndex = 44;
            this.label4.Text = "ID";
            // 
            // Btn_update
            // 
            this.Btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(82)))), ((int)(((byte)(112)))));
            this.Btn_update.FlatAppearance.BorderSize = 0;
            this.Btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_update.ForeColor = System.Drawing.Color.White;
            this.Btn_update.Image = global::prototipo01.Properties.Resources.iconmonstr_synchronization_19_24;
            this.Btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_update.Location = new System.Drawing.Point(297, 373);
            this.Btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_update.Name = "Btn_update";
            this.Btn_update.Size = new System.Drawing.Size(145, 41);
            this.Btn_update.TabIndex = 43;
            this.Btn_update.Text = "Editar";
            this.Btn_update.UseVisualStyleBackColor = false;
            this.Btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // txtBox_Creditos
            // 
            this.txtBox_Creditos.Location = new System.Drawing.Point(297, 184);
            this.txtBox_Creditos.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_Creditos.MaxLength = 45;
            this.txtBox_Creditos.Multiline = true;
            this.txtBox_Creditos.Name = "txtBox_Creditos";
            this.txtBox_Creditos.Size = new System.Drawing.Size(357, 28);
            this.txtBox_Creditos.TabIndex = 42;
            // 
            // txtBox_nombre
            // 
            this.txtBox_nombre.Location = new System.Drawing.Point(297, 117);
            this.txtBox_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_nombre.MaxLength = 30;
            this.txtBox_nombre.Multiline = true;
            this.txtBox_nombre.Name = "txtBox_nombre";
            this.txtBox_nombre.Size = new System.Drawing.Size(357, 28);
            this.txtBox_nombre.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label3.Location = new System.Drawing.Point(220, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Creditos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(220, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nombre";
            // 
            // Cursos_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1045, 645);
            this.Controls.Add(this.CRUD);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cursos_Update";
            this.Text = "Cursos_Update";
            this.Load += new System.EventHandler(this.Cursos_Update_Load);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBox_Pensum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_semestre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbox_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_update;
        private System.Windows.Forms.TextBox txtBox_Creditos;
        private System.Windows.Forms.TextBox txtBox_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}