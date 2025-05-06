public interface IClienteService
{
    IEnumerable<Cliente> ObtenerTodos();
    Cliente ObtenerPorId(int id);
    Cliente Crear(Cliente cliente);
    bool Eliminar(int id);
}
