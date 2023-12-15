namespace ContaSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Havera deposito inicial? s/n : ");
            string depositoinicial = Console.ReadLine().ToUpper();
            Console.WriteLine();

            Conta conta = new Conta(numeroConta, titular);

            if( depositoinicial == "S")
            {
                Console.Write("Entre com o valor do deposito: ");
                conta.Depositar(double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para deposito: ");
            conta.Depositar(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            conta.Sacar(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(conta);

        }
    }
}