namespace EjercicioI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Septimo Ejercicio






            //Sexto Ejercicio

            int radio, altura;
            double volumen;

            Console.WriteLine("Ingrese el radio del cilindro ");
            radio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del cilindro");
            altura = int.Parse(Console.ReadLine());
            double areaB = Math.PI*(Math.Pow(radio, 2));

            volumen = Math.Round(areaB* altura, 2);
            Console.WriteLine("El Volumen del area es " + volumen);







            //Quinto Ejercicio
            
            int bases;
            int height;

            Console.WriteLine("Ingrese la base del rectangulo");
            bases= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectangulo");
            height= int.Parse(Console.ReadLine());

            int perimeter = 2*bases + 2*height;
            int area = bases * height;
            Console.WriteLine("El perimetro del rectangulo es "+perimeter);
            Console.WriteLine("El area del rectangulo es "+area);



            //Cuarto Ejercicio
            int primer, segundo, tercero;

            primer = int.Parse(Console.ReadLine());
            segundo = int.Parse(Console.ReadLine());
            tercero = int.Parse(Console.ReadLine());

            int prom= (primer+segundo+ tercero)/3;

            Console.WriteLine(prom);



            //Tercer Ejercicio

            Random random = new Random();
            int nRnd = random.Next(10, 50);

            int fifteenPorcent = 15;
            float finalPorcent = (nRnd* fifteenPorcent) / 100;
            Console.WriteLine(nRnd);
            Console.WriteLine(nRnd-finalPorcent);


            //Segundo Ejercicio

            Random rnd = new Random();
            double percent = 1.3;
            
            int nRandom= rnd.Next(0,200);

            double porcentaje = nRandom * percent;
            
            Console.WriteLine(nRandom.ToString());
            Console.WriteLine(porcentaje.ToString());

            //Primer Ejercicio
            int n1;
            Console.WriteLine("ingrese un numero");
            n1 = int.Parse(Console.ReadLine());

            n1++;
            Console.WriteLine(n1);

            





        }
    }
}