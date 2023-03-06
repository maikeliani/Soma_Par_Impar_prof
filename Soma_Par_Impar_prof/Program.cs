internal class Program
{
    private static void Main(string[] args)
    {
        int num = 0, somaPar = 0, somaImpar = 0;

        do
        {
            Console.WriteLine( " Informe um numero inteiro: ");
            num = int.Parse(Console.ReadLine());

            if( ( num < 1000) && (num > 0))
            {
                if (num % 2 == 0)
                {
                    somaPar += num; 
                }
                else
                {
                    somaImpar += num; 
                }
            }
            

        } while (num < 1000);
        Console.WriteLine(" A soma dos numeros pares é: " + somaPar);
        Console.WriteLine(" A soma dos numeros impares é: " + somaImpar);
    }
}