namespace Diamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Console.WriteLine("Digite a letra central do diamante: ");
            char letra = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.WriteLine();
            int indice = 0;
            while (true)
            {
                if (alfabeto[indice] == letra)
                {
                    break;
                }

                indice++;
            }

            int espaco = (indice);
            Console.Write(new string(' ', espaco));
            Console.WriteLine('A');
            espaco -= 1;
            int espacoMeio = 1;
            for (int i = 1; i <= indice; i++)
            {
                espacoMeio = (i * 2 - 1);
                Console.Write(new string(' ', espaco));
                Console.Write(alfabeto[i]);
                Console.Write(new string(' ', espacoMeio));
                Console.Write(alfabeto[i]);
                espaco--;
                espacoMeio += 2;
                Console.WriteLine();
            }

            espaco = 1;
            for (int i = indice - 1; i > 0; i--)
            {
                espacoMeio = (i * 2 - 1);
                Console.Write(new string(' ', espaco));
                Console.Write(alfabeto[i]);
                Console.Write(new string(' ', espacoMeio));
                Console.Write(alfabeto[i]);
                espaco++;
                Console.WriteLine();
            }

            Console.Write(new string(' ', indice));
            Console.WriteLine('A');
            Console.ReadLine();
        }
    }
}