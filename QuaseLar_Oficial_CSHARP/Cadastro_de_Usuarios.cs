using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuaseLar_Oficial_CSHARP
{
    
    public partial class Cadastro_de_Usuarios : Form
    {
        public Cadastro_de_Usuarios()
        {
            InitializeComponent();
            txtCep.Leave += async (s, e) => await ValidaCampoCep();
            //Para que funcione o API coma atualizção em "tempo real"

        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCpf.Clear();
            txtCep.Clear();
            txtNumeroCasa.Clear();
            txtEndereco.Clear();
            txtSenha.Clear();
            txtConfirmarSenha.Clear();
        }
        private string ValidaCampoNome()
        {
            string nome = txtNome.Text.Trim();
            if (string.IsNullOrEmpty(nome) || Regex.IsMatch(nome, @"\d"))
            {
                msgErroNome.Text = "O nome so pode conter letras e espaços";
                msgErroNome.ForeColor = System.Drawing.Color.Red;

                return null;
            }
            if (nome.Length <= 3) 
            {
                msgErroNome.Text = "O nome pode ter no minimo 3 caracteres!";
                msgErroNome.ForeColor = System.Drawing.Color.Red;

                return null;
            }
            msgErroNome.Text = "OK";
            msgErroNome.ForeColor = System.Drawing.Color.Green;
            return nome;
        }
        //==================================================================================================================

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            ValidaCampoNome();
        }
        private String ValidaCampoEmail()
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                msgErroEmail.Text = "Preencha o campo";
                msgErroEmail.ForeColor = System.Drawing.Color.Red;
                return null;
            }
            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                msgErroEmail.Text = "⚠ Digite um e-mail válido (ex: exemplo@usuario.com).";
                msgErroEmail.ForeColor = System.Drawing.Color.Red;
                return null;
            }
            if (email.Length <= 15) 
            {
                msgErroEmail.Text = "Email muito curto";
                msgErroEmail.ForeColor = System.Drawing.Color.Red;
                return null;
            }
            msgErroEmail.ForeColor = System.Drawing.Color.Green;
            msgErroEmail.Text = "OK";
            return email;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ValidaCampoEmail();
        }
        //==================================================================================================================

        private string ValidaCampoTelefone()
        {
            string telefone = txtTelefone.Text.Trim();

            if (string.IsNullOrEmpty(telefone))
            {
                msgErroTelefone.Text = "⚠ O campo Telefone é obrigatório.";
                msgErroTelefone.ForeColor = System.Drawing.Color.Red;
                return null;
            }

            // Remove tudo que não for número
            string apenasNumeros = Regex.Replace(telefone, @"\D", "");

            if (apenasNumeros.Length < 10 || apenasNumeros.Length > 11)
            {
                msgErroTelefone.Text = "⚠ Telefone deve conter 10 ou 11 dígitos (com DDD).";
                msgErroTelefone.ForeColor = System.Drawing.Color.Red;
                return null;
            }

            msgErroTelefone.Text = "";
            msgErroTelefone.ForeColor = System.Drawing.Color.Green;
            return telefone;
        }

        private void txtTelefone_StyleChanged(object sender, EventArgs e)
        {
            ValidaCampoTelefone();
        }

        private void txtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ValidaCampoTelefone();
        }
        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            ValidaCampoTelefone();
        }
        //==================================================================================================================
        private string ValidaCampoCpf()
        {
            string cpf = txtCpf.Text.Trim();

            if (string.IsNullOrEmpty(cpf))
            {
                msgErroCpf.Text = "⚠ O campo CPF é obrigatório.";
                msgErroCpf.ForeColor = System.Drawing.Color.Red;
                return null;
            }
            if (cpf.Length < 3)
            {
                msgErroCpf.Text = "Complete o cpf";
                msgErroCpf.ForeColor = System.Drawing.Color.Red;
                return null;
            }
            if (cpf.Length == 18)
            {
                msgErroCpf.Text = "Complete o cpf";
                msgErroCpf.ForeColor = System.Drawing.Color.Red;
                return null;
            }

            msgErroCpf.Text = "";
            msgErroCpf.ForeColor = System.Drawing.Color.Green;
            return cpf;
        }

        private void txtCpf_StyleChanged(object sender, EventArgs e)
        {
            ValidaCampoCpf();
        }

        private void txtCpf_Validating(object sender, CancelEventArgs e)
        {
            ValidaCampoCpf();
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            ValidaCampoCpf();
        }

        private void txtCpf_ReadOnlyChanged(object sender, EventArgs e)
        {
            ValidaCampoCpf();
        }

        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ValidaCampoCpf();
        }

        private void txtCpf_MaskChanged(object sender, EventArgs e)
        {
            ValidaCampoCpf();
        }

        private void txtCpf_Validated(object sender, EventArgs e)
        {
            ValidaCampoCpf();
        }
        //==================================================================================================================
        // Função principal de validação e busca
        
        private async Task ValidaCampoCep()
        {
            string cep = txtCep.Text.Replace("-", "").Trim();
            msgErroCep.Text = "";
            txtEndereco.Text = "";

            if (string.IsNullOrWhiteSpace(cep))
            {
                msgErroCep.Text = "CEP não pode estar vazio.";
                return;
            }

            if (cep.Length != 8 || !long.TryParse(cep, out _))
            {
                msgErroCep.Text = "CEP inválido. Deve conter 8 números.";
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";
                    var response = await client.GetStringAsync(url);

                    JObject endereco = JObject.Parse(response);

                    if (endereco["erro"] != null)
                    {
                        msgErroCep.Text = "CEP não encontrado.";
                        return;
                    }

                    txtEndereco.Text = $"{endereco["logradouro"]}, {txtNumeroCasa.Text}, {endereco["bairro"]}, {endereco["localidade"]} - {endereco["uf"]}";
                }
            }
            catch (HttpRequestException)
            {
                msgErroCep.Text = "Erro de conexão. Verifique sua internet.";
            }
            catch (Exception ex)
            {
                msgErroCep.Text = $"Erro inesperado: {ex.Message}";
            }
        }


        //==================================================================================================================
        //valida se o o endereço realmente é real
        private async Task<bool> ValidaEnderecoReal(string enderecoCompleto)
        {
            string apiKey = "SUA_CHAVE_AQUI";
            string url = $"https://maps.googleapis.com/maps/api/geocode/json?address={Uri.EscapeDataString(enderecoCompleto)}&key={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                string response = await client.GetStringAsync(url);
                JObject json = JObject.Parse(response);

                return json["status"].ToString() == "OK";
            }
        }
        //==================================================================================================================

        private async Task<bool> ValidarCEPViaAPIAsync(string cep)
        {
            using (var http = new HttpClient())
            {
                try
                {
                    var url = $"https://viacep.com.br/ws/{cep}/json/";
                    var resposta = await http.GetAsync(url);
                    if (!resposta.IsSuccessStatusCode)
                        return false;

                    var json = await resposta.Content.ReadAsStringAsync();
                    return !json.Contains("\"erro\": true");
                }
                catch
                {
                    return false;
                }
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            ValidarSenha();
        }

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            string senha = txtSenha.Text;
            string confirmarSenha = txtConfirmarSenha.Text;

            if(confirmarSenha == senha)
            {
                msgErroConfirmarSenha.Text = "OK";
                msgErroConfirmarSenha.ForeColor = System.Drawing.Color.Green;
            }
            if (string.IsNullOrWhiteSpace(confirmarSenha))
            {
                msgErroConfirmarSenha.Text = "Campo não pode estar vazio";
                msgErroConfirmarSenha.ForeColor = System.Drawing.Color.Red;
            }

            if (senha != confirmarSenha)
            {
                msgErroConfirmarSenha.Text = "as senhas não coencidem";
                msgErroConfirmarSenha.ForeColor = System.Drawing.Color.Red;
            }
            

        }

        private string ValidarSenha()
        {
            string senha = txtSenha.Text;
            // Verifica se está vazia
            if (string.IsNullOrWhiteSpace(senha))
            {

                msgErroSenha.Text = "O campo não pode estar vazio.";
                msgErroSenha.ForeColor = System.Drawing.Color.Red;
                return null;
            }

            // Tamanho mínimo
            if (senha.Length < 8)
            {
                
                msgErroSenha.Text = "A senha deve ter pelo menos 8 caracteres.";
                msgErroSenha.ForeColor = System.Drawing.Color.Red;
                return null;
            }

            // Letra maiúscula
            if (!Regex.IsMatch(senha, @"[A-Z]"))
            {
                msgErroSenha.Text = "A senha deve conter pelo menos uma letra maiúscula.";
                msgErroSenha.ForeColor = System.Drawing.Color.Red;
                return null;
            }

            // Letra minúscula
            if (!Regex.IsMatch(senha, @"[a-z]"))
            {
                msgErroSenha.Text = "A senha deve conter pelo menos uma letra minúscula.";
                msgErroSenha.ForeColor = System.Drawing.Color.Red;
                return null;
            }

            // Número
            if (!Regex.IsMatch(senha, @"[0-9]"))
            {
                msgErroSenha.Text = "A senha deve conter pelo menos um número.";
                msgErroSenha.ForeColor = System.Drawing.Color.Red;
                return null;
            }

            // Caractere especial
            if (!Regex.IsMatch(senha, @"[!@#$%^&=*(),~`'+-/\|.?"";':{}|<>]"))
            {
                msgErroSenha.Text = "A senha deve conter pelo menos um caractere especial.";
                msgErroSenha.ForeColor = System.Drawing.Color.Red;
                return null;
            }

            // Sem espaços
            if (senha.Contains(" "))
            {
                msgErroSenha.Text = "A senha não pode conter espaços.";
                msgErroSenha.ForeColor = System.Drawing.Color.Red;
                return null;
            }
            msgErroSenha.Text = "OK";
            msgErroSenha.ForeColor = System.Drawing.Color.Green;
            return senha;

        }


    }
}           