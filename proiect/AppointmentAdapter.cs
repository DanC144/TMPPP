using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    public class AppointmentAdapter : IAppointment
    {
        private readonly Add_orar _addOrar;

        public AppointmentAdapter(Add_orar addOrar)
        {
            _addOrar = addOrar;
        }

        public string GetStomatolog() => _addOrar.stomatolog;
        public string GetNume() => _addOrar.nume;
        public string GetPrenume() => _addOrar.prenume;
        public string GetOra() => _addOrar.ora;
        public string GetNrTelefon() => _addOrar.nr_telefon;
        public string GetProcedura() => _addOrar.procedura;
        public string GetData() => _addOrar.data;
        public string GetOraData() => _addOrar.oradata;
    }
}
