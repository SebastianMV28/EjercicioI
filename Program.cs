namespace EjercicioI
{
    internal class Program
    {
        static void Main(string[] args) { 


            String userSelection = Console.ReadLine();

        //Menu//
        Console.WriteLine("Please, select an option ");
            Console.WriteLine("0");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            Console.WriteLine("8");
            Console.WriteLine("9");
            Console.WriteLine("10");
            Console.WriteLine("...........");
            
            //Switch//

            switch(userSelection){
                case "1":
                    
        int opt1 = AddNumber();
                    break;
                    case "2":
                     
        int opt2 = RandomPlusPorcent();
                break;
                    case "3":
                        
        int opt3 = FifthyPorcentRandom();
                        break;
                         case "4":
                  int opt4 = Prom();
        Console.writeLine(prom());
                    ;
                break;case "5":
                    opt5= AddNumber();
                break;case "6":
                    opt6= AddNumber();
                break;case "7":
                    opt7= AddNumber();
                break;case "8":
                    opt8= AddNumber();
                break;case "9":
                    opt9= AddNumber();
                break;case "10":
                    opt10= AddNumber();
                break;
            default;


            };





    ///Methods///

    static void AddNumber()
    {
        int n1;
        Console.WriteLine("ingrese un numero");
        n1 = int.Parse(Console.ReadLine());

        n1++;
        Console.WriteLine(n1);
    };

    static void RandomPlusPorcent()
    {
        Random rnd = new Random();
        double percent = 1.3;

        int nRandom = rnd.Next(0, 200);

        double porcentaje = nRandom * percent;

        Console.WriteLine(nRandom.ToString());
        Console.WriteLine(porcentaje.ToString());
    }

    static void FifthyPorcentRandom()
    {
        Random random = new Random();
        int nRnd = random.Next(10, 50);

        int fifteenPorcent = 15;
        float finalPorcent = (nRnd * fifteenPorcent) / 100;
        Console.WriteLine(nRnd);
        Console.WriteLine(nRnd - finalPorcent);

    }


    static int Prom(int a, b, c)
    {
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());

        int prom = (a + b + c) / 3;
        return prom;
    }









    ///////////////////////////////////////////////////////
    //Decimo Ejercicio
    int pNumber, sNumber;
    Console.WriteLine("Ingrese el primer numero");
            pNumber= int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero");
            sNumber= int.Parse(Console.ReadLine());
             if (sNumber % pNumber== 0) {
                Console.WriteLine("Es divisible");
            }
            else
{
    Console.WriteLine("No es divisible");
}



//Noveno Ejercicio
double hombres, mujeres;

Console.WriteLine("Ingrese la cantidad de hombres en el grupo");
hombres = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de mujeres en el grupo");
mujeres = double.Parse(Console.ReadLine());
double grupoTotal = hombres + mujeres;


hombres = (hombres / grupoTotal) * 100;
mujeres = (mujeres / grupoTotal) * 100;

Console.WriteLine("El porcentaje de hombres es :" + hombres + "%" + " y el porcentaje de mujeres es :" + mujeres + "%");



//Octavo Ejercicio
double fahrenheit, celsius;
Console.WriteLine("Ingrese la temperatura en grados Celsius");
celsius = double.Parse(Console.ReadLine());
fahrenheit = (celsius * 1.8) + 32;
Console.WriteLine("La temperatura convertida a Fahrenheit es de: " + fahrenheit);



//Septimo Ejercicio
double cms, yardas, metros, pies, pulgadas;

Console.WriteLine("Ingrese los centimetros que desea convertir");
cms = double.Parse(Console.ReadLine());
metros = cms * 0.01;
yardas = cms * 0.0109361;
pies = cms * 0.0328084;
pulgadas = cms * 0.393701;
Console.WriteLine("El valor de los centimetros en pulgadas es " + (Math.Pow(pulgadas, 1)));
Console.WriteLine("El valor de los centimetros en metros es " + (Math.Pow(metros, 1)));
Console.WriteLine("El valor de los centimetros en yardas es " + (Math.Pow(yardas, 1)));
Console.WriteLine("El valor de los centimetros en pies es " + (Math.Pow(pies, 1)));

//Sexto Ejercicio

int radio, altura;
double volumen;

Console.WriteLine("Ingrese el radio del cilindro ");
radio = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del cilindro");
altura = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine("Ingrese un valor para radio mayor a 0");
    radio = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese un valor para altura mayor a 0");
    altura = int.Parse(Console.ReadLine());
} while (radio < 0 || altura < 0);


double areaB = Math.PI * (Math.Pow(radio, 2));

volumen = Math.Round(areaB * altura, 2);
Console.WriteLine("El Volumen del area es " + volumen);



//Quinto Ejercicio

int bases;
int height;

Console.WriteLine("Ingrese la base del rectangulo");
bases = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del rectangulo");
height = int.Parse(Console.ReadLine());

int perimeter = 2 * bases + 2 * height;
int area = bases * height;
Console.WriteLine("El perimetro del rectangulo es " + perimeter);
Console.WriteLine("El area del rectangulo es " + area);



//Cuarto Ejercicio
int primer, segundo, tercero;

primer = int.Parse(Console.ReadLine());
segundo = int.Parse(Console.ReadLine());
tercero = int.Parse(Console.ReadLine());

int prom = (primer + segundo + tercero) / 3;

Console.WriteLine(prom);



//Tercer Ejercicio

Random random = new Random();
int nRnd = random.Next(10, 50);

int fifteenPorcent = 15;
float finalPorcent = (nRnd * fifteenPorcent) / 100;
Console.WriteLine(nRnd);
Console.WriteLine(nRnd - finalPorcent);


//Segundo Ejercicio

Random rnd = new Random();
double percent = 1.3;

int nRandom = rnd.Next(0, 200);

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