using NewsApp.API.Models;
using NewsApp.API.Models.Context;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsApp.API.Controllers
{
    [RoutePrefix("api/news")]
    public class NewsController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();

        [Route("{amountOutstanding}")]
        public IQueryable<News> GetNews(int amountOutstanding)
        {
            try
            {
                return db.News.OrderBy(n => Guid.NewGuid()).Take(amountOutstanding);
            }
            catch (Exception ex)
            {
                // Se deberia de registrar en un log de errores
                var resp = new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent(ex.Message)
                };
                throw new HttpResponseException(resp);
            }
        }

        [HttpPost]
        [Route("list")]
        public HttpResponseMessage GetNewsByFilter(FilterModel filter)
        {
            IQueryable<News> lst = null;
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                if ((filter.endDate.HasValue && !filter.startDate.HasValue) || (!filter.endDate.HasValue && filter.startDate.HasValue))
                    response = Request.CreateResponse(HttpStatusCode.BadRequest, "Se debe proporcionar información fecha de inicio y fecha fin");

                if (filter.endDate.HasValue && filter.startDate.HasValue && !string.IsNullOrWhiteSpace(filter.strFilter))
                {
                    lst = db.News.Where(x => x.title.ToLower().Contains(filter.strFilter.ToLower()) &&
                                                              (x.publishedDate >= filter.startDate.Value &&
                                                               x.publishedDate <= filter.endDate.Value))
                                             .OrderByDescending(p => p.publishedDate);

                }
                else if (filter.endDate.HasValue && filter.startDate.HasValue && string.IsNullOrWhiteSpace(filter.strFilter))
                {
                    lst = db.News.Where(x => x.publishedDate >= filter.startDate.Value && x.publishedDate <= filter.endDate.Value)
                                             .OrderByDescending(p => p.publishedDate);

                }
                else if (!filter.endDate.HasValue && !filter.startDate.HasValue && !string.IsNullOrWhiteSpace(filter.strFilter))
                    lst = db.News.Where(x => x.title.ToLower().Contains(filter.strFilter.ToLower())).OrderByDescending(p => p.publishedDate);
                else // Sino se mando información de filtro se muestan las 5 noticias más recientes
                    lst = db.News.OrderByDescending(p => p.publishedDate).Take(5);


                if (lst == null || (lst != null && lst.Count() == 0))
                    response = Request.CreateResponse(HttpStatusCode.NoContent, "No se encontraron registros", "application/json");
                else
                    response = Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                // Se deberia de registrar en un log de errores
                response = Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }

            return response;
        }
    }
}