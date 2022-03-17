
namespace SistemaParaBanco
{
    public class ATM
    {
        //Propiedades
        private bool usuarioAutenticado
        {
            get{ return usuarioAutenticado; }
            set{ usuarioAutenticado = false; }
        } 
        private int actualNumeroCuenta 
        {
            get{ return actualNumeroCuenta; }
            set{ actualNumeroCuenta = 0; }
        }

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
            Console.WriteLine("\nPor favor indique el tipo de cuenta: ");
            Console.WriteLine("Cuenta: 1 Premier, 2 Priority, 3 Standard");
            int tipoCuenta = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\nColoque su PIN: ");
            int pin = Convert.ToInt16(Console.ReadLine());

            //pendiente usuarioAutenticado = 

            if(usuarioAutenticado)
            {
                actualNumeroCuenta = tipoCuenta;
                
            } else {
                Console.WriteLine("Invalido tipo de cuenta o PIN. Por favor intentelo de nuevo. ");

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