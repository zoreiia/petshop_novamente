namespace petshop_novamente
{
    partial class Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxgeneros = new System.Windows.Forms.GroupBox();
            this.radioButtonmacho = new System.Windows.Forms.RadioButton();
            this.radioButtonfemea = new System.Windows.Forms.RadioButton();
            this.textBoxnomea = new System.Windows.Forms.TextBox();
            this.comboBoxraca = new System.Windows.Forms.ComboBox();
            this.comboBoxespecie = new System.Windows.Forms.ComboBox();
            this.groupBoxsituacao = new System.Windows.Forms.GroupBox();
            this.checkBoxvacinado = new System.Windows.Forms.CheckBox();
            this.checkBoxcastrado = new System.Windows.Forms.CheckBox();
            this.checkBoxpedigree = new System.Windows.Forms.CheckBox();
            this.groupBoxpelo = new System.Windows.Forms.GroupBox();
            this.radioButtoncurto = new System.Windows.Forms.RadioButton();
            this.radioButtonlongo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxpeso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttoncadastrar = new System.Windows.Forms.Button();
            this.buttonalterar = new System.Windows.Forms.Button();
            this.buttonexcluir = new System.Windows.Forms.Button();
            this.dataGridViewpets = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxgeneros.SuspendLayout();
            this.groupBoxsituacao.SuspendLayout();
            this.groupBoxpelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpets)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Animal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Raça:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Espécie:";
            // 
            // groupBoxgeneros
            // 
            this.groupBoxgeneros.Controls.Add(this.radioButtonfemea);
            this.groupBoxgeneros.Controls.Add(this.radioButtonmacho);
            this.groupBoxgeneros.Location = new System.Drawing.Point(50, 144);
            this.groupBoxgeneros.Name = "groupBoxgeneros";
            this.groupBoxgeneros.Size = new System.Drawing.Size(89, 100);
            this.groupBoxgeneros.TabIndex = 1;
            this.groupBoxgeneros.TabStop = false;
            this.groupBoxgeneros.Text = "Gêneros:";
            // 
            // radioButtonmacho
            // 
            this.radioButtonmacho.AutoSize = true;
            this.radioButtonmacho.Location = new System.Drawing.Point(18, 32);
            this.radioButtonmacho.Name = "radioButtonmacho";
            this.radioButtonmacho.Size = new System.Drawing.Size(58, 17);
            this.radioButtonmacho.TabIndex = 0;
            this.radioButtonmacho.TabStop = true;
            this.radioButtonmacho.Text = "Macho";
            this.radioButtonmacho.UseVisualStyleBackColor = true;
            // 
            // radioButtonfemea
            // 
            this.radioButtonfemea.AutoSize = true;
            this.radioButtonfemea.Location = new System.Drawing.Point(17, 69);
            this.radioButtonfemea.Name = "radioButtonfemea";
            this.radioButtonfemea.Size = new System.Drawing.Size(57, 17);
            this.radioButtonfemea.TabIndex = 1;
            this.radioButtonfemea.TabStop = true;
            this.radioButtonfemea.Text = "Fêmea";
            this.radioButtonfemea.UseVisualStyleBackColor = true;
            // 
            // textBoxnomea
            // 
            this.textBoxnomea.Location = new System.Drawing.Point(194, 31);
            this.textBoxnomea.Name = "textBoxnomea";
            this.textBoxnomea.Size = new System.Drawing.Size(134, 20);
            this.textBoxnomea.TabIndex = 2;
            // 
            // comboBoxraca
            // 
            this.comboBoxraca.FormattingEnabled = true;
            this.comboBoxraca.Items.AddRange(new object[] {
            "Pinscher",
            "Golden",
            "Pitbull",
            "Bulldog"});
            this.comboBoxraca.Location = new System.Drawing.Point(194, 64);
            this.comboBoxraca.Name = "comboBoxraca";
            this.comboBoxraca.Size = new System.Drawing.Size(134, 21);
            this.comboBoxraca.TabIndex = 3;
            // 
            // comboBoxespecie
            // 
            this.comboBoxespecie.FormattingEnabled = true;
            this.comboBoxespecie.Items.AddRange(new object[] {
            "Cachorro",
            "Gato"});
            this.comboBoxespecie.Location = new System.Drawing.Point(194, 100);
            this.comboBoxespecie.Name = "comboBoxespecie";
            this.comboBoxespecie.Size = new System.Drawing.Size(134, 21);
            this.comboBoxespecie.TabIndex = 4;
            // 
            // groupBoxsituacao
            // 
            this.groupBoxsituacao.Controls.Add(this.checkBoxpedigree);
            this.groupBoxsituacao.Controls.Add(this.checkBoxcastrado);
            this.groupBoxsituacao.Controls.Add(this.checkBoxvacinado);
            this.groupBoxsituacao.Location = new System.Drawing.Point(180, 144);
            this.groupBoxsituacao.Name = "groupBoxsituacao";
            this.groupBoxsituacao.Size = new System.Drawing.Size(255, 100);
            this.groupBoxsituacao.TabIndex = 5;
            this.groupBoxsituacao.TabStop = false;
            this.groupBoxsituacao.Text = "Situação";
            // 
            // checkBoxvacinado
            // 
            this.checkBoxvacinado.AutoSize = true;
            this.checkBoxvacinado.Location = new System.Drawing.Point(36, 30);
            this.checkBoxvacinado.Name = "checkBoxvacinado";
            this.checkBoxvacinado.Size = new System.Drawing.Size(71, 17);
            this.checkBoxvacinado.TabIndex = 0;
            this.checkBoxvacinado.Text = "Vacinado";
            this.checkBoxvacinado.UseVisualStyleBackColor = true;
            // 
            // checkBoxcastrado
            // 
            this.checkBoxcastrado.AutoSize = true;
            this.checkBoxcastrado.Location = new System.Drawing.Point(36, 67);
            this.checkBoxcastrado.Name = "checkBoxcastrado";
            this.checkBoxcastrado.Size = new System.Drawing.Size(68, 17);
            this.checkBoxcastrado.TabIndex = 1;
            this.checkBoxcastrado.Text = "Castrado";
            this.checkBoxcastrado.UseVisualStyleBackColor = true;
            // 
            // checkBoxpedigree
            // 
            this.checkBoxpedigree.AutoSize = true;
            this.checkBoxpedigree.Location = new System.Drawing.Point(139, 47);
            this.checkBoxpedigree.Name = "checkBoxpedigree";
            this.checkBoxpedigree.Size = new System.Drawing.Size(68, 17);
            this.checkBoxpedigree.TabIndex = 2;
            this.checkBoxpedigree.Text = "Pedigree";
            this.checkBoxpedigree.UseVisualStyleBackColor = true;
            // 
            // groupBoxpelo
            // 
            this.groupBoxpelo.Controls.Add(this.radioButtonlongo);
            this.groupBoxpelo.Controls.Add(this.radioButtoncurto);
            this.groupBoxpelo.Location = new System.Drawing.Point(488, 144);
            this.groupBoxpelo.Name = "groupBoxpelo";
            this.groupBoxpelo.Size = new System.Drawing.Size(200, 100);
            this.groupBoxpelo.TabIndex = 6;
            this.groupBoxpelo.TabStop = false;
            this.groupBoxpelo.Text = "Pelo";
            // 
            // radioButtoncurto
            // 
            this.radioButtoncurto.AutoSize = true;
            this.radioButtoncurto.Location = new System.Drawing.Point(23, 33);
            this.radioButtoncurto.Name = "radioButtoncurto";
            this.radioButtoncurto.Size = new System.Drawing.Size(50, 17);
            this.radioButtoncurto.TabIndex = 0;
            this.radioButtoncurto.TabStop = true;
            this.radioButtoncurto.Text = "Curto";
            this.radioButtoncurto.UseVisualStyleBackColor = true;
            // 
            // radioButtonlongo
            // 
            this.radioButtonlongo.AutoSize = true;
            this.radioButtonlongo.Location = new System.Drawing.Point(115, 66);
            this.radioButtonlongo.Name = "radioButtonlongo";
            this.radioButtonlongo.Size = new System.Drawing.Size(55, 17);
            this.radioButtonlongo.TabIndex = 1;
            this.radioButtonlongo.TabStop = true;
            this.radioButtonlongo.Text = "Longo";
            this.radioButtonlongo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Peso:";
            // 
            // textBoxpeso
            // 
            this.textBoxpeso.Location = new System.Drawing.Point(476, 64);
            this.textBoxpeso.Name = "textBoxpeso";
            this.textBoxpeso.Size = new System.Drawing.Size(134, 20);
            this.textBoxpeso.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data de Nascimento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(476, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // buttoncadastrar
            // 
            this.buttoncadastrar.Location = new System.Drawing.Point(160, 270);
            this.buttoncadastrar.Name = "buttoncadastrar";
            this.buttoncadastrar.Size = new System.Drawing.Size(127, 46);
            this.buttoncadastrar.TabIndex = 11;
            this.buttoncadastrar.Text = "Cadastrar";
            this.buttoncadastrar.UseVisualStyleBackColor = true;
            this.buttoncadastrar.Click += new System.EventHandler(this.buttoncadastrar_Click);
            // 
            // buttonalterar
            // 
            this.buttonalterar.Location = new System.Drawing.Point(320, 270);
            this.buttonalterar.Name = "buttonalterar";
            this.buttonalterar.Size = new System.Drawing.Size(127, 46);
            this.buttonalterar.TabIndex = 12;
            this.buttonalterar.Text = "Alterar";
            this.buttonalterar.UseVisualStyleBackColor = true;
            this.buttonalterar.Click += new System.EventHandler(this.buttonalterar_Click);
            // 
            // buttonexcluir
            // 
            this.buttonexcluir.Location = new System.Drawing.Point(476, 270);
            this.buttonexcluir.Name = "buttonexcluir";
            this.buttonexcluir.Size = new System.Drawing.Size(127, 46);
            this.buttonexcluir.TabIndex = 13;
            this.buttonexcluir.Text = "Excluir";
            this.buttonexcluir.UseVisualStyleBackColor = true;
            this.buttonexcluir.Click += new System.EventHandler(this.buttonexcluir_Click);
            // 
            // dataGridViewpets
            // 
            this.dataGridViewpets.AllowUserToAddRows = false;
            this.dataGridViewpets.AllowUserToDeleteRows = false;
            this.dataGridViewpets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpets.Location = new System.Drawing.Point(12, 338);
            this.dataGridViewpets.Name = "dataGridViewpets";
            this.dataGridViewpets.ReadOnly = true;
            this.dataGridViewpets.Size = new System.Drawing.Size(1068, 226);
            this.dataGridViewpets.TabIndex = 14;
            this.dataGridViewpets.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewpets_CellMouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(721, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Idade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(724, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 31);
            this.label7.TabIndex = 16;
            this.label7.Text = "8";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 576);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewpets);
            this.Controls.Add(this.buttonexcluir);
            this.Controls.Add(this.buttonalterar);
            this.Controls.Add(this.buttoncadastrar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxpeso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBoxpelo);
            this.Controls.Add(this.groupBoxsituacao);
            this.Controls.Add(this.comboBoxespecie);
            this.Controls.Add(this.comboBoxraca);
            this.Controls.Add(this.textBoxnomea);
            this.Controls.Add(this.groupBoxgeneros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.groupBoxgeneros.ResumeLayout(false);
            this.groupBoxgeneros.PerformLayout();
            this.groupBoxsituacao.ResumeLayout(false);
            this.groupBoxsituacao.PerformLayout();
            this.groupBoxpelo.ResumeLayout(false);
            this.groupBoxpelo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxgeneros;
        private System.Windows.Forms.RadioButton radioButtonfemea;
        private System.Windows.Forms.RadioButton radioButtonmacho;
        private System.Windows.Forms.TextBox textBoxnomea;
        private System.Windows.Forms.ComboBox comboBoxraca;
        private System.Windows.Forms.ComboBox comboBoxespecie;
        private System.Windows.Forms.GroupBox groupBoxsituacao;
        private System.Windows.Forms.CheckBox checkBoxpedigree;
        private System.Windows.Forms.CheckBox checkBoxcastrado;
        private System.Windows.Forms.CheckBox checkBoxvacinado;
        private System.Windows.Forms.GroupBox groupBoxpelo;
        private System.Windows.Forms.RadioButton radioButtonlongo;
        private System.Windows.Forms.RadioButton radioButtoncurto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxpeso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttoncadastrar;
        private System.Windows.Forms.Button buttonalterar;
        private System.Windows.Forms.Button buttonexcluir;
        private System.Windows.Forms.DataGridView dataGridViewpets;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

