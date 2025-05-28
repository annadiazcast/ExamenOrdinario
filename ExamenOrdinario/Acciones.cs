using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinario
{
    internal class Acciones : IAcciones
    {
        List<Auto> listaautos = new List<Auto>()
        {
            new Auto(1212,"Jeep","Rubicon",2025,"Negro",5562.35,"Disponible")
        };
        Correo correo = new Correo();

        public List<Auto> Mostrar()
        {
            try
            {
                return listaautos;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                throw;
            }
        }
        public bool Eliminar(int id)
        {
            try
            {
                var objeliminar = listaautos.Find(x => x.Id == id);
                if (objeliminar != null)
                {
                    listaautos.Remove(objeliminar);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                throw;
            }
        }
        public bool Agregar(int id, string marca, string modelo, int anio, string color, double precio, string estado)
        {
            try
            {
                listaautos.Add(new Auto(id, marca, modelo, anio, color, precio, estado));
                return true;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                throw;
            }
        }
        public bool Actualizar(int id, string marca, string modelo, int anio, string color, double precio, string estado)
        {
            try
            {
                var objActualizar = listaautos.Find(x => x.Id == id);
                if (objActualizar != null)
                {
                    objActualizar.Marca = marca;
                    objActualizar.Modelo = modelo;
                    objActualizar.Anio = anio;
                    objActualizar.Color = color;
                    objActualizar.Precio = precio;
                    objActualizar.Estado = estado;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                throw;
            }
        }
        public bool ExportaraExcel()
        {
            try
            {
                var workbook = new XLWorkbook();
                var worksheet = workbook.Worksheets.Add("Autos");

                // Encabezados
                worksheet.Cell(1, 1).Value = "Id";//siempre empiezan las celdad como (1,1)
                worksheet.Cell(1, 2).Value = "Marca";
                worksheet.Cell(1, 3).Value = "Modelo";
                worksheet.Cell(1, 4).Value = "Año";
                worksheet.Cell(1, 5).Value = "Color";
                worksheet.Cell(1, 6).Value = "Precio";
                worksheet.Cell(1, 7).Value = "Estado";

                // Datos
                for (int i = 0; i < listaautos.Count; i++)
                {
                    var auto = listaautos[i];
                    worksheet.Cell(i + 2, 1).Value = auto.Id;
                    worksheet.Cell(i + 2, 2).Value = auto.Marca;
                    worksheet.Cell(i + 2, 3).Value = auto.Modelo;
                    worksheet.Cell(i + 2, 4).Value = auto.Anio;
                    worksheet.Cell(i + 2, 5).Value = auto.Color;
                    worksheet.Cell(i + 2, 6).Value = auto.Precio;
                    worksheet.Cell(i + 2, 7).Value = auto.Estado;

                }

                // Ruta al escritorio
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "ListaDeAutos.xlsx");

                workbook.SaveAs(filePath);
                return true;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                return false;
            }
        }
        public bool ImportarDeExcel()
        {
            try
            {
                var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var filePath = Path.Combine(desktopPath, "Autos.xlsx");//Nombre del excel a importar

                if (!File.Exists(filePath))
                {
                    return false;
                }

                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet("Sheet1");//Nombre de la hoja del archivo de excel a importar

                    var rows = worksheet.RowsUsed().Skip(1); // Saltar encabezado

                    listaautos.Clear(); // Limpiar la lista antes de importar nuevos datos

                    foreach (var row in rows)
                    {
                        int id = 0;
                        int.TryParse(row.Cell(1).Value.ToString(), out id);

                        var marca = row.Cell(2).Value.ToString();
                        var modelo = row.Cell(3).Value.ToString();

                        int anio = 0;
                        int.TryParse(row.Cell(4).Value.ToString(), out anio);

                        var color = row.Cell(5).Value.ToString();

                        double precio = 0;
                        double.TryParse(row.Cell(6).Value.ToString(), out precio);

                        var estado = row.Cell(7).Value.ToString();

                        listaautos.Add(new Auto(id, marca, modelo, anio, color, precio, estado));
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                correo.EnviarCorreo(ex.ToString());
                return false;
            }
        }
        public int ContarAutos()
        {
            int contador = 0;
            return contador=listaautos.Count;

        }
        public double Suma()
        {
            double sumaprecios = 0;
            foreach (var prec in listaautos)
            {
                sumaprecios = sumaprecios + prec.Precio;
            }

            return sumaprecios;
        }



    }
}
