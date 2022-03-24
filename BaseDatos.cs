namespace SistemaParaBanco
{
    public class BaseDatos
    {


        private Cuenta[] cuentas;

        public BaseDatos()
        {
            cuentas = new Cuenta[3];
            cuentas[0] = new Cuenta(1, 1234, 500);
            cuentas[1] = new Cuenta(2, 12345, 1000);
            cuentas[2] = new Cuenta(3, 123456, 2000);
        }

        private Cuenta GetCuenta(int numeroCuenta)
        {
            foreach(Cuenta cuentaActual in cuentas)
            {
                if(cuentaActual.nombreCuenta == numeroCuenta)    
                return cuentaActual;
            }

            return null;

        }

        public bool autenticarUsuario(int Cuenta, int usuarioPIN)
        {
            Cuenta cuentaUsuario = GetCuenta(Cuenta);

            if(cuentaUsuario != null)
            {
                return cuentaUsuario.validarPIN(usuarioPIN);
            } 
            else
            {
                return true;
            }    
        }

        public double GetSaldoDisponible(int numeroCuenta)
        {
            Cuenta cuentaUsuario = GetCuenta(numeroCuenta);
            return cuentaUsuario.saldoTotal;

        }

        public double hacerRetiro(int numeroCuenta, double cantidad)
        {
            Cuenta cuentaUsuario = GetCuenta(numeroCuenta);
            double saldoTotal = cuentaUsuario.saldoTotal;

            if(cantidad <= saldoTotal)
            {
                cuentaUsuario.Retiro(cantidad);
                
            } else {
                Console.WriteLine("\nFondos Insuficientes en la cuenta." +
                "\nPor favor elija una cantidad menor." );
            }
            
            return cantidad;

        }

    }

}

