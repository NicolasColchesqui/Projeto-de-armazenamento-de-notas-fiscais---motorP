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
            this.Visible = false;
            Cadastrar mostrar = new Cadastrar();
            mostrar.Show();
        }//fim do botão cadastrar

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Consultar mostrar = new Consultar();
            mostrar.Show();
        }//fim do botão consultar
    }//fim da classe
}//fim do projeto
