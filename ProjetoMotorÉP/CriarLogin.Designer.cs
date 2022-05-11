
namespace ProjetoMotorÉP
{
    partial class CriarLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarLogin));
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbSenha2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbSenha = new System.Windows.Forms.TextBox();
            this.SenhaIncorretaMessage = new System.Windows.Forms.Label();
            this.CPFinco = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.NomeIncorreto = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label1.Font = new System.Drawing.Font("Romantic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Label1.Location = new System.Drawing.Point(84, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(252, 58);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Criar login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Font = new System.Drawing.Font("Romantic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(47, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Font = new System.Drawing.Font("Romantic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.Location = new System.Drawing.Point(47, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(28, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 482);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtbSenha2
            // 
            this.txtbSenha2.BackColor = System.Drawing.Color.Silver;
            this.txtbSenha2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbSenha2.Font = new System.Drawing.Font("MS Outlook", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtbSenha2.Location = new System.Drawing.Point(51, 373);
            this.txtbSenha2.Name = "txtbSenha2";
            this.txtbSenha2.Size = new System.Drawing.Size(323, 19);
            this.txtbSenha2.TabIndex = 6;
            this.txtbSenha2.TextChanged += new System.EventHandler(this.textBoxSenha2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Font = new System.Drawing.Font("Romantic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.Location = new System.Drawing.Point(47, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Digite novamente a senha";
            // 
            // txtbSenha
            // 
            this.txtbSenha.BackColor = System.Drawing.Color.Silver;
            this.txtbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbSenha.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtbSenha.Location = new System.Drawing.Point(51, 308);
            this.txtbSenha.MaxLength = 8;
            this.txtbSenha.Name = "txtbSenha";
            this.txtbSenha.Size = new System.Drawing.Size(323, 20);
            this.txtbSenha.TabIndex = 8;
            this.txtbSenha.TextChanged += new System.EventHandler(this.textBoxCriarSenha_TextChanged);
            // 
            // SenhaIncorretaMessage
            // 
            this.SenhaIncorretaMessage.AutoSize = true;
            this.SenhaIncorretaMessage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SenhaIncorretaMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.SenhaIncorretaMessage.Location = new System.Drawing.Point(48, 395);
            this.SenhaIncorretaMessage.Name = "SenhaIncorretaMessage";
            this.SenhaIncorretaMessage.Size = new System.Drawing.Size(171, 13);
            this.SenhaIncorretaMessage.TabIndex = 10;
            this.SenhaIncorretaMessage.Text = "Senha incorreta, Digite novamente";
            this.SenhaIncorretaMessage.Visible = false;
            this.SenhaIncorretaMessage.Click += new System.EventHandler(this.SenhaIncorreta_Click);
            // 
            // CPFinco
            // 
            this.CPFinco.AutoSize = true;
            this.CPFinco.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CPFinco.ForeColor = System.Drawing.Color.DarkRed;
            this.CPFinco.Location = new System.Drawing.Point(48, 259);
            this.CPFinco.Name = "CPFinco";
            this.CPFinco.Size = new System.Drawing.Size(139, 13);
            this.CPFinco.TabIndex = 11;
            this.CPFinco.Text = "CPF ja utilizado, Digite outro";
            this.CPFinco.Visible = false;
            this.CPFinco.Click += new System.EventHandler(this.CPFinco_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Font = new System.Drawing.Font("Romantic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label5.Location = new System.Drawing.Point(47, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nome Completo";
            // 
            // txtbNome
            // 
            this.txtbNome.BackColor = System.Drawing.Color.Silver;
            this.txtbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbNome.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtbNome.Location = new System.Drawing.Point(51, 160);
            this.txtbNome.MaxLength = 45;
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(323, 20);
            this.txtbNome.TabIndex = 13;
            this.txtbNome.TextChanged += new System.EventHandler(this.txtbNome_TextChanged);
            // 
            // NomeIncorreto
            // 
            this.NomeIncorreto.AutoSize = true;
            this.NomeIncorreto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NomeIncorreto.ForeColor = System.Drawing.Color.DarkRed;
            this.NomeIncorreto.Location = new System.Drawing.Point(48, 183);
            this.NomeIncorreto.Name = "NomeIncorreto";
            this.NomeIncorreto.Size = new System.Drawing.Size(147, 13);
            this.NomeIncorreto.TabIndex = 14;
            this.NomeIncorreto.Text = "Nome ja utilizado, Digite outro";
            this.NomeIncorreto.Visible = false;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(51, 237);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(323, 20);
            this.mtbCPF.TabIndex = 15;
            this.mtbCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCPF_MaskInputRejected);
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(53, 435);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(166, 20);
            this.btnCadastrarUsuario.TabIndex = 16;
            this.btnCadastrarUsuario.Text = "Cadastrar Usuario";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(212, 476);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 23);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "Tela de login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // CriarLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(414, 542);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.NomeIncorreto);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CPFinco);
            this.Controls.Add(this.SenhaIncorretaMessage);
            this.Controls.Add(this.txtbSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbSenha2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CriarLogin";
            this.Text = "CriarLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbSenha2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbSenha;
        private System.Windows.Forms.Label SenhaIncorretaMessage;
        private System.Windows.Forms.Label CPFinco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.Label NomeIncorreto;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.Button btnLogin;
    }
}