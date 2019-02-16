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
                new News() {
                    title = "Medicamentos empiezan a faltar en las farmacias de Managua",
                    content = @"<p>Encontrar medicina para la epilepsia, por ejemplo, es cada vez más difícil en las farmacias de Managua. Desde hace algunos meses laboratorios como Pfizer y Bayer no están distribuyendo medicamentos, situación que ha generado preocupación entre los consumidores y empresarios de la industria farmacéutica.</p>
                                <p>La presidenta de la Asociación Nicaragüense de Distribuidores de Productos Farmacéuticos (Andiprofa), Rossana Terán, explicó que la escasez de algunos medicamentos es la parte más superficial del problema. Debido a la crisis en Nicaragua los bancos no están otorgando créditos y los laboratorios farmacéuticos están exigiendo a los importadores pagos en efectivo, desembolsos que ellos no están en capacidad de realizar.</p>",
                    publishedDate = (DateTime.Now.AddDays(-2)),
                    imgURL = "https://s3.laprensa.com.ni/wp-content/uploads/2019/02/15091847/medicinas-490x262.jpg"
                },

                new News() {
                    title = "El INSS perdió casi 160,000 afiliados en 2018",
                    content = @"<p>Nicaragua perdió 157,923 empleos formales en el 2018.Esa cantidad de trabajadores dejaron de estar afiliados al Instituto Nicaragüense de Seguridad Social (INSS) entre diciembre de 2017 y diciembre de 2018, según las estadísticas del mercado laboral, que finalmente fueron publicadas este jueves en el sitio web del Banco Central de Nicaragua (BCN).</p>
                                <p>De acuerdo con el BCN, en Nicaragua la cifra de asegurados había ascendido a 913,797 al finalizar el 2017, pero descendió hasta 755,874 en diciembre del año pasado.</p>
                                <p>El sector comercio fue el que más trabajadores formales perdió el año pasado: 69,318 asegurados menos; seguido por el sector de “servicios comunales, sociales y personales”, del que salieron 36,590 afiliados del INSS.&nbsp;</p>
                                <p><div><img alt='END' src='http://endimages.s3.amazonaws.com/ckeditor/2019/02/15/info-version-web-dinero-01.jpg'>- END -</div></p>",
                    publishedDate = (DateTime.Now.AddDays(-2)),
                    imgURL = "https://endimages.s3.amazonaws.com/cache/cb/ed/cbed29ad6fdf3a206530e98e3397634a.jpg"
                },
                new News() {
                    title = "Melvin López asciende al sexto puesto de la Asociación Mundial de Boxeo",
                    content = @"<p>Melvin López es uno de los últimos boxeadores catalogados como promesas del boxeo. Su estrella en el pugilismo amateur era grande, sus proyecciones sin límites. En el noble arte aunque suene contraproducente, trata a veces más de sufrir el daño que con propinarlo. Estamos hablando de sacrificios y es complicado evaluarlo en cada peleador. El caso de López, conocido como Melo, es un volcán sin erupcionar, pero poco a poco se sigue posicionando en los organismos internacionales.</p>
                                <p>En la clasificación de la Asociación Mundial de Boxeo (AMB), perteneciente al mes de enero colocó a Melo en el sexto lugar en las 118 libras. Sobre el nicaragüense está Stephon Young (5to), Shingo Wake (4to), Jason Moloney (3ro), Liborio Solís (2da) y Reymart Gaballo (1ro). En esa división existen tres monarcas. El campeón interino es el filipino Reymart Gaballo, el campeón regular es el japonés Naoya Inoue y el campeón absoluto es el reconocido Nonito Donaire.</p>",
                    publishedDate = (DateTime.Now.AddDays(-4)),
                    imgURL = "https://s3.laprensa.com.ni/wp-content/uploads/2019/02/15170119/d6a41820c012d961caa85dd528accfd5-750x500.jpg"
                },
                new News() {
                    title = "Régimen miente y mete estocada a productos de la canasta básica y a empresarios en versión final de reforma fiscal",
                    content = @"<p>El régimen de Daniel Ortega finiquitó hoy la versión final del proyecto de reforma a la Ley de Concertación Tributaria,&nbsp; que pese a ser rechazada por la gran mayoría del sector privado, dado a que profundizará la recesión económica y producirá más desempleo y cierre de empresas, la aplanadora orteguista se prepara para aprobarla la próxima semana en la Asamblea Nacional.</p>
                                <p>A como se temía, los diputados orteguistas que integran la Comisión de Producción, Economía y Presupuesto de la Asamblea Nacional solo hicieron ajustes menores al proyecto de reforma fiscal, pero se mantuvo en gran medida el objetivo de clavar impuestos a varios productos de la canasta básica, a las materias primas que se usan para producir alimentos, las maquinarias, entre otros.</p>
                                <p>También el régimen apunta a aumentar el anticipo mensual de las medianas y grandes empresas, pese a que estas han advertido que esta medida las dejará sin liquidez y las llevará al borde de la quiebra y las empujará a recortar planilla, es decir despedir personal.</p>",
                    publishedDate = (DateTime.Now.AddDays(-1)),
                    imgURL = "https://s3.laprensa.com.ni/wp-content/uploads/2019/02/15124245/WalmaroGutierrez-750x500.jpg"
                },
                new News() {
                    title = "Dos mujeres más afirman haber sido abusadas por Nobel de la Paz Óscar Arias",
                    content = @"<p>Dos mujeres más afirman haber sufrido abusos sexuales por parte del expresidente de Costa Rica y Premio Nobel de la Paz 1987, óscar Arias, quien el pasado lunes fue denunciado ante la Fiscalía por una violación que habría ocurrido en diciembre de 2014.</p>
                                <p>Los casos revelados en las últimas horas son el de la periodista costarricense Nono Antillón, cuyo testimonio publica el diario La Nación, y el de Emma Daly, directora de comunicaciones de la organización Human Rights Watch, quien denunció su caso en el Washington Post.</p>
                                <p>Daly contó a The Washington Post que óscar Arias en 1990, en un hotel de Managua, Nicaragua, se acercó al político para hacerle una pregunta y en lugar de responder le toco lo senos y le dijo: “No estás usando brassier”.</p>
                                <p>La mujer, que en ese tiempo se desempeñaba como periodista para el periódico costarricense en inglés The Tico Times, confirmó en Twitter su caso y comentó en el reportaje que no presentó una denuncia formal contra Arias porque consideraba que para la época ese tipo de comportamientos eran comunes en América Central.</p>",
                    publishedDate = DateTime.Now,
                    imgURL = "http://cdn1.gepnicaragua.com/wp-content/uploads/2019/02/07114657/OSCAR-ARIAS-750x500.jpg"
                },
                new News() {
                    title = "Estos son los productos de la canasta básica que mantienen sus precios",
                    content = @"<p>En el informe de los precios comparativos del 4 al 11 de febrero de 2019, el <strong>Ministerio de Fomento Industria y Comercio</strong> (Mific), detalló que 17 productos mantienen sus precios.</p>
                                <p>El titular del<strong> Ministerio de Fomento, Industria y Comercio (Mific),</strong> Orlando Solórzano, expresó que, de los 25 productos de la <strong>Canasta Básica Alimenticia</strong>, 17 mantienen sus precios, entre ellos: el arroz 80/20 y 70/30, aceite sellado, frijoles negros, azúcar sulfitada, aceite a granel, pierna de pollo, pollo entero, muslo de pollo, pechuga, pierna con muslo, posta de res, posta de cerdo, huevo mediano, huevo grande, plátano, repollo y pan.</p>
                                <p>La política de entendimiento y consensos ha sido fundamental para que la <strong>estabilidad y el abastecimiento</strong> de los productos se mantengan.</p>
                                <p>Apuntó que el tomate y chiltoma Natalie bajaron sus precios y los frijoles rojos, maíz blanco, queso seco, zanahoria, cebolla amarilla y papa nacional son los productos que aumentaron.</p>
                                <p><em>“El tomate que estaba a 11.50 en mercado oriental bajó a 8.50 y la chiltoma Natalie, que estaba a 18.50 bajó a 12.25, con una rebaja del 15% en el tomate y del 16% en la chiltoma”</em>, informó<em>.</em></p>",
                    publishedDate = DateTime.Now,
                    imgURL = "https://www.el19digital.com/files/articulos/234768.jpg"
                },
                new News() {
                    title = "Inicia Campeonato de béisbol Germán Pomares rindiendo homenaje a leyendas",
                    content = @"<p>Este viernes inició el <strong>Campeonato de Béisbol</strong> de primera división <strong><em>“Comandante Germán Pomares Ordoñez 2019”</em></strong> desde la ciudad de Granada.</p>
                                <p>El escenario deportivo estuvo totalmente lleno en un primer partido dedicado a las glorias del<strong> béisbol de Granada.</strong></p>
                                <p>El equipo de Granada y los Indios del Bóer se enfrentaron en el estadio Roque Tadeo Zavala Sandino.</p>
                                <p>El campeonato durará hasta el mes de septiembre.En este arranque simultáneamente se enfrentaron en nueve ciudades del país los dieciocho equipos en competición.</p>
                                <p><iframe style='border:none;overflow:hidden' src='https://www.facebook.com/plugins/post.php?href=https%3A%2F%2Fwww.facebook.com%2Fel19digital%2Fposts%2F10157181515148724&amp;width=500' scrolling='no' width='500' height='688' frameborder='0></iframe></p>",
                    publishedDate = DateTime.Now,
                    imgURL = "https://www.el19digital.com/files/articulos/235266.jpeg"
                },
                new News() {
                    title = "Enviado OEA en sorpresiva y hermética visita a Nicaragua",
                    content = @"<p>Gonzalo Koncke, jefe de gabinete del secretario general de la Organización de Estados Americanos (OEA), Luis Almagro, visitó Nicaragua de forma sorpresiva para reunirse con el Gobierno de Daniel Ortega y Rosario Murillo, aunque los motivos y resultados de su viaje no han sido revelados. El alto funcionario de la OEA llegó el miércoles por la noche a Managua, salió el jueves de su hotel sin responder las consultas de los medios de comunicación y al volver portaba un documento con el logo de la Cancillería de la República, pero tampoco dio detalles. El jefe del gabinete de Almagro partiría este viernes de regreso a Washington.</p>
                                <p>La OEA tampoco ha oficializado el paso de Koncke en Nicaragua, en ninguna de sus cuentas en redes sociales. Sin embargo, fuentes políticas estimaron que la hermética visita del alto funcionario estaría relacionada con los esfuerzos del organismo internacional en aportar a la solución pacífica a la crisis política que atraviesa Nicaragua, incluyendo un retorno al Diálogo Nacional, suspendido desde julio, y además un acuerdo sobre reformas electorales, que aún no se determina si seguiría el tono de las propuestas hechas en la mesa de entendimiento que la OEA y el Gobierno de Ortega firmaron en febrero de 2017, y que también fue suspendida por Ortega sin dar explicaciones.</p>",
                    publishedDate = (DateTime.Now.AddDays(-3)),
                    imgURL = "https://confidencial.com.ni/wp-content/uploads/2018/09/636717685945374770w.jpg"
                },
                new News() {
                    title = "El poeta Ernesto Cardenal hospitalizado por infección renal",
                    content = @"<p>El poeta Ernesto Cardenal se encuentra hospitalizado en un centro médico nacional por una infección renal, que no es grave en sí, pero que es una situación seria a sus 94 años, informó una fuente cercana al sacerdote trapense.</p>
                                <p>Cardenal se encuentra bajo cuidados médicos en un hospital de las afueras de Managua desde el pasado 4 de febrero, indicó la fuente.</p>
                                <p>El 20 de enero pasado, el autor de “Oración por Marilyn Monroe y otros poemas” (1965) celebró sus 94 años de vida, junto con un grupo de amigos y la edición de su último libro, “Hijos de las estrellas”.</p>
                                <p>Esta es la quinta ocasión que el poeta nicaragüense es ingresado a un hospital en los últimos 14 meses, pero la primera que no requiere ir a la Unidad de Cuidados Intensivos</p>
                                <p>“Ernesto Cardenal, nuestro soldado de las palabras, nuestro adelantado astronauta en sus exploraciones del cosmos, el dulce y también cascarrabias ser humano que hizo de su vida una incesante búsqueda del sentido del ser, de la inmensidad del universo, de la justicia terrena”, escribió en su cuenta en Twitter la escritora y poeta nicaragüense Gioconda Belli.</p>
                                <p>Horas antes, la misma Belli dijo estar “preocupada por la gravedad de nuestro gran poeta Ernesto Cardenal”, y agregó que “él está listo para partir. A sus 94 lo ha dicho con frecuencia. Los que no estamos listos somos nosotros. Ojalá no se nos vaya aún”.</p>
                                <p>El autor de “Epigramas” (1961), a quien su edad y salud no han logrado retirar del todo de la vida pública, es uno de los poetas nicaragüenses más reconocidos a nivel internacional.</p>
                                <p>Cardenal es uno de los autores más prestigiosos de Nicaragua, con obras traducidas a 20 idiomas y reconocimientos como la orden Legión de Honor en Grado de Oficial del Gobierno de Francia.</p>
                                <p>En diciembre pasado, recibió el Premio Internacional Mario Benedetti, que otorga Uruguay, y que dedicó al pueblo nicaragüense y al adolescente Álvaro Conrado, una de las primeras víctimas de las protestas contra el Gobierno del presidente Daniel Ortega, que comenzaron en abril pasado.</p>
                                <p>El Premio Iberoamericano de Poesía Pablo Neruda (2009) y el Premio Reina Sofía de Poesía Iberoamericana (2012) están entre los más recientes e importantes galardones recibidos por el poeta nicaragüense.</p>",
                    publishedDate = (DateTime.Now.AddDays(-1)),
                    imgURL = "https://confidencial.com.ni/wp-content/uploads/2018/06/FV-7102.jpg"
                },
                new News() {
                    title = "",
                    content = @"",
                    publishedDate = (DateTime.Now.AddDays(-4)),
                    imgURL = ""
                },
                new News() {
                    title = "",
                    content = @"",
                    publishedDate = (DateTime.Now.AddDays(-2)),
                    imgURL = ""
                },
                new News() {
                    title = "",
                    content = @"",
                    publishedDate = (DateTime.Now.AddDays(-4)),
                    imgURL = ""
                },
                new News() {
                    title = "",
                    content = @"",
                    publishedDate = (DateTime.Now.AddDays(-3)),
                    imgURL = ""
                },
                new News() {
                    title = "",
                    content = @"",
                    publishedDate = DateTime.Now,
                    imgURL = ""
                },
                new News() {
                    title = "Gobierno aumenta persecución contra empleados públicos",
                    content = @"<p>Un hombre alto, delgado y de voz fuerte, se pasea por un salón lleno de trabajadores del Ministerio de Educación (Mined). Habla en tono amenazante y advierte a los presentes que nadie debe “boicotear los proyectos” del Gobierno que presiden Daniel Ortega y su esposa y vicepresidenta Rosario Murillo. Mientras sigue caminando, el hombre trata de hacer contacto visual con alguno de los trabajadores presentes para lanzar un ultimátum: “Aquí no puede haber gente que bebe leche y maldice la vaca”.</p>
                                <p>La persona que amenaza viste de camisa manga larga y pantalón de vestir. Se llama Harold Delgado y es coordinador de Cultura del Mined. Más conocido como el expresentador del popular programa de televisión La Liga del Saber, que hizo famoso el recordado profesor Julio César Sandoval, fallecido en 2009.</p>
                                <p>La reunión en la que Delgado vertió sus amenazas ocurrió a inicios de 2019, cuando daba instrucciones para un proyecto cultural del Mined e informar los planes de trabajo de este año, que en realidad fue una actividad cargada de&nbsp;amenazas, señalamientos y sentencias para los trabajadores públicos que puedan pensar diferente al régimen de Ortega y Murillo, y ahora se conoce porque su discurso fue grabado y filtrado a CONFIDENCIAL.</p>",
                    publishedDate = DateTime.Now,
                    imgURL = "https://confidencial.com.ni/wp-content/uploads/2015/10/CH-FSLN-Rotondas-3300.jpg"
                },
                new News() {
                    title = "Petronic cambia a otro presidente en siete meses",
                    content = @"<p>El Gobierno de&nbsp;<span>Nicaragua</span>&nbsp;anunció este miércoles un nuevo cambio de director en la Junta Directiva de la estatal Empresa Nicaragüense de Petróleos (Petronic), en medio de la peor crisis sociopolítica del país en décadas, y el cambio de imagen que intenta promover la Distribuidora de Petróleos de Nicaragua (DNP) y sus gasolineras antes las sanciones de Estados Unidos, por sus vínculos con Venezuela.</p>
                                <p>A través de un acuerdo presidencial divulgado en La Gaceta, diario oficial, el Ejecutivo anunció la separación del general del Ejército de&nbsp;< span>Nicaragua</span>&nbsp;en retiro Ramón Humberto Calderón del cargo de presidente de la Junta Directiva de Petronic, sin informar las razones.</p>",
                     publishedDate = (DateTime.Now.AddDays(-1)),
                    imgURL = "https://confidencial.com.ni/wp-content/uploads/2015/10/9607865755_66183c42a7_k.jpg"
                },
            };

            context.News.AddRange(lst);
        }
    }
}   