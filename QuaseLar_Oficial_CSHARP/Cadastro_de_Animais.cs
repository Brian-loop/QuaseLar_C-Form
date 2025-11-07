using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace QuaseLar_Oficial_CSHARP
{
    public partial class Cadastro_de_Animais : Form
    {

        private List<string> caminhosImagens = new List<string>();
        private BancoDeDados bd = new BancoDeDados();

        public Cadastro_de_Animais()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nomePet = txtNomeAnimal.Text.Trim();
            string raca = txtRaca.Text.Trim();
            int idade = int.Parse(txtIdade.Text.Trim());
            string semanasMesesAnos = cmbTempo.SelectedItem.ToString();
            string sexo = cmbSexo.SelectedItem.ToString();
            string castrado = cmbCastrado.SelectedItem.ToString();
            string especie = cmbEspecie.SelectedItem.ToString();
            string porte = cmbPorte.SelectedItem.ToString();
            string vacinado = cmbVacinado.SelectedItem.ToString();
            string motivo = txtMotivo.Text.Trim();

            BancoDeDados bd = new BancoDeDados();
            MySqlConnection conexao = bd.AbrirConexao();

            try
            {
                // ❌ Removido as aspas simples de '@nome_pet'
                // ✅ Corrigido o uso de parâmetros
                string query = @"INSERT INTO tb_adocao 
                         (id_usuario, nome_pet, raca, idade, semanas_meses_anos, 
                          sexo, castrado, especie, porte, vacinado, motivo_da_doacao) 
                         VALUES (1, @nome_pet, @raca, @idade, 
                                 @semanas_meses_anos, @sexo, @castrado, 
                                 @especie, @porte, @vacinado, @motivo);
                         SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, conexao);

                // ✅ Parâmetros corretos
                cmd.Parameters.AddWithValue("@nome_pet", nomePet);
                cmd.Parameters.AddWithValue("@raca", raca);
                cmd.Parameters.AddWithValue("@idade", idade);
                cmd.Parameters.AddWithValue("@semanas_meses_anos", semanasMesesAnos);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@castrado", castrado);
                cmd.Parameters.AddWithValue("@especie", especie);
                cmd.Parameters.AddWithValue("@porte", porte);
                cmd.Parameters.AddWithValue("@vacinado", vacinado);
                cmd.Parameters.AddWithValue("@motivo", motivo);

                // ✅ Executa o comando uma vez e pega o ID gerado
                long idAdocao = Convert.ToInt64(cmd.ExecuteScalar());

                // SALVAR IMAGENS
                string pastaDestino = Path.Combine(Application.StartupPath, "ImagensPets");

                // Cria pasta se não existir
                if (!Directory.Exists(pastaDestino))
                    Directory.CreateDirectory(pastaDestino);

                foreach (string caminho in caminhosImagens)
                {
                    string nomeArquivo = Path.GetFileName(caminho);
                    string destino = Path.Combine(pastaDestino, nomeArquivo);

                    // Copia a imagem para a pasta do projeto
                    File.Copy(caminho, destino, true);

                    string sqlImg = @"INSERT INTO tb_img_animal 
                              (id_adocao, nome_arquivo, localizacao, data_cadastro) 
                              VALUES (@id, @nome, @local, NOW())";

                    MySqlCommand cmdImg = new MySqlCommand(sqlImg, conexao);
                    cmdImg.Parameters.AddWithValue("@id", idAdocao);
                    cmdImg.Parameters.AddWithValue("@nome", nomeArquivo);
                    cmdImg.Parameters.AddWithValue("@local", destino);
                    cmdImg.ExecuteNonQuery();
                }

                // ❌ Removido o cmd.ExecuteNonQuery() duplicado (já executou antes)

                caminhosImagens.Clear();
                ExibirImagens();

                MessageBox.Show("Cadastro Realizado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
            }
            catch (Exception ex)
            {
                // ✅ Mostra erro real para depuração
                MessageBox.Show("Erro ao cadastrar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bd.FecharConexao();
            }
        }


        //private void btnCadastrar_Click(object sender, EventArgs e)
        //{
        //    string nomePet = txtNomeAnimal.Text.Trim();
        //    string raca = txtRaca.Text.Trim();
        //    int idade = int.Parse(txtIdade.Text.Trim());
        //    string semanasMesesAnos = cmbTempo.SelectedItem.ToString();
        //    string sexo = cmbSexo.SelectedItem.ToString();
        //    string castrado = cmbCastrado.SelectedItem.ToString();
        //    string especie = cmbEspecie.SelectedItem.ToString();
        //    string porte = cmbPorte.SelectedItem.ToString();
        //    string vacinado = cmbVacinado.SelectedItem.ToString();
        //    string motivo = txtMotivo.Text.Trim();
        //    BancoDeDados bd = new BancoDeDados();
        //    MySqlConnection conexao = bd.AbrirConexao();

        //    try
        //    {
        //        string query = @"INSERT INTO tb_adocao (id_usuario, nome_pet, raca, idade, semanas_meses_anos, " +
        //            "sexo, castrado, especie, porte, vacinado, motivo_da_doacao) VALUES ('1', '@nome_pet', @raca, @idade, " +
        //            "@semanas_meses_anos, @sexo, @castrado, @especie, @porte, @vacinado, @motivo); SELECT LAST_INSERT_ID();";

        //        MySqlCommand cmd = new MySqlCommand(query, conexao);

        //        cmd.Parameters.AddWithValue("@nome_pet", nomePet);
        //        cmd.Parameters.AddWithValue("@raca", raca);
        //        cmd.Parameters.AddWithValue("@idade", idade);
        //        cmd.Parameters.AddWithValue("@semanas_meses_anos", semanasMesesAnos);
        //        cmd.Parameters.AddWithValue("@sexo", sexo);
        //        cmd.Parameters.AddWithValue("@castrado", castrado);
        //        cmd.Parameters.AddWithValue("@especie", especie);
        //        cmd.Parameters.AddWithValue("@porte", porte);
        //        cmd.Parameters.AddWithValue("@vacinado", vacinado);
        //        cmd.Parameters.AddWithValue("@motivo", motivo);

        //        long idAdocao = Convert.ToInt64(cmd.ExecuteScalar());

        //        //salvar imagens
        //        string pastaDestino = Path.Combine(Application.StartupPath, "ImagensPets");
        //        foreach (string caminho in caminhosImagens)
        //        {
        //            string nomeArquivo = Path.GetFileName(caminho);
        //            string destino = Path.Combine(pastaDestino, nomeArquivo);

        //            // Copia a imagem para a pasta do projeto
        //            File.Copy(caminho, destino, true);

        //            string sqlImg = "INSERT INTO tb_img_animal (id_doacao, nome_arquivo, localizacao, data_cadastro) VALUES (@id, @nome, @local, NOW())";
        //            MySqlCommand cmdImg = new MySqlCommand(sqlImg, conexao);
        //            cmdImg.Parameters.AddWithValue("@id", idAdocao);
        //            cmdImg.Parameters.AddWithValue("@nome", nomeArquivo);
        //            cmdImg.Parameters.AddWithValue("@local", destino);
        //            cmdImg.ExecuteNonQuery();
        //        }

        //        cmd.ExecuteNonQuery();
        //        caminhosImagens.Clear();
        //        ExibirImagens();


        //        MessageBox.Show("Cadastro Realizado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        limparCampos();
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Eroor ao cadastrar");

        //    }
        //    finally
        //    {
        //        bd.FecharConexao();
        //    }

        //}
        private void limparCampos()
        {
            txtNomeAnimal.Clear();
            txtRaca.Clear();
            txtIdade.Clear();
            cmbTempo.SelectedIndex = -1;
            cmbSexo.SelectedIndex = -1;
            cmbEspecie.SelectedIndex = -1;
            cmbCastrado.SelectedIndex = -1;
            cmbPorte.SelectedIndex = -1;
            cmbVacinado.SelectedIndex = -1;
            txtMotivo.Clear();
            caminhosImagens.Clear();
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
    }
}
