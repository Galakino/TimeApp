namespace TimeBd
{
    partial class Historico
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
            this.btnGravar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txbPartidasVencidas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPartiCompet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTituloConquistado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbArtilheiro = new System.Windows.Forms.TextBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(283, 301);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(170, 44);
            this.btnGravar.TabIndex = 47;
            this.btnGravar.Text = "Gravar dados";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(432, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Artilheiros históricos";
            // 
            // txbPartidasVencidas
            // 
            this.txbPartidasVencidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPartidasVencidas.Location = new System.Drawing.Point(436, 180);
            this.txbPartidasVencidas.Name = "txbPartidasVencidas";
            this.txbPartidasVencidas.Size = new System.Drawing.Size(139, 27);
            this.txbPartidasVencidas.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(432, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 22);
            this.label5.TabIndex = 42;
            this.label5.Text = "Partidas vencidas";
            // 
            // txbPartiCompet
            // 
            this.txbPartiCompet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPartiCompet.Location = new System.Drawing.Point(163, 251);
            this.txbPartiCompet.Name = "txbPartiCompet";
            this.txbPartiCompet.Size = new System.Drawing.Size(139, 27);
            this.txbPartiCompet.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Participações em competições";
            // 
            // txbTituloConquistado
            // 
            this.txbTituloConquistado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTituloConquistado.Location = new System.Drawing.Point(163, 180);
            this.txbTituloConquistado.Name = "txbTituloConquistado";
            this.txbTituloConquistado.Size = new System.Drawing.Size(139, 27);
            this.txbTituloConquistado.TabIndex = 34;
            this.txbTituloConquistado.TextChanged += new System.EventHandler(this.txbTituloConquistado_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Títulos conquistados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 36);
            this.label1.TabIndex = 28;
            this.label1.Text = "Sistema de armazenamento de dados";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(305, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 32);
            this.label9.TabIndex = 48;
            this.label9.Text = "Histórico";
            // 
            // txbArtilheiro
            // 
            this.txbArtilheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbArtilheiro.Location = new System.Drawing.Point(434, 251);
            this.txbArtilheiro.Name = "txbArtilheiro";
            this.txbArtilheiro.Size = new System.Drawing.Size(141, 27);
            this.txbArtilheiro.TabIndex = 49;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Location = new System.Drawing.Point(257, 370);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(45, 16);
            this.lblErro.TabIndex = 50;
            this.lblErro.Text = "<erro>";
            // 
            // Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(745, 424);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.txbArtilheiro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbPartidasVencidas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbPartiCompet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbTituloConquistado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Historico";
            this.Text = "Historico";
            this.Load += new System.EventHandler(this.Historico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbPartidasVencidas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPartiCompet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTituloConquistado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbArtilheiro;
        private System.Windows.Forms.Label lblErro;
    }
}