namespace QuaseLar_Oficial_CSHARP
{
    partial class Consulta_de_Animais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPets = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvPetsImg = new System.Windows.Forms.DataGridView();
            this.btnAdicionarImagens = new System.Windows.Forms.Button();
            this.btnRemoverImagens = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetsImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvPetsImg);
            this.panel1.Controls.Add(this.dgvPets);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1696, 728);
            this.panel1.TabIndex = 0;
            // 
            // dgvPets
            // 
            this.dgvPets.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPets.Location = new System.Drawing.Point(23, 61);
            this.dgvPets.Name = "dgvPets";
            this.dgvPets.RowHeadersWidth = 51;
            this.dgvPets.RowTemplate.Height = 24;
            this.dgvPets.Size = new System.Drawing.Size(895, 648);
            this.dgvPets.TabIndex = 1;
            this.dgvPets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPets_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(852, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta de cadastro de animais em adoção";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(1727, 74);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 62);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(1727, 142);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 62);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1727, 678);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 62);
            this.button3.TabIndex = 3;
            this.button3.Text = "Fechar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1727, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 62);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reabilitar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvPetsImg
            // 
            this.dgvPetsImg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPetsImg.Location = new System.Drawing.Point(951, 61);
            this.dgvPetsImg.Name = "dgvPetsImg";
            this.dgvPetsImg.RowHeadersWidth = 51;
            this.dgvPetsImg.RowTemplate.Height = 24;
            this.dgvPetsImg.Size = new System.Drawing.Size(722, 648);
            this.dgvPetsImg.TabIndex = 2;
            // 
            // btnAdicionarImagens
            // 
            this.btnAdicionarImagens.Location = new System.Drawing.Point(1747, 300);
            this.btnAdicionarImagens.Name = "btnAdicionarImagens";
            this.btnAdicionarImagens.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarImagens.TabIndex = 5;
            this.btnAdicionarImagens.Text = "Adicionar Imagens";
            this.btnAdicionarImagens.UseVisualStyleBackColor = true;
            this.btnAdicionarImagens.Click += new System.EventHandler(this.btnAdicionarImagens_Click);
            // 
            // btnRemoverImagens
            // 
            this.btnRemoverImagens.Location = new System.Drawing.Point(1738, 378);
            this.btnRemoverImagens.Name = "btnRemoverImagens";
            this.btnRemoverImagens.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverImagens.TabIndex = 6;
            this.btnRemoverImagens.Text = "Remover imagens";
            this.btnRemoverImagens.UseVisualStyleBackColor = true;
            this.btnRemoverImagens.Click += new System.EventHandler(this.btnRemoverImagens_Click);
            // 
            // Consulta_de_Animais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1839, 749);
            this.Controls.Add(this.btnRemoverImagens);
            this.Controls.Add(this.btnAdicionarImagens);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.panel1);
            this.Name = "Consulta_de_Animais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta_de_Animais";
            this.Load += new System.EventHandler(this.Consulta_de_Animais_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetsImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPetsImg;
        private System.Windows.Forms.Button btnAdicionarImagens;
        private System.Windows.Forms.Button btnRemoverImagens;
    }
}