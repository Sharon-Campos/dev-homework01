using System;

namespace dev_homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! - My name is: Francisco");

            //Constantes
            const string nombre = "Sharon";
            //Variables
            int edad = 19;
        
            Console.WriteLine($"Mi nombre es: {nombre} y mi edad es { edad } años.");

            float miDomingo = 150.5F;

            Console.WriteLine($"Mi domingo es de {miDomingo}");
        
            var resultado = miDomingo * 46;

            Console.WriteLine($"Resultado: { resultado }");


            var areaTriangulo = 0F;

            float basee = 315.0723F;
            float altura = 11238.0234F;
            const float dos = 2.0F;
            areaTriangulo = basee * altura / dos;
        
            Console.WriteLine ($"Area de un triangulo es igual a la base: ({basee}) por la altura ({altura}) entre dos");
            Console.WriteLine ($"Resutlado Area: {areaTriangulo} ");

            char letraA = 'a';
            Console.WriteLine ($"Letara: { letraA}");

            float  floatF = 1F/3;
            double doubleD = 1D/3;
            decimal decimalD = 1M/3;

            Console.WriteLine ($"flotante: {floatF}");
            Console.WriteLine ($"doubleD: {doubleD}");
            Console.WriteLine ($"decimalD: {decimalD}");

            bool falso = false;
            bool verdadero = true;
            Console.WriteLine ($"Falso { falso }  Verdadero { verdadero}");
            // Tarea
            /* ESTA ES MI TAREA 
              1) área de un triángulo, circulo, cuadrado.
              2) Si mi sueldo es de $100,000, ¿cuanto es el 10%?
              3) Si de domingo me dan 15 pesos ¿cuanto dinero junte en 3 años?  
              4) Si de domingo me dan 15 pesos y cada año me aumentan 20% ¿cuanto dinero junte en 5 años?;
              5) Investigar el problema de los conejos de Fibonacci (programar la respuesta.)            
            */

            Console.WriteLine("\n"); //Salto de linea
            Console.WriteLine("**************************************");
            Console.WriteLine("TAREA - Ejercicio 01");
            Console.WriteLine("Área de un Triángulo");

            var x = 10;
            var y = 20;
            
            Console.WriteLine($"Base: { x }");
            Console.WriteLine($"Altura: { y }");
            Console.WriteLine($"área es igual: { (x*y)/2 }");
            Console.WriteLine("**************************************");
            Console.WriteLine("\n");

            //ejercicio 1

         var areaTriang = 0F;

            float baase = 24.5F;
            float altur = 30.1F;
            const float doss = 2.0F;
            areaTriangulo = baase * altur / doss;
        
            Console.WriteLine ($"Area de un triangulo es igual a la base: ({baase}) por la altura ({altur}) entre dos");
            Console.WriteLine ($"Resultado Area: {areaTriang} ");

          

         var areaCirculo = 0F;

            const float Pi = 3.1416F;
            float Rcuadrado = 9F;
            const float doos = 2.0F;
            areaCirculo = Pi * Rcuadrado / doos;
        
            Console.WriteLine ($"Area de un circulo es igual Pi: ({Pi}) por Radio al cuadrado ({Rcuadrado}) entre dos");
            Console.WriteLine ($"Resultado Area: {areaCirculo} ");



         var areaCuadrado  = 0F;

            float basse = 10;
            float alturaa = 10;
            
            areaCuadrado = basse * alturaa;
        
            Console.WriteLine ($"Area de un cuadrado es igual a la base: ({basse}) por la altura ({alturaa})");
            Console.WriteLine ($"Resultado Area: {areaCuadrado} ");

         //ejercicio 2
         
         var porcentaje = 0F;

            Console.WriteLine ($"si mi sueldo es de $100,000, ¿cuanto es el 10%?");
            const float cienporciento = 100F;
            const float sueldo = 100000F;
            float X = 10F;

            Console.WriteLine ($"Porcentaje es : el cienporciento({cienporciento}) por X  ({X}) entre sueldo ({sueldo})");
            Console.WriteLine ($"Resultado porcentaje: {porcentaje} ");

          //ejercicio 3

         var domingo =0F;
             
            Console.WriteLine ($"Si de domingo me dan 15 pesos ¿cuanto dinero junte en 3 años?");
            const float semanas = 156F;
            const float dinero = 15F;
            float años = 3F;

            Console.WriteLine ($"domindo es: dinero({dinero}) por semanas({semanas}) por años ({años})");
            Console.WriteLine ($"Resultado porcentaje: {domingo} ");

         //ejercicio 4

         var domingo1año = 0F;
            Console.WriteLine ($" Si de domingo me dan 15 pesos y cada año me aumentan 20% ¿cuanto dinero junte en 5 años?");
            const float  semanaas= 52F;
            const float dineroo = 15F;
            const float aumento= 20F;

            Console.WriteLine ($"domindo es: dinero({dineroo}) por semanas({semanaas})  mas el 20% ({aumento})");
            Console.WriteLine ($"Resultado porcentaje: {domingo1año} ");

         var domingo1a5años= 0F;
             float primeraño = 780F;
             float segundoaño = 936F;
             float terceraño = 1123.2F;
             float cuartoaño = 1347.84F;
             float quintoaño = 1617.408F;

             Console.WriteLine ($"Mi domindo despues de 5 años es: la suma del primer año ({primeraño}) mas segundo año({segundoaño})  mas tercer año({terceraño})mas cuarto año({cuartoaño})  mas quinto año({quintoaño})");
             Console.WriteLine ($"Resultado porcentaje: {domingo1a5años} ");

         //ejercicio 5

         var fibonacci = 0F;
             
             Console.WriteLine ($"Investigar el problema de los conejos de Fibonacci (programar la respuesta.)");

             float primermes = 1F;
             float segundomes = 2;
             float tercermes = 3;
             float cuartomes= 5;
             float quintomes = 8;
             float sextomes = 13;

             Console.WriteLine ($"cada mes una pareja tiene una parejita de otros conejos");
             Console.WriteLine ($"para calcular la cantidad de conejos se: ({primermes})mantiene el primer mes uno({segundomes}) segundo mes do({tercermes})tercer mes tres({cuartomes})cuarto mes cinco({quintomes})quinto mes ocho({sextomes})sexto mes 13");
             Console.WriteLine ($"Resultado porcentaje: {fibonacci} ");






            
    
        }
    }
}
