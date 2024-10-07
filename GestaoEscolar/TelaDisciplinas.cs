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
    public partial class TelaDisciplinas : Form
    {
        // Declara as variáveis globais
        // Define a string de conexão
        string strConexao = ("Data Source=DESKTOP-QP6F04T;Initial Catalog=GESTAO_ESCOLAR;Integrated Security=true");

        public TelaDisciplinas()
        {
            InitializeComponent();
        }

        private void picBoxVoltar_Click(object sender, EventArgs e)
        {
            TelaMenu telaMenu = new TelaMenu();
            this.Hide();
            telaMenu.ShowDialog();
            this.Close();
        }

        private void guna2DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Manipular as colunas
            foreach (DataGridViewColumn coluna in dgvDisciplinas.Columns)
            {
                switch (coluna.Name)
                {
                    case "pk_id_disciplina": //ID da disciplina
                        // Oculta a coluna (esconder as colunas)
                        coluna.Visible = false;
                        break;
                    case "materia": //materia
                        coluna.Width = 50;
                        // Atera o título da coluna
                        coluna.HeaderText = "MATÉRIA";
                        break;
                    case "dia_da_semana": // dia da aula na semana
                        coluna.Width = 200;
                        // Atera o título da coluna
                        coluna.HeaderText = "DIA DE AULA";
                        break;    
                }
            }
        }

        private void TelaDisciplinas_Shown(object sender, EventArgs e)
        {
            // Cria um objeto para conextar com o BD
            SqlConnection con = new SqlConnection(strConexao);
            try
            {
                con.Open(); // Abre a conexão com banco de dados
                string sql = @"SELECT * FROM DISCIPLINA";
                // Define o comando SQL e a conexão do BD
                SqlCommand cmd = new SqlCommand(sql, con);
                // Executa a consulta
                SqlDataReader dados = cmd.ExecuteReader();
                if (dados.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dados); // Carrega os dados para o DataTable
                    dgvDisciplinas.DataSource = dt; // Preenche o DataGridView
                }
                else
                {
                    MessageBox.Show("Nenhuma disciplina encontrada!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro: " + erro.Message);
            }
            finally
            {
                con.Close(); // Fecha a conexão com o BD
            }
        }
    }
}
