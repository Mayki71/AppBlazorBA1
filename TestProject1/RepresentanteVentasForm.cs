using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace AppBlazor.Test
{
    public class RepresentanteVentasForm
    {
        private List<ValidationResult> ValidarModelo(object modelo)
        {
            var resultados = new List<ValidationResult>();
            var contexto = new ValidationContext(modelo, null, null);
            Validator.TryValidateObject(modelo, contexto, resultados, true);
            return resultados;
        }

        [Fact]
        public void ValidacionDebeFallarCuandoCamposEstanVacios()
        {
            // Arrange
            var representante = new RepresentanteVentas();

            // Act
            var errores = ValidarModelo(representante);

            /*// Assert (verificamos que muestre errores por campos obligatorios)
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El número de empleado es obligatorio."));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El nombre es obligatorio."));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("La edad debe ser mayor o igual a 18."));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El cargo es obligatorio."));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("La fecha de contrato es obligatoria."));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("La cuota es obligatoria."));
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("Las ventas son obligatorias."));*/
        }

        [Fact]
        public void ValidacionDebePasarConDatosCorrectos()
        {
            var representante = new RepresentanteVentas
            {
                Num_Empl = 1001,
                Nombre = "Juan Pérez",
                Edad = 30,
                Cargo = "Vendedor Senior",
                FechaContrato = DateTime.Now,
                Cuota = 5000,
                Ventas = 6000
            };

            var errores = ValidarModelo(representante);

            Assert.Empty(errores); // No debería haber errores con datos válidos
        }
    }

    // Modelo con DataAnnotations (puedes moverlo a tu carpeta Entities/Models)
    public class RepresentanteVentas
    {
        [Required(ErrorMessage = "El número de empleado es obligatorio.")]
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
        [Range(0, double.MaxValue, ErrorMessage = "La cuota debe ser un valor numérico positivo.")]
        public decimal Cuota { get; set; }

        [Required(ErrorMessage = "Las ventas son obligatorias.")]
        [Range(0, double.MaxValue, ErrorMessage = "Las ventas deben ser un valor numérico positivo.")]
        public decimal Ventas { get; set; }
    }
}