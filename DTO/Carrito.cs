using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeladeriaTAMS.Models;


namespace HeladeriaTAMS.DTO
{
    public class Carrito
    {
        public decimal total { get; set; }
        public List<Proforma>? itemsCarrito { get; set; }
    }
}