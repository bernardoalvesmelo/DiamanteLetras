namespace Diamante
{
    public class Program
    {
        public static void Main()
        {
            char[] alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char letra = Convert.ToChar(ReceberValor("Digite a letra central do diamante: ").ToUpper());
            int indice = Array.IndexOf(alfabeto, letra);
            Console.WriteLine();
            Console.WriteLine(FormatarLetraA(indice));
            for (int i = 1; i <= indice; i++)
            {
                EscreverLinha(alfabeto, indice, i);
            }

            for (int i = indice - 1; i > 0; i--)
            {
                EscreverLinha(alfabeto, indice, i);
            }

            Console.WriteLine(FormatarLetraA(indice));
            Console.ReadLine();
        }

        static string ReceberValor(string mensagem)
        {
            Console.Write(mensagem);
            return Console.ReadLine();
        }

        static string FormatarLetraA(int indice)
        {
            return new string(' ', indice) + 'A';
        }

        static void EscreverLinha(char[] alfabeto, int indice, int i)
        {
            int espaco = (indice - i);
            int espacoMeio = (i * 2 - 1);
            Console.Write(new string(' ', espaco));
            Console.Write(alfabeto[i]);
            Console.Write(new string(' ', espacoMeio));
            Console.Write(alfabeto[i]);
            Console.WriteLine();
        }
    }
}