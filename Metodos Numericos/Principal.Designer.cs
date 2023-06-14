
namespace Metodos_Numericos
{
    partial class Principal
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
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnTemas = new System.Windows.Forms.Button();
            this.panelUnidades = new System.Windows.Forms.Panel();
            this.btnBiseccion = new System.Windows.Forms.Button();
            this.btnSimpson = new System.Windows.Forms.Button();
            this.btnEuler = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFormHijo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenuLateral.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelUnidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFormHijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.AutoScroll = true;
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMenuLateral.Controls.Add(this.panelUnidades);
            this.panelMenuLateral.Controls.Add(this.btnTemas);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(250, 561);
            this.panelMenuLateral.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // btnTemas
            // 
            this.btnTemas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTemas.FlatAppearance.BorderSize = 0;
            this.btnTemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemas.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnTemas.Location = new System.Drawing.Point(0, 100);
            this.btnTemas.Name = "btnTemas";
            this.btnTemas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTemas.Size = new System.Drawing.Size(250, 45);
            this.btnTemas.TabIndex = 1;
            this.btnTemas.Text = "Temas";
            this.btnTemas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemas.UseVisualStyleBackColor = true;
            this.btnTemas.Click += new System.EventHandler(this.btnTemas_Click);
            // 
            // panelUnidades
            // 
            this.panelUnidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelUnidades.Controls.Add(this.btnEuler);
            this.panelUnidades.Controls.Add(this.btnSimpson);
            this.panelUnidades.Controls.Add(this.btnBiseccion);
            this.panelUnidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUnidades.Location = new System.Drawing.Point(0, 145);
            this.panelUnidades.Name = "panelUnidades";
            this.panelUnidades.Size = new System.Drawing.Size(250, 122);
            this.panelUnidades.TabIndex = 2;
            // 
            // btnBiseccion
            // 
            this.btnBiseccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBiseccion.FlatAppearance.BorderSize = 0;
            this.btnBiseccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiseccion.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnBiseccion.Location = new System.Drawing.Point(0, 0);
            this.btnBiseccion.Name = "btnBiseccion";
            this.btnBiseccion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBiseccion.Size = new System.Drawing.Size(250, 40);
            this.btnBiseccion.TabIndex = 2;
            this.btnBiseccion.Text = "Bisección";
            this.btnBiseccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBiseccion.UseVisualStyleBackColor = true;
            this.btnBiseccion.Click += new System.EventHandler(this.btnBiseccion_Click);
            // 
            // btnSimpson
            // 
            this.btnSimpson.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSimpson.FlatAppearance.BorderSize = 0;
            this.btnSimpson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpson.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSimpson.Location = new System.Drawing.Point(0, 40);
            this.btnSimpson.Name = "btnSimpson";
            this.btnSimpson.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSimpson.Size = new System.Drawing.Size(250, 40);
            this.btnSimpson.TabIndex = 3;
            this.btnSimpson.Text = "Simpson";
            this.btnSimpson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimpson.UseVisualStyleBackColor = true;
            this.btnSimpson.Click += new System.EventHandler(this.btnSimpson_Click);
            // 
            // btnEuler
            // 
            this.btnEuler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEuler.FlatAppearance.BorderSize = 0;
            this.btnEuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEuler.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEuler.Location = new System.Drawing.Point(0, 80);
            this.btnEuler.Name = "btnEuler";
            this.btnEuler.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEuler.Size = new System.Drawing.Size(250, 40);
            this.btnEuler.TabIndex = 4;
            this.btnEuler.Text = "Euler";
            this.btnEuler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEuler.UseVisualStyleBackColor = true;
            this.btnEuler.Click += new System.EventHandler(this.btnEuler_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Metodos_Numericos.Properties.Resources.OIP;
            this.pictureBox1.Location = new System.Drawing.Point(24, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelFormHijo
            // 
            this.panelFormHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelFormHijo.Controls.Add(this.pictureBox2);
            this.panelFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormHijo.Location = new System.Drawing.Point(250, 0);
            this.panelFormHijo.Name = "panelFormHijo";
            this.panelFormHijo.Size = new System.Drawing.Size(684, 561);
            this.panelFormHijo.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Metodos_Numericos.Properties.Resources.R__1_;
            this.pictureBox2.Location = new System.Drawing.Point(207, 185);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(270, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelFormHijo);
            this.Controls.Add(this.panelMenuLateral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panelMenuLateral.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelUnidades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFormHijo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelUnidades;
        private System.Windows.Forms.Button btnEuler;
        private System.Windows.Forms.Button btnSimpson;
        private System.Windows.Forms.Button btnBiseccion;
        private System.Windows.Forms.Button btnTemas;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelFormHijo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}