using System;
using System.Collections.Generic;
using System.Text;

namespace PRUEBASINGLENTON
{
    class PatronSingleton
    {
        //El patron de diseño Singleton  consiste en que la clase solo tenga una unica instancia
        //Y proporcionar un punto de acceso en general a ella
        // en este ejercico se plantea:
        // que  en un vaso se proporcione agua 

        private static PatronSingleton vaso = null;
        //creamos un metodo de tipo singletonllamado vaso
        public static PatronSingleton Vaso
        {
            get
            {
                //preguntaremos si mi vaso esta vacio
                if (vaso == null)
                {

                    vaso = new PatronSingleton();
                }
                return vaso;
            }
        }

        public string Agua = " ";

        //creamos un constructor 
        public PatronSingleton()
        // mediante la clase PatronSinglenton podemos proporcionar :
        {
            Agua = " Agua de coco ";
        }
    }

}
