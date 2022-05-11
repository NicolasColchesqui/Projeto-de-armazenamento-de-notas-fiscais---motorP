
namespace ProjetoMotorÉP
{
    partial class Consultar
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
            this.lblConsultar = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.txtbCNPJ = new System.Windows.Forms.TextBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lsvConsultaDados = new System.Windows.Forms.ListView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtbTotal = new System.Windows.Forms.TextBox();
            this.txtbDeletar = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.pictureNota = new System.Windows.Forms.PictureBox();
            this.lblVerFoto = new System.Windows.Forms.Label();
            this.txtbVerFoto = new System.Windows.Forms.TextBox();
            this.btnVerNota = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNota)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Location = new System.Drawing.Point(477, 42);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(51, 13);
            this.lblConsultar.TabIndex = 0;
            this.lblConsultar.Text = "Consultar";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Location = new System.Drawing.Point(477, 110);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(34, 13);
            this.lblCNPJ.TabIndex = 1;
            this.lblCNPJ.Text = "CNPJ";
            // 
            // txtbCNPJ
            // 
            this.txtbCNPJ.Location = new System.Drawing.Point(517, 107);
            this.txtbCNPJ.MaxLength = 14;
            this.txtbCNPJ.Name = "txtbCNPJ";
            this.txtbCNPJ.Size = new System.Drawing.Size(119, 20);
            this.txtbCNPJ.TabIndex = 2;
            this.txtbCNPJ.TextChanged += new System.EventHandler(this.txtbCNPJ_TextChanged);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(660, 109);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(27, 13);
            this.lblMes.TabIndex = 3;
            this.lblMes.Text = "Mês";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(848, 109);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(49, 13);
            this.lblSituacao.TabIndex = 5;
            this.lblSituacao.Text = "Situação";
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Items.AddRange(new object[] {
            "Pendente",
            "Pago"});
            this.cmbSituacao.Location = new System.Drawing.Point(903, 106);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(121, 21);
            this.cmbSituacao.TabIndex = 6;
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbMes.Location = new System.Drawing.Point(693, 106);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(36, 21);
            this.cmbMes.TabIndex = 7;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(540, 157);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(189, 56);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lsvConsultaDados
            // 
            this.lsvConsultaDados.HideSelection = false;
            this.lsvConsultaDados.Location = new System.Drawing.Point(480, 238);
            this.lsvConsultaDados.Name = "lsvConsultaDados";
            this.lsvConsultaDados.Size = new System.Drawing.Size(564, 109);
            this.lsvConsultaDados.TabIndex = 9;
            this.lsvConsultaDados.UseCompatibleStateImageBehavior = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(480, 525);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(651, 416);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(228, 53);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "Atualizar essa consulta";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtbTotal
            // 
            this.txtbTotal.Enabled = false;
            this.txtbTotal.Location = new System.Drawing.Point(944, 184);
            this.txtbTotal.Name = "txtbTotal";
            this.txtbTotal.Size = new System.Drawing.Size(100, 20);
            this.txtbTotal.TabIndex = 12;
            this.txtbTotal.TextChanged += new System.EventHandler(this.txtbTotal_TextChanged);
            // 
            // txtbDeletar
            // 
            this.txtbDeletar.Location = new System.Drawing.Point(851, 527);
            this.txtbDeletar.Name = "txtbDeletar";
            this.txtbDeletar.Size = new System.Drawing.Size(100, 20);
            this.txtbDeletar.TabIndex = 13;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(636, 530);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(209, 13);
            this.lblCodigo.TabIndex = 14;
            this.lblCodigo.Text = "Insira o código da linha que deseja deletar:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(957, 524);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 15;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // pictureNota
            // 
            this.pictureNota.Location = new System.Drawing.Point(12, 12);
            this.pictureNota.Name = "pictureNota";
            this.pictureNota.Size = new System.Drawing.Size(459, 547);
            this.pictureNota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNota.TabIndex = 16;
            this.pictureNota.TabStop = false;
            // 
            // lblVerFoto
            // 
            this.lblVerFoto.AutoSize = true;
            this.lblVerFoto.Location = new System.Drawing.Point(570, 353);
            this.lblVerFoto.Name = "lblVerFoto";
            this.lblVerFoto.Size = new System.Drawing.Size(191, 13);
            this.lblVerFoto.TabIndex = 17;
            this.lblVerFoto.Text = "Insira o código da nota que deseja ver:";
            // 
            // txtbVerFoto
            // 
            this.txtbVerFoto.Location = new System.Drawing.Point(767, 353);
            this.txtbVerFoto.Name = "txtbVerFoto";
            this.txtbVerFoto.Size = new System.Drawing.Size(100, 20);
            this.txtbVerFoto.TabIndex = 18;
            // 
            // btnVerNota
            // 
            this.btnVerNota.Location = new System.Drawing.Point(873, 351);
            this.btnVerNota.Name = "btnVerNota";
            this.btnVerNota.Size = new System.Drawing.Size(83, 22);
            this.btnVerNota.TabIndex = 19;
            this.btnVerNota.Text = "Ver nota";
            this.btnVerNota.UseVisualStyleBackColor = true;
            this.btnVerNota.Click += new System.EventHandler(this.btnVerNota_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(851, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Valor Total Nota:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(598, 472);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(325, 13);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "Esse botão altera o status da consulta para pendente ou para pago";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(747, 110);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(26, 13);
            this.lblAno.TabIndex = 22;
            this.lblAno.Text = "Ano";
            // 
            // cmbAno
            // 
            this.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.cmbAno.Location = new System.Drawing.Point(779, 107);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(45, 21);
            this.cmbAno.TabIndex = 23;
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 571);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerNota);
            this.Controls.Add(this.txtbVerFoto);
            this.Controls.Add(this.lblVerFoto);
            this.Controls.Add(this.pictureNota);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtbDeletar);
            this.Controls.Add(this.txtbTotal);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lsvConsultaDados);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.cmbSituacao);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.txtbCNPJ);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblConsultar);
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.TextBox txtbCNPJ;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ListView lsvConsultaDados;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtbTotal;
        private System.Windows.Forms.TextBox txtbDeletar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.PictureBox pictureNota;
        private System.Windows.Forms.Label lblVerFoto;
        private System.Windows.Forms.TextBox txtbVerFoto;
        private System.Windows.Forms.Button btnVerNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.ComboBox cmbAno;
    }
}