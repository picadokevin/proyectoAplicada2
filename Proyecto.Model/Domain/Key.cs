using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Model.Domain
{
    public class Key
    {
        private String codKey;
        private int Status;

        public Key()
        {
        }

        public Key(string codKey, int status)
        {
            this.codKey = codKey;
            Status = status;
        }

        public string CodKey { get => codKey; set => codKey = value; }
        public int Status1 { get => Status; set => Status = value; }
    }
}
