using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ParcialFinal.Controlador;

namespace ParcialFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var Registro = new Register();
            Registro.Show();
        }

        private void bttLogin_Click(object sender, EventArgs e)
        {
            var dt = DBConnection.ExecuteQuery("select nombre from USUARIO");
            MessageBox.Show(dt.Rows[0].ToString());
            List<string> ListN = new List<string>();
            
            foreach (DataRow Name in dt.Rows)
            {
                ListN.Add(Name[0].ToString());
            }

            foreach (string name in ListN)
            {
                if (name != txtUser.Text)
                {
                    MessageBox.Show("Debe registrarse para iniciar sesión!");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}