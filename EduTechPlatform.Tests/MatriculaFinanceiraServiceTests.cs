
using EduTechPlatform.App;
using Xunit;

namespace EduTechPlatform.Tests
{
    public class MatriculaFinanceiraServiceTests
    {
        [Theory]
        [InlineData(1000.00, 10, true, 500.00)]
        [InlineData(1000.00, 4, false, 900.00)]
        [InlineData(1000.00, 10, false, 1000.00)]
        public void CalcularValorMensalidade_DeveRetornarValorCorreto(
            double valorBase, int diaPagamento,
            bool eBolsista, double valorEsperado)
        {
            var service = new MatriculaFinanceiraService();

            decimal resultado = service.CalcularValorMensalidade(
                (decimal)valorBase,
                diaPagamento,
                eBolsista
            );

            Assert.Equal((decimal)valorEsperado, resultado);
        }

        [Theory]
        [InlineData(false, "APROVADO", true)]
        [InlineData(true, "APROVADO", false)]
        [InlineData(false, "REPROVADO", false)]
        public void PodeRealizarRematricula_DeveRetornarResultadoCorreto(
            bool possuiPendenciaFinanceira,
            string situacaoAcademica,
            bool resultadoEsperado)
        {
            var service = new MatriculaFinanceiraService();

            bool resultado = service.PodeRealizarRematricula(
                possuiPendenciaFinanceira,
                situacaoAcademica
            );

            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
