using Newtonsoft.Json;

namespace FrontEnd.Infra.Authentication
{
    public class AuthenticationResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken{get; set;}

        [JsonProperty("token_type")]
        public string TokenType{get; set;}

        [JsonProperty("expires_in")]
        public string ExpiresIn{get; set;}

        [JsonProperty("refresh_token")]
        public string RefreshToken{get; set;}

        [JsonProperty("scope")]
        public string Scope{get; set;}

        [JsonProperty("active")]
        public string Active{get; set;}
    }
}