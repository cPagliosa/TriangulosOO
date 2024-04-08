namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("****************************************\n" +
                              "**   Confira o tipo do seu Triangulo  **\n" +
                              "****************************************");

                //entrada
                Entrada(triangulo);

                //validar triagulo e da a saida
                Saida(triangulo);

                Console.WriteLine("\nVocê quer fazer?\n[1] Sim   [2] Não");
                Console.Write("qual a sua escolha: ");
                int h = Convert.ToInt32(Console.ReadLine());
                if (h == 2) break;
            }


            
        }

        private static void Saida(Triangulo triangulo)
        {
            if (triangulo.ValidarTriangulo(triangulo.Altura, triangulo.Largura, triangulo.Comprimento))
            {
                Console.WriteLine($"\nO seu Triangulo é do tipo {triangulo.ReconhecerTriangulo(triangulo.Altura, triangulo.Largura, triangulo.Comprimento)}.");
            }
            else
            {
                Console.WriteLine("Triangulo Invalido!!");
            }
        }

        private static void Entrada(Triangulo triangulo)
        {
            Console.Write("Informe o comprimento do triangulo: ");
            triangulo.Comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o altura do triangulo: ");
            triangulo.Altura = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o largura do triangulo: ");
            triangulo.Largura = Convert.ToDecimal(Console.ReadLine());
        }
    }
}
