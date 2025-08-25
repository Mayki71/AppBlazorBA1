using AppBlazer.EntitiesA1;

namespace AppBlazor.ClientA1.Services
{
    public class RepresentanteVentasService
    {
        private List<RepresentateVentasListCls> lista;

        public RepresentanteVentasService()
        {
            lista = new List<RepresentateVentasListCls>();

            lista.Add(new RepresentateVentasListCls
            {
                Num_Empl = 1,
                Nombre = "Juan Pérez",
                Edad = 30,
                Cargo = "Vendedor",
                FechaContrato = new DateTime(2020, 5, 10),
                Cuota = 1500.50m,
                Ventas = 20000.75m
            });

            lista.Add(new RepresentateVentasListCls
            {
                Num_Empl = 2,
                Nombre = "María Gómez",
                Edad = 28,
                Cargo = "Asistente",
                FechaContrato = new DateTime(2021, 3, 15),
                Cuota = 1200.00m,
                Ventas = 15000.25m
            });

        }

        public List<RepresentateVentasListCls> listarRepresentanteVentas()
        {
            return lista;
        }
        public void eliminarRepresentanteVentas(int Num_Empl)
        {
            var listaQueda = lista.Where(p => p.Num_Empl != Num_Empl).ToList();
            lista = listaQueda;
        }

    }
}
