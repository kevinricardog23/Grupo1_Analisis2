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
            this.button1 = new System.Windows.Forms.Button();
            this.Pnl_ListadoAlumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_ListadoAlumnos
            // 
            this.Pnl_ListadoAlumnos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_ListadoAlumnos.Controls.Add(this.Lbl_ListadoAlumnos);
            this.Pnl_ListadoAlumnos.Location = new System.Drawing.Point(104, 28);
            this.Pnl_ListadoAlumnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_ListadoAlumnos.Name = "Pnl_ListadoAlumnos";
            this.Pnl_ListadoAlumnos.Size = new System.Drawing.Size(1157, 59);
            this.Pnl_ListadoAlumnos.TabIndex = 23;
            // 
            // Lbl_ListadoAlumnos
            // 
            this.Lbl_ListadoAlumnos.AutoSize = true;
            this.Lbl_ListadoAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.Lbl_ListadoAlumnos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Lbl_ListadoAlumnos.Location = new System.Drawing.Point(35, 18);
            this.Lbl_ListadoAlumnos.Name = "Lbl_ListadoAlumnos";
            this.Lbl_ListadoAlumnos.Size = new System.Drawing.Size(217, 24);
            this.Lbl_ListadoAlumnos.TabIndex = 0;
            this.Lbl_ListadoAlumnos.Text = "Litado de Catedraticos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 57);
            this.button1.TabIndex = 24;
            this.button1.Text = "Generar reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AlumnosxCatedratico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 663);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pnl_ListadoAlumnos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlumnosxCatedratico";
            this.Text = "AlumnosxCatedratico";
            this.Load += new System.EventHandler(this.AlumnosxCatedratico_Load);
            this.Pnl_ListadoAlumnos.ResumeLayout(false);
            this.Pnl_ListadoAlumnos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_ListadoAlumnos;
        private System.Windows.Forms.Label Lbl_ListadoAlumnos;
        private System.Windows.Forms.Button button1;
    }
}