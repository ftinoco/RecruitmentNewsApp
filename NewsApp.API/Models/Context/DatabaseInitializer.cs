using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace NewsApp.API.Models.Context
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);

            var lst = new List<News>()
            {
                new News() {
                    title = "Trump declara emergencia en frontera sur",
                    content =@"<p>El presidente Donald Trump anunció este viernes que firmará una declaración de emergencia nacional para abordar la situación en la frontera sur, mientras sostiene que sus acciones son consistentes con las de sus predecesores.</p>
                              <p>“Voy a firmar una emergencia nacional y ha sido firmada muchas veces antes. La firmaron otros presidentes desde 1977 o así les dio el poder a los presidentes”, dijo Trump. “Rara vez ha habido un problema. Lo firman, a nadie le importa. Supongo que no fueron muy emocionantes”.</p>",
                    publishedDate= DateTime.Now,
                    imgURL="https://cnnespanol2.files.wordpress.com/2019/02/gettyimages-1125035052.jpg?quality=100&strip=info"
                },
                new News() {
                    title = "USAID niega que ayuda humanitaria esté envenenada",
                    content =@"<p>Pocos días después de que llegara a Colombia la ayuda humanitaria para Venezuela procedente de <a href='https://cnnespanol.cnn.com/seccion/estados-unidos/' title='Estados Unidos' target='_blank' class='auto-link'>Estados Unidos</a>, Larry Sacks, el director para Colombia de la 
                                Agencia de Estados Unidos para el Desarrollo Internacional, Usaid, negó que el envío de la ayuda sea intervencionismo <a href='https://cnnespanol.cnn.com/category/politica/' title='político' target='_blank' class='auto-link'>político</a> y rechazó las acusaciones de que la comida viene envenenada.</p>
                               <p>Desde el centro de acopio del puente internacional de Tienditas, en Norte de Santander, Colombia, Sacks le dijo a CNN en Español que las ayuda humanitaria que llegó hace pocos días a Colombia, está esperando ser entregada a los más necesitados de Venezuela, en especial a niños, jóvenes y personas de la tercera edad que están en condiciones más críticas.</p>",
                    publishedDate = DateTime.Now,
                    imgURL = "https://cnnespanol2.files.wordpress.com/2019/02/larry-sacks-usaid.jpg?quality=100&strip=info"
                },
                new News() {
                    title = "Estas aplicaciones podrían estar espiándote desde tu teléfono celular",
                    content = @"<p>Unas 17 mil aplicaciones de Android estarían registrando la actividad de los usuarios y creando un historial permanente con esa información con fines publicitarios; lo cual va en contra de las prácticas recomendadas por Google.</p>
                               <p>A esa conclusión llegó una investigación publicada por Serge Egelman, director de investigación en el grupo de Privacidad y Seguridad del Instituto Internacional de Ciencias de la Computación.</p>",
                    publishedDate = (DateTime.Now.AddDays(-3)),
                    imgURL = "https://www.infobae.com/new-resizer/BYF8IyDu50zn-g_z_7YEwyF7n50=/1200x0/filters:quality(100)/s3.amazonaws.com/arc-wordpress-client-uploads/infobae-wp/wp-content/uploads/2017/08/11164811/Colectivo-celular-leer-1920-3.jpg"
                },
                new News() {
                    title = "Los grandes tiburones blancos pueden haber acabado con el tiburón más grande que haya existido",
                    content = @"<p>El megalodón, también conocido como el <a href='https://cnnespanol.cnn.com/tag/tiburones/' title='tiburón' target='_self class='auto-link'>tiburón</a> más grande de todos los tiempos, se extinguió un millón de años antes de lo pensado, debido a la competencia de tiburones blancos mucho más pequeños, según una nueva investigación.</p>
                                <p>El documento completo se publica en el <a href='https://peerj.com/articles/6088/'>Journal of Life and Environmental Sciences</a>.</p>
                                <p>Un equipo de científicos afirma que el depredador prehistórico gigante, como se ve en innumerables documentales y películas como “The Meg”, protagonizado por Jason Statham, murió hace 3,6 millones de años, en lugar de hace 2,6 millones de años.</p>",
                    publishedDate = (DateTime.Now.AddDays(-1)),
                    imgURL = "https://cnnespanol2.files.wordpress.com/2019/02/190214140534-giant-prehistoric-megalodon-mystery-solved-restricted-exlarge-169.jpg?quality=100&strip=info"
                },
            };

            context.News.AddRange(lst);
        }
    }
}