public class ClienteService : IClienteService
{
    private readonly List<Cliente> _clientes = new();
    private int _siguienteId = 1;

    public IEnumerable<Cliente> ObtenerTodos() => _clientes;

    public Cliente ObtenerPorId(int id) => _clientes.FirstOrDefault(c => c.Id == id);

    public Cliente Crear(Cliente cliente)
    {
        cliente.Id = _siguienteId++;
        _clientes.Add(cliente);
        return cliente;
    }

    public bool Eliminar(int id)
    {
        var cliente = ObtenerPorId(id);
        if (cliente == null) return false;
        _clientes.Remove(cliente);
        return true;
    }
}
