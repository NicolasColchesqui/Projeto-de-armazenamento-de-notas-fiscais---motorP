
namespace ProjetoMotorÉP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Acessar = new System.Windows.Forms.Button();
            this.Criar = new System.Windows.Forms.Button();
            this.Esquecer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(83, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 366);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.DimGray;
            this.Label1.Font = new System.Drawing.Font("Romantic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Label1.Location = new System.Drawing.Point(177, 51);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(145, 58);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Romantic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(112, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.Color.Silver;
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsuario.Location = new System.Drawing.Point(116, 153);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(279, 20);
            this.textBoxUsuario.TabIndex = 3;
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("Romantic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.Location = new System.Drawing.Point(112, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.BackColor = System.Drawing.Color.Silver;
            this.textBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSenha.Font = new System.Drawing.Font("MS Outlook", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBoxSenha.Location = new System.Drawing.Point(116, 203);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(279, 19);
            this.textBoxSenha.TabIndex = 5;
            this.textBoxSenha.TextChanged += new System.EventHandler(this.textBoxSenha_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(104, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "---------------------------------------------------------------------------------" +
    "-----------------";
            // 
            // Acessar
            // 
            this.Acessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Acessar.Font = new System.Drawing.Font("Romantic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Acessar.Location = new System.Drawing.Point(107, 260);
            this.Acessar.Name = "Acessar";
            this.Acessar.Size = new System.Drawing.Size(292, 34);
            this.Acessar.TabIndex = 7;
            this.Acessar.Text = "Acessar";
            this.Acessar.UseVisualStyleBackColor = true;
            this.Acessar.Click += new System.EventHandler(this.Acessar_Click);
            // 
            // Criar
            // 
            this.Criar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Criar.Font = new System.Drawing.Font("Romantic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Criar.Location = new System.Drawing.Point(107, 300);
            this.Criar.Name = "Criar";
            this.Criar.Size = new System.Drawing.Size(292, 34);
            this.Criar.TabIndex = 8;
            this.Criar.Text = "criar login";
            this.Criar.UseVisualStyleBackColor = true;
            this.Criar.Click += new System.EventHandler(this.Criar_Click);
            // 
            // Esquecer
            // 
            this.Esquecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Esquecer.Font = new System.Drawing.Font("Romantic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Esquecer.Location = new System.Drawing.Point(107, 340);
            this.Esquecer.Name = "Esquecer";
            this.Esquecer.Size = new System.Drawing.Size(292, 34);
            this.Esquecer.TabIndex = 9;
            this.Esquecer.Text = "esqueceu a senha?";
            this.Esquecer.UseVisualStyleBackColor = true;
            this.Esquecer.Click += new System.EventHandler(this.Esquecer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoMotorÉP.Properties.Resources.o_valle_del_bove_vale_grande_da_lava_do_deserto_no_flanco_oriental_do_vulcão_etna_66742224;
            this.ClientSize = new System.Drawing.Size(513, 444);
            this.Controls.Add(this.Esquecer);
            this.Controls.Add(this.Criar);
            this.Controls.Add(this.Acessar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Login Vale";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Acessar;
        private System.Windows.Forms.Button Criar;
        private System.Windows.Forms.Button Esquecer;
    }
}

