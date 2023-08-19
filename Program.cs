namespace EjercicioI
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            n1 = int.Parse(Console.ReadLine());

            n1++;
            Console.WriteLine(n1);

            





        }
    }
}