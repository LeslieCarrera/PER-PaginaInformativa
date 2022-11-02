using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace per.Pages
{
    public class BaseModel: PageModel
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
        
            public string Service { get; set; }
            [Required(ErrorMessage = "Email requerido")]
            [DataType(dataType: DataType.EmailAddress)]
            public string Liame { get; set; }

            public string Message { get; set; }
 

        }



        public async Task<IActionResult> OnPost()
        {


            var mailbody = $@"<h1>Buen día Pedro!</h1>
               <h2>Estos son los datos de una nueva solicitud para ponerse en contacto contigo:</h2>
                <h3>Nombre:</h3><p> {Contact.Eman}</p>
                <h3>Servicio Solicitado:</h3><p> {Contact.Service}</p>
                <h3>Dirección Email:</h3> {Contact.Liame}</p>
                <h3>Mensaje:</h3> <p>{Contact.Message}</p>
                ";
            using (var message = new MailMessage("pedroeloy_rdz_servicio@hotmail.com", "pedroeloyrdz@hotmail.com"))
            {
                message.To.Add(new MailAddress("pedro@percepciones.com.mx"));
                message.From = new MailAddress("pedroeloy_rdz_servicio@hotmail.com");
                message.Subject = "Alguien quiere ponerse en contacto contigo";
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
                    if (ModelState.IsValid && Contact.Name == null && Contact.Email == null)
                    {
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
