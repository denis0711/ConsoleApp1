
using ConsoleApp1;
using System.Net;
using System.Text.Json;
using System.Text;


var url = "";
var json = "";

UsuarioLogin usuarioLogin = new UsuarioLogin { login = "0000027", senha = "33gKl7fWqPd58UcovM08TA==" };

var content = new StringContent(
            JsonSerializer.Serialize(usuarioLogin),
            Encoding.UTF8,
            "application/json");


try
{
    Console.WriteLine("Vai testar tem Homol desabilitando o SSL");
    url = "http://api.stage.pdahub.com.br/api/";

    Console.WriteLine();

    // Desabilita a verificação do certificado SSL/TLS
    ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

    HttpClientHandler clientHandler = new HttpClientHandler();
    HttpClient client = new HttpClient(clientHandler);


    var response = client.PostAsync(string.Concat(url, "Autenticacao"), content).Result;

    // Lembre-se de restaurar a verificação do certificado em ambientes de produção
    ServicePointManager.ServerCertificateValidationCallback = null;



    if (response.IsSuccessStatusCode)
    {
        json = response.Content.ReadAsStringAsync().Result;
        Console.WriteLine(json);
    }
    else
    {
        Console.WriteLine("Erro ao Rodar a API");
    }



}
catch(Exception ex)
{

    Console.WriteLine("Erro ao testar usando o http://api.stage.pdahub.com.br/api/ ");
    Console.WriteLine(ex.Message);
}


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


try
{
    Console.WriteLine("Vai testar tem Homol deixan o SSL habilitado");
    url = "https://api.stage.pdahub.com.br/api/";
    Console.WriteLine();


    HttpClient client2 = new HttpClient();


    var response = client2.PostAsync(string.Concat(url, "Autenticacao"), content).Result;


    if (response.IsSuccessStatusCode)
    {
        json = response.Content.ReadAsStringAsync().Result;
        Console.WriteLine(json);
    }
    else
    {
        Console.WriteLine("Erro ao Rodar a API");
    }



}
catch (Exception ex)
{

    Console.WriteLine("Erro ao testar usando o https://api.stage.pdahub.com.br/api/ ");
    Console.WriteLine(ex.Message);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


try
{
    Console.WriteLine("Vai testar em Producao desabilitando o SSL");
    url = "http://api.pdahub.com.br/api/";
    Console.WriteLine();


    // Desabilita a verificação do certificado SSL/TLS
    ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

    HttpClientHandler clientHandler = new HttpClientHandler();
    HttpClient client3 = new HttpClient(clientHandler);


    var response = client3.PostAsync(string.Concat(url, "Autenticacao"), content).Result;

    // Lembre-se de restaurar a verificação do certificado em ambientes de produção
    ServicePointManager.ServerCertificateValidationCallback = null;



    if (response.IsSuccessStatusCode)
    {
        json = response.Content.ReadAsStringAsync().Result;
        Console.WriteLine(json);
    }
    else
    {
        Console.WriteLine("Erro ao Rodar a API");
    }



}
catch (Exception ex)
{

    Console.WriteLine("Erro ao testar usando o http://api.pdahub.com.br/api/ ");
    Console.WriteLine(ex.Message);
}




Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


try
{
    Console.WriteLine("Vai testar em  producao deixan o SSL habilitado");
    url = "https://api.pdahub.com.br/api/";
    Console.WriteLine();

    HttpClient client4 = new HttpClient();


    var response = client4.PostAsync(string.Concat(url, "Autenticacao"), content).Result;


    if (response.IsSuccessStatusCode)
    {
        json = response.Content.ReadAsStringAsync().Result;
        Console.WriteLine(json);
    }
    else
    {
        Console.WriteLine("Erro ao Rodar a API");
    }



}
catch (Exception ex)
{

    Console.WriteLine("Erro ao testar usando o https://api.pdahub.com.br/api/ ");
    Console.WriteLine(ex.Message);
}



