using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.DataSet1TableAdapters; //usa el DAL
using System.Data; //usa el DATA TABLE

namespace BLL
{
    public class ClassLogicaPersona
    {
        //ATRIBUTOS
        private PersonaTableAdapter persona = null;

        //PROPIEDADES
        private PersonaTableAdapter PERSONA
        {
            get
            {
                if (persona == null)
                    persona = new PersonaTableAdapter();
                return persona;
            }
        }

        //METODOS
        public DataTable ListarPersonas()
        {
            return PERSONA.GetData();
        }

    }
}
