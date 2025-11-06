using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuaseLar_Oficial_CSHARP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void acessoFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acessoEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmailAcesso.Text.Equals("a") && txtSenhaAcesso.Text.Equals("1"))
                {
                    var painelDeBotoes = new Painel_de_botoes();
                    painelDeBotoes.Show();

                    this.Visible = false;
                    
                }
                else {
                    msgErroAcesso.Text = "Email ou Senha incorretos!!";
                    txtEmailAcesso.Focus();
                    txtSenhaAcesso.Focus();
                }

            }
            catch { 
            }
        }

        private void txtEmailAcesso_TextChanged(object sender, EventArgs e)
        {
            msgErroAcesso.Text = "";
        }

        private void txtSenhaAcesso_TextChanged(object sender, EventArgs e)
        {
            msgErroAcesso.Text = "";
        }
    }
}
