using System;
namespace CAIValidaciones
{
    public class Validaciones
    {
        public static double ValidarNumero(string numInput)
        {
            double cleanNum = 0;
            while (!double.TryParse(numInput, out cleanNum))
            {
                Console.Write("El número ingresado no es válido. Ingrese otro número: ");
                numInput = Console.ReadLine();
            }
            return cleanNum;
        }


    }
}
