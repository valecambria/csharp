namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hello, " + nombre + " !");
            if(nombre == "valentino"){
                Console.WriteLine("Introduce tu edad");
                string edad = Console.ReadLine();
                Console.WriteLine(nombre + " tenes " + edad + " años!");
            }
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine(date);
        }
    }
}