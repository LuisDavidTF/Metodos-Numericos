
namespace Metodos_Numericos
{
    partial class Form2
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgb = new System.Windows.Forms.DataGridView();
            this.Iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NuevoIntervalo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbFx = new System.Windows.Forms.TextBox();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bElevar = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.bMul = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bRes = new System.Windows.Forms.Button();
            this.bPun = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bX = new System.Windows.Forms.Button();
            this.bSum = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.bSup = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtX1
            // 
            this.txtX1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtX1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX1.Location = new System.Drawing.Point(45, 82);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(46, 29);
            this.txtX1.TabIndex = 2;
            // 
            // txtX2
            // 
            this.txtX2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtX2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX2.Location = new System.Drawing.Point(135, 82);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(46, 29);
            this.txtX2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "f(x)";
            // 
            // dgb
            // 
            this.dgb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iteracion,
            this.m,
            this.a,
            this.b,
            this.NuevoIntervalo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgb.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgb.Location = new System.Drawing.Point(135, 168);
            this.dgb.Name = "dgb";
            this.dgb.Size = new System.Drawing.Size(374, 224);
            this.dgb.TabIndex = 1;
            // 
            // Iteracion
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iteracion.DefaultCellStyle = dataGridViewCellStyle1;
            this.Iteracion.HeaderText = "Iteracion";
            this.Iteracion.Name = "Iteracion";
            this.Iteracion.ReadOnly = true;
            this.Iteracion.Width = 50;
            // 
            // m
            // 
            this.m.HeaderText = "m";
            this.m.Name = "m";
            this.m.ReadOnly = true;
            this.m.Width = 50;
            // 
            // a
            // 
            this.a.HeaderText = "a";
            this.a.Name = "a";
            this.a.ReadOnly = true;
            this.a.Width = 50;
            // 
            // b
            // 
            this.b.HeaderText = "b";
            this.b.Name = "b";
            this.b.ReadOnly = true;
            this.b.Width = 50;
            // 
            // NuevoIntervalo
            // 
            this.NuevoIntervalo.HeaderText = "Nuevo Intervalo";
            this.NuevoIntervalo.Name = "NuevoIntervalo";
            this.NuevoIntervalo.ReadOnly = true;
            // 
            // tbFx
            // 
            this.tbFx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFx.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFx.Location = new System.Drawing.Point(45, 117);
            this.tbFx.Name = "tbFx";
            this.tbFx.ReadOnly = true;
            this.tbFx.Size = new System.Drawing.Size(217, 29);
            this.tbFx.TabIndex = 11;
            // 
            // b7
            // 
            this.b7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.b7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(15, 168);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(24, 33);
            this.b7.TabIndex = 12;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.b8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(45, 168);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(24, 33);
            this.b8.TabIndex = 13;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.b9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(75, 168);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(24, 33);
            this.b9.TabIndex = 14;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // bElevar
            // 
            this.bElevar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bElevar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.bElevar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bElevar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bElevar.Location = new System.Drawing.Point(105, 168);
            this.bElevar.Name = "bElevar";
            this.bElevar.Size = new System.Drawing.Size(24, 33);
            this.bElevar.TabIndex = 15;
            this.bElevar.Text = "^";
            this.bElevar.UseVisualStyleBackColor = false;
            this.bElevar.Click += new System.EventHandler(this.bElevar_Click);
            // 
            // b4
            // 
            this.b4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.b4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(15, 207);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(24, 33);
            this.b4.TabIndex = 16;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.b5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(45, 207);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(24, 33);
            this.b5.TabIndex = 17;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.b6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(75, 207);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(24, 33);
            this.b6.TabIndex = 18;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // bMul
            // 
            this.bMul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bMul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.bMul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bMul.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMul.Location = new System.Drawing.Point(105, 207);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(24, 33);
            this.bMul.TabIndex = 19;
            this.bMul.Text = "*";
            this.bMul.UseVisualStyleBackColor = false;
            this.bMul.Click += new System.EventHandler(this.bMul_Click);
            // 
            // b1
            // 
            this.b1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(15, 246);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(24, 33);
            this.b1.TabIndex = 20;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(45, 246);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(24, 33);
            this.b2.TabIndex = 21;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(75, 246);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(24, 33);
            this.b3.TabIndex = 22;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // bRes
            // 
            this.bRes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.bRes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bRes.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRes.Location = new System.Drawing.Point(105, 246);
            this.bRes.Name = "bRes";
            this.bRes.Size = new System.Drawing.Size(24, 33);
            this.bRes.TabIndex = 23;
            this.bRes.Text = "-";
            this.bRes.UseVisualStyleBackColor = false;
            this.bRes.Click += new System.EventHandler(this.bRes_Click);
            // 
            // bPun
            // 
            this.bPun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bPun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.bPun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bPun.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPun.Location = new System.Drawing.Point(15, 285);
            this.bPun.Name = "bPun";
            this.bPun.Size = new System.Drawing.Size(24, 33);
            this.bPun.TabIndex = 24;
            this.bPun.Text = ".";
            this.bPun.UseVisualStyleBackColor = false;
            this.bPun.Click += new System.EventHandler(this.bPun_Click);
            // 
            // b0
            // 
            this.b0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.b0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b0.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.Location = new System.Drawing.Point(45, 285);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(24, 33);
            this.b0.TabIndex = 25;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // bX
            // 
            this.bX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.bX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bX.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bX.Location = new System.Drawing.Point(75, 285);
            this.bX.Name = "bX";
            this.bX.Size = new System.Drawing.Size(24, 33);
            this.bX.TabIndex = 26;
            this.bX.Text = "x";
            this.bX.UseVisualStyleBackColor = false;
            this.bX.Click += new System.EventHandler(this.bX_Click);
            // 
            // bSum
            // 
            this.bSum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.bSum.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSum.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSum.Location = new System.Drawing.Point(105, 285);
            this.bSum.Name = "bSum";
            this.bSum.Size = new System.Drawing.Size(24, 33);
            this.bSum.TabIndex = 27;
            this.bSum.Text = "+";
            this.bSum.UseVisualStyleBackColor = false;
            this.bSum.Click += new System.EventHandler(this.bSum_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(268, 113);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(93, 36);
            this.btnCalcular.TabIndex = 28;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // bSup
            // 
            this.bSup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.bSup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSup.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSup.Location = new System.Drawing.Point(87, 324);
            this.bSup.Name = "bSup";
            this.bSup.Size = new System.Drawing.Size(42, 36);
            this.bSup.TabIndex = 29;
            this.bSup.Text = "<-";
            this.bSup.UseVisualStyleBackColor = false;
            this.bSup.Click += new System.EventHandler(this.bSup_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Metodos_Numericos.Properties.Resources.R__1_;
            this.pictureBox2.Location = new System.Drawing.Point(369, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(515, 463);
            this.Controls.Add(this.bSup);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.bSum);
            this.Controls.Add(this.bX);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bPun);
            this.Controls.Add(this.bRes);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.bMul);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.bElevar);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.tbFx);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.dgb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Bisección";
            ((System.ComponentModel.ISupportInitialize)(this.dgb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgb;
        private System.Windows.Forms.TextBox tbFx;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bElevar;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button bMul;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bRes;
        private System.Windows.Forms.Button bPun;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bX;
        private System.Windows.Forms.Button bSum;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button bSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn m;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn NuevoIntervalo;
    }
}

