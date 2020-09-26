using System;
using System.IO;
using System.Web.Mvc;

namespace DemoPdf.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public string GetPDFData()
        {
            var pdfPath = Path.Combine(System.Web.Hosting.HostingEnvironment.MapPath("~/pspdfkit/License.pdf"));
            byte[] bytes = System.IO.File.ReadAllBytes(pdfPath);
            return Convert.ToBase64String(bytes);
        }

        public string GeneratePDF()
        {
            var pdfPath = Path.Combine(System.Web.Hosting.HostingEnvironment.MapPath("~/pspdfkit/License.pdf"));
            //// Convert to Bytes Array

            ////  return bytes;
            //HttpResponseMessage Response = new HttpResponseMessage(HttpStatusCode.OK);

            ////S2:Read File as Byte Array
            byte[] bytes = System.IO.File.ReadAllBytes(pdfPath);
            return Convert.ToBase64String(bytes);
            // var blob = new Blob()

            //  return bytes;
            //if (bytes == null)
            //    throw new HttpResponseException(HttpStatusCode.NotFound);
            ////S3:Set Response contents and MediaTypeHeaderValue
            //Response.Content = new ByteArrayContent(bytes);
            //Response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

            //return Response;
            //  return Convert.(bytes);
            // string fileName = @"c:\docs\insurance_report.pdf";
            //  string contentType = "application/pdf";

            //   return new FilePathResult(pdfPath, contentType);
        }
    }
}