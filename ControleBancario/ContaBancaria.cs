namespace ControleBancario
{
    class ContaBancaria
    {
        public string NomeTitular { get; set; }
        public int NumeroConta { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string nomeTitular, int numeroConta)
        {
            NomeTitular = nomeTitular;
            NumeroConta = numeroConta;
        }

        public void Saque(double valor)
        {
            Saldo -= valor;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Transferencia(double valor)
        {
            Saldo -= valor;
        }
    }
}
