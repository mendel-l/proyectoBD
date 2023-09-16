using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinUI
{
    public partial class CreateUSR : Form
    {
        Hashpassword autentication = new Hashpassword(); //se crea un objeto 

        public CreateUSR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Usuario = NomUsr.Text;
            string Contras = Contra.Text;
            string cContra = CContra.Text;
            string idpersona= TIDP.Text;
            string idrol = TIDR.Text;

            int IDROL = 0;
            int IDP = 0;

            int.TryParse(idpersona, out IDP);
            int.TryParse(idrol, out IDROL);

            autentication.crearUsuario(Usuario, Contras, IDP, IDROL);
        }
    }
}
