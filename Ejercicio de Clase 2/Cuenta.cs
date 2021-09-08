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
        public Cuenta() { }
        public Cuenta(int _num, TipoDeExtraccion extra) {
            this.num = _num;
            this.ext = extra;
        }
        public int insersion(int num) {
            return;
        }
        public int extraccion(int num, TipoDeExtraccion extra) { return; }
    }

    public class Cta_Cte_Pesos : Cuenta { }

    public class Cta_Cte_Dolares : Cuenta { }

    public class Caja_Ahorro_Pesos : Cuenta { }
}
