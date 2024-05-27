using ServicePayment.Entities;

namespace ServicePayment.Services
{
    public class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            //Cria variavel e armazena o valor total do contrato dividido pelos meses;
            var basicQuota = contract.TotalValue / months;

            for(int i = 1; i <= months; i++)
            {
                var date = contract.Date.AddMonths(i);

                // adiciona a taxa de juros simples mensal e armazena na variavel;
                var updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);

                // adiciona o valor da taxa de pagamento e soma com o valor atualizado;
                var fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);

                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
