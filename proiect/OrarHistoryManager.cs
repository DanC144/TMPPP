using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    public class OrarHistoryManager
    {
        private readonly string _connectionString;

        public OrarHistoryManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddHistoryEntry(Add_orar appointment)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string Query = "INSERT INTO OrarHistory (Ora, Stomatolog, Procedura, Nume, Prenume, Data, Nr_telefon, OraData) VALUES (@Ora, @Stomatolog, @Procedura, @Nume, @Prenume, @Data, @Nr_telefon, @OraData)";
                SqlCommand command = new SqlCommand(Query, connection);

                command.Parameters.AddWithValue("@Ora", appointment.ora);
                command.Parameters.AddWithValue("@Stomatolog", appointment.stomatolog);
                command.Parameters.AddWithValue("@Procedura", appointment.procedura);
                command.Parameters.AddWithValue("@Nume", appointment.nume);
                command.Parameters.AddWithValue("@Prenume", appointment.prenume);
                command.Parameters.AddWithValue("@Data", appointment.data);
                command.Parameters.AddWithValue("@Nr_telefon", appointment.nr_telefon);
                command.Parameters.AddWithValue("@OraData", appointment.oradata);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Add_orar> GetHistoryEntries()
        {
            List<Add_orar> historyEntries = new List<Add_orar>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string Query = "SELECT * FROM OrarHistory";
                SqlCommand command = new SqlCommand(Query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Add_orar historyEntry = new Add_orar
                    {
                        ora = reader["Ora"].ToString(),
                        stomatolog = reader["Stomatolog"].ToString(),
                        procedura = reader["Procedura"].ToString(),
                        nume = reader["Nume"].ToString(),
                        prenume = reader["Prenume"].ToString(),
                        data = reader["Data"].ToString(),
                        nr_telefon = reader["Nr_telefon"].ToString(),
                        oradata = reader["OraData"].ToString()
                    };

                    historyEntries.Add(historyEntry);
                }
            }

            return historyEntries;
        }

        public void ClearHistory()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string Query = "DELETE FROM OrarHistory";
                SqlCommand command = new SqlCommand(Query, connection);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void RestoreFromHistory(Add_orar appointment)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string Query = "INSERT INTO SavedTable (Ora, Stomatolog, Procedura, Nume, Prenume, Data, Nr_telefon, OraData) VALUES (@Ora, @Stomatolog, @Procedura, @Nume, @Prenume, @Data, @Nr_telefon, @OraData)";
                SqlCommand command = new SqlCommand(Query, connection);

                command.Parameters.AddWithValue("@Ora", appointment.ora);
                command.Parameters.AddWithValue("@Stomatolog", appointment.stomatolog);
                command.Parameters.AddWithValue("@Procedura", appointment.procedura);
                command.Parameters.AddWithValue("@Nume", appointment.nume);
                command.Parameters.AddWithValue("@Prenume", appointment.prenume);
                command.Parameters.AddWithValue("@Data", appointment.data);
                command.Parameters.AddWithValue("@Nr_telefon", appointment.nr_telefon);
                command.Parameters.AddWithValue("@OraData", appointment.oradata);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
