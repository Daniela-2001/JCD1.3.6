namespace JCD1._3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de linhas para desenhar a árvore: ");
            int lines = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            while (lines >= i) // Controla o número de linhas da árvore

            {
                int j = 1;
                while (j <= i) // Controla os caracteres da árvore
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine("");
                i++;
            }
        }
    }
}