using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiciosCelulares.Models;
namespace ServiciosCelulares.Clases
{
    public class clsModelo
    {
        public Modelo modelo { get; set; }
        private CELULARESEntities DBCelulares = new CELULARESEntities();

        public List<Modelo> ListarModelos()
        {
            return DBCelulares.Modeloes
                .OrderBy(p => p.NombreModelo)
                .ToList();

        }
        public Modelo Consultar(int modeloID)
        {
            return DBCelulares.Modeloes.FirstOrDefault(e => e.ModeloID == modeloID);
        }

        public String Insertar()
        {
            try
            {
                DBCelulares.Modeloes.Add(modelo);
                DBCelulares.SaveChanges();
                return "Se realizo la modelo con el ModeloID: " + modelo.ModeloID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Actualizar()
        {
            try
            {
                Modelo _modelo = Consultar(modelo.ModeloID);
                if (_modelo == null)
                {
                    return "El modelo con ID: " + modelo.ModeloID + ", no existe en la base de datos";
                }
                _modelo.ModeloID = modelo.ModeloID;
                _modelo.Marca = modelo.Marca;
                _modelo.NombreModelo = modelo.NombreModelo;
                DBCelulares.SaveChanges();
                return "Se actualizó el modelo con el ID: " + modelo.ModeloID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Eliminar()
        {
            try
            {
                Modelo _modelo = Consultar(modelo.ModeloID);
                if (_modelo == null)
                {
                    return "El modelo con ModeloID: " + modelo.ModeloID + ", no existe en la base de datos";
                }
                DBCelulares.Modeloes.Remove(_modelo);
                DBCelulares.SaveChanges();
                return "Se eliminó el modelo de la base de datos, ID: " + modelo.ModeloID;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}