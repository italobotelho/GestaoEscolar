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
    public partial class TelaProfessores : Form
    {
        // Declara as variáveis globais
        // Define a string de conexão
        string strConexao = ("Data Source=DESKTOP-QP6F04T;Initial Catalog=GESTAO_ESCOLAR;Integrated Security=true");

        // Variável de controle para inserir ou alterar
        int COD_PROF;

        public TelaProfessores()
        {
            InitializeComponent();
        }

        // Método que limpa os campos
        public void limpaCampos()
        {
            txtNomeProf.Clear();
            txtEnderecoProf.Clear();
            txtTelefoneProf.Clear();
            txtEmailProf.Clear();
        }

        private void buscaProfessores()
        {
            // Cria um objeto para conextar com o BD
            SqlConnection con = new SqlConnection(strConexao);
            try
            {
                con.Open(); // Abre a conexão com banco de dados
                string sql = @"SELECT * FROM PROFESSOR";
                // Define o comando SQL e a conexão do BD
                SqlCommand cmd = new SqlCommand(sql, con);
                // Executa a consulta
                SqlDataReader dados = cmd.ExecuteReader();
                if (dados.HasRows)
                {
                    // Cria uma tabela genérica
                    DataTable dt = new DataTable();
                    dt.Load(dados); // Carrega os dados para o DataTable
                    dgvProf.DataSource = dt; // Preenche o DataGridView
                }
                else
                {
                    MessageBox.Show("Nenhum professor encontrado!");
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

        private void btnCadastrarProf_Click(object sender, EventArgs e)
        {
            // Criar um objeto para conectar com o BD
            SqlConnection con = new SqlConnection(strConexao);

            string NOME_PROF, ENDERECO_PROF, TELEFONE_PROF, EMAIL_PROF;
            NOME_PROF = txtNomeProf.Text;
            ENDERECO_PROF = txtEnderecoProf.Text;
            TELEFONE_PROF = txtTelefoneProf.Text;
            EMAIL_PROF = txtEmailProf.Text;


            if ((NOME_PROF == "") || (ENDERECO_PROF == "") || (TELEFONE_PROF == "") || (EMAIL_PROF == ""))
            {
                txtNomeProf.Focus();

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
                    if (COD_PROF <= -1)
                    {
                        // Define o comando SQL (INSERT)
                        cmd = new SqlCommand(@"INSERT INTO PROFESSOR(nome_prof, endereco_prof, telefone_prof, email_prof) VALUES(@nome, @endereco, @telefone, @email);", con);
                        msg = "cadastrado";
                    }
                    else
                    {
                        // Define o comando SQL (UPDATE)
                        cmd = new SqlCommand(@"UPDATE PROFESSOR SET nome_prof=@nome, endereco_prof=@endereco, telefone_prof=@telefone, email_prof=@email WHERE pk_id_matricula_prof=@id;", con);
                        msg = "atualizado";
                    }
                    // Define os valores para os parâmetros
                    cmd.Parameters.AddWithValue("@nome", txtNomeProf.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEnderecoProf.Text.Trim());
                    cmd.Parameters.AddWithValue("@telefone", txtTelefoneProf.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmailProf.Text.Trim());

                    // Verifica se o comando é um UPDATE
                    if (COD_PROF > -1)
                    {
                        // Define o parâmetro @id
                        cmd.Parameters.AddWithValue("@id", COD_PROF);
                    }
                    // Executa o comando SQL
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Professor " + msg + " com sucesso!");
                    // Chama o método "btnNovo_Click"
                    btnNovoProf_Click(null, null);
                    // Atualiza o dataGridView
                    buscaProfessores();
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

        private void btnNovoProf_Click(object sender, EventArgs e)
        {
            // Define que será feita uma inserção
            COD_PROF = -1;
            // Chama a função limpaCampos
            limpaCampos();
            // Desativa o botão excluir
            btnExcluirProf.Enabled = false;
            // Coloca o foco no textbox
            txtNomeProf.Focus();
        }

        private void btnExcluirProf_Click(object sender, EventArgs e)
        {
            // Verifica se o usuário clicou no botão sim
            DialogResult resultado = MessageBox.Show("Deseja realmente excluir?", "Confirma exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    // Verifica se algum professor foi selecionado
                    if (COD_PROF > -1)
                    {
                        // Define o comando SQL (DELETE)
                        cmd = new SqlCommand(@"DELETE FROM PROFESSOR WHERE pk_id_matricula_prof=@id;", con);
                        // Define o parâmetro @id
                        cmd.Parameters.AddWithValue("@id", COD_PROF);
                        // Executa o comando SQL
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Professor excluído com sucesso!");
                        // Chama o método "btnNovo_Click"
                        btnNovoProf_Click(null, null);
                        // Atualiza o dataGridView
                        buscaProfessores();
                    }
                    else
                    {
                        MessageBox.Show("Nenhum professor selecionado!");
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

        private void btnConsultarProf_Click(object sender, EventArgs e)
        {
            // Cria um objeto para conectar com o BD
            SqlConnection con = new SqlConnection(strConexao);

            //Criando variável para receber o ID da matricula
            string PESQUISAR_PROF;

            PESQUISAR_PROF = txtPesquisarProf.Text;

            //Verificando se o campo está vazio
            if (PESQUISAR_PROF == "")
            {
                txtPesquisarProf.Focus();

                MessageBox.Show("Preencha o campo para fazer uma consulta!");
            }
            else
            {
                try
                {
                    // Abre a conexão com o BD
                    con.Open();
                    // Definir o comando SQL (SELECT)
                    string sql = @"SELECT * FROM PROFESSOR WHERE pk_id_matricula_prof=" + txtPesquisarProf.Text.Trim();
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
                        txtNomeProf.Text = dt.Rows[0]["nome_prof"].ToString();
                        txtEnderecoProf.Text = dt.Rows[0]["endereco_prof"].ToString();
                        txtTelefoneProf.Text = dt.Rows[0]["telefone_prof"].ToString();
                        txtEmailProf.Text = dt.Rows[0]["email_prof"].ToString();
                        // Exibe a aba "cadastro"
                        tabControl1.SelectedIndex = 0;
                        // Define a MATRICULA (ID) do professor para uma possível Edição ou Exclusão
                        COD_PROF = int.Parse(txtPesquisarProf.Text.Trim());
                        // Habilita o botão excluir
                        btnExcluirProf.Enabled = true;
                    }
                    else
                    { // Se não existir nenhum professor com o codigo digitado
                        MessageBox.Show("Nenhum professor encontrado!");
                        txtPesquisarProf.Focus();
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

        private void TelaProfessores_Shown(object sender, EventArgs e)
        {
            // Chama o método que preenche o datagridview (dgvProfessores)
            buscaProfessores();
            // Chama o método btnNovo_click
            btnNovoProf_Click(null, null);
        }

        private void dgvProf_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Adiciona o tooltip nas imagens do datagridview
            dgvProf.Rows[e.RowIndex].Cells["editar_prof"].ToolTipText = "Clique aqui para editar.";
            dgvProf.Rows[e.RowIndex].Cells["excluir_prof"].ToolTipText = "Clique aqui para excluir.";
        }

        private void dgvProf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegar a MATRICULA (ID) do professor
            COD_PROF = Convert.ToInt32(dgvProf.Rows[e.RowIndex].Cells["pk_id_matricula_prof"].Value.ToString());
            // Verifica qual coluna foi clicada
            if (dgvProf.Columns[e.ColumnIndex] == dgvProf.Columns["editar_prof"])
            {
                txtNomeProf.Text = dgvProf.Rows[e.RowIndex].Cells["nome_prof"].Value.ToString();
                txtEnderecoProf.Text = dgvProf.Rows[e.RowIndex].Cells["endereco_prof"].Value.ToString();
                txtTelefoneProf.Text = dgvProf.Rows[e.RowIndex].Cells["telefone_prof"].Value.ToString();
                txtEmailProf.Text = dgvProf.Rows[e.RowIndex].Cells["email_prof"].Value.ToString();
                // Habilitar o botão 'btnExcluir'
                btnExcluirProf.Enabled = true;
                // Coloca o foco na tabPage "cadastro"
                tabControl1.SelectedIndex = 0;
            }
            // Verificar se a coluna clicada foi a 'excluir'
            else if (dgvProf.Columns[e.ColumnIndex] ==dgvProf.Columns["excluir_prof"])
            {
                // Chama o método 'click' do botão excluir
                this.btnExcluirProf_Click(null, null);
            }
        }

        private void dgvProf_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Manipular as colunas
            foreach (DataGridViewColumn coluna in dgvProf.Columns)
            {
                switch (coluna.Name)
                {
                    case "pk_id_matricula_prof": //ID do Professor
                        coluna.Width = 30;
                        // Atera o título da coluna
                        coluna.HeaderText = "ID";
                        break;
                    case "nome_prof": // Nome do Professor
                        coluna.Width = 100;
                        // Atera o título da coluna
                        coluna.HeaderText = "NOME";
                        break;
                    case "endereco_prof":
                        coluna.Width = 150;
                        // Atera o título da coluna
                        coluna.HeaderText = "ENDEREÇO";
                        break;
                    case "telefone_prof":
                        coluna.Width = 70;
                        // Atera o título da coluna
                        coluna.HeaderText = "TELEFONE";
                        break;
                    case "email_prof":
                        coluna.Width = 100;
                        coluna.HeaderText = "E-MAIL";
                        break;
                    case "editar_prof":
                        // Alterar a ordem / posição da coluna
                        coluna.DisplayIndex = 5;
                        coluna.Width = 30;
                        break;
                    case "excluir_prof":
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
