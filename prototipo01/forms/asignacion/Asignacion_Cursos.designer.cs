namespace prototipo01.forms.asignacion
{
    partial class Asignacion_Cursos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Btn_Asignar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(104, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 48);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asignación de cursos";
            // 
            // txtBox1
            // 
            this.txtBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBox1.Location = new System.Drawing.Point(344, 29);
            this.txtBox1.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox1.Multiline = true;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(58, 28);
            this.txtBox1.TabIndex = 3;
            this.txtBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(246, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Carné";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(58, 78);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(946, 476);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Btn_Asignar);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.txtBox4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.Btn_Ok);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtBox3);
            this.tabPage1.Controls.Add(this.txtBox2);
            this.tabPage1.Controls.Add(this.txtBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(938, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Btn_Asignar
            // 
            this.Btn_Asignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(70)))), ((int)(((byte)(96)))));
            this.Btn_Asignar.FlatAppearance.BorderSize = 0;
            this.Btn_Asignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Asignar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Asignar.ForeColor = System.Drawing.Color.White;
            this.Btn_Asignar.Location = new System.Drawing.Point(431, 386);
            this.Btn_Asignar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Asignar.Name = "Btn_Asignar";
            this.Btn_Asignar.Size = new System.Drawing.Size(101, 48);
            this.Btn_Asignar.TabIndex = 18;
            this.Btn_Asignar.Text = "Asignar";
            this.Btn_Asignar.UseVisualStyleBackColor = false;
            this.Btn_Asignar.Click += new System.EventHandler(this.Btn_Asignar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(693, 200);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.status,
            this.seccion,
            this.asignar});
            this.dataGridView1.Location = new System.Drawing.Point(180, 176);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(583, 193);
            this.dataGridView1.TabIndex = 12;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo de Curso";
            this.codigo.Name = "codigo";
            this.codigo.Width = 200;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 200;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // seccion
            // 
            this.seccion.HeaderText = "Sección";
            this.seccion.Name = "seccion";
            // 
            // asignar
            // 
            this.asignar.HeaderText = "Asignar";
            this.asignar.Name = "asignar";
            // 
            // txtBox4
            // 
            this.txtBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBox4.Location = new System.Drawing.Point(235, 120);
            this.txtBox4.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox4.Multiline = true;
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.Size = new System.Drawing.Size(315, 28);
            this.txtBox4.TabIndex = 11;
            this.txtBox4.TextChanged += new System.EventHandler(this.txtBox4_TextChanged);
            this.txtBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label6.Location = new System.Drawing.Point(62, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "No. boleta de pago";
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(153)))));
            this.Btn_Ok.FlatAppearance.BorderSize = 0;
            this.Btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ok.ForeColor = System.Drawing.Color.White;
            this.Btn_Ok.Location = new System.Drawing.Point(575, 120);
            this.Btn_Ok.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(38, 28);
            this.Btn_Ok.TabIndex = 9;
            this.Btn_Ok.Text = "OK";
            this.Btn_Ok.UseVisualStyleBackColor = false;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label5.Location = new System.Drawing.Point(506, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "No. de estudiante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label4.Location = new System.Drawing.Point(428, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label3.Location = new System.Drawing.Point(345, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Carrera";
            // 
            // txtBox3
            // 
            this.txtBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBox3.Location = new System.Drawing.Point(488, 29);
            this.txtBox3.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox3.Multiline = true;
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(156, 28);
            this.txtBox3.TabIndex = 5;
            this.txtBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtBox2
            // 
            this.txtBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBox2.Location = new System.Drawing.Point(416, 29);
            this.txtBox2.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox2.Multiline = true;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(58, 28);
            this.txtBox2.TabIndex = 4;
            this.txtBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Asignacion_Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 578);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Asignacion_Cursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion_Cursos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignar;
        private System.Windows.Forms.Button Btn_Asignar;
    }
}