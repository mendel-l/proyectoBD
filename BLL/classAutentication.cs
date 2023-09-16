using DAL.DataSet2TableAdapters;
using System;

namespace BLL
{
    internal class Hashpassword
    {
        private UsuarioTableAdapter usuario = null;
        private UsuarioTableAdapter Usuario
        {
            get
            {
                if (usuario == null)
                {
                    usuario = new UsuarioTableAdapter();
                }

                return usuario;
            }
        }

        public string VerifyPassword(string usuario, string password)
        {
            var userData = Usuario.GetDataUser(usuario);/*
            Console.WriteLine(userData[0][2].ToString() + userData[0][3].ToString());*/
            try
            {
                if (userData.Rows.Count == 1)
                {
                    string savedHash = userData.Rows[0][2].ToString();
                    string sal = userData.Rows[0][3].ToString();
                    string generateHash = BCrypt.Net.BCrypt.HashPassword(password, sal);
                    if (generateHash == savedHash)
                    {
                        string nivelAcceso = userData.Rows[0][5].ToString();
                        return nivelAcceso;
                    }
                    else
                    {
                        /*Console.WriteLine("Hash diferente");*/
                        return "Invalido";
                    }
                }

                /* Console.WriteLine();*/
                return "Invalido";

            }
            catch (Exception error)
            {
                return "Invalido:" + error.ToString();
            }

        }


    }

}
