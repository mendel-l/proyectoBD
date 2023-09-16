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
    public partial class Login : Form
    {
        ClassLogicaPersona logica = new ClassLogicaPersona(); //se crea un objeto 

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu form = new FormMenu();
            form.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void CreatAcc_Click(object sender, EventArgs e)
        {

        }

        private void InSesion_Click(object sender, EventArgs e)
        {

        }
    }
}
