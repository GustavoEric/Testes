
namespace gol_show
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblPergunta = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnAmarelo = new System.Windows.Forms.Button();
            this.btnAtl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPergunta
            // 
            this.lblPergunta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.BackColor = System.Drawing.Color.Transparent;
            this.lblPergunta.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblPergunta.Location = new System.Drawing.Point(493, 129);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(170, 34);
            this.lblPergunta.TabIndex = 2;
            this.lblPergunta.Text = "PERGUNTA";
            // 
            // lblA
            // 
            this.lblA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.Color.Transparent;
            this.lblA.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(539, 396);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(249, 34);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "ALTERNATIVA A";
            this.lblA.Click += new System.EventHandler(this.lblA_Click);
            // 
            // lblB
            // 
            this.lblB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblB.AutoSize = true;
            this.lblB.BackColor = System.Drawing.Color.Transparent;
            this.lblB.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(539, 533);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(246, 34);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "ALTERNATIVA B";
            this.lblB.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblC
            // 
            this.lblC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblC.AutoSize = true;
            this.lblC.BackColor = System.Drawing.Color.Transparent;
            this.lblC.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(539, 673);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(246, 34);
            this.lblC.TabIndex = 7;
            this.lblC.Text = "ALTERNATIVA C";
            this.lblC.Click += new System.EventHandler(this.lblC_Click);
            // 
            // lblD
            // 
            this.lblD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblD.AutoSize = true;
            this.lblD.BackColor = System.Drawing.Color.Transparent;
            this.lblD.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(539, 813);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(249, 34);
            this.lblD.TabIndex = 8;
            this.lblD.Text = "ALTERNATIVA D";
            this.lblD.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblE
            // 
            this.lblE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblE.AutoSize = true;
            this.lblE.BackColor = System.Drawing.Color.Transparent;
            this.lblE.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.Location = new System.Drawing.Point(535, 953);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(246, 34);
            this.lblE.TabIndex = 9;
            this.lblE.Text = "ALTERNATIVA E";
            this.lblE.Click += new System.EventHandler(this.lblE_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(39, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 14);
            this.panel1.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gol_show.Properties.Resources.arduino;
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnVerde
            // 
            this.btnVerde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerde.BackColor = System.Drawing.Color.Green;
            this.btnVerde.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btnVerde.FlatAppearance.BorderSize = 3;
            this.btnVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerde.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerde.Location = new System.Drawing.Point(316, 518);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(110, 71);
            this.btnVerde.TabIndex = 12;
            this.btnVerde.Text = "0";
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // btnAmarelo
            // 
            this.btnAmarelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAmarelo.BackColor = System.Drawing.Color.Yellow;
            this.btnAmarelo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAmarelo.FlatAppearance.BorderSize = 3;
            this.btnAmarelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAmarelo.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmarelo.Location = new System.Drawing.Point(1492, 512);
            this.btnAmarelo.Name = "btnAmarelo";
            this.btnAmarelo.Size = new System.Drawing.Size(110, 71);
            this.btnAmarelo.TabIndex = 13;
            this.btnAmarelo.Text = "0";
            this.btnAmarelo.UseVisualStyleBackColor = false;
            this.btnAmarelo.Click += new System.EventHandler(this.btnAmarelo_Click);
            // 
            // btnAtl
            // 
            this.btnAtl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtl.BackColor = System.Drawing.Color.Transparent;
            this.btnAtl.FlatAppearance.BorderSize = 0;
            this.btnAtl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtl.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtl.Location = new System.Drawing.Point(1868, 1040);
            this.btnAtl.Name = "btnAtl";
            this.btnAtl.Size = new System.Drawing.Size(40, 28);
            this.btnAtl.TabIndex = 14;
            this.btnAtl.UseVisualStyleBackColor = false;
            this.btnAtl.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1604, 1043);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Vez de responder do time: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gol_show.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtl);
            this.Controls.Add(this.btnAmarelo);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblPergunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Button btnAmarelo;
        private System.Windows.Forms.Button btnAtl;
        private System.Windows.Forms.Label label1;
    }
}