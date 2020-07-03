using System;
using System.IO;
using System.Net;

namespace restClient
{
	public enum HttpVerb
	{
		Get,
		Post,
		Put,
		Delete
	}

	public class RestClient
	{
		public string EndPoint { get; set; }
		public HttpVerb HttpMethod { get; set; }

		public RestClient()
		{
			EndPoint = string.Empty;
			HttpMethod = HttpVerb.Get;
		}

		public string MakeRequest()
		{
			string responseValue = string.Empty;

			HttpWebRequest request = WebRequest.Create(EndPoint) as HttpWebRequest;

			// désactive les erreurs liées au certificat
			request.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

			//request.Method = HttpMethod.ToString();
			request.Method = WebRequestMethods.Http.Get;


			using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
			{
				if(response.StatusCode != HttpStatusCode.OK)
					throw new ApplicationException("Error code : " + response.StatusCode);

				// charge le stream (json, xml..)
				using (Stream responseStream = response.GetResponseStream())
				{
					if (responseStream != null)
					{
						// lit le stream
						using (StreamReader reader = new StreamReader(responseStream))
						{
							responseValue = reader.ReadToEnd();
						}
					}
				}
			}

			return responseValue;
		}
	}
}
