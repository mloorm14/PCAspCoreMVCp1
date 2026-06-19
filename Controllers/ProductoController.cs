using Microsoft.AspNetCore.Mvc;
using MiPrimerMVC.Models;

namespace MiPrimerMVC.Controllers
{
    /// <summary>
    /// Controlador responsable de las operaciones CRUD sobre Producto.
    /// Hereda de Controller (no ControllerBase) para tener acceso
    /// a la API de Vistas (View(), TempData, ModelState, etc.).
    /// </summary>
    public class ProductoController : Controller
    {
        // ----------------------------------------------------------------
        // Repositorio en memoria (solo para fines didacticos).
        // En produccion se inyectaria IProductoRepository via DI.
        // ----------------------------------------------------------------
        private static readonly List<Producto> _productos = new();
        private static int _nextId = 1;

        // ----------------------------------------------------------------
        // GET: /Producto/Index
        // Recupera todos los productos y los pasa como modelo a la vista.
        // ----------------------------------------------------------------
        public IActionResult Index()
        {
            return View(_productos);
        }

        // ----------------------------------------------------------------
        // GET: /Producto/Create
        // Devuelve el formulario vacio para crear un nuevo producto.
        // ----------------------------------------------------------------
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // ----------------------------------------------------------------
        // POST: /Producto/Create
        //
        // [ValidateAntiForgeryToken] registra un filtro de autorizacion
        // que llama a IAntiforgery.ValidateRequestAsync() ANTES de que
        // este metodo se ejecute. Si el token no es valido, devuelve
        // HTTP 400 Bad Request inmediatamente.
        //
        // El parametro 'producto' es populado por el Model Binder:
        // ComplexObjectModelBinder itera las propiedades del tipo,
        // extrae los valores del FormValueProvider y ejecuta las
        // validaciones. ModelState refleja el resultado.
        // ----------------------------------------------------------------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                // Todos los ValidationAttribute pasaron: persistir.
                producto.Id = _nextId++;
                _productos.Add(producto);

                // TempData persiste un mensaje entre el redirect (PRG pattern).
                TempData["Exito"] =
                    $"Producto '{producto.Nombre}' registrado correctamente.";

                // Post/Redirect/Get pattern: evita el reenvio del formulario
                // al recargar la pagina.
                return RedirectToAction(nameof(Index));
            }

            // Al menos un ValidationAttribute fallo.
            // Se reenvía la vista con el objeto 'producto' (datos ingresados)
            // para que los tag helpers rendericen los mensajes de error
            // usando ModelState["Campo"].Errors.
            return View(producto);
        }
    }
}