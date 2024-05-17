using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proiect
{
    public sealed partial class Form1 : Form
    {
        // Private static instance of the same class that is the only instance of the class.
        private static readonly Lazy<Form1> lazy = new Lazy<Form1>(() => new Form1());

        // Public static property to get the instance.
        public static Form1 Instance => lazy.Value;

        private readonly OrarHistoryManager _orarHistoryManager;

        // Private constructor to prevent direct instantiation.
        private Form1()
        {
            InitializeComponent();
            _orarHistoryManager = new OrarHistoryManager(@"Data Source=DESKTOP-9OBO5BD;Initial Catalog=TMPP;Integrated Security=True;Encrypt=False");
            show();
        }

        private void comboBox1_Stomatolog_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        void show()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-9OBO5BD;Initial Catalog=TMPP;Integrated Security=True;Encrypt=False"))
            {
                string Query = "SELECT * FROM Orar";
                SqlCommand command = new SqlCommand(Query, connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                try
                {
                    connection.Open();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ExportToExcelAndClone(Add_orar originalAppointment)
        {
            // Clone the original appointment
            Add_orar clonedAppointment = (Add_orar)originalAppointment.Clone();

            // Export the cloned appointment to Excel
            clonedAppointment.ExportToExcel();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1_Stomatolog.Text == "" || textBox1_Nume.Text == "" || textBox2_Prenume.Text == "" || textBox3_Nr_telefon.Text == "" || comboBox2_Procedura.Text == "" || comboBox1_ora.Text == "")
            {
                MessageBox.Show("Completeaza toate campurile");
            }
            else
            {
                AddOrarBuilder builder = new AddOrarBuilder();
                Add_orar appointment = builder
                    .WithStomatolog(comboBox1_Stomatolog.Text)
                    .WithNume(textBox1_Nume.Text)
                    .WithPrenume(textBox2_Prenume.Text)
                    .WithNr_Telefon(textBox3_Nr_telefon.Text)
                    .WithOra(comboBox1_ora.Text)
                    .WithProcedura(comboBox2_Procedura.Text)
                    .WithData(monthCalendar1.SelectionRange.Start.ToShortDateString())
                    .WithOradata(comboBox1_ora.Text + monthCalendar1.SelectionRange.Start.ToShortDateString())
                    .Build();

                AddAppointmentToDatabase(appointment);
                show(); // Refresh the DataGridView
                ExportToExcelAndClone(appointment); // Export clone to Excel
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

                // Delete the row from the DataGridView
                dataGridView1.Rows.RemoveAt(rowIndex);

                // Delete the row from the database
                DeleteAppointmentFromDatabase(rowIndex);
            }
        }

        private void AddAppointmentToDatabase(Add_orar appointment)
        {
            AppointmentDatabaseManager manager = new AppointmentDatabaseManager();
            manager.AddAppointmentToDatabase(appointment);
        }

        private void DeleteAppointmentFromDatabase(int rowIndex)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-9OBO5BD;Initial Catalog=TMPP;Integrated Security=True;Encrypt=False"))
            {
                connection.Open();

                int idToDelete = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Id"].Value);
                idToDelete = idToDelete - 1;
                string query = "DELETE FROM Orar WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", idToDelete);

                command.ExecuteNonQuery();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            _orarHistoryManager.RestoreFromHistory();
            show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            _orarHistoryManager.AddHistoryEntry();
            show();
        }

    }
}
