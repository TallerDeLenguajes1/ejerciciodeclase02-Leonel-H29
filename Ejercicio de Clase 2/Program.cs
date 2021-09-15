using System;

namespace Ejercicio_de_Clase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta APesos = new Caja_Ahorro_Pesos();
            Cuenta CDolares = new Cta_Cte_Dolares();
            Cuenta CPesos = new Caja_Ahorro_Pesos();


            APesos.insercion(5000);
            CDolares.insercion(5000);
            CPesos.insercion(5000);


            CPesos.extraccion(30000, Cuenta.TipoDeExtraccion.CajeroAutomatico); //mas de 20k por cajero
            CPesos.extraccion(300, Cuenta.TipoDeExtraccion.CajeroAutomatico); //ok
            CPesos.extraccion(600, Cuenta.TipoDeExtraccion.CajeroHumano); //ok

            CDolares.extraccion(300, Cuenta.TipoDeExtraccion.CajeroAutomatico); //mas de 200 por cajero
            CDolares.extraccion(100, Cuenta.TipoDeExtraccion.CajeroAutomatico); //ok
            CDolares.extraccion(600, Cuenta.TipoDeExtraccion.CajeroHumano); //ok

            APesos.extraccion(999999999, Cuenta.TipoDeExtraccion.CajeroAutomatico); //sin fondos
            APesos.extraccion(30000, Cuenta.TipoDeExtraccion.CajeroAutomatico); //mas de 10k por cajero
            APesos.extraccion(500, Cuenta.TipoDeExtraccion.CajeroAutomatico); //ok
            APesos.extraccion(600, Cuenta.TipoDeExtraccion.CajeroHumano); //ok
        }
    }
}
