
using System.Net.Http;



var httpClient = HttpClientFactory.Create();
var url = "https://catfact.ninja/fact";
HttpResponseMessage responseMessage = await httpClient.GetAsync(url);

if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
{
    var content = responseMessage.Content;
    var catFact = await content.ReadAsAsync<CatFact>();
    Console.WriteLine(catFact);
   SaveToFile(catFact);

}
else
{
    Console.WriteLine($"There was an error: {responseMessage.ReasonPhrase}"); 
}

static void SaveToFile(CatFact catFact)
{
    using (var writer = File.AppendText($"CatFact.txt"))
    {
        writer.WriteLine(catFact);
    }
}

