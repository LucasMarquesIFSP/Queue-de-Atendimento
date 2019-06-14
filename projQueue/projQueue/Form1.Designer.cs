namespace projQueue
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
            this.list_senha = new System.Windows.Forms.ListBox();
            this.list_chamadas = new System.Windows.Forms.ListBox();
            this.btn_gerar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_listSenha = new System.Windows.Forms.Button();
            this.btn_chamar = new System.Windows.Forms.Button();
            this.btn_listAtend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_guiche = new System.Windows.Forms.Label();
            this.cb_guiche = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // list_senha
            // 
            this.list_senha.FormattingEnabled = true;
            this.list_senha.Location = new System.Drawing.Point(12, 36);
            this.list_senha.Name = "list_senha";
            this.list_senha.Size = new System.Drawing.Size(184, 134);
            this.list_senha.TabIndex = 0;
            // 
            // list_chamadas
            // 
            this.list_chamadas.FormattingEnabled = true;
            this.list_chamadas.Location = new System.Drawing.Point(347, 36);
            this.list_chamadas.Name = "list_chamadas";
            this.list_chamadas.Size = new System.Drawing.Size(333, 147);
            this.list_chamadas.TabIndex = 1;
            // 
            // btn_gerar
            // 
            this.btn_gerar.Location = new System.Drawing.Point(55, 9);
            this.btn_gerar.Name = "btn_gerar";
            this.btn_gerar.Size = new System.Drawing.Size(83, 21);
            this.btn_gerar.TabIndex = 2;
            this.btn_gerar.Text = "Gerar";
            this.btn_gerar.UseVisualStyleBackColor = true;
            this.btn_gerar.Click += new System.EventHandler(this.btn_gerar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 21);
            this.button2.TabIndex = 3;
            this.button2.Text = "Adicionar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_listSenha
            // 
            this.btn_listSenha.Location = new System.Drawing.Point(32, 176);
            this.btn_listSenha.Name = "btn_listSenha";
            this.btn_listSenha.Size = new System.Drawing.Size(141, 21);
            this.btn_listSenha.TabIndex = 4;
            this.btn_listSenha.Text = "Listar Senhas";
            this.btn_listSenha.UseVisualStyleBackColor = true;
            this.btn_listSenha.Click += new System.EventHandler(this.btn_listSenha_Click);
            // 
            // btn_chamar
            // 
            this.btn_chamar.Location = new System.Drawing.Point(545, 10);
            this.btn_chamar.Name = "btn_chamar";
            this.btn_chamar.Size = new System.Drawing.Size(83, 21);
            this.btn_chamar.TabIndex = 5;
            this.btn_chamar.Text = "Chamar";
            this.btn_chamar.UseVisualStyleBackColor = true;
            this.btn_chamar.Click += new System.EventHandler(this.btn_chamar_Click);
            // 
            // btn_listAtend
            // 
            this.btn_listAtend.Location = new System.Drawing.Point(428, 189);
            this.btn_listAtend.Name = "btn_listAtend";
            this.btn_listAtend.Size = new System.Drawing.Size(200, 21);
            this.btn_listAtend.TabIndex = 6;
            this.btn_listAtend.Text = "Listar Atendimentos";
            this.btn_listAtend.UseVisualStyleBackColor = true;
            this.btn_listAtend.Click += new System.EventHandler(this.btn_listAtend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Guichê: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Guichês Disponiveis";
            // 
            // lbl_guiche
            // 
            this.lbl_guiche.AutoSize = true;
            this.lbl_guiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guiche.Location = new System.Drawing.Point(250, 82);
            this.lbl_guiche.Name = "lbl_guiche";
            this.lbl_guiche.Size = new System.Drawing.Size(0, 39);
            this.lbl_guiche.TabIndex = 10;
            this.lbl_guiche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_guiche
            // 
            this.cb_guiche.FormattingEnabled = true;
            this.cb_guiche.Location = new System.Drawing.Point(418, 11);
            this.cb_guiche.Name = "cb_guiche";
            this.cb_guiche.Size = new System.Drawing.Size(121, 21);
            this.cb_guiche.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 222);
            this.Controls.Add(this.cb_guiche);
            this.Controls.Add(this.lbl_guiche);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_listAtend);
            this.Controls.Add(this.btn_chamar);
            this.Controls.Add(this.btn_listSenha);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_gerar);
            this.Controls.Add(this.list_chamadas);
            this.Controls.Add(this.list_senha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_senha;
        private System.Windows.Forms.ListBox list_chamadas;
        private System.Windows.Forms.Button btn_gerar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_listSenha;
        private System.Windows.Forms.Button btn_chamar;
        private System.Windows.Forms.Button btn_listAtend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_guiche;
        private System.Windows.Forms.ComboBox cb_guiche;
    }
}

