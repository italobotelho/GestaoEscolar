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
    public partial class TelaSobre : Form
    {
        public TelaSobre()
        {
            InitializeComponent();
        }

        private void picBoxVoltarSobre_Click(object sender, EventArgs e)
        {
            TelaMenu telaMenu = new TelaMenu();
            this.Hide();
            telaMenu.ShowDialog();
            this.Close();
        }

        private void lklblGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/italobotelho/");
        }

        private void lklblLinkedin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/italobotelho/");
        }

        private void lklblInsta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/nego.italo/");
        }

        private void lklblEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/#inbox?compose=GTvVlcSKkVPzZnjgtXlQPglLGQkWGXMmLGJwjPfHVFjpPtqPDdcXCjNXNqwZMTwCBKCdqztQGSQCR");
        }
    }
}
