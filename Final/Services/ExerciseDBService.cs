using Final.Models;
using Newtonsoft.Json;
using System.Text.Json;

namespace Final.Services;

public class ExerciseDBService : IExerciseDBService
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;
    public ExerciseDBService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
    }

    public async Task<List<ExerciseDB>> GetExerciseDBsByBodyPart(string bodyPart)
    {
        var apiUrl = _configuration["ExerciseDB:Url"];
        var apiKey = _configuration["ExerciseDB:ApiKey"];
        var request = new HttpRequestMessage(HttpMethod.Get, $"{apiUrl}/exercises/bodyPart/{bodyPart}");
        request.Headers.Add("X-RapidAPI-Key", apiKey);
        var response = await _httpClient.SendAsync(request);

        //var response = await _httpClient.GetAsync($"{apiUrl}/exercises/bodyPart/{bodyPart}");
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var exerciseDBs = JsonConvert.DeserializeObject<List<ExerciseDB>>(content);
            return exerciseDBs;
        }
        // Handle error cases
        return null;
    }
    //------------------------------------------------------------------------------------------------------
    public async Task<List<ExerciseDB>> GetBodyPartList()
    {
        var apiUrl = _configuration["ExerciseDB:Url"];
        var apiKey = _configuration["ExerciseDB:ApiKey"];
        var request = new HttpRequestMessage(HttpMethod.Get, $"{apiUrl}/exercises/bodyPartList");
        request.Headers.Add("X-RapidAPI-Key", apiKey);
        var response = await _httpClient.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var exerciseDBs = JsonConvert.DeserializeObject<List<ExerciseDB>>(content);
            return exerciseDBs;
        }
        // Handle error cases
        return null;
    }
    //---------------------------------------------------------------------------------------------------------
    public async Task<List<ExerciseDB>> GetEquipmentList()
    {
        var apiUrl = _configuration["ExerciseDB:Url"];
        var apiKey = _configuration["ExerciseDB:ApiKey"];
        var request = new HttpRequestMessage(HttpMethod.Get, $"{apiUrl}/exercises/equipmentList");
        request.Headers.Add("X-RapidAPI-Key", apiKey);
        var response = await _httpClient.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var exerciseDBs = JsonConvert.DeserializeObject<List<ExerciseDB>>(content);
            return exerciseDBs;
        }
        // Handle error cases
        return null;
    }
    //---------------------------------------------------------------------------------------------------------
    public async Task<List<ExerciseDB>> GetTargetList()
    {
        var apiUrl = _configuration["ExerciseDB:Url"];
        var apiKey = _configuration["ExerciseDB:ApiKey"];
        var request = new HttpRequestMessage(HttpMethod.Get, $"{apiUrl}/exercises/targetList");
        request.Headers.Add("X-RapidAPI-Key", apiKey);
        var response = await _httpClient.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var exerciseDBs = JsonConvert.DeserializeObject<List<ExerciseDB>>(content);
            return exerciseDBs;
        }
        // Handle error cases
        return null;
    }
    //---------------------------------------------------------------------------------------------------------
    public async Task<List<ExerciseDB>> GetExerciseByEquipment(string equipment)
    {
        var apiUrl = _configuration["ExerciseDB:Url"];
        var apiKey = _configuration["ExerciseDB:ApiKey"];
        var request = new HttpRequestMessage(HttpMethod.Get, $"{apiUrl}/exercises/equipment/{equipment}");
        request.Headers.Add("X-RapidAPI-Key", apiKey);
        var response = await _httpClient.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var exerciseDBs = JsonConvert.DeserializeObject<List<ExerciseDB>>(content);
            return exerciseDBs;
        }
        // Handle error cases
        return null;
    }
    //---------------------------------------------------------------------------------------------------------
    public async Task<List<ExerciseDB>> GetExercisesByTarget(string target)
    {
        var apiUrl = _configuration["ExerciseDB:Url"];
        var apiKey = _configuration["ExerciseDB:ApiKey"];
        var request = new HttpRequestMessage(HttpMethod.Get, $"{apiUrl}/exercises/target/{target}");
        request.Headers.Add("X-RapidAPI-Key", apiKey);
        var response = await _httpClient.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var exerciseDBs = JsonConvert.DeserializeObject<List<ExerciseDB>>(content);
            return exerciseDBs;
        }
        // Handle error cases
        return null;
    }
    //---------------------------------------------------------------------------------------------------------
    public async Task<List<ExerciseDB>> GetExercisesById(string id)
    {
        var apiUrl = _configuration["ExerciseDB:Url"];
        var apiKey = _configuration["ExerciseDB:ApiKey"];
        var request = new HttpRequestMessage(HttpMethod.Get, $"{apiUrl}/exercises/exercise/{id}");
        request.Headers.Add("X-RapidAPI-Key", apiKey);
        var response = await _httpClient.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var exerciseDBs = JsonConvert.DeserializeObject<List<ExerciseDB>>(content);
            return exerciseDBs;
        }
        // Handle error cases
        return null;
    }
    //---------------------------------------------------------------------------------------------------------
    public async Task<List<ExerciseDB>> GetExercisesByName(string name)
    {
        var apiUrl = _configuration["ExerciseDB:Url"];
        var apiKey = _configuration["ExerciseDB:ApiKey"];
        var request = new HttpRequestMessage(HttpMethod.Get, $"{apiUrl}/exercises/name/{name}");
        request.Headers.Add("X-RapidAPI-Key", apiKey);
        var response = await _httpClient.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var exerciseDBs = JsonConvert.DeserializeObject<List<ExerciseDB>>(content);
            return exerciseDBs;
        }
        // Handle error cases
        return null;
    }
    //---------------------------------------------------------------------------------------------------------
    public async Task<List<ExerciseDB>> GetAllExercises()
    {
        var apiUrl = _configuration["ExerciseDB:Url"];
        var apiKey = _configuration["ExerciseDB:ApiKey"];
        var request = new HttpRequestMessage(HttpMethod.Get, $"{apiUrl}/exercises");
        request.Headers.Add("X-RapidAPI-Key", apiKey);
        var response = await _httpClient.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var exerciseDBs = JsonConvert.DeserializeObject<List<ExerciseDB>>(content);
            return exerciseDBs;
        }
        return null;
    }
}