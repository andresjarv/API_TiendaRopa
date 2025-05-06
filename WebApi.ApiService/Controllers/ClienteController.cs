using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ClienteController : ControllerBase
{
    private readonly IClienteService _clienteService;

    public ClienteController(IClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Cliente>> Get() => Ok(_clienteService.ObtenerTodos());

    [HttpGet("{id}")]
    public ActionResult<Cliente> Get(int id)
    {
        var cliente = _clienteService.ObtenerPorId(id);
        if (cliente == null) return NotFound();
        return Ok(cliente);
    }

    [HttpPost]
    public ActionResult<Cliente> Post(Cliente cliente)
    {
        var nuevo = _clienteService.Crear(cliente);
        return CreatedAtAction(nameof(Get), new { id = nuevo.Id }, nuevo);
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        if (!_clienteService.Eliminar(id)) return NotFound();
        return NoContent();
    }
}

