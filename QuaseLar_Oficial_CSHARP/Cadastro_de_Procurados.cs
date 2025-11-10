using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuaseLar_Oficial_CSHARP
{
    public partial class Cadastro_de_Procurados : Form

    {
        private List<string> caminhosImagens = new List<string>();
        private BancoDeDados bd = new BancoDeDados();
        public Cadastro_de_Procurados()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        { 

            ValidacaNome();
            ValidaRaca();
            ValidaEspecie();
            ValidaSexo();
            ValidaIdade();
            ValidaMotivo();
            ValidaTempo();
            ValidaPorte();

            if (string.IsNullOrWhiteSpace(txtNomeAnimal.Text) ||
                cmbEspecie.SelectedItem == null ||
                cmbSexo.SelectedItem == null ||
                cmbPorte.SelectedItem == null ||
                cmbEspecie.SelectedItem == null ||
                cmbTempo.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomePet = txtNomeAnimal.Text.Trim();
            string raca = txtRaca.Text.Trim();
            string idade = txtIdade.Text.Trim();
            string semanasMesesAnos = cmbTempo.SelectedItem.ToString();
            string sexo = cmbSexo.SelectedItem.ToString();
            string especie = cmbEspecie.SelectedItem.ToString();
            string porte = cmbPorte.SelectedItem.ToString();
            string motivo = txtMotivo.Text.Trim();

            BancoDeDados bd = new BancoDeDados();
            using (MySqlConnection conexao = bd.AbrirConexao())
            {
                try
                {
                    string query = @"
                INSERT INTO tb_adocao tb_procurados
                    id_usuario, nome_p, raca_p, idade_p, semanas_meses_anos_p, 
                    sexo_p, especie_p, porte_p, ultima_vez_visto
                ) 
                VALUES (
                    1, @nome_pet, @raca, @idade, @semanas_meses_anos, 
                    @sexo, @especie, @porte, @ultima_vez_visto
                );
                SELECT LAST_INSERT_ID();";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome_pet", nomePet);
                        cmd.Parameters.AddWithValue("@raca_p", raca);
                        cmd.Parameters.AddWithValue("@idade", idade);
                        cmd.Parameters.AddWithValue("@semanas_meses_anos", semanasMesesAnos);
                        cmd.Parameters.AddWithValue("@sexo", sexo);
                        cmd.Parameters.AddWithValue("@especie", especie);
                        cmd.Parameters.AddWithValue("@porte", porte);
                        cmd.Parameters.AddWithValue("@ultima_vez_visto", motivo);

                        long idAdocao = Convert.ToInt64(cmd.ExecuteScalar());

                        string pastaDestino = Path.Combine(Application.StartupPath, "ImagensPets");
                        if (!Directory.Exists(pastaDestino))
                            Directory.CreateDirectory(pastaDestino);

                        foreach (string caminho in caminhosImagens)
                        {
                            if (!File.Exists(caminho))
                                continue;

                            string nomeArquivo = Path.GetFileName(caminho);
                            string destino = Path.Combine(pastaDestino, nomeArquivo);

                            File.Copy(caminho, destino, true);

                            string sqlImg = @"
                        INSERT INTO id_img_procurados (
                            id_procurados, nome_arquivo, localizacao, data_cadastro
                        ) VALUES (
                            @id, @nome, @local, NOW()
                        )";

                            using (MySqlCommand cmdImg = new MySqlCommand(sqlImg, conexao))
                            {
                                cmdImg.Parameters.AddWithValue("@id", idAdocao);
                                cmdImg.Parameters.AddWithValue("@nome", nomeArquivo);
                                cmdImg.Parameters.AddWithValue("@local", destino);
                                cmdImg.ExecuteNonQuery();
                            }
                        }
                    }

                    caminhosImagens.Clear();
                    ExibirImagens();
                    limparCampos();

                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bd.FecharConexao();
                }
            }
        }


        private void ValidacaNome()
        {
            string nome = txtNomeAnimal.Text.Trim();
            msgErroNome.Text = "";
            string padrao = @"^[a-zA-Zà-úÀ-Ú\s-]+$";

            if (string.IsNullOrEmpty(nome))
            {
                msgErroNome.ForeColor = System.Drawing.Color.Red;
                msgErroNome.Text = "O campo Nome do animal é obrigatório.";
                return;
            }
            if (!Regex.IsMatch(nome, padrao))
            {
                msgErroNome.ForeColor = System.Drawing.Color.Red;
                msgErroNome.Text = "So letra e espaços";
                return;
            }

            if (nome.Length < 2)
            {
                msgErroNome.Text = "O Nome do animal deve ter pelo menos 2 caracteres.";
                msgErroNome.ForeColor = System.Drawing.Color.Red;

                return;
            }
            else
            {
                msgErroNome.ForeColor = System.Drawing.Color.Green;
                msgErroNome.Text = "OK";
            }
        }
        private void ValidaRaca()
        {
            string raca = txtRaca.Text.Trim();
            msgErroRaca.Text = "";
            string padrao = @"^[a-zA-Zà-úÀ-Ú\s-]+$";

            if (!Regex.IsMatch(raca, padrao))
            {
                msgErroRaca.ForeColor = System.Drawing.Color.Red;
                msgErroRaca.Text = "Só letras e espaços";
            }
            if (string.IsNullOrEmpty(raca))
            {
                msgErroRaca.ForeColor = System.Drawing.Color.Red;
                msgErroRaca.Text = "O campo Raça é obrigatório.";
                return;
            }

            if (raca.Length < 2)
            {
                msgErroRaca.ForeColor = System.Drawing.Color.Red;
                msgErroRaca.Text = "O Nome do animal deve ter pelo menos 2 caracteres.";
                return;
            }
            else
            {
                msgErroRaca.ForeColor = System.Drawing.Color.Green;
                msgErroRaca.Text = "OK";
            }
        }
        private void ValidaMotivo()
        {
            string motivo = txtMotivo.Text.Trim();
            msgErroMotivo.Text = "";

            if (string.IsNullOrEmpty(motivo))
            {
                msgErroMotivo.ForeColor = System.Drawing.Color.Red;
                msgErroMotivo.Text = "O campo Motivo é obrigatório.";
                return;
            }
            if (motivo.Length < 5)
            {
                msgErroMotivo.ForeColor = System.Drawing.Color.Red;
                msgErroMotivo.Text = "O Motivo deve ter pelo menos 5 caracteres.";
                return;
            }
            else
            {
                msgErroMotivo.ForeColor = System.Drawing.Color.Green;
                msgErroMotivo.Text = "OK";
            }
        }
        private void ValidaIdade()
        {
            string idade = txtIdade.Text.Trim();
            msgErroIdade.Text = "";

            if (string.IsNullOrEmpty(idade))
            {
                msgErroIdade.ForeColor = System.Drawing.Color.Red;
                msgErroIdade.Text = "O campo Idade é obrigatório.";
                return;
            }
            if (!int.TryParse(idade, out int idadeNum) || idadeNum <= 0)
            {
                msgErroIdade.ForeColor = System.Drawing.Color.Red;
                msgErroIdade.Text = "A Idade deve ser um número maior que zero.";
                return;
            }
            else
            {
                msgErroIdade.ForeColor = System.Drawing.Color.Green;
                msgErroIdade.Text = "OK";
            }
        }
        private void ValidaTempo()
        {
            string tempo = cmbTempo.SelectedIndex.ToString();
            msgErroIdade2.Text = "";
            if (cmbTempo.SelectedIndex == -1)
            {
                msgErroIdade2.ForeColor = System.Drawing.Color.Red;
                msgErroIdade2.Text = "Selecione o tempo.";
                return;
            }
            else
            {
                msgErroIdade2.ForeColor = System.Drawing.Color.Green;
                msgErroIdade2.Text = "OK";
            }
        }
        private void ValidaPorte()
        {
            string porte = cmbPorte.SelectedIndex.ToString();
            msgErroPorte.Text = "";
            if (cmbPorte.SelectedIndex == -1)
            {
                msgErroPorte.ForeColor = System.Drawing.Color.Red;
                msgErroPorte.Text = "Selecione o porte do animal.";
                return;
            }
            else
            {
                msgErroPorte.ForeColor = System.Drawing.Color.Green;
                msgErroPorte.Text = "OK";
            }
        }
       
        
        private void ValidaSexo()
        {
            string sexo = cmbEspecie.SelectedIndex.ToString();
            msgErroSexo.Text = "";
            if (cmbSexo.SelectedIndex == -1)
            {
                msgErroSexo.ForeColor = System.Drawing.Color.Red;
                msgErroSexo.Text = "Selecione uma opção";
                return;
            }
            else
            {
                msgErroSexo.ForeColor = System.Drawing.Color.Green;
                msgErroSexo.Text = "OK";
            }
        }
        private void ValidaEspecie()
        {
            string especie = cmbEspecie.SelectedIndex.ToString();
            msgErroEspecie.Text = "";

            if (cmbEspecie.SelectedIndex == -1)
            {
                msgErroEspecie.ForeColor = System.Drawing.Color.Red;
                msgErroEspecie.Text = "Selecione uma opção";
                return;
            }
            else
            {
                msgErroEspecie.ForeColor = System.Drawing.Color.Green;
                msgErroEspecie.Text = "OK";
            }
        }

        private void btnAdicionarImagens_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Multiselect = true;
            openFile.Filter = "Imagens (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (openFile.FileNames.Length + caminhosImagens.Count > 5)
                {
                    MessageBox.Show("O maximo de imagens é 5");
                    return;

                }
                foreach (string caminho in openFile.FileNames)
                    caminhosImagens.Add(caminho);
                ExibirImagens();
            }
        }
        private void limparCampos()
        {
            txtNomeAnimal.Clear();
            txtRaca.Clear();
            txtIdade.Clear();
            cmbTempo.SelectedIndex = -1;
            cmbSexo.SelectedIndex = -1;
            cmbEspecie.SelectedIndex = -1;
            cmbPorte.SelectedIndex = -1;
            txtMotivo.Clear();
            caminhosImagens.Clear();
        }


        private void ExibirImagens()
        {
            foreach (var pic in groupBox2.Controls)
                if (pic is PictureBox pb)
                    pb.Image = null;

            for (int i = 0; i < caminhosImagens.Count && i < 5; i++)
            {
                PictureBox pictureBox = groupBox2.Controls.Find("pictureBox" + (i + 1), true)[0] as PictureBox;
                pictureBox.Image = Image.FromFile(caminhosImagens[i]);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void txtNomeAnimal_TextChanged(object sender, EventArgs e)
        {
            ValidacaNome();
        }

        private void txtRaca_TextChanged(object sender, EventArgs e)
        {
            ValidaRaca();
        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {
            ValidaIdade();
        }

        private void cmbTempo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidaTempo();
        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidaSexo();
        }

        private void cmbCastrado_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidaEspecie();
        }

        private void cmbPorte_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidaPorte();
        }

        private void txtMotivo_TextChanged(object sender, EventArgs e)
        {
            ValidaMotivo();
        }
    }
}
