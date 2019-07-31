﻿using AppMvcBasica.Models;
using DevIO.Business.Interfaces;
using DevIO.Business.Models.Validations;
using System;
using System.Threading.Tasks;

namespace DevIO.Business.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        public async Task Adicionar(Fornecedor fornecedor)
        {
            //validar o estado da entidade
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor) &&
                !ExecutarValidacao(new EnderecoValidation(), fornecedor.Endereco)) return;

            return;
        }

        public async Task Atualizar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)) return;

            return;

        }

        public async Task AtualizarEndereco(Endereco endereco)
        {
            if (!ExecutarValidacao(new EnderecoValidation(), endereco)) return;

            return;
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}