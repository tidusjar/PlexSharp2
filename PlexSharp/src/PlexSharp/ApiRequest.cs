#region Copyright
// /************************************************************************
//    Copyright (c) 2016 Jamie Rees
//    File: ApiRequest.cs
//    Created By: Jamie Rees
//   
//    Permission is hereby granted, free of charge, to any person obtaining
//    a copy of this software and associated documentation files (the
//    "Software"), to deal in the Software without restriction, including
//    without limitation the rights to use, copy, modify, merge, publish,
//    distribute, sublicense, and/or sell copies of the Software, and to
//    permit persons to whom the Software is furnished to do so, subject to
//    the following conditions:
//   
//    The above copyright notice and this permission notice shall be
//    included in all copies or substantial portions of the Software.
//   
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
//    MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//    NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
//    LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
//    OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
//    WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//  ************************************************************************/
#endregion
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

using PlexSharp.Interfaces;

using RestSharp;

namespace PlexSharp
{
    internal sealed class ApiRequest : IApiRequest
    {
        /// <summary>
        /// An API request handler
        /// </summary>
        /// <typeparam name="T">The type of class you want to deserialize</typeparam>
        /// <param name="request">The request.</param>
        /// <param name="baseUri">The base URI.</param>
        /// <returns>
        /// The type of class you want to deserialize
        /// </returns>
        /// <exception cref="ApiRequestException"></exception>
        public T Execute<T>(IRestRequest request, Uri baseUri) where T : new()
        {
            var client = new RestClient { BaseUrl = baseUri };

            var response = client.Execute(request);
            return ReturnData<T>(response);
        }

        /// <summary>
        /// Executes the request asynchronously.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">The request.</param>
        /// <param name="baseUri">The base URI.</param>
        /// <returns></returns>
        public async Task<T> ExecuteAsync<T>(IRestRequest request, Uri baseUri) where T : new()
        {
            var client = new RestClient { BaseUrl = baseUri };

            var response = await client.ExecuteTaskAsync(request);
            return ReturnData<T>(response);
        }

        /// <summary>
        /// Executes the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="baseUri">The base URI.</param>
        /// <returns></returns>
        /// <exception cref="ApiRequestException"></exception>
        public IRestResponse Execute(IRestRequest request, Uri baseUri)
        {
            var client = new RestClient { BaseUrl = baseUri };

            var response = client.Execute(request);

            CheckException(response);

            return response;
        }

        /// <summary>
        /// Executes the request asynchronously and returns the RestResponse.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="baseUri">The base URI.</param>
        /// <returns></returns>
        public async Task<IRestResponse> ExecuteAsync(IRestRequest request, Uri baseUri)
        {
            var client = new RestClient { BaseUrl = baseUri };

            var response = await client.ExecuteTaskAsync(request);

            CheckException(response);

            return response;
        }

        /// <summary>
        /// Determines whether the response is in XML.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <returns></returns>
        private bool IsXmlDocument(string response)
        {
            return response.TrimStart().StartsWith("<", StringComparison.Ordinal);
        }

        /// <summary>
        /// Checks the content type and deserializes the result.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response">The response.</param>
        /// <returns></returns>
        private T ReturnData<T>(IRestResponse response)
        {
            CheckException(response);
            var json = response.Content;

            if (IsXmlDocument(response.Content))
            {
                var doc = new XmlDocument();
                doc.LoadXml(json);
                json = JsonConvert.SerializeXmlNode(doc); // convert it into JSON
                Debug.WriteLine(json);
            }


            var obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }

        /// <summary>
        /// Checks to see if the response has an exception.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <exception cref="ApiRequestException"></exception>
        private void CheckException(IRestResponse response)
        {
            if (response.ErrorException != null)
            {
                var message = "Error retrieving response. Check inner details for more info.";

                throw new ApiRequestException(message, response.ErrorException);
            }
        }
    }
}