using System.Net.Security;
using Microsoft.Extensions.Configuration;
using FrontEnd.Infra.Authentication;
namespace FrontEnd.Steps.Context
{
    public class BaseContext
    {
        public IConfiguration configuration;
        public AuthenticationResponse Authentication{get;set;}
    }
}