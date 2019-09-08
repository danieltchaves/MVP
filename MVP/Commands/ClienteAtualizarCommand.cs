using MVP.Base.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Commands
{
    public class ClienteAtualizarCommand : Command
    {
        public string Nome { get; set; }

        public ClienteAtualizarCommand(string nome)
        {
            Nome = nome;
        }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
