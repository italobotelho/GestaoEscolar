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
    public partial class TelaAlunos : Form
    {
        
        // Declara as variáveis globais
        // Define a string de conexão
        string strConexao = ("Data Source=DESKTOP-QP6F04T;Initial Catalog=GESTAO_ESCOLAR;Integrated Security=true");

        // Variável de controle para inserir ou alterar
        int COD_ALUNO;

        public TelaAlunos()
        {
            InitializeComponent();
        }

        // Método que limpa os campos
        public void limpaCampos()
        {
            txtNomeAluno.Clear();
            txtEnderecoAluno.Clear();
            txtTelefoneAluno.Clear();
            txtEmailAluno.Clear();
        }

        private void buscaAlunos()
        {
            // Cria um objeto para conextar com o BD
            SqlConnection con = new SqlConnection(strConexao);
            try
            {
                con.Open(); // Abre a conexão com banco de dados
                string sql = @"SELECT * FROM ALUNO";
                // Define o comando SQL e a conexão do BD
                SqlCommand cmd = new SqlCommand(sql, con);
                // Executa a consulta
                SqlDataReader dados = cmd.ExecuteReader();
                if (dados.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dados); // Carrega os dados para o DataTable
                    dgvAlunos.DataSource = dt; // Preenche o DataGridView
                }
                else
                {
                    MessageBox.Show("Nenhum aluno encontrado!");
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

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            // Criar um objeto para conectar com o BD
            SqlConnection con = new SqlConnection(strConexao);

            string NOME_ALUNO, ENDERECO_ALUNO, TELEFONE_ALUNO, EMAIL_ALUNO;
            NOME_ALUNO = txtNomeAluno.Text;
            ENDERECO_ALUNO = txtEnderecoAluno.Text;
            TELEFONE_ALUNO = txtTelefoneAluno.Text;
            EMAIL_ALUNO = txtEmailAluno.Text;


            if ((NOME_ALUNO == "") || (ENDERECO_ALUNO == "") || (TELEFONE_ALUNO == "") || (EMAIL_ALUNO == ""))
            {
                txtNomeAluno.Focus();

                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                try
                {
                    // Abre a conexão com o BD
                    con.Open();
                    // Declara um objeto para executar um comando SQL
                    SqlCommand cmd;
                    string msg;
                    // Verifica se é um novo cadastro ou atualização
                    if (COD_ALUNO <= -1)
                    {
                        // Define o comando SQL (INSERT)
                        cmd = new SqlCommand(@"INSERT INTO ALUNO(nome_aluno, endereco_aluno, telefone_aluno, email_aluno) VALUES(@nome, @endereco, @telefone, @email);", con);
                        msg = "cadastrado";
                    }
                    else
                    {
                        // Define o comando SQL (UPDATE)
                        cmd = new SqlCommand(@"UPDATE ALUNO SET nome_aluno=@nome, endereco_aluno=@endereco, telefone_aluno=@telefone, email_aluno=@email WHERE pk_id_rm_aluno=@id;", con);
                        msg = "atualizado";
                    }
                    // Define os valores para os parâmetros
                    cmd.Parameters.AddWithValue("@nome", txtNomeAluno.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEnderecoAluno.Text.Trim());
                    cmd.Parameters.AddWithValue("@telefone", txtTelefoneAluno.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmailAluno.Text.Trim());

                    // Verifica se o comando é um UPDATE
                    if (COD_ALUNO > -1)
                    {
                        // Define o parâmetro @id
                        cmd.Parameters.AddWithValue("@id", COD_ALUNO);
                    }
                    // Executa o comando SQL
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Aluno " + msg + " com sucesso!");
                    // Chama o método "btnNovo_Click"
                    btnNovoAluno_Click(null, null);
                    // Atualiza o dataGridView
                    buscaAlunos();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
                finally
                {
                    // Fecha a conexão com o BD
                    con.Close();
                }
            }
                
        }

        private void btnNovoAluno_Click(object sender, EventArgs e)
        {
            // Define que será feita uma inserção
            COD_ALUNO = -1;
            // Chama a função limpaCampos
            limpaCampos();
            // Desativa o botão excluir
            btnExcluirAluno.Enabled = false;
            // Coloca o foco no textbox
            txtNomeAluno.Focus();
        }

        private void btnConsultarAluno_Click(object sender, EventArgs e)
        {
            // Cria um objeto para conectar com o BD
            SqlConnection con = new SqlConnection(strConexao);

            string PESQUISAR_ALUNO;

            PESQUISAR_ALUNO = txtPesquisarAluno.Text;

            if (PESQUISAR_ALUNO == "")
            {
                txtPesquisarAluno.Focus();

                MessageBox.Show("Preencha o campo para fazer uma consulta.");
            }
            else
            {
                try
                {
                    // Abre a conexão com o BD
                    con.Open();
                    // Definir o comando SQL (SELECT)
                    string sql = @"SELECT * FROM ALUNO WHERE pk_id_rm_aluno=" + txtPesquisarAluno.Text.Trim();
                    // Cria um objeto para executar o comando SQL
                    SqlCommand cmd = new SqlCommand(sql, con);
                    // Executar o comando SQL e armazenar em uma variável os dados retornados
                    SqlDataReader dados = cmd.ExecuteReader();
                    // Verifica se a consulta retornou registros
                    if (dados.HasRows == true)
                    {
                        // Cria uma tabela genérica e vazia
                        DataTable dt = new DataTable();
                        // Carrega os dados para a tabela genérica
                        dt.Load(dados);
                        // Atribui os valores retornados para os componentes
                        txtNomeAluno.Text = dt.Rows[0]["nome_aluno"].ToString();
                        txtEnderecoAluno.Text = dt.Rows[0]["endereco_aluno"].ToString();
                        txtTelefoneAluno.Text = dt.Rows[0]["telefone_aluno"].ToString();
                        txtEmailAluno.Text = dt.Rows[0]["email_aluno"].ToString();
                        // Exibe a aba "cadastro"
                        tabControl1.SelectedIndex = 0;
                        // Define o RM do aluno para uma possível Edição ou Exclusão
                        COD_ALUNO = int.Parse(txtPesquisarAluno.Text.Trim());
                        // Habilita o botão excluir
                        btnExcluirAluno.Enabled = true;
                    }
                    else
                    { // Se não existir nenhum aluno com o codigo digitado
                        MessageBox.Show("Nenhum aluno encontrado!");
                        txtPesquisarAluno.Focus();
                    }
                }
                catch (Exception erro)
                {
                    // Exibe a mensagem de erro
                    MessageBox.Show("Erro: " + erro.Message);
                }
                finally
                {
                    // Fecha a conexão com o BD
                    con.Close();
                }
            }
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            TelaMenu telaMenu = new TelaMenu();
            this.Hide();
            telaMenu.ShowDialog();
            this.Close();
        }

        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            // Verifica se o usuário clicou no botão sim
            DialogResult resultado = MessageBox.Show("Deseja realmente excluir?","Confirma exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Se o usuário tiver clicado em 'sim'
            if (resultado == DialogResult.Yes)
            {
                // Cria um objeto para conectar com o BD
                SqlConnection con = new SqlConnection(strConexao);
                try
                {
                    // Abre a conexão com o BD
                    con.Open();
                    // Declara um objeto para executar um comando SQL
                    SqlCommand cmd;
                    // Verifica se algum aluno foi selecionado
                    if (COD_ALUNO > -1)
                    {
                        // Define o comando SQL (DELETE)
                        cmd = new SqlCommand(@"DELETE FROM ALUNO WHERE pk_id_rm_aluno=@id;", con);
                        // Define o parâmetro @id
                        cmd.Parameters.AddWithValue("@id", COD_ALUNO);
                        // Executa o comando SQL
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Aluno excluído com sucesso!");
                        // Chama o método "btnNovo_Click"
                        btnNovoAluno_Click(null, null);
                        // Atualiza o dataGridView
                        buscaAlunos();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum aluno selecionado!");
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro: " + erro.Message);
                }
                finally
                {
                    // Fecha a conexão com o BD
                    con.Close();
                }
            }
        }

        private void TelaAlunos_Shown(object sender, EventArgs e)
        {
            // Chama o método que preenche o datagridview (dgvAlunos)
            buscaAlunos();
            // Chama o método btnNovo_click
            btnNovoAluno_Click(null, null);
        }

        private void dgvAlunos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Adiciona o tooltip nas imagens do datagridview
            dgvAlunos.Rows[e.RowIndex].Cells["editar_aluno"].ToolTipText = "Clique aqui para editar.";
            dgvAlunos.Rows[e.RowIndex].Cells["excluir_aluno"].ToolTipText = "Clique aqui para excluir.";
        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar o RM do aluno
            COD_ALUNO = Convert.ToInt32(
            dgvAlunos.Rows[e.RowIndex].Cells["pk_id_rm_aluno"].Value.ToString());
            // Verifica qual coluna foi clicada
            if (dgvAlunos.Columns[e.ColumnIndex] == dgvAlunos.Columns["editar_aluno"])
            {
                txtNomeAluno.Text = dgvAlunos.Rows[e.RowIndex].Cells["nome_aluno"].Value.ToString();
                txtEnderecoAluno.Text = dgvAlunos.Rows[e.RowIndex].Cells["endereco_aluno"].Value.ToString();
                txtTelefoneAluno.Text = dgvAlunos.Rows[e.RowIndex].Cells["telefone_aluno"].Value.ToString();
                txtEmailAluno.Text = dgvAlunos.Rows[e.RowIndex].Cells["email_aluno"].Value.ToString();
                // Habilitar o botão 'btnExcluir'
                btnExcluirAluno.Enabled = true;
                // Coloca o foco na tabPage "cadastro"
                tabControl1.SelectedIndex = 0;
            }
            // Verificar se a coluna clicada foi a 'excluir'
            else if (dgvAlunos.Columns[e.ColumnIndex] == dgvAlunos.Columns["excluir_aluno"])
            {
                // Chama o método 'click' do botão excluir
                this.btnExcluirAluno_Click(null, null);
            }
        }

        private void dgvAlunos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Manipular as colunas
            foreach (DataGridViewColumn coluna in dgvAlunos.Columns)
            {
                switch (coluna.Name)
                {
                    case "pk_id_rm_aluno": //RM do Aluno
                        coluna.Width = 30;
                        // Atera o título da coluna
                        coluna.HeaderText = "RM";
                        break;
                    case "nome_aluno": // Nome do Aluno
                        coluna.Width = 100;
                        // Atera o título da coluna
                        coluna.HeaderText = "NOME";
                        break;
                    case "endereco_aluno":
                        coluna.Width = 150;
                        // Atera o título da coluna
                        coluna.HeaderText = "ENDEREÇO";
                        break;
                    case "telefone_aluno":
                        coluna.Width = 70;
                        // Atera o título da coluna
                        coluna.HeaderText = "TELEFONE";
                        break;
                    case "email_aluno":
                        coluna.Width = 100;
                        coluna.HeaderText = "E-MAIL";
                        break;
                    case "editar_aluno":
                        // Alterar a ordem / posição da coluna
                        coluna.DisplayIndex = 5;
                        coluna.Width = 30;
                        break;
                    case "excluir_aluno":
                        // Alterar a ordem / posição da coluna
                        coluna.DisplayIndex = 6;
                        coluna.Width = 30;
                        break;
                    default:
                        // Oculta a coluna (esconder as colunas)
                        coluna.Visible = false;
                        break;
                }
            }
        }
    }
}
