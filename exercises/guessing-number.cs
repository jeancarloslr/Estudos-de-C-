class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);

        int respostaInt = 0; // Initialize with a default value to enter the loop
        while (respostaInt != numeroAleatorio)
        {
            Console.WriteLine("Diga um número de 1 a 100");
            string resposta = Console.ReadLine();
            
            // Ensure input is valid
            if (!int.TryParse(resposta, out respostaInt))
            {
                Console.WriteLine("Por favor, insira um número válido.");
                continue; // Skip the rest of the loop iteration and prompt again
            }

            int difference = Math.Abs(respostaInt - numeroAleatorio);

            if (respostaInt == numeroAleatorio)
            {
                Console.WriteLine("Right number");
            }
             else
            {
                // Feedback based on the difference
                if (difference <= 5)
                {
                    Console.WriteLine("Very close!");
                }
                else if (difference <= 10)
                {
                    Console.WriteLine("Close!");
                }
                else if (difference <= 20)
                {
                    Console.WriteLine("Far!");
                }
                else
                {
                    Console.WriteLine("So far!");
                }
            }
        }
    }
}




























