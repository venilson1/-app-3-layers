using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseMySQL
{
    public class Base : Ipessoa
    {
        //propriedades
        public string Nome;
        public string Telefone;
        public string CPF;

        public Base(string _nome, string _telefone, string _CPF)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.CPF = _CPF;
        }

        public Base() { }

        public void SetNome(string _nome)
        {
            this.Nome = _nome;
        }
        public void SetTelefone(string _telefone)
        {
            this.Telefone = _telefone;
        }
        public void SetCPF(string _CPF)
        {
            this.CPF = _CPF;
        }

        public virtual void Gravar()
        {
            String connectionString = ConfigurationManager.AppSettings["MySqlConnection"];
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            MySqlCommand command = new MySqlCommand(
                    "insert into " + this.GetType().Name + "s (" +
                    "ID, " +
                    "telefone, " +
                    "cpf) " +
                    "values('" + this.Nome + "', '" + this.Telefone + "', '" + this.CPF + "')", connection);

            command.ExecuteNonQuery();
            connection.Close();
            command.Parameters.Clear();
        }
    }
}
