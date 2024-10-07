using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoEscolar
{
    public partial class TelaLogin : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source=LAB3-7; initial catalog= GESTAO_ESCOLAR; Integrated Security= True");
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conectar.Open();
                SqlCommand verificar = new SqlCommand("SELECT * FROM USUARIO WHERE nome_usuario = '" + txtUsuario.Text + "' AND senha_usuario = '" + txtSenha.Text + "'", conectar);
                bool resultado = verificar.ExecuteReader().HasRows;

                if (resultado == true)
                {
                    TelaMenu Menu = new TelaMenu();
                    this.Hide();
                    Menu.ShowDialog();
                    this.Close(); //esconde a tela anterior 

                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!");
                    conectar.Close();
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível estabelecer a conexão. Verifique o código!");
            }
        }
    }
}
