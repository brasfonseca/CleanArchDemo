using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace VerboCaptacao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Execute().Wait();
            CreateHostBuilder(args).Build().Run();
        }

        static async Task Execute()
        {
            //var apiKey = Environment.GetEnvironmentVariable("NAME_OF_THE_ENVIRONMENT_VARIABLE_FOR_YOUR_SENDGRID_KEY");
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("contato@verboproducoes.com", "Verbo Produções");
            var subject = "Sistema de Captação de Recursos - Teste Email";
            var to = new EmailAddress("brasfonseca@gmail.com", "Flávio Fonseca");
            var plainTextContent = "vamos lá Flávio";
            var htmlContent = "<strong>vamos!</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
