using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using System;

// Referece : https://docs.microsoft.com/en-us/dotnet/api/overview/azure/app-auth-migration

namespace Lab.AzureKeyVault101
{
    public static class Program
    {
        private static void Main(string[] args)
        {

            var client = new SecretClient(new Uri("https://dfc-dev-shared-kv.vault.azure.net"), new DefaultAzureCredential());

            var secret = client.GetSecret("dfc-servicetaxonomy-editor-appregistration-id").Value;

            Console.WriteLine(secret.Value);

            //AzureServiceTokenProvider tokenProvider = new AzureServiceTokenProvider();

            //var client = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(tokenProvider.KeyVaultTokenCallback));

            //var secretBundle = client.GetSecretAsync("https://dfc-dev-shared-kv.vault.azure.net/secrets/dfc-servicetaxonomy-editor-appregistration-id").Result;

            //Console.WriteLine(secretBundle.Value);

            Console.WriteLine("Hello World!");
        }
    }
}
