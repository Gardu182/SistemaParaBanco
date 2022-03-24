
namespace SistemaParaBanco
{
    public class ATM
    {
  
        private BaseDatos baseDatos;
        //Propiedades
        private bool usuarioAutenticado;
        private int actualNumeroCuenta;

        //enumeracion para el menu de opciones
        private enum menuoOpciones
        {
            Balance = 1,
            Retiros = 2,
            Depositos = 3,
            Salir = 4

        }
    
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

                realizarTransaccion();
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

            usuarioAutenticado = baseDatos.autenticarUsuario(tipoCuenta , pin);

            if(usuarioAutenticado)
            {
                actualNumeroCuenta = tipoCuenta;
            } 
            else 
            {
                Console.WriteLine("Tipo de cuenta o PIN Invalido. Por favor intentelo de nuevo. ");
            }

        }

        public void realizarTransaccion()
        {
            double transaccionActual;
            bool usuarioSalio = false;

            while(!usuarioSalio)
            {
                int seleccionMenuPrincipal = mostrarMenu();

                switch(seleccionMenuPrincipal)
                {
                    case (int)menuoOpciones.Balance:
                    transaccionActual = CrearTransaccion(seleccionMenuPrincipal);
                    Console.WriteLine("\nSu valance al dia de hoy es de: {0:C2}.", transaccionActual);
                    break;
                    
                    case (int)menuoOpciones.Retiros:
                    transaccionActual = CrearTransaccion(seleccionMenuPrincipal);
                    break;

                    case (int)menuoOpciones.Depositos:
                    transaccionActual = CrearTransaccion(seleccionMenuPrincipal);
                    break;

                    case (int)menuoOpciones.Salir:
                    Console.WriteLine("\nSaliendo del Sistema");
                    usuarioSalio = true;
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

        private double CrearTransaccion(int tipo)
        {
            double temp = 0;

            switch((menuoOpciones) tipo)
            {
                case menuoOpciones.Balance:
                temp = baseDatos.GetSaldoDisponible(actualNumeroCuenta);
                break;

                case menuoOpciones.Retiros:
                Console.WriteLine("Proporcione la cantidad a retirar:");
                double cantidad = Convert.ToInt32(Console.ReadLine());
                temp = baseDatos.hacerRetiro(actualNumeroCuenta, cantidad);
                break;

                case menuoOpciones.Depositos:
                break;

            }

            return temp; 
        }

    }

}