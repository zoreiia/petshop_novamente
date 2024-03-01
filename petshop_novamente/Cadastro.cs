using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace petshop_novamente
{
    public partial class Cadastro : Form
    {

        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        string pelo;
        string castrado;
        string pedigree;
        string vacinado;
        string genero;
        string id;


        public Cadastro()
        {
            servidor = "Server=localhost;Database=bdpetshop;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            InitializeComponent();
            atualiza_lista();
        }

        private void limpar()
        {
            textBoxnomea.Clear(); radioButtoncurto.Checked = false; radioButtonfemea.Checked = false; radioButtonlongo.Checked = false; radioButtonmacho.Checked = false; textBoxpeso.Clear(); checkBoxcastrado.Checked = false; checkBoxpedigree.Checked = false; checkBoxvacinado.Checked = false;
        }


        private void atualiza_lista()
        {
            try
            {

                conexao.Open();

                comando.CommandText = "SELECT * FROM tbl_pets;";
                MySqlDataAdapter adaptadoruser = new MySqlDataAdapter(comando);
                DataTable tabelauser = new DataTable();
                adaptadoruser.Fill(tabelauser);
                dataGridViewpets.DataSource = tabelauser;



            }
            catch (Exception erro_mysql)
            {

                MessageBox.Show(erro_mysql.Message);
                //MessageBox.Show("Erro de Sistema. Informe o suporte");
            }
            finally
            {

                conexao.Close();
            }



        }



        private void buttoncadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //dateTimePicker1.Format = DateTimePickerFormat.Custom;
                //dateTimePicker1.CustomFormat = "yyyy-MM-dd";


                if (radioButtonmacho.Checked)
                {
                    genero = "Macho";
                }
                else
                {
                    genero = "Fêmea";
                }

                if (radioButtonlongo.Checked)
                {
                    pelo = "Longo";
                }
                else
                {
                    pelo = "Curto";
                }

                if (checkBoxvacinado.Checked)
                {
                    vacinado = "Sim";
                }
                else
                {
                    vacinado = "Não";
                }

                if (checkBoxcastrado.Checked)
                {
                    castrado = "Sim";
                }
                else
                {
                    castrado = "Não";
                }

                if (checkBoxpedigree.Checked)
                {
                    pedigree = "Sim";
                }
                else
                {
                    pedigree = "Não";
                }

                if (textBoxnomea.Text != "")
                {
                    conexao.Open();
                    comando.CommandText = "INSERT INTO tbl_pets(nomepet,raca,especie,genero,data,peso,pelo,vacinado,castrado,pedigree) VALUES('" + textBoxnomea.Text + "', '" + comboBoxraca.Text + "', '" + comboBoxespecie.Text + "', '" + genero + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', '" + textBoxpeso.Text + "', '" + pelo + "', '" + vacinado + "', '" + castrado + "', '" + pedigree + "');";
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastrado");

                }
                else
                {
                    MessageBox.Show("Campo Nome obrigatório.");
                }


            }
            catch (Exception erro_mysql)
            {
                MessageBox.Show(erro_mysql.Message);
                //MessageBox.Show("Erro de Sistema. Informe o suporte");
            }
            finally
            {
                conexao.Close();
            }
            atualiza_lista();
            limpar();
        }

        private void buttonexcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Continuar?", "Atenção!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                try
                {

                    conexao.Open();
                    comando.CommandText = "DELETE FROM tbl_pets WHERE id = " + id + ";";
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Pet(s) Removido(s) com Sucesso! - " + resultado + "Registros Removidos...");
                    }
                    else
                    {
                        MessageBox.Show("Pet não encontrado");
                    }

                }
                catch (Exception erro_mysql)
                {

                    MessageBox.Show("Erro de Sistema. Informe o suporte");

                }
                finally
                {

                    conexao.Close();

                }
                atualiza_lista();
                limpar();
            }
            else
            {
                MessageBox.Show("Cancelado");
            }
        }


        private void buttonalterar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Continuar?", "Atenção!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (radioButtonmacho.Checked)
                {
                    genero = "Macho";
                }
                else
                {
                    genero = "Fêmea";
                }

                if (radioButtonlongo.Checked)
                {
                    pelo = "Longo";
                }
                else
                {
                    pelo = "Curto";
                }

                if (checkBoxvacinado.Checked)
                {
                    vacinado = "Sim";
                }
                else
                {
                    vacinado = "Não";
                }

                if (checkBoxcastrado.Checked)
                {
                    castrado = "Sim";
                }
                else
                {
                    castrado = "Não";
                }

                if (checkBoxpedigree.Checked)
                {
                    pedigree = "Sim";
                }
                else
                {
                    pedigree = "Não";
                }


                try
                {

                    conexao.Open();
                    comando.CommandText = "UPDATE tbl_pets SET nomepet = '" + textBoxnomea.Text + "', raca = '" + comboBoxraca.Text + "', especie = '" + comboBoxespecie.Text + "', genero = '" + genero + "', data = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "', peso = '" + textBoxpeso.Text + "', pelo = '" + pelo + "', vacinado = '" + vacinado + "', castrado = '" + castrado + "', pedigree = '" + pedigree + "' WHERE  id = " + id + ";";
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Contato(s) Atualizado(s) com Sucesso! - " + resultado + " Registro(s) Alterado(s)...");
                    }
                    else
                    {
                        MessageBox.Show("Contato não encontrado");
                    }

                }
                catch (Exception erro_mysql)
                {

                    MessageBox.Show(erro_mysql.Message);

                }
                finally
                {

                    conexao.Close();

                }
                atualiza_lista();
                limpar();
            }
            else
            {
                MessageBox.Show("Cancelado");
            }
        }

        private void dataGridViewpets_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewpets.CurrentRow.Cells[4].Value.ToString() == "Macho")
            {
                radioButtonmacho.Checked = true;
            }
            else
            {
                radioButtonfemea.Checked = true;
            }

            id = dataGridViewpets.CurrentRow.Cells[0].Value.ToString();
            textBoxnomea.Text = dataGridViewpets.CurrentRow.Cells[1].Value.ToString();
            comboBoxraca.Text = dataGridViewpets.CurrentRow.Cells[2].Value.ToString();
            comboBoxespecie.Text = dataGridViewpets.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridViewpets.CurrentRow.Cells[5].Value.ToString();
            textBoxpeso.Text = dataGridViewpets.CurrentRow.Cells[6].Value.ToString();

            if (dataGridViewpets.CurrentRow.Cells[7].Value.ToString() == "Longo")
            {
                radioButtonlongo.Checked = true;
            }
            else
            {
                radioButtoncurto.Checked = true;
            }

            if (dataGridViewpets.CurrentRow.Cells[8].Value.ToString() == "Sim")
            {
                checkBoxvacinado.Checked = true;
            }
            else
            {
                checkBoxvacinado.Checked = false;
            }

            if (dataGridViewpets.CurrentRow.Cells[9].Value.ToString() == "Sim")
            {
                checkBoxcastrado.Checked = true;
            }
            else
            {
                checkBoxcastrado.Checked = false;
            }

            if (dataGridViewpets.CurrentRow.Cells[10].Value.ToString() == "Sim")
            {
                checkBoxpedigree.Checked = true;
            }
            else
            {
                checkBoxpedigree.Checked = false;
            }

        }
       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label7.Text = (DateTime.Now - dateTimePicker1.Value).ToString();
            TimeSpan idade = DateTime.Now - dateTimePicker1.Value;
            label7.Text = (idade.TotalDays/365).ToString("00");
            
        }
    }
}
