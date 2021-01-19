using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseMySQL
{
    public interface Ipessoa
    {
        void SetNome(string _nome);
        void SetTelefone(string _telefone);
        void SetCPF(string _CPF);
        void Gravar();
    }
}
