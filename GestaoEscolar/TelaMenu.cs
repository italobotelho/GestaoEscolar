using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoEscolar
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        private void btnAlunos_Click(object sender, EventArgs e)
        {
            TelaAlunos menuAlunos = new TelaAlunos();
            this.Hide();
            menuAlunos.ShowDialog();
            this.Close();
        }

        private void btnProfessores_Click(object sender, EventArgs e)
        {
            TelaProfessores menuProfessores = new TelaProfessores();
            this.Hide();
            menuProfessores.ShowDialog();
            this.Close(); 
        }

        private void btnDisciplinas_Click(object sender, EventArgs e)
        {
            TelaDisciplinas telaDisciplinas = new TelaDisciplinas();
            this.Hide();
            telaDisciplinas.ShowDialog();
            this.Close(); 
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            TelaSobre telaSobre = new TelaSobre();
            this.Hide();
            telaSobre.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Você realmente deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (resp == DialogResult.Yes)
            {
                TelaLogin telaLogin = new TelaLogin();
                this.Hide();
                telaLogin.ShowDialog();
                this.Close();
            }
        }
    }
}
