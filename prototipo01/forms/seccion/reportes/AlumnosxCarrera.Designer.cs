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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Pnl_ListadoAlumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_ListadoAlumnos
            // 
            this.Pnl_ListadoAlumnos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_ListadoAlumnos.Controls.Add(this.Lbl_ListadoAlumnos);
            this.Pnl_ListadoAlumnos.Location = new System.Drawing.Point(108, 27);
            this.Pnl_ListadoAlumnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_ListadoAlumnos.Name = "Pnl_ListadoAlumnos";
            this.Pnl_ListadoAlumnos.Size = new System.Drawing.Size(1157, 59);
            this.Pnl_ListadoAlumnos.TabIndex = 22;
            // 
            // Lbl_ListadoAlumnos
            // 
            this.Lbl_ListadoAlumnos.AutoSize = true;
            this.Lbl_ListadoAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_ListadoAlumnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_ListadoAlumnos.Location = new System.Drawing.Point(68, 21);
            this.Lbl_ListadoAlumnos.Name = "Lbl_ListadoAlumnos";
            this.Lbl_ListadoAlumnos.Size = new System.Drawing.Size(306, 24);
            this.Lbl_ListadoAlumnos.TabIndex = 0;
            this.Lbl_ListadoAlumnos.Text = "Listado de Alumnos por Carrera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Carrera";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(253, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 24);
            this.comboBox1.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 34);
            this.button1.TabIndex = 25;
            this.button1.Text = "Generar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AlumnosxCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 663);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pnl_ListadoAlumnos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AlumnosxCarrera";
            this.Text = "AlumnosxCarrera";
            this.Load += new System.EventHandler(this.AlumnosxCarrera_Load);
            this.Pnl_ListadoAlumnos.ResumeLayout(false);
            this.Pnl_ListadoAlumnos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_ListadoAlumnos;
        private System.Windows.Forms.Label Lbl_ListadoAlumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}