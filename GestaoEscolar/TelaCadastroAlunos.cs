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
    public partial class TelaCadastroAlunos : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source=DESKTOP-QP6F04T; initial catalog= GESTAO_ESCOLAR; Integrated Security= True");

        int COD_CLIENTE;

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            string NOME_ALUNO, ENDERECO_ALUNO, TELEFONE_ALUNO, EMAIL_ALUNO;

            NOME_ALUNO = txtNomeAluno.Text;
            ENDERECO_ALUNO = txtEnderecoAluno.Text;
            TELEFONE_ALUNO = txtTelefoneAluno.Text;
            EMAIL_ALUNO = txtEmailAluno.Text;

            try
            {
                conectar.Open();
                SqlCommand cadastrar = new SqlCommand();

                if (COD_CLIENTE == 0)
                {
                    cadastrar.CommandText = "INSERT INTO ALUNO (nome_aluno, endereco_aluno, telefone_aluno, email_aluno) VALUES ('" + NOME_ALUNO + "', '" + ENDERECO_ALUNO + "', '" + TELEFONE_ALUNO + "', '" + EMAIL_ALUNO + "')";
                }
                else
                {
                    cadastrar.CommandText = "UPDATE ALUNO SET nome_aluno= '" + txtNomeAluno.Text + " 'endereco_aluno+ ' " + txtEnderecoAluno.Text + "', telefone_aluno+ '" + txtTelefoneAluno.Text + "', email_aluno= '" + txtEmailAluno.Text + "' WHERE COD_CLIENTE= " + COD_CLIENTE;

                    COD_CLIENTE = 0;
                }

                //local onde sera guardado os dados
                cadastrar.Connection = conectar;

                //executar query
                cadastrar.ExecuteNonQuery();

                //fechar conexao 
                conectar.Close();

                MessageBox.Show("Cadastro efetuado com sucesso!");

                txtNomeAluno.Clear();
                txtEnderecoAluno.Clear();
                txtTelefoneAluno.Clear();
                txtEmailAluno.Clear();

                txtNomeAluno.Focus();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("NÃO FOI POSSÍVEL CONECTAR COM O BANCO DE DADOS!!!!" + Convert.ToString(ex));
            }
        }
        public TelaCadastroAlunos()
        {
            InitializeComponent();
        }

        public TelaCadastroAlunos(Alunos alunos)
        {
            this.Text = "Cadastro Alunos";
            COD_CLIENTE = alunos.cod_cliente;
            txtNomeAluno.Text = alunos.nome;
            txtEnderecoAluno.Text = alunos.endereco;
            txtTelefoneAluno.Text = alunos.telefone;
            txtEmailAluno.Text = alunos.email;
            
        }

        private void picBoxVoltarAlunos_Click(object sender, EventArgs e)
        {
            TelaAlunos telaAlunos = new TelaAlunos();
            this.Hide();
            telaAlunos.ShowDialog();
            this.Close();
        }

        private void btnLimparCadAluno_Click(object sender, EventArgs e)
        {
            txtNomeAluno.Clear();
            txtEnderecoAluno.Clear();
            txtTelefoneAluno.Clear();
            txtEmailAluno.Clear();

            txtNomeAluno.Focus();
        }
    }
}
