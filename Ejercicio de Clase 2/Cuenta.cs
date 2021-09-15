using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Clase_2
{
    //Clase padre: Cuenta
    public class Cuenta
    {
        public enum TipoDeExtraccion { CajeroHumano = 1, CajeroAutomatico };

        private float cantidad;
        TipoDeExtraccion ext;

        public float Cantidad { get => cantidad; set => cantidad = value; }

        public Cuenta() {}
        
        public void insercion(int monto) {
            this.cantidad += monto;
        }
        public virtual void extraccion(int monto, TipoDeExtraccion extra) {}
    }

    //Clase hija: Cuenta Corriente en Pesos
    public class Cta_Cte_Pesos : Cuenta {

        public override void extraccion(int monto, TipoDeExtraccion tipo)
        {
            switch (tipo)
            {
                case TipoDeExtraccion.CajeroAutomatico:

                    if ((this.Cantidad - monto) < -5000)
                    {
                        Console.WriteLine("no se puede extraer, la cuenta quedaria con menos de -5000 pesos");
                    }
                    else
                    {
                        if (monto > 20000)
                        {
                            Console.WriteLine("No se puede extraer mas de 20k por cajero automatico, visite una caja");
                        }
                        else
                        {
                            this.Cantidad -= monto;
                        }
                    }
                    break;

                case TipoDeExtraccion.CajeroHumano:
                    this.Cantidad -= monto;
                    break;
            }
        }
    }

    //Clase hija: Cuenta Corriente en Dolares
    public class Cta_Cte_Dolares : Cuenta {
        public override void extraccion(int monto, TipoDeExtraccion tipo)
        {
            switch (tipo)
            {
                case TipoDeExtraccion.CajeroAutomatico:

                    if (monto > 200)
                    {
                        Console.WriteLine("No se puede extraer mas de 200 dolares por cajero automatico, visite una caja");
                    }
                    else
                    {
                        this.Cantidad -= monto;
                    }
                    break;

                case TipoDeExtraccion.CajeroHumano:
                    this.Cantidad -= monto;
                    break;
            }
        }

    }

    //Clase hija: Caja de Ahorros en Pesos
    public class Caja_Ahorro_Pesos : Cuenta {
        public override void extraccion(int monto, TipoDeExtraccion tipo)
        {
            switch (tipo)
            {
                case TipoDeExtraccion.CajeroAutomatico:

                    if (monto > 10000)
                    {
                        Console.WriteLine("No se puede extraer mas de 10k por cajero automatico, visite una caja");
                    }
                    else
                    {
                        this.Cantidad -= monto;
                    }
                    break;

                case TipoDeExtraccion.CajeroHumano:
                    this.Cantidad -= monto;
                    break;
            }
        }
    }
}
