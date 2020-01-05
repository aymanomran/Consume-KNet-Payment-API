using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaVstoreTask
{
    class APIClass
    {
        public static string callApi(string _URL, Method method, Dictionary<string, object> parameters)
        {
            var client = new RestClient(_URL);
            var request = new RestRequest(method);
            StringBuilder MyParametersSB = new StringBuilder();
            request.AddHeader("authorization", "sk_test_ca596ef8-4377-4187-bfd2-c2eb2b4e8039");
            request.AddHeader("content-type", "application/json");
            foreach (KeyValuePair<string, object> p in parameters)
            {
                MyParametersSB.Append(p.Key + "=" + p.Value + "&");
            }
            MyParametersSB.Remove(MyParametersSB.Length - 1, 1);

            string MyParameters = MyParametersSB.ToString();
            request.AddParameter("application/x-www-form-urlencoded",
                MyParameters, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            string json = response.Content.ToString();
            return json;
        }
    }
}
