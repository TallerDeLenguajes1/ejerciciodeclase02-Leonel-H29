using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Clase_2
{
    public enum TipoDeExtraccion {CajeroHumano =1,CajeroAutomatico };
    public class Cuenta
    {
        int num;
        TipoDeExtraccion ext;
        public Cuenta() {
            this.num = 0;
        }
        public Cuenta(int _num, TipoDeExtraccion extra) {
            this.num = _num;
            this.ext = extra;
        }
        public int insersion(int num) {
            return 0;
        }
        public int extraccion(int num, TipoDeExtraccion extra) { return 0; }
    }

    public class Cta_Cte_Pesos : Cuenta {

        public int insersion(int num)
        {
            return 0;
        }
        public int extraccion(int num, TipoDeExtraccion extra) { 
           if(extra == CajeroHumano)
            {
                if(num >= 20000)
                {
                    Console.WriteLine(@"Se extrajo {num}");
                    return num;
                }
                else {
                    Console.WriteLine(@"No puede extraer ese dinero");
                    return 0;
                }
            }
            else {
                if (num >= 20000)
                {
                    Console.WriteLine(@"Se extrajo {num}");
                    return num;
                }
                else
                {
                    Console.WriteLine(@"No puede extraer ese dinero");
                    return 0;
                }
            }
        }
    }

    public class Cta_Cte_Dolares : Cuenta {
        public int insersion(int num)
        {
            return 0;
        }
        public int extraccion(int num, TipoDeExtraccion extra)
        {
            if (extra == CajeroHumano)
            {
                if (num >= 20000)
                {
                    Console.WriteLine(@"Se extrajo {num}");
                    return num;
                }
                else
                {
                    Console.WriteLine(@"No puede extraer ese dinero");
                    return 0;
                }
            }
            else
            {
                if (num >= 20000)
                {
                    Console.WriteLine(@"Se extrajo {num}");
                    return num;
                }
                else
                {
                    Console.WriteLine(@"No puede extraer ese dinero");
                    return 0;
                }
            }
        }

    }

    public class Caja_Ahorro_Pesos : Cuenta {
        public int insersion(int num)
        {
            return 0;
        }
        public int extraccion(int num, TipoDeExtraccion extra)
        {
            if (extra == CajeroHumano)
            {
                if (num >= 20000)
                {
                    Console.WriteLine(@"Se extrajo {num}");
                    return num;
                }
                else
                {
                    Console.WriteLine(@"No puede extraer ese dinero");
                    return 0;
                }
            }
            else
            {
                if (num >= 20000)
                {
                    Console.WriteLine(@"Se extrajo {num}");
                    return num;
                }
                else
                {
                    Console.WriteLine(@"No puede extraer ese dinero");
                    return 0;
                }
            }
        }
    }
}
