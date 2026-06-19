using System.ComponentModel.DataAnnotations;

namespace MiPrimerMVC.Models
{
    /// <summary>
    /// Modelo de dominio que representa un producto del catalogo.
    /// Las Data Annotations declaran las restricciones de validacion
    /// que el pipeline de ASP.NET Core evaluara automaticamente
    /// durante el Model Binding antes de ejecutar la accion POST.
    /// </summary>
    public class Producto
    {
        // Identificador generado por el repositorio; no se valida.
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        [StringLength(100, MinimumLength = 2,
            ErrorMessage = "El nombre debe tener entre 2 y 100 caracteres.")]
        [Display(Name = "Nombre del Producto")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "La descripcion es obligatoria.")]
        [StringLength(500,
            ErrorMessage = "La descripcion no puede superar los 500 caracteres.")]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; } = string.Empty;

        [Required(ErrorMessage = "El precio es obligatorio.")]
        [Range(0.01, 99999.99,
            ErrorMessage = "El precio debe estar entre $0.01 y $99,999.99.")]
        [DataType(DataType.Currency)]
        [Display(Name = "Precio (USD)")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El stock es obligatorio.")]
        [Range(0, 10000,
            ErrorMessage = "El stock debe estar entre 0 y 10,000 unidades.")]
        [Display(Name = "Stock disponible")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "La categoria es obligatoria.")]
        [StringLength(50,
            ErrorMessage = "La categoria no puede superar los 50 caracteres.")]
        [Display(Name = "Categoria")]
        public string Categoria { get; set; } = string.Empty;
    }
}