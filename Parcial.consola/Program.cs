namespace Parcial.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area, volumen;
            double Base;
            double contador = 0;
            bool repite=true;

            do
            {
                double radio = PedirDoubleEntreMinYMax("Ingrese el radio: ", -100, 999);
                double altura = PedirDoubleEntreMinYMax("Ingrese la altura: ", -100, 999);

               if (radio==0 && altura==0)
                {
                    repite = false;
                }
               else
                {
                    if (radio < 0 | altura < 0)
                    {
                        Console.WriteLine("Por favor ingrese numeros positivos");
                    }
                    else
                    {
                        if (radio > 0 && altura > 0)
                        {
                            area = CalcularArea(radio, altura);
                            Base = CalcularBase(radio);
                            volumen = CalcularVolumen(altura, Base);

                            Console.WriteLine($"El area del cilindro es: {area}");
                            Console.WriteLine($"El volumen del cilindro es: {volumen}");

                            contador = contador + 1;
                        }
                        else
                        {
                            Console.WriteLine("Ingrese numero distintos a 0");
                        }
                    }

                }

            } while (repite);

            Console.WriteLine($"Cantidad de cilindros ingresados: {contador}");
        }

        private static double CalcularVolumen(double altura, double Base) => Base * altura;

        private static double CalcularArea(double radio, double altura) => 2 * Math.PI * radio * (altura + radio);

        private static double CalcularBase(double radio) =>Math.PI * Math.Pow(radio, 2);

        private static double PedirDoubleEntreMinYMax(string Mensaje, double min, double max)
        {
            double nro = 0;
            do
            {
                Console.Write(Mensaje);
                string strConsola = Console.ReadLine();
                strConsola = strConsola.Replace('.', ',');
                if (!double.TryParse(strConsola, out nro))
                {
                    Console.WriteLine("Número mal ingresado");

                }
                else if (nro >= min && nro <= max)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"El número debe estar entre {min} y {max}");
                }

            } while (true);
            return nro;
        }
    }
}