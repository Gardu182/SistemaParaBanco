namespace SistemaParaBanco
{
    public class BaseDatos
    {


        private Cuenta[] cuentas;

        public BaseDatos()
        {
            cuentas = new Cuenta[3];
            cuentas[0] = new Cuenta(1, 1234, 500, 500);
            //cuentas[1] = new Cuenta("Priority",12345, 1000, 1000);
            //cuentas[2] = new Cuenta("Standard",123456, 2000, 2000);
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

    }

}

