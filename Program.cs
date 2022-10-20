namespace Program
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            Test test = new Test();
            test.Mensaje();
            Ejercicio ejercicio = new Ejercicio();
            ejercicio.Ex1();



        }
    }

    public class Test
    {
        public  void Mensaje()
        {
            Console.WriteLine("Este es un mensaje");
            Console.WriteLine("Este es otro mensaje");
        }


    }

    public class Ejercicio
    {
        public void Ex1()
        {
            int edad;
            string nombre, apellido, aficion;
            Console.Write("Nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Edad: ");
            edad = Int32.Parse(Console.ReadLine());
            Console.Write("Aficion: ");
            aficion = Console.ReadLine();

            Console.WriteLine("============= INFORMACION BASICA =============");
            Console.WriteLine($"Eres {nombre} {apellido}");
            Console.WriteLine($"Tienes {edad} años de edad");
            Console.WriteLine($"Hobby: {aficion}");

        }
    }


}