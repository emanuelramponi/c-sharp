namespace Program
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            Test.Mensaje();
            Ejercicio.Ex1();

        }
    }

    public class Test
    {
        public static void Mensaje()
        {
            Console.WriteLine("Este es un mensaje");
            Console.WriteLine("Este es otro mensaje");
        }
                
    }

    public class Ejercicio
    {
        public static void Ex1()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Edad: ");
            string edad = Console.ReadLine();
            Console.Write("Aficion: ");
            string aficion = Console.ReadLine();

            Console.WriteLine("============= INFORMACION BASICA =============");
            Console.WriteLine($"Eres {nombre} {apellido}");
            Console.WriteLine($"Tienes {edad} años de edad");
            Console.WriteLine($"Hobby: {aficion}");

        }
    }


}