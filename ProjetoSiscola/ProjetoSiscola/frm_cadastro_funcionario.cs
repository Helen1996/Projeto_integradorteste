using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSiscola
{
    public partial class frm_cadastro_funcionario : Form
    {
        public frm_cadastro_funcionario()
        {
            InitializeComponent();
        }

        private void pcb_senha_MouseHover(object sender, EventArgs e)
        {
            txt_senha.PasswordChar = '\0';
        }

        private void pcb_senha_MouseLeave(object sender, EventArgs e)
        {
            txt_senha.PasswordChar = '*';
        }

        private void pcb_senha_Click(object sender, EventArgs e)
        {

        }

        private void frm_cadastro_funcionario_Load(object sender, EventArgs e)
        {

        }
    }
}
