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

        public void AddHistoryEntry()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string Query = "DELETE FROM OrarHistory";
                SqlCommand command = new SqlCommand(Query, connection);
                command.ExecuteNonQuery();
                Query = "INSERT INTO OrarHistory (Ora, Stomatolog, Procedura, Nume, Prenume, Data, Nr_telefon, OraData)  SELECT Ora, Stomatolog, Procedura, Nume, Prenume, Data, Nr_telefon, OraData FROM Orar ";
                command = new SqlCommand(Query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Snapshot saved");

            }
        }


        public void RestoreFromHistory()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string Query = "DELETE FROM Orar";
                SqlCommand command = new SqlCommand(Query, connection);
                command.ExecuteNonQuery();
                Query = "INSERT INTO Orar (Ora, Stomatolog, Procedura, Nume, Prenume, Data, Nr_telefon, OraData) SELECT Ora, Stomatolog, Procedura, Nume, Prenume, Data, Nr_telefon, OraData FROM OrarHistory ";
                command = new SqlCommand(Query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Restored");

            }
        }
    }
}
