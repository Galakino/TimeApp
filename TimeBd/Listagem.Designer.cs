namespace TimeBd
{
    partial class Listagem
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage02 = new System.Windows.Forms.TabPage();
            this.btnListar1 = new System.Windows.Forms.Button();
            this.lbllink = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblJogador = new System.Windows.Forms.Label();
            this.cbxJogador = new System.Windows.Forms.ComboBox();
            this.cbxGeral = new System.Windows.Forms.ComboBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage02.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage02);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(715, 339);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage02
            // 
            this.tabPage02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage02.Controls.Add(this.btnListar1);
            this.tabPage02.Controls.Add(this.lbllink);
            this.tabPage02.Controls.Add(this.linkLabel1);
            this.tabPage02.Controls.Add(this.lblJogador);
            this.tabPage02.Controls.Add(this.cbxJogador);
            this.tabPage02.Controls.Add(this.cbxGeral);
            this.tabPage02.Controls.Add(this.lblErro);
            this.tabPage02.Controls.Add(this.lstLista);
            this.tabPage02.Controls.Add(this.label2);
            this.tabPage02.Controls.Add(this.btnListar);
            this.tabPage02.ForeColor = System.Drawing.Color.Black;
            this.tabPage02.Location = new System.Drawing.Point(4, 25);
            this.tabPage02.Name = "tabPage02";
            this.tabPage02.Size = new System.Drawing.Size(707, 310);
            this.tabPage02.TabIndex = 2;
            this.tabPage02.Text = "Listagem geral";
            this.tabPage02.Click += new System.EventHandler(this.tabPage02_Click);
            // 
            // btnListar1
            // 
            this.btnListar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnListar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar1.Location = new System.Drawing.Point(480, 41);
            this.btnListar1.Name = "btnListar1";
            this.btnListar1.Size = new System.Drawing.Size(75, 28);
            this.btnListar1.TabIndex = 10;
            this.btnListar1.Text = "Listar";
            this.btnListar1.UseVisualStyleBackColor = false;
            this.btnListar1.Click += new System.EventHandler(this.btnListar1_Click);
            // 
            // lbllink
            // 
            this.lbllink.AutoSize = true;
            this.lbllink.Location = new System.Drawing.Point(184, 277);
            this.lbllink.Name = "lbllink";
            this.lbllink.Size = new System.Drawing.Size(71, 16);
            this.lbllink.TabIndex = 9;
            this.lbllink.Text = "Site oficial:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(272, 277);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 16);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblJogador
            // 
            this.lblJogador.AutoSize = true;
            this.lblJogador.Location = new System.Drawing.Point(84, 74);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(198, 16);
            this.lblJogador.TabIndex = 7;
            this.lblJogador.Text = "Escolha o jogador que quer ver:";
            // 
            // cbxJogador
            // 
            this.cbxJogador.FormattingEnabled = true;
            this.cbxJogador.Location = new System.Drawing.Point(305, 71);
            this.cbxJogador.Name = "cbxJogador";
            this.cbxJogador.Size = new System.Drawing.Size(142, 24);
            this.cbxJogador.TabIndex = 6;
            this.cbxJogador.SelectedIndexChanged += new System.EventHandler(this.cbxJogador_SelectedIndexChanged);
            // 
            // cbxGeral
            // 
            this.cbxGeral.FormattingEnabled = true;
            this.cbxGeral.Items.AddRange(new object[] {
            "Dados Gerais",
            "Histórico",
            "Informação contato",
            "Informação Finanças",
            "Jogadores"});
            this.cbxGeral.Location = new System.Drawing.Point(305, 41);
            this.cbxGeral.Name = "cbxGeral";
            this.cbxGeral.Size = new System.Drawing.Size(142, 24);
            this.cbxGeral.TabIndex = 5;
            this.cbxGeral.SelectedIndexChanged += new System.EventHandler(this.cbxGeral_SelectedIndexChanged);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Location = new System.Drawing.Point(8, 13);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(44, 16);
            this.lblErro.TabIndex = 4;
            this.lblErro.Text = "label3";
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 16;
            this.lstLista.Location = new System.Drawing.Point(140, 117);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(415, 148);
            this.lstLista.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar por:";
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(480, 41);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 28);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Listagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 340);
            this.Controls.Add(this.tabControl1);
            this.Name = "Listagem";
            this.Text = "Listagem";
            this.Load += new System.EventHandler(this.Listagem_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage02.ResumeLayout(false);
            this.tabPage02.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage02;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.ComboBox cbxGeral;
        private System.Windows.Forms.Label lblJogador;
        private System.Windows.Forms.ComboBox cbxJogador;
        private System.Windows.Forms.Label lbllink;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnListar1;
    }
}