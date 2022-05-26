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
    public partial class CriarLogin : Form
    {
        MySqlConnection conexao;

        public string dados;
        public string comando;
        public long CPF;

        public CriarLogin()
        {
            InitializeComponent();

            //conexão com o banco de dados
            conexao = new MySqlConnection("server=localhost;DataBase=NotaConsumidor;Uid=root;password=;");
            try
            {
                conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Algo deu errado!\n\n" + e);
                conexao.Close();
            }//fim da conexão
        }//fim do construtor

        private void CadastroLogin()
        {
            try
            {
                dados = "('" + CPF + "','" + txtbNome.Text + "','" + txtbSenha.Text + "')";

                comando = "INSERT INTO login(CPF, nome, senha) values" + dados;

                MySqlCommand sql = new MySqlCommand(comando, conexao);
                comando = "" + sql.ExecuteNonQuery();
                MessageBox.Show("Cadastro de usuário realizado!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Algo deu errado" + e);
            }//fim do try catch
        }//fim do método cadastroLogin

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            if (txtbSenha.Text == "" || txtbSenha2.Text == "" || txtbNome.Text == "" || mtbCPF.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                this.mtbCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;//Exclui a máscara antes de enviar ao banco
                if (Convert.ToInt64(mtbCPF.Text) < 10000000000)
                {
                    MessageBox.Show("Preencha o campo CPF com todos os digitos!");
                }
                else
                {
                    if (txtbSenha.Text == txtbSenha2.Text)
                    {
                        CPF = Convert.ToInt64(this.mtbCPF.Text);
                        verificarCPF();
                    }
                    else
                    {
                        MessageBox.Show("As senhas não são iguais!");
                    }
                }//fim da validação de campo CPF incompleto

                txtbNome.Text = "";
                mtbCPF.Text = "";
                txtbSenha.Text = "";
                txtbSenha2.Text = "";

            }//fim da validação de campo vazio         
        }//fim do botão cadastrar usuario

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mostrar = new Form1();
            mostrar.Show();
        }//fim do botão login

        //NOVA ENTRADA
        private void verificarCPF()
        {
            try
            {
                string query = "select * from login where(CPF = " + CPF + ")";

                MySqlCommand comando = new MySqlCommand(query, conexao);

                MySqlDataReader ler = comando.ExecuteReader();

                if (ler.HasRows)
                {
                    MessageBox.Show("O CPF já está cadastrado no sistema!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    CadastroLogin();
                }
            }//fim do try
            catch (Exception e)
            {
                MessageBox.Show("Algo deu errado!" + e);
            }//fim do catch
        }//fim do verificarCPF
        private void CriarLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }//fim do método para encerrar o programa

        private void textBoxCriarUsuario_TextChanged(object sender, EventArgs e)
        {

        }  
        private void textBoxCriarSenha_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxSenha2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SenhaIncorreta_Click(object sender, EventArgs e)
        {

        }

        private void CPFinco_Click(object sender, EventArgs e)
        {

        }

        private void txtbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        //NOVA ENTRADA impede o usuário de coloca números no campo nome
        private void txtbNome_KeyPress(object sender, KeyPressEventArgs num)
        {
            if (char.IsDigit(num.KeyChar))
            {
                num.Handled = true;
            }
        }//fim do evento KeyPress para o textbox nome
    }//fim da classe
}//fim do projeto
