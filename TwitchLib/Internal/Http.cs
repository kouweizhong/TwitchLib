using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Enums;
using TwitchLib.Exceptions.API;

namespace TwitchLib.Internal
{
    internal class Http
    {
        public Method Method = Method.GET;
        public API API = API.v3;
        public bool RequireCredentials = true;
        public string AccessToken = null;

        private string url;
        private List<KeyValuePair<string, string>> urlSegments = new List<KeyValuePair<string, string>>();
        private List<KeyValuePair<string, string>> payloadParameters = new List<KeyValuePair<string, string>>();

        public Http(string url)
        {
            this.url = url;
        }

        public void AddUrlSegmentRequired(string key, object value)
        {
            if (key != null && value != null)
                urlSegments.Add(new KeyValuePair<string, string>(key, value.ToString()));
            else
                throw new BadParameterException("Required URL segment is null!");
        }

        public void AddUrlSegmentIfNotNull(string key, object value)
        {
            if (key != null && value != null)
                urlSegments.Add(new KeyValuePair<string, string>(key, value.ToString()));
        }

        public void AddParameterIfNotNull(string key, string value)
        {
            if (key != null && value != null)
                payloadParameters.Add(new KeyValuePair<string, string>(key, value));
        }

        public void AddParameterRequired(string key, object value)
        {
            if (key != null && value != null)
                payloadParameters.Add(new KeyValuePair<string, string>(key, value.ToString()));
            else
                throw new BadParameterException("Required payload parameter is null!");
        }

        public async Task ExecuteAsync()
        {
            await requestAsync();
        }

        public void Execute()
        {
            request();
        }

        public async Task<string> ExecuteResponseAsStringAsync()
        {
            return await requestAsync();
        }

        public string ExecuteResponseAsString()
        {
            return request();
        }

        public async Task<T> ExecuteResponseAsModelAsync<T>()
        {
            return JsonConvert.DeserializeObject<T>(await requestAsync(), TwitchLibJsonDeserializer);
        }

        public T ExecuteResponseAsModel<T>()
        {
            return JsonConvert.DeserializeObject<T>(request(), TwitchLibJsonDeserializer);
        }

        private async Task<string> requestAsync()
        {
            var req = WebRequest.CreateHttp(buildUrl());
            req.Method = Method.ToString().ToUpper();
            req.ContentType = "application/json";
            if (API != API.VOID)
                req.Accept = $"application/vnd.twitchtv.v{(int)API}+json";

            if(RequireCredentials)
            {
                if (!string.IsNullOrEmpty(AccessToken))
                    req.Headers["Authorization"] = $"OAuth {Common.Helpers.FormatOAuth(AccessToken)}";
                else if (!string.IsNullOrEmpty(TwitchAPI.Shared.AccessToken))
                    req.Headers["Authorization"] = $"OAuth {Common.Helpers.FormatOAuth(AccessToken)}";
            }

            if (payloadParameters != null && payloadParameters.Count > 0)
                using (var writer = new StreamWriter(await req.GetRequestStreamAsync()))
                    writer.Write(buildPayload());

            try
            {
                var resp = await req.GetResponseAsync();
                using (var reader = new StreamReader(resp.GetResponseStream()))
                {
                    string data = await reader.ReadToEndAsync();
                    return data;
                }
            } catch(WebException ex) { handleWebException(ex); }

            return null;
        }

        private string request()
        {
            var req = WebRequest.CreateHttp(buildUrl());
            req.Method = Method.ToString().ToUpper();
            req.ContentType = "application/json";
            if (API != API.VOID)
                req.Accept = $"application/vnd.twitchtv.v{(int)API}+json";

            if (RequireCredentials)
            {
                if (!string.IsNullOrEmpty(AccessToken))
                    req.Headers["Authorization"] = $"OAuth {Common.Helpers.FormatOAuth(AccessToken)}";
                else if (!string.IsNullOrEmpty(TwitchAPI.Shared.AccessToken))
                    req.Headers["Authorization"] = $"OAuth {Common.Helpers.FormatOAuth(AccessToken)}";
            }

            if (payloadParameters != null && payloadParameters.Count > 0)
                using (var writer = new StreamWriter(req.GetRequestStream()))
                    writer.Write(buildPayload());

            try
            {
                var resp = req.GetResponse();
                using (var reader = new StreamReader(resp.GetResponseStream()))
                {
                    string data = reader.ReadToEnd();
                    return data;
                }
            }
            catch (WebException ex) { handleWebException(ex); }

            return null;
        }

        private string buildPayload()
        {
            JObject json = new JObject();
            foreach (var parameter in payloadParameters)
                json[parameter.Key] = parameter.Value;
            return json.ToString();
        }

        private string buildUrl()
        {
            if (RequireCredentials)
                AddUrlSegmentRequired("client_id", TwitchAPI.Shared.ClientId);

            for(int i = 0; i < urlSegments.Count; i++)
            {
                if (i == 0)
                    url = $"{url}?{urlSegments[i].Key}={urlSegments[i].Value}";
                else
                    url = $"{url}&{urlSegments[i].Key}={urlSegments[i].Value}";
            }

            return url;
        }

        private void handleWebException(WebException e)
        {
            HttpWebResponse errorResp = e.Response as HttpWebResponse;
            if (errorResp == null)
                throw e;
            switch (errorResp.StatusCode)
            {
                case HttpStatusCode.BadRequest:
                    throw new BadRequestException("Your request failed because either: \n 1. Your ClientID was invalid/not set.\n 2. You requested a username when the server was expecting a user ID.");
                case HttpStatusCode.Unauthorized:
                    throw new BadScopeException("Your request was blocked due to bad credentials (do you have the right scope for your access token?).");
                case HttpStatusCode.NotFound:
                    throw new BadResourceException("The resource you tried to access was not valid.");
                case (HttpStatusCode)422:
                    throw new NotPartneredException("The resource you requested is only available to channels that have been partnered by Twitch.");
                default:
                    throw e;
            }
        }

        #region SerialiazationSettings
        public static JsonSerializerSettings TwitchLibJsonDeserializer = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore, MissingMemberHandling = MissingMemberHandling.Ignore };

        public class TwitchLibJsonSerializer
        {
            private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                ContractResolver = new LowercaseContractResolver(),
                NullValueHandling = NullValueHandling.Ignore
            };

            public static string SerializeObject(object o)
            {
                return JsonConvert.SerializeObject(o, Formatting.Indented, Settings);
            }

            public class LowercaseContractResolver : DefaultContractResolver
            {
                protected override string ResolvePropertyName(string propertyName)
                {
                    return propertyName.ToLower();
                }
            }
        }
        #endregion
    }
}
