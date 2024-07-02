using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace GenerarCHeque
{
    public class Conexion
    {
        //atributos: describen el estado de un objeto(variables)
        private string Servidor;
        private string Base; //Para el nombre de la base de datos
        private string Usuario;
        private string Clave;
        private bool Seguridad; //permite establecer el metodo de autenticacion de Windows para conectarnos a sql

        //Un singleTon: para declarar una sola instancia de una clase
        //Para que la clase se autoInstancie 
        private static Conexion con = null;

        //constructor: cuando necesito pasarle valores iniciales a una clase. (para inicializar una conexion)
        private Conexion()
        {
            this.Base = "dbCheques";
            this.Servidor = "DESKTOP-066J2C5\\SQLEXPRESS";
            this.Usuario = "sa";
            this.Clave = "";
            this.Seguridad = true;//true = porque se esta usando Windows authentication
        }

        //metodo para poder inicializar la conexion, que devuelve el string de conexion = cadena
        public SqlConnection CrearConnexion()
        {
            SqlConnection Cadena = new SqlConnection(); //cadena es una variable (string de conexion)
            try
            {
                //crear cadena de conexion
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";
                //validar el tipo de seguridad usando en la conexion
                if (this.Seguridad) //=true
                {
                    Cadena.ConnectionString += "Integrated Security = SSPI"; //metodo de authentication de windows
                    //+= porque esta parte se va agregar a la cadena.ConnectionString del de arriba
                }
                else //si no esta conectado con windows; seguridad = false (que esta conectado con sql authentication)
                {
                    Cadena.ConnectionString += "User Id =" + this.Usuario + ";Password=" + this.Clave;
                }
            }
            catch (Exception ex)// en caso de que no se haga la conexion con db
            {
                Cadena = null; //para que marque que no hay una cadena
                throw ex; //mostrar un mensaje con el error encontrado
            }
            return Cadena;
        }
        //metodo para generar una instancia al constructor dentro de esta clase
        //para asignarle valores a las variables privadas que hay en el constructor
        public static Conexion getInstancia()
        {
            if (con == null) //significa que no hay conexion
            {
                con = new Conexion(); //para que cree otra conexion
            }
            return con;

        }

        //ojo
        public int InsertarCheque(string companyName, float amount, string payTheOrderOf, string memo)
        {
            int idcheck = 0;
            using (SqlConnection conexion = CrearConnexion())
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO cheque (company_name, date_check, amount, pay_the_order_of, memo) OUTPUT INSERTED.idcheck VALUES (@companyName, GETDATE(), @amount, @payTheOrderOf, @memo)", conexion))
                {
                    cmd.Parameters.AddWithValue("@companyName", companyName);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cmd.Parameters.AddWithValue("@payTheOrderOf", payTheOrderOf);
                    cmd.Parameters.AddWithValue("@memo", memo);

                    idcheck = (int)cmd.ExecuteScalar();  // Obtener el valor de idcheck generado
                }
            }
            return idcheck;
        }
    }
}
