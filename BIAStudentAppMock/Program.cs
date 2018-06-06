using System;
using System.Net.Http;
using System.Net;
using System.Text;

using Microsoft.Extensions.Configuration;
using System.IO;
using Newtonsoft.Json;

namespace BIAStudentAppMock
{
    class Program
    {

        #region [vars]
        int BiroInvoiceAssistantUserId = 10;
        IConfiguration Configuration;
        HttpClient client;
        #endregion

        static void Main(string[] args)
        {
            Program program = new Program();
            program.RunProgram();
        }

        #region [public]
        void RunProgram()
        {
            Initialize();

            string query = "/api/invoice/get-next?user_id={0}";
            query = string.Format(query, BiroInvoiceAssistantUserId);

            HttpResponseMessage msg = client.GetAsync(query).GetAwaiter().GetResult();
            string content = msg.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            InvoiceBuffer ret = JsonConvert.DeserializeObject<InvoiceBuffer>(content);

            // complete the record such that the fields prefixed by Finished are now filled with
            // data
            ret.FinishedBy = BiroInvoiceAssistantUserId; // your UserID
            ret.FinishedGross = ret.RihGross;
            ret.FinishedVat = ret.FinishedVat;

            // finish the record via the host
            content = JsonConvert.SerializeObject(ret);
            query = "/api/invoice/finish";
            StringContent contentStr = new StringContent(content, Encoding.UTF8, "application/json");
            msg = client.PostAsync(query, contentStr).GetAwaiter().GetResult();
            content = msg.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            Console.WriteLine(content);
        }
        #endregion

        #region [private]
        void Initialize()
        {
            client = new HttpClient();
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            Configuration = builder.Build();
            string addr = Configuration["BiroInvoiceAssistantHost:Address"];

            client.BaseAddress = new Uri(addr);
        }
        #endregion
    }
}
