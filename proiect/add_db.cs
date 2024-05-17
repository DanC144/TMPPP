using OfficeOpenXml;
using System;
using System.Data.SqlClient;

namespace proiect
{
    public abstract class Data_base
    {
        public abstract void add();

    }
    public class Add_orar : Data_base, ICloneable
    {
        public string nume { get; set; }
        public string prenume { get; set; }
        public string stomatolog { get; set; }
        public string ora { get; set; }
        public string nr_telefon { get; set; }
        public string procedura { get; set; }
        public string data { get; set; }
        public string oradata { get; set; }

        // Constructor
        public Add_orar()
        {
        }

        // Copy constructor
        public Add_orar(Add_orar other)
        {
            nume = other.nume;
            prenume = other.prenume;
            stomatolog = other.stomatolog;
            ora = other.ora;
            nr_telefon = other.nr_telefon;
            procedura = other.procedura;
            data = other.data;
            oradata = other.oradata;
        }

        // Clone method
        public object Clone()
        {
            return new Add_orar(this);
        }

        public void ExportToExcel()
        {
            // Define a file path for the Excel file
            string filePath = "C:\\Users\\danax\\OneDrive\\Desktop\\gittt\\TMPPP\\Appointment.xlsx";

            // Create a new Excel package
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Add a new worksheet to the Excel package
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Appointments");

                // Define column headers
                worksheet.Cells["A1"].Value = "Stomatolog";
                worksheet.Cells["B1"].Value = "Nume";
                worksheet.Cells["C1"].Value = "Prenume";
                worksheet.Cells["D1"].Value = "Ora";
                worksheet.Cells["E1"].Value = "Nr Telefon";
                worksheet.Cells["F1"].Value = "Procedura";
                worksheet.Cells["G1"].Value = "Data";
                worksheet.Cells["H1"].Value = "Ora Data";

                // Populate data from the appointment object
                worksheet.Cells["A2"].Value = stomatolog;
                worksheet.Cells["B2"].Value = nume;
                worksheet.Cells["C2"].Value = prenume;
                worksheet.Cells["D2"].Value = ora;
                worksheet.Cells["E2"].Value = nr_telefon;
                worksheet.Cells["F2"].Value = procedura;
                worksheet.Cells["G2"].Value = data;
                worksheet.Cells["H2"].Value = oradata;

                // Save the Excel package to the file
                FileInfo excelFile = new FileInfo(filePath);
                excelPackage.SaveAs(excelFile);
            }
            MessageBox.Show("Appointment exported to Excel successfully!");
        }
        public override void add()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-9OBO5BD;Initial Catalog = TMPP; Integrated Security = True;Encrypt=False"))
            {
                string Query = "insert into Orar (Ora, Stomatolog, Procedura, Nume, Prenume, Data,Nr_telefon,OraData) values (@Ora, @Stomatolog, @Procedura, @Nume, @Prenume, @Data,@Nr_telefon,@OraData)";
                SqlCommand command = new SqlCommand(Query, connection);

                command.Parameters.AddWithValue("@Ora", ora);
                command.Parameters.AddWithValue("@Stomatolog", stomatolog);
                command.Parameters.AddWithValue("@Procedura", procedura);
                command.Parameters.AddWithValue("@Nume", nume);
                command.Parameters.AddWithValue("@Prenume", prenume);
                command.Parameters.AddWithValue("@Data", data);
                command.Parameters.AddWithValue("@Nr_telefon", nr_telefon);
                command.Parameters.AddWithValue("@OraData", oradata);







                try
                {

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();



                }
                catch (Exception ex)
                {

                    MessageBox.Show("Eroare: " + ex.Message);
                }
            }
        }
    }

    public class AddOrarBuilder
    {
        private Add_orar _addOrar = new Add_orar();

        public AddOrarBuilder WithNume(string nume)
        {
            _addOrar.nume = nume;
            return this;
        }

        public AddOrarBuilder WithPrenume(string prenume)
        {
            _addOrar.prenume = prenume;
            return this;
        }

        public AddOrarBuilder WithStomatolog(string stomatolog)
        {
            _addOrar.stomatolog = stomatolog;
            return this;
        }

        public AddOrarBuilder WithOra(string ora)
        {
            _addOrar.ora = ora;
            return this;
        }

        public AddOrarBuilder WithNr_Telefon(string nr_telefon)
        {
            _addOrar.nr_telefon = nr_telefon;
            return this;
        }

        public AddOrarBuilder WithProcedura(string procedura)
        {
            _addOrar.procedura = procedura;
            return this;
        }

        public AddOrarBuilder WithData(string data)
        {
            _addOrar.data = data;
            return this;
        }

        public AddOrarBuilder WithOradata(string oradata)
        {
            _addOrar.oradata = oradata;
            return this;
        }

        public Add_orar Build()
        {
            return _addOrar;
        }

        // Method to clone the current state of the builder
        public AddOrarBuilder CloneBuilder()
        {
            var clonedBuilder = new AddOrarBuilder();
            clonedBuilder._addOrar = (Add_orar)_addOrar.Clone();
            return clonedBuilder;
        }


    }
}
