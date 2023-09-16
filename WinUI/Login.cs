using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.Text;

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

        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convierte los bytes hash en una cadena hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public bool VerifyPassword(string enteredPassword, string storedHashedPassword)
        {
            string enteredPasswordHash = HashPassword(enteredPassword);
            return enteredPasswordHash == storedHashedPassword;
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
            string username = tbUser.Text;
            string enteredPassword = tbPass.Text;

            string storedHashedPassword = logica.GetStoredPasswordHash(username);

            if (VerifyPassword(enteredPassword, storedHashedPassword))
            {
                // Contraseña correcta, inicia sesión
                FormMenu form = new FormMenu();
                form.Show();
            }
            else
            {
                // Contraseña incorrecta, muestra un mensaje de error
                MessageBox.Show("Contraseña incorrecta. Intenta de nuevo.");
            }
        }
    }
}
