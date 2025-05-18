using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ExamenOrdinario
{
    internal class Correo
    {
        public void EnviarCorreo(string error)
        {

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("112609@alumnouninter.mx");//correo del que se manda
                mail.To.Add("annabelen_diaz@hotmail.com");//correo al que se manda
                mail.Subject = "Error en la aplicación WinForms";
                mail.Body = $"Se ha producido un error:\n\n{error}";

                SmtpClient smtp = new SmtpClient("smtp.office365.com", 587);
                smtp.Credentials = new NetworkCredential("112609@alumnouninter.mx", "Hastaelultimodia01");//correo y contraseña de que se manda
                smtp.EnableSsl = true;

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                // En producción podrías loguear este error también
                Console.WriteLine("Error al enviar el correo: " + ex.Message);
            }
        }
    }
}
