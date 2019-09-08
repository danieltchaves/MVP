using MVP.Base.Commands;
using MVP.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Commands
{
    public class ClienteSalvarCommand : Command
    {
        public string Nome { get; set; }
        public ClienteSalvarCommand(string nome)
        {
            Nome = nome;
        }

        public override bool IsValid()
        {
            return !string.IsNullOrEmpty(Nome);
        }
    }
}
