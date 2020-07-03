using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ParcialFinal.Controlador;

namespace ParcialFinal
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {    
            string card;
            string name;
            string lastName;
            string password;
            string dui;
            string dateBirth;

            name = textBox1.Text;
            lastName = textBox2.Text;
            dui = textBox3.Text;
            card = textBox4.Text;
            dateBirth = textBox5.Text;
            password = textBox6.Text;
            string idDep = "";
            
            var dt = DBConnection.ExecuteQuery($"SELECT 'idDepartamento' FROM 'DEPARTAMENTO'");
            foreach (DataRow row in dt.Rows)
            {
                idDep = row[0].ToString();
            }
            
             DBConnection.ExecuteNonQuery(
                $"INSERT INTO USUARIO (idDepartamento, idUsuario, contraseña, nombre, apellido, dui, fechaNacimiento) " +
                $"VALUES('{idDep}','{card}', '{password}', '{name}', '{lastName}', '{dui}', '{dateBirth}')");
             
             MessageBox.Show("Ha sido registrado exitosamente!");
             
             var Login = new Form1();
        }
    }
}