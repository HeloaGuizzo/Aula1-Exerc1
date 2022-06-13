namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nome = "Heloá Guizzo";
            string rua = "Rua Alarico Correa Leite";
            int numero = 96;
            int cep = 12446230;
            int telefone = 991212030;

            Console.WriteLine($"Nome: {nome}\nEndereço: {rua}, {numero}\nCEP: {cep}\n "+
                $"Telefone: {telefone}");
        }
    }
}
