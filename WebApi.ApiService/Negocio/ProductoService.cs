using System.Collections.Generic;
using System.Linq;
using WebApi.ApiService.Entidades;

namespace WebApi.ApiService.Negocio
{
    public class ProductoService : IProductoService
    {
        private readonly List<Producto> _productos = new List<Producto>();
        private int _nextId = 1;

        public List<Producto> ObtenerTodos() => _productos;

        public Producto ObtenerPorId(int id) => _productos.FirstOrDefault(p => p.Id == id);

        public void Agregar(Producto producto)
        {
            producto.Id = _nextId++;
            _productos.Add(producto);
        }

        public bool Eliminar(int id)
        {
            var producto = ObtenerPorId(id);
            return producto != null && _productos.Remove(producto);
        }
    }
}

