using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace per.Pages
{
    public class OrderPageModel : PageModel
    {
        [BindProperty]
        public ContactFormModel Contact { get; set; }

        public class ContactFormModel
        {
            public string Name { get; set; }

            public string Email { get; set; }

            [Required]
            [DataType(dataType: DataType.Text)]
            public string Eman { get; set; }

            public string EmanTasl { get; set; }

            [Required(ErrorMessage = "Email requerido")]
            [DataType(dataType: DataType.EmailAddress)]
            public string Liame { get; set; }
            public string Size { get; set; }
            public string Reto { get; set; }

            [DataType(DataType.PhoneNumber)]
            public string Numero { get; set; }
            public string  Meta { get; set; }
            public string Link { get; set; }
            public DateTime Fecha { get; set; }
            public DateTime Hora { get; set; }


        }

        public static async Task<Response> SendEmail( string contenido)
        {

            // var apiKey = ConfigurationManager.AppSettings["SendgridApikey"] ;  
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            //var from = new EmailAddress(ConfigurationManager.AppSettings["SengridEmailFrom"]);
            var from = new EmailAddress("hola@lideresqueinspiran.com");
            var subject = "Un posible cliente quiere ponerse en contacto contigo";
            var to = new EmailAddress("enigmashik@gmail.com");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = contenido;
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
            return response;
        }

        public async Task<IActionResult> OnPost()
        {
            DateTime Agenda = new DateTime(Contact.Fecha.Year, Contact.Fecha.Month, Contact.Fecha.Day, Contact.Hora.Hour, Contact.Hora.Minute, 0);
            var mailbody = $@"<h1>Buen día Pedro!</h1>
               <h2>Estos son los datos de un posible cliente:</h2>
                <h3>Nombre:</h3><p> {Contact.Eman}  {Contact.EmanTasl} </p>
                <h3>Dirección Email:</h3> {Contact.Liame}</p>
                <h3>Tamaño del equipo de Ventas:</h3> {Contact.Size}</p>
                <h3>Número Móvil:</h3> {Contact.Numero}</p>
                <h3>Linkedin:</h3> {Contact.Link}</p>
                <h3>Fecha Solicitada:</h3> {Agenda}</p>
                <h3>Meta de ventas para el año actual:</h3> {Contact.Meta}</p>
                <h3>Mayor reto enfrentado éste año:</h3> <p>{Contact.Reto}</p>";

            /*  var mailbody = $@" <h1>Buen día Pedro!</h1>
                 <h2>Estos son los datos de una nueva solicitud para ponerse en contacto contigo:</h2>
                  <h3>Nombre:</h3><p> {Contact.Eman}</p>
                  <h3>Servicio Solicitado:</h3><p> {Contact.Service}</p>
                  <h3>Dirección Email:</h3> {Contact.Liame}</p>
                  <h3>Mensaje:</h3> <p>{Contact.Message}</p>
                  ";*/
              using (var message = new MailMessage("pedroeloy_rdz_servicio@hotmail.com", "pedroeloyrdz@hotmail.com"))
              {
                  //"pedro@percepciones.com.mx"
                  message.To.Add(new MailAddress("enigmashik@gmail.com"));
                  message.From = new MailAddress("pedroeloy_rdz_servicio@hotmail.com");
                  message.Subject = "Un posible cliente quiere ponerse en contacto contigo";
                  message.Body = mailbody;
                  message.IsBodyHtml = true;

                  //Configure an SmtpClient to send the mail.            
                  SmtpClient client = new SmtpClient();
                  client.DeliveryMethod = SmtpDeliveryMethod.Network;
                  client.EnableSsl = true;
                  client.Host = "smtp.office365.com";
                  client.Port = 587;

                  //Setup credentials to login to our sender email address ("UserName", "Password")

                  NetworkCredential credentials = new NetworkCredential("pedroeloy_rdz_servicio@hotmail.com", "bG2sr!6R77W!");
                  client.UseDefaultCredentials = true;
                  client.Credentials = credentials;


            try
            {
                if (ModelState.IsValid && Contact.Name == null && Contact.Email == null && Contact.Size != "-- Tamaño de tu equipo comercial --")
                {
                   // var response = SendEmail(mailbody);
                    client.Send(message);
                    return RedirectToPage("Agradecimiento");
                }
                else
                {
                    return RedirectToPage("Index");
                }
            }
            catch (Exception e)
            {
                return RedirectToPage("Index");
            }


        }
       }
    }
}