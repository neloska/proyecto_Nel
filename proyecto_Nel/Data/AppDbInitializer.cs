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
                            Nombre = "Gijon",
                            logolURL = "https://i.pinimg.com/originals/94/71/df/9471dff5831a040a8288072c6697f32c.jpg",
                            Descripcion = "Esto es una descripcion de gijon"
                        },

                        new ciudades()
                        {
                            Nombre = "Oviedo",
                            logolURL = "https://images.squarespace-cdn.com/content/v1/5a86b05bcf81e0af04936cc7/1534417590635-76526BKJ8IJ1SCB8TUXK/que-ver-en-asturias-oviedo.jpg",
                            Descripcion = "Esto es una descripcion de oviedo"
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
                            FotoDePerfilURL = "https://i.pinimg.com/474x/a0/fe/f9/a0fef98ebec2fb037a49dc06bcee86d8--monopoly.jpg",
                            DescripcionPropietario = "Pues eso, el viejo del monopoly"
                        },

                        new propietario()
                        {
                            NombreCompleto = "Amancio Ortega",
                            FotoDePerfilURL = "https://cope-cdnmed.agilecontent.com/resources/jpg/9/9/1634539525199.jpg",
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
                            FotoDePerfilURL = "https://happytravel.viajes/wp-content/uploads/2020/04/146-1468479_my-profile-icon-blank-profile-picture-circle-hd.png",
                            DescripcionEmpleado = "Empleado 1"
                        },

                        new empleados()
                        {
                            NombreCompleto = "Empelado 2",
                            FotoDePerfilURL = "https://happytravel.viajes/wp-content/uploads/2020/04/146-1468479_my-profile-icon-blank-profile-picture-circle-hd.png",
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
                            Nombre = "Propiedad 1",
                            Descripcion = "Descripcion de la propiedad 1",
                            precioPropiedad = 7500000.00,
                            FotoPropiedadURL = "https://st3.idealista.com/news/archivos/styles/imagen_big_lightbox/public/2020-06/im-191825.jpg?sv=_9b9J8T9&itok=7HUggoEv",
                            FechaPublicacion = System.DateTime.Now.AddSeconds(5),
                            FechaFinal = System.DateTime.Now.AddDays(10),
                            IdCiudad = 1,
                            IdEmpelado = 1,
                            PropiedadCiudad = PropiedadCiudad.Mansion
                        },

                        new propiedades()
                        {
                            Nombre = "Propiedad 2",
                            Descripcion = "Descripcion de la propiedad 2",
                            precioPropiedad = 355000.00,
                            FotoPropiedadURL = "https://design-milk.com/images/2017/10/KW-Apartment-anthill-1.jpg",
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
                            IdPropietario = 5,
                            IdPropiedad =7,
                        },

                        new propietarios_propiedad()
                        {
                            IdPropietario = 6,
                            IdPropiedad = 8,
                        },
                    });
                    context.SaveChanges();
                } 
            }
        }
    }
}
