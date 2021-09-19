using System;

namespace Clase_5_Numerados
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Alfajor alfajor1 = new Alfajor(Alfajores.CapitanDelEspacio , (int)Alfajores.CapitanDelEspacio);
            Alfajor alfajor2 = new Alfajor(Alfajores.Fulbito , (int)Alfajores.Fulbito);
            Alfajor alfajor3 = new Alfajor(Alfajores.jorgito, (int)Alfajores.jorgito);

            Alfajor.Mostrar(alfajor1);
            Alfajor.Mostrar(alfajor2);
            Alfajor.Mostrar(alfajor3);*/

            string variable = "CapitanDelEspacio";

            
            Alfajores alfajores = (Alfajores) Enum.Parse(typeof(Alfajores),variable);

            Console.WriteLine(alfajores);

            switch (alfajores)//creo el switch con tab y al poner el nombre de una variable de tipo "Enum"
            {                //y haciendo un click en cualquier lado me completa con todas las opciones de ese enumerado.

                case Alfajores.jorgito:
                    break;
                case Alfajores.CapitanDelEspacio:
                    break;
                case Alfajores.Guaymallen:
                    break;
                case Alfajores.Fulbito:
                    break;
                default:
                    break;
            }
            

            foreach (Alfajores item in Enum.GetValues(typeof(Alfajores)))
            {
                Console.WriteLine($"Nombre {item} ");
                Console.WriteLine($"Precio {(int)item}");
                Console.WriteLine("");
            }
        }
    }
}
