using System;
using System.Globalization;

namespace ControleBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem-vindo ao nosso aplicativo do banco, favor digitar o seu nome completo:");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Favor digitar o número de sua conta:");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine();

            ContaBancaria conta = new ContaBancaria(nomeCompleto, numeroConta);

            int resposta = 0;
            string resposta2 = "Não";

            while (resposta != 5)
            {

                Console.WriteLine("Digite o número da operação que desejas realizar, conforme legenda abaixo:");
                Console.WriteLine("1 - Realizar Saque");
                Console.WriteLine("2 - Realizar Depósito");
                Console.WriteLine("3 - Realizar Transferência");
                Console.WriteLine("4 - Consultar Saldo da conta");
                Console.WriteLine("5 - Sair do aplicativo");

                resposta = int.Parse(Console.ReadLine());

                if (resposta == 1)
                {
                    Console.Write("Digite o valor que desejas sacar: ");
                    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();
                    Console.WriteLine("Saque realizado com sucesso!");
                    Console.WriteLine();
                    conta.Saque(valor);
                }
                else if (resposta == 2)
                {
                    Console.Write("Digite o valor que desejas depositar: ");
                    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();
                    Console.WriteLine("Depósito efetuado com sucesso!");
                    Console.WriteLine();
                    conta.Deposito(valor);
                }
                else if (resposta == 3)
                {
                    Console.Write("Digite o valor que desejas transferir: ");
                    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();
                    Console.WriteLine("Transferência efetuada com sucesso!");
                    Console.WriteLine();
                    conta.Transferencia(valor);
                }
                else if (resposta == 4)
                {
                    Console.WriteLine("O saldo atual da conta é de R$ " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine();
                }

                if (resposta != 5)
                {
                    Console.WriteLine("Desejas sair do aplicativo? (Sim ou Não)");
                    resposta2 = Console.ReadLine();
                    if (resposta2 == "Sim")
                    {
                        resposta = 5;
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Agradecemos sua visita, até logo!");
        }
    }
}
