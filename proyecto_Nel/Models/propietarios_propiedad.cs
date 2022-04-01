namespace proyecto_Nel.Models
{
    //tabla intermedia de propiedad y propietarios
    public class propietarios_propiedad
    {
        public int IdPropiedad { get; set; }
        public propiedades propiedades { get; set; }

        public int IdPropietario { get; set; }
        public propietario propietario { get; set; }
    }
}
