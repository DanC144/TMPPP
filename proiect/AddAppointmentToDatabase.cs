using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using proiect;

namespace proiect
{
    public class AppointmentDatabaseManager
    {
        public void AddAppointmentToDatabase(Add_orar appointment)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-9OBO5BD;Initial Catalog=TMPP;Integrated Security=True;Encrypt=False"))
            {
                string query = "INSERT INTO Orar (Ora, Stomatolog, Procedura, Nume, Prenume, Data, Nr_telefon, OraData) " +
                               "VALUES (@Ora, @Stomatolog, @Procedura, @Nume, @Prenume, @Data, @Nr_telefon, @OraData)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Ora", appointment.ora);
                    command.Parameters.AddWithValue("@Stomatolog", appointment.stomatolog);
                    command.Parameters.AddWithValue("@Procedura", appointment.procedura);
                    command.Parameters.AddWithValue("@Nume", appointment.nume);
                    command.Parameters.AddWithValue("@Prenume", appointment.prenume);
                    command.Parameters.AddWithValue("@Data", appointment.data);
                    command.Parameters.AddWithValue("@Nr_telefon", appointment.nr_telefon);
                    command.Parameters.AddWithValue("@OraData", appointment.oradata);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
