namespace TP06_192149
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_Limpar = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Estatistica = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Rol = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_media = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Detalhes = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Altura = new System.Windows.Forms.TextBox();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lbl_Aviso = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Lbx_Inseridos = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Lbx_Ordenados = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Lbl_Media = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Limpar,
            this.Menu_Estatistica,
            this.Menu_Detalhes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(892, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_Limpar
            // 
            this.Menu_Limpar.Name = "Menu_Limpar";
            this.Menu_Limpar.Size = new System.Drawing.Size(56, 19);
            this.Menu_Limpar.Text = "Limpar";
            this.Menu_Limpar.Click += new System.EventHandler(this.Menu_Limpar_Click);
            // 
            // Menu_Estatistica
            // 
            this.Menu_Estatistica.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Rol,
            this.Menu_media});
            this.Menu_Estatistica.Name = "Menu_Estatistica";
            this.Menu_Estatistica.Size = new System.Drawing.Size(64, 19);
            this.Menu_Estatistica.Text = "Calculos";
            // 
            // Menu_Rol
            // 
            this.Menu_Rol.Name = "Menu_Rol";
            this.Menu_Rol.Size = new System.Drawing.Size(180, 22);
            this.Menu_Rol.Text = "Rol";
            this.Menu_Rol.Click += new System.EventHandler(this.Menu_Rol_Click);
            // 
            // Menu_media
            // 
            this.Menu_media.Name = "Menu_media";
            this.Menu_media.Size = new System.Drawing.Size(180, 22);
            this.Menu_media.Text = "Média";
            this.Menu_media.Click += new System.EventHandler(this.Menu_media_Click);
            // 
            // Menu_Detalhes
            // 
            this.Menu_Detalhes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Sobre});
            this.Menu_Detalhes.Name = "Menu_Detalhes";
            this.Menu_Detalhes.Size = new System.Drawing.Size(64, 19);
            this.Menu_Detalhes.Text = "Detalhes";
            // 
            // Menu_Sobre
            // 
            this.Menu_Sobre.Name = "Menu_Sobre";
            this.Menu_Sobre.Size = new System.Drawing.Size(180, 22);
            this.Menu_Sobre.Text = "Sobre";
            this.Menu_Sobre.Click += new System.EventHandler(this.Menu_Sobre_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_Altura);
            this.groupBox1.Controls.Add(this.Txt_Nome);
            this.groupBox1.Location = new System.Drawing.Point(16, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(410, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "(cm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Altura: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // Txt_Altura
            // 
            this.Txt_Altura.Location = new System.Drawing.Point(111, 58);
            this.Txt_Altura.Name = "Txt_Altura";
            this.Txt_Altura.Size = new System.Drawing.Size(219, 22);
            this.Txt_Altura.TabIndex = 1;
            this.Txt_Altura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyVerif);
            this.Txt_Altura.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Altura_Validating);
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(111, 30);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(219, 22);
            this.Txt_Nome.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lbl_Aviso);
            this.groupBox2.Location = new System.Drawing.Point(16, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 46);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // Lbl_Aviso
            // 
            this.Lbl_Aviso.AutoSize = true;
            this.Lbl_Aviso.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Aviso.Location = new System.Drawing.Point(122, 18);
            this.Lbl_Aviso.Name = "Lbl_Aviso";
            this.Lbl_Aviso.Size = new System.Drawing.Size(164, 16);
            this.Lbl_Aviso.TabIndex = 0;
            this.Lbl_Aviso.Text = "Limite de 50 informações";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Lbx_Inseridos);
            this.groupBox3.Location = new System.Drawing.Point(16, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 356);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inseridos";
            // 
            // Lbx_Inseridos
            // 
            this.Lbx_Inseridos.FormattingEnabled = true;
            this.Lbx_Inseridos.ItemHeight = 16;
            this.Lbx_Inseridos.Location = new System.Drawing.Point(7, 22);
            this.Lbx_Inseridos.Name = "Lbx_Inseridos";
            this.Lbx_Inseridos.Size = new System.Drawing.Size(189, 324);
            this.Lbx_Inseridos.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Lbx_Ordenados);
            this.groupBox4.Location = new System.Drawing.Point(224, 186);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 356);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ordenados";
            // 
            // Lbx_Ordenados
            // 
            this.Lbx_Ordenados.FormattingEnabled = true;
            this.Lbx_Ordenados.ItemHeight = 16;
            this.Lbx_Ordenados.Location = new System.Drawing.Point(6, 22);
            this.Lbx_Ordenados.Name = "Lbx_Ordenados";
            this.Lbx_Ordenados.Size = new System.Drawing.Size(189, 324);
            this.Lbx_Ordenados.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP06_192149.Properties.Resources.altura;
            this.pictureBox1.Location = new System.Drawing.Point(484, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 382);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Lbl_Media);
            this.groupBox5.Location = new System.Drawing.Point(460, 459);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(408, 73);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Média:";
            // 
            // Lbl_Media
            // 
            this.Lbl_Media.AutoSize = true;
            this.Lbl_Media.Location = new System.Drawing.Point(76, 33);
            this.Lbl_Media.Name = "Lbl_Media";
            this.Lbl_Media.Size = new System.Drawing.Size(149, 16);
            this.Lbl_Media.TabIndex = 0;
            this.Lbl_Media.Text = "A média das alturas é: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 554);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Lista de Alturas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Detalhes;
        private System.Windows.Forms.ToolStripMenuItem Menu_Sobre;
        private System.Windows.Forms.ToolStripMenuItem Menu_Estatistica;
        private System.Windows.Forms.ToolStripMenuItem Menu_Rol;
        private System.Windows.Forms.ToolStripMenuItem Menu_media;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Altura;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Lbl_Aviso;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox Lbx_Inseridos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox Lbx_Ordenados;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label Lbl_Media;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem Menu_Limpar;
    }
}

