namespace PryMirkoLopezBearzi_2025._05._07
{
    partial class FrmInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.CmbH = new System.Windows.Forms.ComboBox();
            this.LblT = new System.Windows.Forms.Label();
            this.PbBatman = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PbWonder = new System.Windows.Forms.PictureBox();
            this.PbSuper = new System.Windows.Forms.PictureBox();
            this.LblFue = new System.Windows.Forms.Label();
            this.LblDestreza = new System.Windows.Forms.Label();
            this.NuDFuer = new System.Windows.Forms.NumericUpDown();
            this.NuDDestr = new System.Windows.Forms.NumericUpDown();
            this.BtnCrear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbBatman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbWonder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSuper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuDFuer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuDDestr)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbH
            // 
            this.CmbH.FormattingEnabled = true;
            this.CmbH.Location = new System.Drawing.Point(43, 63);
            this.CmbH.Name = "CmbH";
            this.CmbH.Size = new System.Drawing.Size(121, 21);
            this.CmbH.TabIndex = 0;
            this.CmbH.SelectedIndexChanged += new System.EventHandler(this.CmbH_SelectedIndexChanged);
            // 
            // LblT
            // 
            this.LblT.AutoSize = true;
            this.LblT.Location = new System.Drawing.Point(52, 32);
            this.LblT.Name = "LblT";
            this.LblT.Size = new System.Drawing.Size(88, 13);
            this.LblT.TabIndex = 2;
            this.LblT.Text = "Escoga un heroe";
            // 
            // PbBatman
            // 
            this.PbBatman.Image = ((System.Drawing.Image)(resources.GetObject("PbBatman.Image")));
            this.PbBatman.InitialImage = ((System.Drawing.Image)(resources.GetObject("PbBatman.InitialImage")));
            this.PbBatman.Location = new System.Drawing.Point(67, 128);
            this.PbBatman.Name = "PbBatman";
            this.PbBatman.Size = new System.Drawing.Size(295, 170);
            this.PbBatman.TabIndex = 3;
            this.PbBatman.TabStop = false;
            this.PbBatman.Click += new System.EventHandler(this.PbBatman_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PbWonder
            // 
            this.PbWonder.Image = ((System.Drawing.Image)(resources.GetObject("PbWonder.Image")));
            this.PbWonder.Location = new System.Drawing.Point(67, 128);
            this.PbWonder.Name = "PbWonder";
            this.PbWonder.Size = new System.Drawing.Size(305, 199);
            this.PbWonder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbWonder.TabIndex = 4;
            this.PbWonder.TabStop = false;
            this.PbWonder.Click += new System.EventHandler(this.PbWonder_Click);
            // 
            // PbSuper
            // 
            this.PbSuper.Image = ((System.Drawing.Image)(resources.GetObject("PbSuper.Image")));
            this.PbSuper.Location = new System.Drawing.Point(67, 128);
            this.PbSuper.Name = "PbSuper";
            this.PbSuper.Size = new System.Drawing.Size(305, 199);
            this.PbSuper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbSuper.TabIndex = 5;
            this.PbSuper.TabStop = false;
            this.PbSuper.Click += new System.EventHandler(this.PbSuper_Click);
            // 
            // LblFue
            // 
            this.LblFue.AutoSize = true;
            this.LblFue.Location = new System.Drawing.Point(456, 63);
            this.LblFue.Name = "LblFue";
            this.LblFue.Size = new System.Drawing.Size(39, 13);
            this.LblFue.TabIndex = 6;
            this.LblFue.Text = "Fuerza";
            // 
            // LblDestreza
            // 
            this.LblDestreza.AutoSize = true;
            this.LblDestreza.Location = new System.Drawing.Point(456, 99);
            this.LblDestreza.Name = "LblDestreza";
            this.LblDestreza.Size = new System.Drawing.Size(49, 13);
            this.LblDestreza.TabIndex = 7;
            this.LblDestreza.Text = "Destreza";
            // 
            // NuDFuer
            // 
            this.NuDFuer.Location = new System.Drawing.Point(522, 63);
            this.NuDFuer.Name = "NuDFuer";
            this.NuDFuer.Size = new System.Drawing.Size(120, 20);
            this.NuDFuer.TabIndex = 9;
            this.NuDFuer.ValueChanged += new System.EventHandler(this.NuDFuer_ValueChanged);
            // 
            // NuDDestr
            // 
            this.NuDDestr.Location = new System.Drawing.Point(522, 92);
            this.NuDDestr.Name = "NuDDestr";
            this.NuDDestr.Size = new System.Drawing.Size(120, 20);
            this.NuDDestr.TabIndex = 10;
            this.NuDDestr.ValueChanged += new System.EventHandler(this.NuDDestr_ValueChanged);
            // 
            // BtnCrear
            // 
            this.BtnCrear.Location = new System.Drawing.Point(503, 128);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(139, 52);
            this.BtnCrear.TabIndex = 11;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.NuDDestr);
            this.Controls.Add(this.NuDFuer);
            this.Controls.Add(this.LblDestreza);
            this.Controls.Add(this.LblFue);
            this.Controls.Add(this.PbSuper);
            this.Controls.Add(this.PbWonder);
            this.Controls.Add(this.PbBatman);
            this.Controls.Add(this.LblT);
            this.Controls.Add(this.CmbH);
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbBatman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbWonder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbSuper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuDFuer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuDDestr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbH;
        private System.Windows.Forms.Label LblT;
        private System.Windows.Forms.PictureBox PbBatman;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox PbWonder;
        private System.Windows.Forms.PictureBox PbSuper;
        private System.Windows.Forms.Label LblFue;
        private System.Windows.Forms.Label LblDestreza;
        private System.Windows.Forms.NumericUpDown NuDFuer;
        private System.Windows.Forms.NumericUpDown NuDDestr;
        private System.Windows.Forms.Button BtnCrear;
    }
}

