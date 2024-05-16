using AlmoxarifadoDomain.Interfaces;
using AlmoxarifadoDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlmoxarifadoDomain.Services
{
    public class EstoqueService : IEstoqueService
    {
        public bool VerificarEstoqueAbaixoMinimo(Estoque estoque, int qtdRetirada)
        {
            return estoque.Quantidade - qtdRetirada < estoque.produto.ESTOQUE_MIN;
        }
    }
}
