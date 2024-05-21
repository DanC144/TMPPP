using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using proiect;

namespace proiect
{
    public class AppointmentDatabaseManager
    {
        public void AddAppointmentToDatabase(IAppointment appointment)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-9OBO5BD;Initial Catalog=TMPP;Integrated Security=True;Encrypt=False"))
            {
                string query = "INSERT INTO Orar (Ora, Stomatolog, Procedura, Nume, Prenume, Data, Nr_telefon, OraData) " +
                               "VALUES (@Ora, @Stomatolog, @Procedura, @Nume, @Prenume, @Data, @Nr_telefon, @OraData)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Ora", appointment.GetOra());
                    command.Parameters.AddWithValue("@Stomatolog", appointment.GetStomatolog());
                    command.Parameters.AddWithValue("@Procedura", appointment.GetProcedura());
                    command.Parameters.AddWithValue("@Nume", appointment.GetNume());
                    command.Parameters.AddWithValue("@Prenume", appointment.GetPrenume());
                    command.Parameters.AddWithValue("@Data", appointment.GetData());
                    command.Parameters.AddWithValue("@Nr_telefon", appointment.GetNrTelefon());
                    command.Parameters.AddWithValue("@OraData", appointment.GetOraData());

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
