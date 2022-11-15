using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using HeladeriaTAMS.Data;
using HeladeriaTAMS.Models;
using HeladeriaTAMS.Services;

namespace HeladeriaTAMS.Controllers.Rest
{
    [ApiController]
    [Route("api/productoref")]
    public class ProductoRestRefController : ControllerBase
    {
        private readonly ProductoService _service;


        public ProductoRestRefController(ProductoService service){
             _service = service;
        }


        [HttpPost]
        public Task<Producto> CreateProducto(Producto producto){
            return _service.crearProducto(producto);
        }

    }
}