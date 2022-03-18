
namespace SistemaParaBanco
{
    public class ATM
    {
  
        private BaseDatos baseDatos;
        //Propiedades
        private bool usuarioAutenticado;
        private int actualNumeroCuenta;
    
        //Constructor de la classe ATM
        public ATM()
        {
            usuarioAutenticado = false;
            actualNumeroCuenta = 0;
            baseDatos = new BaseDatos();
        }

        //Metodos de la clase ATM
        public void run()
        {
            while(true)
            {
                while(!usuarioAutenticado)
                {
                    Console.WriteLine("\nBienvenido!");
                    autenticarUsuario();
                }

                usuarioAutenticado = false;
                actualNumeroCuenta = 0;
                Console.WriteLine("\nGracias! Adios!");

            }


        }

        public void autenticarUsuario()
        {
            //string nombreCuenta;
            Console.WriteLine("\nPor favor indique el tipo de cuenta: ");
            Console.WriteLine("Cuenta: 1 Premier,  2 Priority,  3 Standard");
            int tipoCuenta = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\nColoque su PIN: ");
            int pin = Convert.ToInt16(Console.ReadLine());

            //usuarioAutenticado = cuenta.autenticarUsuario(tipoCuenta , pin);

            if(usuarioAutenticado)
            {
                actualNumeroCuenta = 0;//baseDatos;
            } 
            else 
            {
                Console.WriteLine("Tipo de cuenta o PIN Invalido. Por favor intentelo de nuevo. ");
            }

        }

        public void realizarTransaccion()
        {
            bool usuarioSalio = false;

            while(!usuarioSalio)
            {
                int seleccionMenuPrincipal = mostrarMenu();

                switch(seleccionMenuPrincipal)
                {
                    case 1:
                    break;

                    case 2:
                    break;

                    case 3:
                    break;

                    case 4:
                    break;

                    default:
                    Console.WriteLine(
                        "\nNo proporciono una seleccion valida. Por favor intentelo de nuevo. ");
                    break;

                }

            }
        }

        public int mostrarMenu()
        {
 
            Console.WriteLine("\nMenu Principal: ");
            Console.WriteLine("1 - Ver Balance");
            Console.WriteLine("2 - Retiro de efectivo");
            Console.WriteLine("3 - Depositos");
            Console.WriteLine("4 - Salir\n");
            Console.WriteLine("Elejir una opcion");
            int opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;

        }

    }

}