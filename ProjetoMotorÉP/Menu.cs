using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMotorÉP
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar mostrar = new Cadastrar();
            mostrar.Show();
        }//fim do botão cadastrar

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultar mostrar = new Consultar();
            mostrar.Show();
        }//fim do botão consultar

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }//fim da classe
}//fim do projeto
