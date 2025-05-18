using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinario
{
    internal interface IAcciones
    {
        List<Auto> Mostrar();
        bool Agregar(int id, string marca, string modelo, int anio, string color, double precio, string estado);
        bool Eliminar(int id);
        bool Actualizar(int id, string marca, string modelo, int anio, string color, double precio, string estado);
        bool ExportaraExcel();
        bool ImportarDeExcel();

    }
}
