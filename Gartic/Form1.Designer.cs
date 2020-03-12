namespace Gartic
{
    partial class Form1
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
            this.pnDesenhar = new System.Windows.Forms.Panel();
            this.lsbUsers = new System.Windows.Forms.ListBox();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lsbConversa = new System.Windows.Forms.ListBox();
            this.pcbVermelho = new System.Windows.Forms.PictureBox();
            this.pcbPreto = new System.Windows.Forms.PictureBox();
            this.pcbAzul = new System.Windows.Forms.PictureBox();
            this.pcbVerde = new System.Windows.Forms.PictureBox();
            this.pnCores = new System.Windows.Forms.Panel();
            this.pcbBranco = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbVermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPreto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVerde)).BeginInit();
            this.pnCores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBranco)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDesenhar
            // 
            this.pnDesenhar.BackColor = System.Drawing.Color.White;
            this.pnDesenhar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDesenhar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnDesenhar.Location = new System.Drawing.Point(138, 12);
            this.pnDesenhar.Name = "pnDesenhar";
            this.pnDesenhar.Size = new System.Drawing.Size(760, 270);
            this.pnDesenhar.TabIndex = 0;
            this.pnDesenhar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pnDesenhar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pnDesenhar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.pnDesenhar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lsbUsers
            // 
            this.lsbUsers.FormattingEnabled = true;
            this.lsbUsers.Location = new System.Drawing.Point(12, 12);
            this.lsbUsers.Name = "lsbUsers";
            this.lsbUsers.Size = new System.Drawing.Size(120, 394);
            this.lsbUsers.TabIndex = 1;
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(139, 385);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(565, 20);
            this.txtEnviar.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(711, 385);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(48, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lsbConversa
            // 
            this.lsbConversa.FormattingEnabled = true;
            this.lsbConversa.Location = new System.Drawing.Point(139, 289);
            this.lsbConversa.Name = "lsbConversa";
            this.lsbConversa.Size = new System.Drawing.Size(620, 82);
            this.lsbConversa.TabIndex = 4;
            // 
            // pcbVermelho
            // 
            this.pcbVermelho.BackColor = System.Drawing.Color.Red;
            this.pcbVermelho.Location = new System.Drawing.Point(93, 3);
            this.pcbVermelho.Name = "pcbVermelho";
            this.pcbVermelho.Size = new System.Drawing.Size(25, 23);
            this.pcbVermelho.TabIndex = 5;
            this.pcbVermelho.TabStop = false;
            this.pcbVermelho.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pcbPreto
            // 
            this.pcbPreto.BackColor = System.Drawing.SystemColors.InfoText;
            this.pcbPreto.Location = new System.Drawing.Point(65, 3);
            this.pcbPreto.Name = "pcbPreto";
            this.pcbPreto.Size = new System.Drawing.Size(25, 23);
            this.pcbPreto.TabIndex = 6;
            this.pcbPreto.TabStop = false;
            this.pcbPreto.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pcbAzul
            // 
            this.pcbAzul.BackColor = System.Drawing.Color.DodgerBlue;
            this.pcbAzul.Location = new System.Drawing.Point(34, 3);
            this.pcbAzul.Name = "pcbAzul";
            this.pcbAzul.Size = new System.Drawing.Size(25, 23);
            this.pcbAzul.TabIndex = 7;
            this.pcbAzul.TabStop = false;
            this.pcbAzul.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pcbVerde
            // 
            this.pcbVerde.BackColor = System.Drawing.Color.Lime;
            this.pcbVerde.Location = new System.Drawing.Point(3, 3);
            this.pcbVerde.Name = "pcbVerde";
            this.pcbVerde.Size = new System.Drawing.Size(25, 23);
            this.pcbVerde.TabIndex = 8;
            this.pcbVerde.TabStop = false;
            this.pcbVerde.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pnCores
            // 
            this.pnCores.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnCores.Controls.Add(this.pcbBranco);
            this.pnCores.Controls.Add(this.pcbVermelho);
            this.pnCores.Controls.Add(this.pcbVerde);
            this.pnCores.Controls.Add(this.pcbAzul);
            this.pnCores.Controls.Add(this.pcbPreto);
            this.pnCores.Location = new System.Drawing.Point(765, 289);
            this.pnCores.Name = "pnCores";
            this.pnCores.Size = new System.Drawing.Size(118, 60);
            this.pnCores.TabIndex = 9;
            // 
            // pcbBranco
            // 
            this.pcbBranco.BackColor = System.Drawing.Color.White;
            this.pcbBranco.Location = new System.Drawing.Point(49, 32);
            this.pcbBranco.Name = "pcbBranco";
            this.pcbBranco.Size = new System.Drawing.Size(26, 24);
            this.pcbBranco.TabIndex = 9;
            this.pcbBranco.TabStop = false;
            this.pcbBranco.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(765, 348);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Yellow;
            this.progressBar1.Location = new System.Drawing.Point(138, 278);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(760, 10);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Value = 100;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 435);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.pnCores);
            this.Controls.Add(this.lsbConversa);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.lsbUsers);
            this.Controls.Add(this.pnDesenhar);
            this.Name = "Form1";
            this.Text = "ComicArt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pcbVermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPreto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVerde)).EndInit();
            this.pnCores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBranco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnDesenhar;
        private System.Windows.Forms.ListBox lsbUsers;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lsbConversa;
        private System.Windows.Forms.PictureBox pcbVermelho;
        private System.Windows.Forms.PictureBox pcbPreto;
        private System.Windows.Forms.PictureBox pcbAzul;
        private System.Windows.Forms.PictureBox pcbVerde;
        private System.Windows.Forms.Panel pnCores;
        private System.Windows.Forms.PictureBox pcbBranco;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}

