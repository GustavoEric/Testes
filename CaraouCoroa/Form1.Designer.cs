namespace CaraouCoroa
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbCara = new System.Windows.Forms.RadioButton();
            this.rdbCoroa = new System.Windows.Forms.RadioButton();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.ptbMoeda = new System.Windows.Forms.PictureBox();
            this.ptbComputador = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.btnZera = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTema = new System.Windows.Forms.ComboBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMoeda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbComputador)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbCara
            // 
            this.rdbCara.AutoSize = true;
            this.rdbCara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCara.Location = new System.Drawing.Point(59, 285);
            this.rdbCara.Name = "rdbCara";
            this.rdbCara.Size = new System.Drawing.Size(51, 17);
            this.rdbCara.TabIndex = 0;
            this.rdbCara.TabStop = true;
            this.rdbCara.Text = "Cara";
            this.rdbCara.UseVisualStyleBackColor = true;
            this.rdbCara.CheckedChanged += new System.EventHandler(this.rdbCara_CheckedChanged);
            // 
            // rdbCoroa
            // 
            this.rdbCoroa.AutoSize = true;
            this.rdbCoroa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCoroa.Location = new System.Drawing.Point(275, 285);
            this.rdbCoroa.Name = "rdbCoroa";
            this.rdbCoroa.Size = new System.Drawing.Size(58, 17);
            this.rdbCoroa.TabIndex = 1;
            this.rdbCoroa.TabStop = true;
            this.rdbCoroa.Text = "Coroa";
            this.rdbCoroa.UseVisualStyleBackColor = true;
            this.rdbCoroa.CheckedChanged += new System.EventHandler(this.rdbCoroa_CheckedChanged);
            // 
            // btnVerifica
            // 
            this.btnVerifica.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVerifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifica.Location = new System.Drawing.Point(101, 346);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(75, 23);
            this.btnVerifica.TabIndex = 2;
            this.btnVerifica.Text = "Verificar";
            this.btnVerifica.UseVisualStyleBackColor = false;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // ptbMoeda
            // 
            this.ptbMoeda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbMoeda.Location = new System.Drawing.Point(23, 122);
            this.ptbMoeda.Name = "ptbMoeda";
            this.ptbMoeda.Size = new System.Drawing.Size(144, 131);
            this.ptbMoeda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMoeda.TabIndex = 3;
            this.ptbMoeda.TabStop = false;
            // 
            // ptbComputador
            // 
            this.ptbComputador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbComputador.Location = new System.Drawing.Point(210, 122);
            this.ptbComputador.Name = "ptbComputador";
            this.ptbComputador.Size = new System.Drawing.Size(144, 131);
            this.ptbComputador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbComputador.TabIndex = 4;
            this.ptbComputador.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Você";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Computador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(403, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vitórias:";
            // 
            // btnZera
            // 
            this.btnZera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZera.Location = new System.Drawing.Point(486, 346);
            this.btnZera.Name = "btnZera";
            this.btnZera.Size = new System.Drawing.Size(101, 23);
            this.btnZera.TabIndex = 9;
            this.btnZera.Text = "Novo Jogo";
            this.btnZera.UseVisualStyleBackColor = true;
            this.btnZera.Click += new System.EventHandler(this.btnZera_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Derrotas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(360, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 108);
            this.label4.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(487, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 108);
            this.label6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tema:";
            // 
            // cmbTema
            // 
            this.cmbTema.FormattingEnabled = true;
            this.cmbTema.Location = new System.Drawing.Point(23, 38);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(121, 21);
            this.cmbTema.TabIndex = 14;
            this.cmbTema.SelectedIndexChanged += new System.EventHandler(this.cmbTema_SelectedIndexChanged);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(171, 36);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 15;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 401);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.cmbTema);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnZera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbComputador);
            this.Controls.Add(this.ptbMoeda);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.rdbCoroa);
            this.Controls.Add(this.rdbCara);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbMoeda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbComputador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbCara;
        private System.Windows.Forms.RadioButton rdbCoroa;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.PictureBox ptbMoeda;
        private System.Windows.Forms.PictureBox ptbComputador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnZera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTema;
        private System.Windows.Forms.Button btnAplicar;
    }
}

