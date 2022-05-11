
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
            this.txtbSenha = new System.Windows.Forms.TextBox();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblCriarLogin = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblSenha2 = new System.Windows.Forms.Label();
            this.txtbSenha2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbSenha
            // 
            this.txtbSenha.BackColor = System.Drawing.Color.White;
            this.txtbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbSenha.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtbSenha.Location = new System.Drawing.Point(51, 304);
            this.txtbSenha.MaxLength = 8;
            this.txtbSenha.Name = "txtbSenha";
            this.txtbSenha.PasswordChar = '*';
            this.txtbSenha.Size = new System.Drawing.Size(323, 20);
            this.txtbSenha.TabIndex = 3;
            this.txtbSenha.TextChanged += new System.EventHandler(this.textBoxCriarSenha_TextChanged);
            // 
            // txtbNome
            // 
            this.txtbNome.BackColor = System.Drawing.Color.White;
            this.txtbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbNome.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtbNome.Location = new System.Drawing.Point(51, 190);
            this.txtbNome.MaxLength = 45;
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(323, 20);
            this.txtbNome.TabIndex = 1;
            this.txtbNome.TextChanged += new System.EventHandler(this.txtbNome_TextChanged);
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(51, 248);
            this.mtbCPF.Mask = "000.000.000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(323, 20);
            this.mtbCPF.TabIndex = 2;
            this.mtbCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCPF_MaskInputRejected);
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.BackColor = System.Drawing.Color.LightBlue;
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(129, 409);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(175, 36);
            this.btnCadastrarUsuario.TabIndex = 5;
            this.btnCadastrarUsuario.Text = "Cadastrar Usuario";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = false;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LightBlue;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogin.Location = new System.Drawing.Point(282, 526);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 23);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "Ir para login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblCriarLogin
            // 
            this.lblCriarLogin.AutoSize = true;
            this.lblCriarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriarLogin.ForeColor = System.Drawing.Color.White;
            this.lblCriarLogin.Location = new System.Drawing.Point(143, 112);
            this.lblCriarLogin.Name = "lblCriarLogin";
            this.lblCriarLogin.Size = new System.Drawing.Size(146, 31);
            this.lblCriarLogin.TabIndex = 18;
            this.lblCriarLogin.Text = "Criar Login";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(48, 169);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 18);
            this.lblNome.TabIndex = 19;
            this.lblNome.Text = "Nome";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.White;
            this.lblCPF.Location = new System.Drawing.Point(48, 227);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(38, 18);
            this.lblCPF.TabIndex = 20;
            this.lblCPF.Text = "CPF";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(48, 283);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(50, 18);
            this.lblSenha.TabIndex = 21;
            this.lblSenha.Text = "Senha";
            // 
            // lblSenha2
            // 
            this.lblSenha2.AutoSize = true;
            this.lblSenha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha2.ForeColor = System.Drawing.Color.White;
            this.lblSenha2.Location = new System.Drawing.Point(48, 335);
            this.lblSenha2.Name = "lblSenha2";
            this.lblSenha2.Size = new System.Drawing.Size(178, 18);
            this.lblSenha2.TabIndex = 22;
            this.lblSenha2.Text = "Digite a senha novamente";
            // 
            // txtbSenha2
            // 
            this.txtbSenha2.Location = new System.Drawing.Point(51, 356);
            this.txtbSenha2.MaxLength = 8;
            this.txtbSenha2.Name = "txtbSenha2";
            this.txtbSenha2.PasswordChar = '*';
            this.txtbSenha2.Size = new System.Drawing.Size(323, 20);
            this.txtbSenha2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjetoMotorÉP.Properties.Resources.icons8_usuário_de_gênero_neutro_48;
            this.pictureBox1.Location = new System.Drawing.Point(194, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // CriarLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbSenha2);
            this.Controls.Add(this.lblSenha2);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCriarLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.txtbSenha);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CriarLogin";
            this.Text = "CriarLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CriarLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbSenha;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblCriarLogin;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblSenha2;
        private System.Windows.Forms.TextBox txtbSenha2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}