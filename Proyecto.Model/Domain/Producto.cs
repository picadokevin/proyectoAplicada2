using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Model.Domain
{
   public class Producto
    {
        private int codProduct;
        private String nameProduct;
        private float priceProduct;
        private String descriptionProduct;
        private String image;
        private Category category;
        public Producto()
        {
            category = new Category();
        }

        public Producto(int codProduct, string nameProduct, float priceProduct, string descriptionProduct, string image, Category category)
        {
            this.codProduct = codProduct;
            this.nameProduct = nameProduct;
            this.priceProduct = priceProduct;
            this.descriptionProduct = descriptionProduct;
            this.image = image;
            this.category = category;
        }

        public int CodProduct { get => codProduct; set => codProduct = value; }
        public string NameProduct { get => nameProduct; set => nameProduct = value; }
        public float PriceProduct { get => priceProduct; set => priceProduct = value; }
        public string DescriptionProduct { get => descriptionProduct; set => descriptionProduct = value; }
        public string Image { get => image; set => image = value; }
        public Category Category { get => category; set => category = value; }
    }

}
