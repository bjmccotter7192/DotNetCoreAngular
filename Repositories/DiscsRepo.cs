using System;
using System.Collections.Generic;
using System.Net.Http;
using CoreAngular.Models;
using Newtonsoft.Json;

public class DiscsRepo
{
    private HttpClient _httpClient;

    public DiscsRepo()
    {
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new System.Uri("https://disc-golf-is-life.herokuapp.com/api");
    }

    public IEnumerable<Disc> GetAllDiscs()
    {
        List<Disc> discs;
        try
        {
            var discJson = _httpClient.GetAsync(_httpClient.BaseAddress + "/discs").Result.Content.ReadAsStringAsync().Result;
            discs = JsonConvert.DeserializeObject<List<Disc>>(discJson);
        }
        catch(Exception ex)
        {
            throw new Exception($"Something went wrong beej {ex.Message}");
        }

        return discs;
    }
}