namespace Laboratorio2_10_CalculosYVersiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el Nombre del Cliente");
            string nombreCliente = Console.ReadLine();

            Console.WriteLine("Introduzca el Saldo actual");
            double saldoActual = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduzca el Monto a depositar");
            double montoDeposito = Convert.ToDouble(Console.ReadLine());

            double nuevoSaldo = saldoActual + montoDeposito;




        }
    }
}