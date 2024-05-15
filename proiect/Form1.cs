using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            show();
        }

        private void comboBox1_Stomatolog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void show()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-9OBO5BD;Initial Catalog = TMPP; Integrated Security = True;Encrypt=False"))
            {
                string Query = "SELECT * FROM Orar";
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    // Fill the DataTable with data from the database
                    dataAdapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        

        private void button1_Click(object sender, EventArgs e)
        {


            Stomatolog stomatolog = new Stomatolog();
            Nume nume = new Nume();
            Prenume prenume = new Prenume();
            Nr_telefon nr_Telefon = new Nr_telefon();
            Ora ora = new Ora();
            Procedura procedura = new Procedura();
            Data data = new Data();


            if (comboBox1_Stomatolog.Text == "" || textBox1_Nume.Text == "" || textBox2_Prenume.Text == "" || textBox3_Nr_telefon.Text == "" || comboBox2_Procedura.Text == "" || comboBox1_ora.Text == "")
            {
                MessageBox.Show("Completeaza toate campurile");
            }
            else
            {
                stomatolog.add(comboBox1_Stomatolog.Text);
                nume.add(textBox1_Nume.Text);
                prenume.add(textBox2_Prenume.Text);
                nr_Telefon.add(textBox3_Nr_telefon.Text);
                ora.add(comboBox1_ora.Text);
                procedura.add(comboBox2_Procedura.Text);
                data.add(monthCalendar1.SelectionRange.Start.ToShortDateString());




                Add_orar adaugarebd = new Add_orar();
                adaugarebd.get_data(stomatolog.Stomatolog_, nume.Nume_, prenume.Prenume_, ora.Ora_, nr_Telefon.Nr_telefon_, procedura.Procedura_, data.Data_);
                adaugarebd.add();
                show();
            }



        }

        private void textBox2_Prenume_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Nume_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Nr_telefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_Procedura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                MessageBox.Show($"Index of selected row: {rowIndex}");

                // Șterge rândul din DataGridView
                dataGridView1.Rows.RemoveAt(rowIndex);

                // Construiește interogarea SQL pentru a șterge rândul din baza de date
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-9OBO5BD;Initial Catalog=TMPP;Integrated Security=True;Encrypt=False"))
                {
                    connection.Open();

                  
                    int idToDelete = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Id"].Value);

                    string query = "DELETE FROM Orar WHERE ID = @ID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", idToDelete);

                    // Execută comanda SQL de ștergere
                    command.ExecuteNonQuery();
                }
            }
        }

    }




}
