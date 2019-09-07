using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Model.Domain
{
    public class Key
    {
        private String codKey;
       
        private int idSuppliers;

        public Key()
        {
        }

        public Key(string codKey, int idSuppliers)
        {
            this.codKey = codKey;
            this.idSuppliers = idSuppliers;
        }

        public string CodKey { get => codKey; set => codKey = value; }
        public int IdSuppliers { get => idSuppliers; set => idSuppliers = value; }
    }
}
