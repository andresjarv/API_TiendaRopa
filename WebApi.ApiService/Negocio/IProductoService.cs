using System.Collections.Generic;
using WebApi.ApiService.Entidades;

namespace WebApi.ApiService.Negocio
{
    public interface IProductoService
    {
        /// <summary>
        /// Obtiene todos los productos registrados en el sistema.
        /// </summary>
        /// <returns>Una lista de objetos <see cref="Producto"/>.</returns>
        List<Producto> ObtenerTodos();

        /// <summary>
        /// Busca un producto por su ID único.
        /// </summary>
        /// <param name="id">ID del producto a buscar.</param>
        /// <returns>El <see cref="Producto"/> si se encuentra; de lo contrario, <c>null</c>.</returns>
        Producto ObtenerPorId(int id);

        /// <summary>
        /// Agrega un nuevo producto al sistema.
        /// </summary>
        /// <param name="producto">Datos del producto a agregar. Debe incluir Nombre, Precio y Stock.</param>
        /// <remarks>
        /// El ID del producto se genera automáticamente (se ignora si se proporciona en el objeto).
        /// </remarks>
        void Agregar(Producto producto);

        /// <summary>
        /// Elimina un producto existente por su ID.
        /// </summary>
        /// <param name="id">ID del producto a eliminar.</param>
        /// <returns>
        /// <c>true</c> si el producto se eliminó correctamente; 
        /// <c>false</c> si no se encontró el producto.
        /// </returns>
        bool Eliminar(int id);
    }
}

