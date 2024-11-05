namespace DiaSemanaArreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número");
            string[] diasSemana = new string[7];

            diasSemana[0] = "Lunes";
            diasSemana[1] = "Martes";
            diasSemana[2] = "Miércoles";
            diasSemana[3] = "Jueves";
            diasSemana[4] = "Viernes";
            diasSemana[5] = "Sábado";
            diasSemana[6] = "Domingo";

            string input = Console.ReadLine();
            int.TryParse(input, out int result);

            if (result > 0 && result <= 7)
            {
                Console.WriteLine(diasSemana[result - 1]);
            }
            else
            {
                Console.WriteLine("Dato Incorrecto");
            }
        }
    }
}
