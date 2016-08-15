using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;
using System.Configuration;
using System.Threading.Tasks;
using HelloWorldConsole.Interface;

namespace HelloWorldConsole
{
    class ServiceAccess : IServiceAccess
    {
        public static Uri uri = new Uri(ConfigurationSettings.AppSettings["APIURL"].ToString());
        public static RestClient restClient = new RestClient();

        /// <summary>
        /// Static Method to Call the API.
        /// </summary>
        /// <returns></returns>
        public String getDataString()
        {
            String strResponse = String.Empty;
            RestRequest restRequest;

            try
            {
                restRequest = new RestRequest();

                // Set the URL for the request
                restClient.BaseUrl = uri;

                // Setup the request
                restRequest.Resource = "HelloWorldApi";
                restRequest.Method = Method.GET;

                // Clear the request parameters
                restRequest.Parameters.Clear();

                // Execute the call and get the response
                var response = restClient.Execute(restRequest);

                if (response.Content != null)
                {
                    strResponse = response.Content.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return strResponse;
        }
    }
}
