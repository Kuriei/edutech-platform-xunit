namespace EduTechPlatform.App
{
    public class MatriculaFinanceiraService
    {
        public decimal CalcularValorMensalidade(decimal valorBase, int diaPagamento, bool eBolsista)
        {
            if (eBolsista)
            {
                return valorBase * 0.50m; // 50% de desconto
            }
            
            if (diaPagamento <= 5)
            {
                return valorBase * 0.90m; // 10% de desconto por pontualidade
            }

            return valorBase; // Valor integral
        }

        public bool PodeRealizarRematricula(bool possuiPendenciaFinanceira, string situacaoAcademica)
        {
            // True se não tiver pendência E a situação não for REPROVADO
            return !possuiPendenciaFinanceira && situacaoAcademica != "REPROVADO";
        }
    }
}