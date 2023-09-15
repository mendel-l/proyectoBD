using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BLL; //invocamos la logica del negocio

namespace WinUI
{
    public partial class Persona : Form
    {
        ClassLogicaPersona logica = new ClassLogicaPersona(); //se crea un objeto 
        public Persona()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logica.ListarPersonas(); //carga los datos
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona form = new Persona();
            this.Show();
        }
    }
}
