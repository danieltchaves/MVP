﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.BusinessLogic
{
    public interface IClienteRepository : IDisposable
    {
        void Salvar(string nome);
        void Ataulizar(string nome);
        void Deletar(string nome);
        IEnumerable<ClienteModel> Buscar();
    }
}
