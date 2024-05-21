using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect
{
    public interface IAppointment
    {
        string GetStomatolog();
        string GetNume();
        string GetPrenume();
        string GetOra();
        string GetNrTelefon();
        string GetProcedura();
        string GetData();
        string GetOraData();
    }
}
