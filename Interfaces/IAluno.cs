﻿using API2.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API2.Interfaces
{
    interface IAluno
    {
        Aluno Cadastrar(Aluno a);

        List<Aluno> LerTodos();

        Aluno BuscarPorId(int id);

        Aluno Alterar(int id, Aluno a);

        void Excluir(int id);
    }
}
