using MVP.Base.Commands;
using MVP.BusinessLogic;
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
        IClienteRepository _clienteRepository;
        public ClienteSalvarCommand(string nome, IClienteRepository clienteRepository)
        {
            Nome = nome;
            _clienteRepository = clienteRepository;
            _clienteRepository.Salvar(nome);
        }

        public override bool IsValid()
        {
            return !string.IsNullOrEmpty(Nome);
        }
    }
}
