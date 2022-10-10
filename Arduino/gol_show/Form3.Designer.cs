namespace gol_show
{
    partial class Form3
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
            this.lblTimeVerde = new System.Windows.Forms.Label();
            this.lblTimeAmarelo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimeVerde
            // 
            this.lblTimeVerde.AutoSize = true;
            this.lblTimeVerde.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeVerde.Font = new System.Drawing.Font("MV Boli", 200.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeVerde.ForeColor = System.Drawing.Color.Yellow;
            this.lblTimeVerde.Location = new System.Drawing.Point(307, 471);
            this.lblTimeVerde.Name = "lblTimeVerde";
            this.lblTimeVerde.Size = new System.Drawing.Size(367, 430);
            this.lblTimeVerde.TabIndex = 0;
            this.lblTimeVerde.Text = "0";
            // 
            // lblTimeAmarelo
            // 
            this.lblTimeAmarelo.AutoSize = true;
            this.lblTimeAmarelo.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeAmarelo.Font = new System.Drawing.Font("MV Boli", 200.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeAmarelo.ForeColor = System.Drawing.Color.Green;
            this.lblTimeAmarelo.Location = new System.Drawing.Point(1263, 491);
            this.lblTimeAmarelo.Name = "lblTimeAmarelo";
            this.lblTimeAmarelo.Size = new System.Drawing.Size(367, 430);
            this.lblTimeAmarelo.TabIndex = 1;
            this.lblTimeAmarelo.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Image = global::gol_show.Properties.Resources.Design_sem_nome__1_;
            this.pictureBox1.Location = new System.Drawing.Point(1848, 1007);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gol_show.Properties.Resources.Pontuação;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTimeAmarelo);
            this.Controls.Add(this.lblTimeVerde);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeVerde;
        private System.Windows.Forms.Label lblTimeAmarelo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}