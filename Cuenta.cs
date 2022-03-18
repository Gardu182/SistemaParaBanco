namespace SistemaParaBanco
{

    public class Cuenta
    {

        //Propiedades
        public int nombreCuenta {get; set;}
        public int PIN {get; set;}
        public double saldoDisponible {get; set;}
        public double saldoTotal {get; set;}  

        //Metodo constructor
        public Cuenta(int elNombreCuenta, int elPIN, double elSaldoDisponible, double elSaldoTotal)
        {
            nombreCuenta = elNombreCuenta;
            PIN = elPIN;
            saldoDisponible = elSaldoDisponible;
            saldoTotal = elSaldoTotal;

        }

        //Metodos de la clase Cuenta
        public bool validarPIN(int usuarioPIN)
        {
            if(usuarioPIN == PIN){
                return true;
            } 
            else 
            {
                return false;
            }
            
        }

        public void credito(double cantidad)
        {
            saldoTotal += cantidad;

        }

    }

}