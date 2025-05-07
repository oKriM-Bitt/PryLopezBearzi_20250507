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
            this.CmbH = new System.Windows.Forms.ComboBox();
            this.PbH = new System.Windows.Forms.PictureBox();
            this.LblT = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // PbH
            // 
            this.PbH.Location = new System.Drawing.Point(52, 147);
            this.PbH.Name = "PbH";
            this.PbH.Size = new System.Drawing.Size(522, 140);
            this.PbH.TabIndex = 1;
            this.PbH.TabStop = false;
            this.PbH.Click += new System.EventHandler(this.PbH_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(266, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 140);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(130, 280);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(522, 140);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblT);
            this.Controls.Add(this.PbH);
            this.Controls.Add(this.CmbH);
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbH;
        private System.Windows.Forms.PictureBox PbH;
        private System.Windows.Forms.Label LblT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

