using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using proyecto_Nel.Models;
using System.Collections.Generic;
using System.Linq;

namespace proyecto_Nel.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //referencia al archivo al que vamos a enviar datos a la base de datos o pedirlos
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //CIUDADES
                if (!context.ciudades.Any())
                {
                    context.ciudades.AddRange(new List<ciudades>(){
                        new ciudades()
                        {
                            NombreCiudad = "Gijon",
                            logolURL = "D:/NelAllendeIglesias/Proyecto/Backend/imagenes/ciudades/gijon.jpg",
                            DescripcionCiudad = "Esto es una descripcion de gijon"
                        },

                        new ciudades()
                        {
                            NombreCiudad = "Oviedo",
                            logolURL = "D:/NelAllendeIglesias/Proyecto/Backend/imagenes/ciudades/oviedo.jpg",
                            DescripcionCiudad = "Esto es una descripcion de oveido"
                        },
                    });
                    context.SaveChanges();
                }

                //PROPIETARIOS
                if (!context.propietario.Any())
                {
                    context.propietario.AddRange(new List<propietario>(){
                        new propietario()
                        {
                            NombreCompleto = "El señor del Monopoly",
                            FotoDePerfilURL = "D:/NelAllendeIglesias/Proyecto/Backend/imagenes/propietarios/monopoly.jpg",
                            DescripcionPropietario = "Pues eso, el viejo del monopoly"
                        },

                        new propietario()
                        {
                            NombreCompleto = "Amancio Ortega",
                            FotoDePerfilURL = "D:/NelAllendeIglesias/Proyecto/Backend/imagenes/propietarios/amancio.jpg",
                            DescripcionPropietario = "Pues eso, el viejo del zara"
                        },
                    });
                    context.SaveChanges();
                }

                //EMPLEADOS
                if (!context.empleados.Any())
                {
                    context.empleados.AddRange(new List<empleados>(){
                        new empleados()
                        {
                            NombreCompleto = "Empelado 1",
                            FotoDePerfilURL = "D:/NelAllendeIglesias/Proyecto/Backend/imagenes/empleados/empleado-1.jpg",
                            DescripcionEmpleado = "Empleado 1"
                        },

                        new empleados()
                        {
                            NombreCompleto = "Empelado 2",
                            FotoDePerfilURL = "D:/NelAllendeIglesias/Proyecto/Backend/imagenes/empleados/empleado-2.jpg",
                            DescripcionEmpleado = "Empleado 2"
                        },
                    });
                    context.SaveChanges();
                }

                //PROPIEDADES
                if (!context.propiedades.Any())
                {
                    context.propiedades.AddRange(new List<propiedades>(){
                        new propiedades()
                        {
                            NombrePropiedad = "Propiedad 1",
                            DescripcionPropiedad = "Descripcion de la propiedad 1",
                            precioPropiedad = 7500000.00,
                            FotoPropiedadURL = "D:/NelAllendeIglesias/Proyecto/Backend/imagenes/propiedades/casa-1.jpg",
                            FechaPublicacion = System.DateTime.Now.AddSeconds(5),
                            FechaFinal = System.DateTime.Now.AddDays(10),
                            IdCiudad = 1,
                            IdEmpelado = 1,
                            PropiedadCiudad = PropiedadCiudad.Mansion
                        },

                        new propiedades()
                        {
                            NombrePropiedad = "Propiedad 2",
                            DescripcionPropiedad = "Descripcion de la propiedad 2",
                            precioPropiedad = 355000.00,
                            FotoPropiedadURL = "D:/NelAllendeIglesias/Proyecto/Backend/imagenes/propiedades/casa-2.jpg",
                            FechaPublicacion = System.DateTime.Now.AddSeconds(5),
                            FechaFinal = System.DateTime.Now.AddDays(10),
                            IdCiudad = 2,
                            IdEmpelado = 2,
                            PropiedadCiudad = PropiedadCiudad.Apartamento
                        },
                    });
                    context.SaveChanges();
                }

                //PROPIETARIOS_PROPIEDAD
                if (!context.propietarios_propiedad.Any())
                {
                    context.propietarios_propiedad.AddRange(new List<propietarios_propiedad>(){
                        new propietarios_propiedad()
                        {
                            IdPropietario = 1,
                            IdPropiedad = 1,
                        },

                        new propietarios_propiedad()
                        {
                            IdPropietario = 2,
                            IdPropiedad = 2,
                        },
                    });
                    context.SaveChanges();
                } 
            }
        }
    }
}
