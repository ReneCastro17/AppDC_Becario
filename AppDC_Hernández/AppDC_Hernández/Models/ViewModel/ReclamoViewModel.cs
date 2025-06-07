using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace AppDC_Hernández.Models.ViewModel
{
    public class ReclamoViewModel 
    {
        [Required(ErrorMessage = "El nombre del proveedor es obligatorio.")]
        [RegularExpression(@"^[A-Za-zÁÉÍÓÚáéíóúÑñ\s]+$", ErrorMessage = "El nombre solo debe contener letras.")]
        public string NombreProveedor { get; set; }

        [Required(ErrorMessage = "La dirección del proveedor es obligatoria.")]
        public string DireccionProveedor { get; set; }

        [Required(ErrorMessage = "Los nombres del consumidor son obligatorios.")]
        [RegularExpression(@"^[A-Za-zÁÉÍÓÚáéíóúÑñ\s]+$", ErrorMessage = "El nombre solo debe contener letras.")]
        public string NombresConsumidor { get; set; }

        [Required(ErrorMessage = "Los apellidos del consumidor son obligatorios.")]
        [RegularExpression(@"^[A-Za-zÁÉÍÓÚáéíóúÑñ\s]+$", ErrorMessage = "El apellido solo debe contener letras.")]
        public string ApellidosConsumidor { get; set; }

        [Required(ErrorMessage = "El DUI es obligatorio.")]
        [RegularExpression(@"^\d{8}-\d{1}$", ErrorMessage = "El DUI debe tener formato 00000000-0.")]
        public string DUI { get; set; }

        [Required(ErrorMessage = "El detalle del reclamo es obligatorio.")]
        public string DettalleReclamo { get; set; }

        [Required(ErrorMessage = "El monto del reclamo es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El monto debe ser mayor o igual a 0.01.")]
        public decimal? MontoReclamado { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [StringLength(10, ErrorMessage = "El teléfono no puede tener más de 10 dígitos.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Solo se permiten números en el teléfono.")]
        public string Telefono { get; set; }

    }
}

