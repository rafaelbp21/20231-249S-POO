namespace exemplo_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta1 = new Conta();
            minhaConta1.codigo = 123;
            minhaConta1.saldo = 1500.0f;
            minhaConta1.tipo = "corrente";
            minhaConta1.dono = "Du";

            minhaConta1.imprimirSaldo();

            Conta minhaConta2 = new Conta();
            minhaConta2.codigo = 456;
            // minhaConta2.saldo = 1500.0f; // Comentando para obter o valor default
            minhaConta2.tipo = "corrente";
            minhaConta2.dono = "Murilo";

            minhaConta2.imprimirSaldo();

            Conta minhaConta3 = new Conta();
            minhaConta3.codigo = 789;
            minhaConta3.saldo = 20000.0f;
            minhaConta3.tipo = "corrente";
            minhaConta3.dono = "Cecília";

            minhaConta3.imprimirSaldo();

            Console.WriteLine();
            Console.WriteLine("----------------------------------- Sacando...");
            Console.WriteLine();

            minhaConta1.sacar(100.0f);
            minhaConta2.sacar(500.0f);
            minhaConta3.sacar(5000.25f);

            minhaConta1.imprimirSaldo();
            minhaConta2.imprimirSaldo();
            minhaConta3.imprimirSaldo();

            Console.WriteLine();
            Console.WriteLine("----------------------------------- Depositando...");
            Console.WriteLine();

            minhaConta1.depositar(1000.0f);
            minhaConta2.depositar(3000.0f);
            minhaConta3.depositar(25.0f);

            minhaConta1.imprimirSaldo();
            minhaConta2.imprimirSaldo();
            minhaConta3.imprimirSaldo();

            Console.WriteLine();
            Console.WriteLine("----------------------------------- Transferindo...");
            Console.WriteLine();

            minhaConta1.transferir(250.0f,minhaConta2);
            minhaConta1.transferir(250.0f, minhaConta3);

            minhaConta1.imprimirSaldo();
            minhaConta2.imprimirSaldo();
            minhaConta3.imprimirSaldo();
        }
    }
}