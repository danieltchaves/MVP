using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    public class ClienteModel
    {
        public int Id { get; }
        public string Nome { get; }

        ClienteModel(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
