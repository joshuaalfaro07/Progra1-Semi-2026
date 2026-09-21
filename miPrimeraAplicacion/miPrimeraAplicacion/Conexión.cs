using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;  //Esta libreria es para usar bases de datos
using System.Data.SqlClient; // Esta libreria permite usar SQLServer


namespace miPrimeraAplicacion
{
    class Conexión
    {
        //Definir los miembro, atributos y metodos de la clase
        public SqlConnection objConexion = new SqlConnection(); //Conectarme a la BD
        public SqlCommand objComando = new SqlCommand(); //Ejecutar consultas (Insert, update, delete, select) SQL en la BD
        public SqlDataAdapter objDataAdapter = new SqlDataAdapter(); //Un puente entre la BD y la aplicacion.
        DataSet ObjDs = new DataSet(); // Representa una copia en memoria de la arquitectura de la BD

        public Conexión() {// Constructor e inicializadorde los mienbros de la clase
            String cadenaCoenxion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
        
        }
    }
}
