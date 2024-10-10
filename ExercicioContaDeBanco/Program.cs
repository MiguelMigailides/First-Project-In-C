using System.Net;
using System.Globalization;

namespace ExercicioContaDeBanco {
    class Program {
        public static void Main(string[] args) {
            ContaBancaria conta; 

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine()); 

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n): ");
            char resp = char.Parse(Console.ReadLine());    
            if(resp == 's' ||  resp == 'S') {
                Console.Write("Entre com o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }else {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor como depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atulizado:");
            Console.WriteLine(conta);

            Console.Write("Entre um valor como saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);

            Console.WriteLine();
            Console.WriteLine(conta);


        }
    }
}