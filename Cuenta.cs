namespace SistemaParaBanco
{

    public class Cuenta
    {

        //Propiedades
        public int nombreCuenta {get; set;}
        public int PIN {get; set;}
        public double saldoTotal {get; set;}  

        //Metodo constructor
        public Cuenta(int elNombreCuenta, int elPIN, double elSaldoTotal)
        {
            nombreCuenta = elNombreCuenta;
            PIN = elPIN;
            saldoTotal = elSaldoTotal;

        }

        //Metodos de la clase Cuenta
        public bool validarPIN(int usuarioPIN)
        {
            if(PIN == usuarioPIN){
                return true;
            } 
            else 
            {
                return false;
            }
            
        }

        public void Retiro(double cantidad)
        {
            saldoTotal -= cantidad;

        }

        public void Desposito(double cantidad)
        {
            saldoTotal += cantidad;

        }

    }

}