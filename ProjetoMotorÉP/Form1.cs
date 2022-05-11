using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProjetoMotorÉP
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao;

        public long usuario;
        public string senha;
        public string nome;

        public string dados;
        public string comando;
        public long CPF;

        public Form1()
        {//criando construtor
            InitializeComponent();
        }//fim construtor

        private void verificarAcesso()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=notaConsumidor;Uid=root;Password=;");
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Algo deu errado!\n\n" + e);
                conexao.Close();
            }//fim da conexão

            try
            {
                string verficarUsuario = "SELECT * FROM login WHERE(CPF ='" + usuario + "') and (senha='" + senha + "')";
                MySqlCommand comando = new MySqlCommand(verficarUsuario, conexao);
                MySqlDataReader ler = comando.ExecuteReader();

                if (ler.HasRows)
                {
                    this.Visible = false;
                    Menu mostrar = new Menu();
                    mostrar.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!");
                }

                ler.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Algo deu errado! \n\n" + e);
            }//fim do try/catch
        }//fim do método de verificação

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Acessar_Click(object sender, EventArgs e)
        {
            if ((txtbUsuario.Text == "") || (txtbSenha.Text == ""))
            {
                MessageBox.Show("Preencha todos os campos para acessar o sistema!");
            }
            else
            {
                this.txtbUsuario.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                usuario = Convert.ToInt64(txtbUsuario.Text);
                senha = txtbSenha.Text;
                verificarAcesso();
            }//fim da validação        
        }//fim do botão acessar

        private void Criar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CriarLogin mostrar = new CriarLogin();
            mostrar.Show();
        }

        private void Esquecer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contate o suporte", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
