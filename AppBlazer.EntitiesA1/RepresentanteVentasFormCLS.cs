using System.ComponentModel.DataAnnotations;

namespace AppBlazer.EntitiesA1
{
    public class RepresentanteVentasFormCLS
    {
        [Required(ErrorMessage = "El número de empleado es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El id del libro debe ser un número positivo")]
        public int Num_Empl { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public string Nombre { get; set; }

        [Range(18, 99, ErrorMessage = "La edad debe ser mayor o igual a 18.")]
        public int Edad { get; set; } 

        [Required(ErrorMessage = "El cargo es obligatorio.")]
        [StringLength(50, ErrorMessage = "El cargo no puede exceder los 50 caracteres.")]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "La fecha de contrato es obligatoria.")]
        [DataType(DataType.Date, ErrorMessage = "Debe ingresar una fecha válida.")]
        public DateTime FechaContrato { get; set; }

        [Required(ErrorMessage = "La cuota es obligatoria.")]
        [Range(1, double.MaxValue, ErrorMessage = "La cuota debe ser un valor numérico positivo.")]
        public decimal Cuota { get; set; }

        [Required(ErrorMessage = "Las ventas son obligatorias.")]
        [Range(1, double.MaxValue, ErrorMessage = "Las ventas deben ser un valor numérico positivo.")]
        public decimal Ventas { get; set; }

    }
}
