using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;


namespace proiect
{

    public abstract class Data_base
    {
        public abstract void add();
    
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
    }

    public class Add_orar:Data_base
    {

        public string nume { get; set; }
        public string prenume { get; set; }

        public string stomatolog {  get; set; }
        public string ora { get; set; }
        public string nr_telefon { get; set; }
        public string procedura { get; set; }

        public string data {  get; set; }

        public string oradata { get; set; }



        public void get_data(string stomatolog_,string surname, string name,string ora_,string nr_telefon_, string procedura_,string data_, string oradata_)
        {
            stomatolog = stomatolog_;
            nume = surname;
            prenume = name;
            ora = ora_;
            nr_telefon = nr_telefon_;
            procedura = procedura_;
            data = data_;
            oradata = oradata_;
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



}

