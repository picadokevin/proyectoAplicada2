using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Model.Domain
{
   public class Category
    {
        private int codCategory;
        private String detailCategory;
        public Category()
        {

        }
        public Category(int codCategory, string detailCategory)
        {
            this.codCategory = codCategory;
            this.detailCategory = detailCategory;
        }

        public int CodCategory { get => codCategory; set => codCategory = value; }
        public string DetailCategory { get => detailCategory; set => detailCategory = value; }
    }
}
