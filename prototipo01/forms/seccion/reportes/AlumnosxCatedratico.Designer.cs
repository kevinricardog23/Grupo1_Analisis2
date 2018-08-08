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
            this.Txt_CodCat = new System.Windows.Forms.TextBox();
            this.Lbl_CodCate = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pnl_ListadoAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.Lbl_ListadoAlumnos.Size = new System.Drawing.Size(342, 24);
            this.Lbl_ListadoAlumnos.TabIndex = 0;
            this.Lbl_ListadoAlumnos.Text = "Listado de Alumnos por Catedratico";
            // 
            // Txt_CodCat
            // 
            this.Txt_CodCat.Location = new System.Drawing.Point(388, 137);
            this.Txt_CodCat.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_CodCat.MaxLength = 11;
            this.Txt_CodCat.Name = "Txt_CodCat";
            this.Txt_CodCat.Size = new System.Drawing.Size(175, 22);
            this.Txt_CodCat.TabIndex = 41;
            this.Txt_CodCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Lbl_CodCate
            // 
            this.Lbl_CodCate.AutoSize = true;
            this.Lbl_CodCate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CodCate.Location = new System.Drawing.Point(123, 137);
            this.Lbl_CodCate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_CodCate.Name = "Lbl_CodCate";
            this.Lbl_CodCate.Size = new System.Drawing.Size(235, 25);
            this.Lbl_CodCate.TabIndex = 40;
            this.Lbl_CodCate.Text = "Codigo de Catedratico:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1351, 436);
            this.dataGridView1.TabIndex = 42;
            // 
            // AlumnosxCatedratico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 663);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txt_CodCat);
            this.Controls.Add(this.Lbl_CodCate);
            this.Controls.Add(this.Pnl_ListadoAlumnos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlumnosxCatedratico";
            this.Text = "AlumnosxCatedratico";
            this.Load += new System.EventHandler(this.AlumnosxCatedratico_Load);
            this.Pnl_ListadoAlumnos.ResumeLayout(false);
            this.Pnl_ListadoAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_ListadoAlumnos;
        private System.Windows.Forms.Label Lbl_ListadoAlumnos;
        private System.Windows.Forms.TextBox Txt_CodCat;
        private System.Windows.Forms.Label Lbl_CodCate;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}