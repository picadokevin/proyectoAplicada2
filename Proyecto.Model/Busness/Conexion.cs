using Proyecto.Model.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Model.Busness
{
  public  class Conexion
    {
        Conexion conexionData;
        public List<Key> Getkey(String title)
        {
            return this.conexionData.Getkey(title);
        }
    }
}
