namespace prototipo01
{
    partial class Edificion_Update
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edificion_Update));
            this.CRUD = new System.Windows.Forms.TabControl();
            this.Btn_Actualizar = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.epErrorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.epErrorDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.epErrorUbicacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.CRUD.SuspendLayout();
            this.Btn_Actualizar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorDescripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorUbicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // CRUD
            // 
            this.CRUD.Controls.Add(this.Btn_Actualizar);
            this.CRUD.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRUD.Location = new System.Drawing.Point(12, 76);
            this.CRUD.Margin = new System.Windows.Forms.Padding(2);
            this.CRUD.Name = "CRUD";
            this.CRUD.SelectedIndex = 0;
            this.CRUD.Size = new System.Drawing.Size(876, 498);
            this.CRUD.TabIndex = 3;
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Controls.Add(this.button1);
            this.Btn_Actualizar.Controls.Add(this.txtBox2);
            this.Btn_Actualizar.Controls.Add(this.txtBox1);
            this.Btn_Actualizar.Controls.Add(this.label4);
            this.Btn_Actualizar.Controls.Add(this.label2);
            this.Btn_Actualizar.Location = new System.Drawing.Point(4, 28);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Padding = new System.Windows.Forms.Padding(2);
            this.Btn_Actualizar.Size = new System.Drawing.Size(868, 466);
            this.Btn_Actualizar.TabIndex = 0;
            this.Btn_Actualizar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(70)))), ((int)(((byte)(96)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(437, 310);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(332, 233);
            this.txtBox2.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox2.Multiline = true;
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(317, 28);
            this.txtBox2.TabIndex = 15;
            // 
            // txtBox1
            // 
            this.txtBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBox1.Location = new System.Drawing.Point(332, 132);
            this.txtBox1.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox1.Multiline = true;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(317, 28);
            this.txtBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label4.Location = new System.Drawing.Point(223, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ubicación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label2.Location = new System.Drawing.Point(223, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actualizar Edificio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 48);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(814, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // epErrorNombre
            // 
            this.epErrorNombre.ContainerControl = this;
            // 
            // epErrorDescripcion
            // 
            this.epErrorDescripcion.ContainerControl = this;
            // 
            // epErrorUbicacion
            // 
            this.epErrorUbicacion.ContainerControl = this;
            // 
            // Edificion_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 585);
            this.Controls.Add(this.CRUD);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Edificion_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edificion_Update";
            this.Load += new System.EventHandler(this.Edificion_Update_Load);
            this.CRUD.ResumeLayout(false);
            this.Btn_Actualizar.ResumeLayout(false);
            this.Btn_Actualizar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorDescripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorUbicacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CRUD;
        private System.Windows.Forms.TabPage Btn_Actualizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider epErrorNombre;
        private System.Windows.Forms.ErrorProvider epErrorDescripcion;
        private System.Windows.Forms.ErrorProvider epErrorUbicacion;
    }
}