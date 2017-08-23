using System;

namespace Lista21082017ex10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string nome;
            char sexo;
            decimal altura, peso_ideal;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu sexo (inicial): ");
            sexo = Char.ToUpper(Convert.ToChar(Console.ReadLine()));


			Console.WriteLine("Digite sua altura: ");
            altura = Convert.ToDecimal(Console.ReadLine());

            if (sexo == 'M') {
                peso_ideal = (72.7m * altura) - 58m;
                Console.Write("{1}, Seu peso Ideal é: {0}", peso_ideal, nome);
            } else if (sexo == 'F'){
                peso_ideal = (62.1m * altura) - 44.7m;
                Console.Write("{1}, Seu peso Ideal é: {0}", peso_ideal, nome);
            } else {
                Console.WriteLine("Sexo inválido.");
                Console.ReadKey();
            }
            // Console.Write("Seu peso Ideal é: {0}", peso_ideal); não funciona aqui
            Console.ReadKey();
        }
    }
}
