using AlmoxarifadoDomain.Models;
using AlmoxarifadoDomain.Services;
using Moq;
using System.Linq.Expressions;

namespace TDD_Almoxarifado
{
    public class EstoqueTest
    {
        [Fact]
        public void VerificarEstoqueAbaixoMinimo_DeveRetornarTrue_SeEstoqueAposRetiradaForMenorQueEstoqueMinimo()
        {
            //arrange

            var mockEstoque = new Mock<Estoque>();
            var mockProduto = new Mock<Produto>();

            mockProduto.Setup(p => p.ESTOQUE_MIN).Returns(10);
            mockEstoque.Setup(e=>e.Quantidade).Returns(15);
            mockEstoque.Setup(e=>e.produto).Returns(mockProduto.Object);
            var estoqueService = new EstoqueService();

            //act
            var resultado = estoqueService.VerificarEstoqueAbaixoMinimo(mockEstoque.Object, 7);

            //Assert
            Assert.True(resultado);

        }
    }
}