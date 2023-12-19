using System.Text.Json.Nodes;
using maui_poc.Repository;

namespace maui_poc.Services;

static class ResourceService
{
    public static async Task GetAllResources()
    {
        try
        {
            
            ResourceRepository repo = new();
            var resources = repo.GetAll();
            if (resources.Count == 0)
            {
                var client = new HttpClient();
                var list = new List<Model.Resource>();
                var response =
                    await client.GetAsync("http://portal.greenmilesoftware.com/get_resources_since");
                var result = await response.Content.ReadAsStringAsync();
                JsonNode forecastNode = JsonNode.Parse(result);
                foreach (var node in forecastNode!.AsArray())
                {
                    var resource = new Model.Resource();
                    var subnode = node!["resource"];
                    resource.Key = subnode!["resource_id"]!.GetValue<string>();
                    resource.Value = subnode!["value"]!.GetValue<string>();
                    resource.Module = subnode!["module_id"]!.GetValue<string>();
                    resource.Language = subnode!["language_id"]!.GetValue<string>();
                
                    list.Add(resource);
                
                }
            
                repo.Insert(list);
            }
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }
}