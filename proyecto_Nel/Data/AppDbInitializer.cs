using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using proyecto_Nel.Data.Static;
using proyecto_Nel.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                            logolURL = "https://i.pinimg.com/originals/94/71/df/9471dff5831a040a8288072c6697f32c.jpg",
                            DescripcionCiudad = "Se sitúa a orillas del mar Cantábrico, en el Principado de Asturias, comunidad " +
                            "autónoma de la que es el municipio más poblado, con 268 896 habitantes en 2021."
                        },

                        new ciudades()
                        {
                            NombreCiudad = "Oviedo",
                            logolURL = "https://images.squarespace-cdn.com/content/v1/5a86b05bcf81e0af04936cc7/1534417590635-76526BKJ8IJ1SCB8TUXK/que-ver-en-asturias-oviedo.jpg",
                            DescripcionCiudad = "Es reconocida como una de las ciudades con mayor calidad de vida de Europa según la Comisión Europea."
                        },

                        new ciudades()
                        {
                            NombreCiudad = "Candas",
                            logolURL = "https://sudigastro.es/wp-content/uploads/2019/07/Candas-6-1020x685.jpeg",
                            DescripcionCiudad = "Un bonito pueblo asturiano rodeado de un verde paisaje y fabulosas playas." +
                            " Candás ha estado vinculada desde siempre al mar."
                        },

                        new ciudades()
                        {
                            NombreCiudad = "Piedras Blancas",
                            logolURL = "https://www.turismoasturias.es/documents/11022/32125/Castrillon4.jpg?t=1389211106741",
                            DescripcionCiudad = "Piedras Blancas es la capital del concejo de Castrillón, donde se ubica la sede de la administración " +
                            "y la gran mayoría de servicios municipales."
                        },

                        new ciudades()
                        {
                            NombreCiudad = "Cudillero",
                            logolURL = "https://i.pinimg.com/originals/1e/0c/18/1e0c1865951794011f0400b6e69505f2.jpg",
                            DescripcionCiudad = " Dispone de un paisaje increíble, con playas únicas, verdes valles, ríos" +
                            " y cascadas, vertiginosos acantilados y media montaña con brañas vaqueiras."
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
                            DescripcionPropietario = "Rich Uncle-Milburn Pennybags. Como es un personaje de ficción que le da personalidad a" +
                            " un juego, sabemos poco de su historia, sólo que es muy rico, que su esposa se llama Marge y que tiene un sobrino de nombre Randy."
                        },

                        new propietario()
                        {
                            NombreCompleto = "Amancio Ortega",
                            FotoDePerfilURL = "https://cope-cdnmed.agilecontent.com/resources/jpg/9/9/1634539525199.jpg",
                            DescripcionPropietario = "Es un empresario español que, junto a su esposa Rosalía Mera, creó" +
                            " Inditex (Industria de Diseño Textil), un gigante empresarial del sector textil. Su éxito empresarial" +
                            " le ha llevado a convertirse en uno de los hombres más ricos del mundo."
                        },

                        new propietario()
                        {
                            NombreCompleto = "Fernando Alonso",
                            FotoDePerfilURL = "https://cdn-1.motorsport.com/images/amp/6D1nZ9V0/s1000/fernando-alonso-alpine-f1-1.jpg",
                            DescripcionPropietario = "Es un piloto español de automovilismo de velocidad. Ha ganado dos veces el Campeonato Mundial de Pilotos de Fórmula 1 en" +
                            " 2005 y 2006, una vez el Campeonato Mundial de Resistencia de la FIA en 2019, las 24 Horas de Le Mans de" +
                            " 2018 y 2019 y las 24 Horas de Daytona de 2019."
                        },

                        new propietario()
                        {
                            NombreCompleto = "Rafael Nadal",
                            FotoDePerfilURL = "http://t0.gstatic.com/licensed-image?q=tbn:ANd9GcS302112Ltqg1w2lA_Pa0IMBo7_y0S3oF8jAC16oYP3sFWqfNL7YzwB8w1ehl6D",
                            DescripcionPropietario = "Está considerado como el mejor tenista de toda la historia en pistas de tierra batida" +
                            "​​​ y uno de los mejores de todos los tiempos.​​​​"
                        },

                        new propietario()
                        {
                            NombreCompleto = "Karim Benzema",
                            FotoDePerfilURL = "https://assets.laliga.com/squad/2021/t186/p19927/2048x2048/p19927_t186_2021_1_002_000.jpg",
                            DescripcionPropietario = "Es un futbolista francés de ascendencia argelina​​ que juega como delantero en el Real Madrid Club de Fútbol de" +
                            " la Primera División de España desde la temporada 2009-10."
                        },

                        new propietario()
                        {
                            NombreCompleto = "Monserrat Caballe",
                            FotoDePerfilURL = "https://www.plateamagazine.com/images/fotos/noticias/Caballe_EFE.jpg",
                            DescripcionPropietario = "Formada en Barcelona, destacó por su voz de soprano lírica, con bello pianissimo en el registro agudo." +
                            " Especialista del repertorio del bel canto, fue una de las primeras voces del mundo por su calidad vocal, inspiración y perfecto dominio de la técnica."
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
                            DescripcionEmpleado = "Junior FullStack Developer"
                        },

                        new empleados()
                        {
                            NombreCompleto = "Empelado 2",
                            FotoDePerfilURL = "https://happytravel.viajes/wp-content/uploads/2020/04/146-1468479_my-profile-icon-blank-profile-picture-circle-hd.png",
                            DescripcionEmpleado = "Senior FullStack Developer"
                        },

                        new empleados()
                        {
                            NombreCompleto = "Empelado 3",
                            FotoDePerfilURL = "https://happytravel.viajes/wp-content/uploads/2020/04/146-1468479_my-profile-icon-blank-profile-picture-circle-hd.png",
                            DescripcionEmpleado = "Agente Inmoviliario"
                        },

                        new empleados()
                        {
                            NombreCompleto = "Empelado 4",
                            FotoDePerfilURL = "https://happytravel.viajes/wp-content/uploads/2020/04/146-1468479_my-profile-icon-blank-profile-picture-circle-hd.png",
                            DescripcionEmpleado = "Agente Inmoviliario"
                        },

                        new empleados()
                        {
                            NombreCompleto = "Empelado 5",
                            FotoDePerfilURL = "https://happytravel.viajes/wp-content/uploads/2020/04/146-1468479_my-profile-icon-blank-profile-picture-circle-hd.png",
                            DescripcionEmpleado = "Agente Inmoviliario"
                        },

                        new empleados()
                        {
                            NombreCompleto = "Empelado 6",
                            FotoDePerfilURL = "https://happytravel.viajes/wp-content/uploads/2020/04/146-1468479_my-profile-icon-blank-profile-picture-circle-hd.png",
                            DescripcionEmpleado = "Administrativo"
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
                            NombrePropiedad = "Mansión Rey Pelayo",
                            DescripcionPropiedad  = "Lujoso complejo con 10 habitaciones, 4 baños y 500m2. " +
                            "Cuenta con 5 plazas de garaje.",
                            precioPropiedad = 7500000.00,
                            FotoPropiedadURL = "https://st3.idealista.com/news/archivos/styles/imagen_big_lightbox/public/2020-06/im-191825.jpg?sv=_9b9J8T9&itok=7HUggoEv",
                            FechaPublicacion = System.DateTime.Now.AddSeconds(5),
                            FechaFinal = System.DateTime.Now.AddDays(10),
                            IdCiudad = 1008,
                            IdEmpelado = 7,
                            PropiedadCiudad = PropiedadCiudad.Mansion
                        },

                        new propiedades()
                        {
                            NombrePropiedad = "Campo San Francisco",
                            DescripcionPropiedad  = "Espacioso apartamento de 3 habitaciones, 2 baños y 100m2." +
                            " Balcón con vistas al parque.",
                            precioPropiedad = 355000.00,
                            FotoPropiedadURL = "https://design-milk.com/images/2017/10/KW-Apartment-anthill-1.jpg",
                            FechaPublicacion = System.DateTime.Now.AddSeconds(5),
                            FechaFinal = System.DateTime.Now.AddDays(10),
                            IdCiudad = 1009,
                            IdEmpelado = 8,
                            PropiedadCiudad = PropiedadCiudad.Apartamento
                        },

                        new propiedades()
                        {
                            NombrePropiedad = "Urbanización Los Campos",
                            DescripcionPropiedad  = "Moderno Chalet con 4 habitaciones, 2 baños y 150m2. " +
                            "Domótica instalada en la enteridad de la vivienda.",
                            precioPropiedad = 950000.00,
                            FotoPropiedadURL = "https://storage.googleapis.com/static.inmoweb.es/clients/745/property/573766/image/resized_vivienda-frontal.jpg",
                            FechaPublicacion = System.DateTime.Now.AddSeconds(5),
                            FechaFinal = System.DateTime.Now.AddDays(70),
                            IdCiudad = 1010,
                            IdEmpelado = 9,
                            PropiedadCiudad = PropiedadCiudad.Chalet
                        },

                        new propiedades()
                        {
                            NombrePropiedad = "El Flamenco",
                            DescripcionPropiedad  = "Contiene 3 habitaciones, 1 baño y 80m2." +
                            " Casa en la parte alta de Piedras Blancas.",
                            precioPropiedad = 350000.00,
                            FotoPropiedadURL = "https://img3.idealista.com/blur/WEB_DETAIL_TOP-L-L/0/id.pro.es.image.master/74/24/24/160819073.jpg",
                            FechaPublicacion = System.DateTime.Now.AddSeconds(5),
                            FechaFinal = System.DateTime.Now.AddDays(120),
                            IdCiudad = 1011,
                            IdEmpelado = 10,
                            PropiedadCiudad = PropiedadCiudad.Casa
                        },

                        new propiedades()
                        {
                            NombrePropiedad = "Casa de pescadores",
                            DescripcionPropiedad  = "Dispone de 2 habitaciones 1 baño y 55m2."+
                            " Humilde casa en la zona turística de Cudillero.",
                            precioPropiedad = 120000.00,
                            FotoPropiedadURL = "https://images.turismoenportugal.org/Casa-Museu-do-Pescador-Nazare.jpg",
                            FechaPublicacion = System.DateTime.Now.AddSeconds(5),
                            FechaFinal = System.DateTime.Now.AddDays(170),
                            IdCiudad = 1012,
                            IdEmpelado = 11,
                            PropiedadCiudad = PropiedadCiudad.Casa
                        },

                        new propiedades()
                        {
                            NombrePropiedad = "Plaza del Ayuntamiento de Gijón",
                            DescripcionPropiedad  = "Céntrico apartamento con 3 habitaciones, 2 baños y 90m2." +
                            " Situada en la parte turística de la villa.",
                            precioPropiedad = 480000.00,
                            FotoPropiedadURL = "https://admin.apartamentosmichelangelobenidorm.com/Images/GetImage/18_m__dsc5612.jpg",
                            FechaPublicacion = System.DateTime.Now.AddSeconds(5),
                            FechaFinal = System.DateTime.Now.AddDays(65),
                            IdCiudad = 1008,
                            IdEmpelado = 12,
                            PropiedadCiudad = PropiedadCiudad.Apartamento
                        },

                        new propiedades()
                        {
                            NombrePropiedad = "Mansión El Cristo",
                            DescripcionPropiedad  = "Complejo de 3 edificios con 9 habitaciones, 6 baños y 375m2." +
                            " Situada en el extrarradio de Oviedo.",
                            precioPropiedad = 3500000.00,
                            FotoPropiedadURL = "https://d500.epimg.net/cincodias/imagenes/2018/03/25/midinero/1521978855_468775_1521979400_noticia_normal.jpg",
                            FechaPublicacion = System.DateTime.Now.AddSeconds(5),
                            FechaFinal = System.DateTime.Now.AddDays(200),
                            IdCiudad = 1009,
                            IdEmpelado = 7,
                            PropiedadCiudad = PropiedadCiudad.Mansion
                        },

                        new propiedades()
                        {
                            NombrePropiedad = "Urbanización La Madreña",
                            DescripcionPropiedad  = "Chalet de dos pisos con 5 habitaciones, 3 baños y 230m2." +
                            " Ubicada a 5 minutos de la playa de Perlora.",
                            precioPropiedad = 900000.00,
                            FotoPropiedadURL = "https://q-xx.bstatic.com/images/hotel/max1024x768/116/116633837.jpg",
                            FechaPublicacion = System.DateTime.Now.AddSeconds(5),
                            FechaFinal = System.DateTime.Now.AddDays(200),
                            IdCiudad = 1010,
                            IdEmpelado = 8,
                            PropiedadCiudad = PropiedadCiudad.Chalet
                        },

                        new propiedades()
                        {
                            NombrePropiedad = "Casa Pepito",
                            DescripcionPropiedad  = "Tranquila casa a las afueras del poblado con 3 habitaciones, 2 bañlos y 125m2." +
                            " Cuenta con un jardín de 60m2.",
                            precioPropiedad = 320000.00,
                            FotoPropiedadURL = "https://i.pinimg.com/originals/8a/b9/35/8ab935a951e8f3fdd561f7638ff15324.jpg",
                            FechaPublicacion = System.DateTime.Now.AddSeconds(5),
                            FechaFinal = System.DateTime.Now.AddDays(200),
                            IdCiudad = 1011,
                            IdEmpelado = 9,
                            PropiedadCiudad = PropiedadCiudad.Casa
                        },

                        new propiedades()
                        {
                            NombrePropiedad = "Beach Sight Cudillero",
                            DescripcionPropiedad  = "Lujoso apartamento con 4 habitaciones, 3 baños y 100m2" +
                            " Vistas privilegiadas a la playa.",
                            precioPropiedad = 470000.00,
                            FotoPropiedadURL = "https://i0.wp.com/inversionisto.com/wp-content/uploads/2020/05/c46e7e2b-82c1-4052-91fd-91f32f9ea7ee.jpg?fit=1024%2C768&ssl=1&resize=1280%2C950",
                            FechaPublicacion = System.DateTime.Now.AddSeconds(5),
                            FechaFinal = System.DateTime.Now.AddDays(200),
                            IdCiudad = 1012,
                            IdEmpelado = 10,
                            PropiedadCiudad = PropiedadCiudad.Apartamento
                        },
                    });
                    context.SaveChanges();
                }

                //PROPIETARIOS_PROPIEDAD
                if (!context.propietarios_propiedad.Any())
                {
                    context.propietarios_propiedad.AddRange(new List<propietarios_propiedad>(){
                        //new propietarios_propiedad()
                        //{
                        //    IdPropietario = 2004,
                        //    IdPropiedad =1,
                        //},

                        //new propietarios_propiedad()
                        //{
                        //    IdPropietario = 2005,
                        //    IdPropiedad = 2,
                        //},

                        //new propietarios_propiedad()
                        //{
                        //    IdPropietario = 2006,
                        //    IdPropiedad =3,
                        //},

                        //new propietarios_propiedad()
                        //{
                        //    IdPropietario = 2007,
                        //    IdPropiedad = 4,
                        //},

                        //new propietarios_propiedad()
                        //{
                        //    IdPropietario = 2008,
                        //    IdPropiedad =5,
                        //},

                        //new propietarios_propiedad()
                        //{
                        //    IdPropietario = 2009,
                        //    IdPropiedad = 6,
                        //},

                        //new propietarios_propiedad()
                        //{
                        //    IdPropietario = 2004,
                        //    IdPropiedad =7,
                        //},

                        //new propietarios_propiedad()
                        //{
                        //    IdPropietario = 2005,
                        //    IdPropiedad = 8,
                        //},

                        //new propietarios_propiedad()
                        //{
                        //    IdPropietario = 2006,
                        //    IdPropiedad =9,
                        //},

                        //new propietarios_propiedad()
                        //{
                        //    IdPropietario = 2007,
                        //    IdPropiedad = 10,
                        //},


                    });
                    context.SaveChanges();
                } 
            }
        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {   
                //ROLES
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                //comprobamos que el rol existe en la base de datos, sino existen los crea
                if (!await roleManager.RoleExistsAsync(RolesUsuario.Admin))
                    await roleManager.CreateAsync(new IdentityRole(RolesUsuario.Admin));

                if (!await roleManager.RoleExistsAsync(RolesUsuario.User))
                    await roleManager.CreateAsync(new IdentityRole(RolesUsuario.User));

                //USUARIOS
                //admin
                var UserManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<usuarioApp>>();
                string adminUserEmail = "admin@proyecto_nel.com";

                var adminUser= await UserManager.FindByEmailAsync(adminUserEmail);
                if(adminUser == null)
                {
                    var newAdminUser = new usuarioApp()
                    {
                        NombreCompleto = "Admin",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    //añadimos el user a la base de datos con su correo y una contraseña
                    await UserManager.CreateAsync(newAdminUser, "Proyecto_nel@1234?");
                    //añadimos el user al rol
                    await UserManager.AddToRoleAsync(newAdminUser, RolesUsuario.Admin);
                }

                //user
                string UsuarioAppEmail = "user@proyecto_nel.com";

                var UsuarioApp = await UserManager.FindByEmailAsync(UsuarioAppEmail);
                if (UsuarioApp == null)
                {
                    var newUsuarioApp = new usuarioApp()
                    {
                        NombreCompleto = "Usuario App",
                        UserName = "app-user",
                        Email = UsuarioAppEmail,
                        EmailConfirmed = true
                    };
                    //añadimos el user a la base de datos con su correo y una contraseña
                    await UserManager.CreateAsync(newUsuarioApp, "Proyecto_nel@1234?");
                    //añadimos el user al rol
                    await UserManager.AddToRoleAsync(newUsuarioApp, RolesUsuario.User);
                }
            }
        }
    }
}
