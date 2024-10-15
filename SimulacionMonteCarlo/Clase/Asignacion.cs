using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionMonteCarlo.Clase
{
    public class Asignacion
    {
        public int  IdPunto { get; set; }
        public int Panel1 { get; set; }
        public int Panel2 { get; set; }
        public int Panel3 { get; set; }
        public int Panel4 { get; set; }
        public int Panel5 { get; set; }
        public int PanelE { get; set; }

        public Asignacion()
        {

        }
        public Asignacion(Asignacion asignacion)
        {
            IdPunto = asignacion.IdPunto;
            Panel1 = asignacion.Panel1;
            Panel2 = asignacion.Panel2;
            Panel3 = asignacion.Panel3;
            Panel4 = asignacion.Panel4;
            Panel5 = asignacion.Panel5;
            PanelE = asignacion.PanelE;
        }

    }
}
