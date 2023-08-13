using System;
using System.Net.Http;
using Newtonsoft.Json;

class Program
{
    private const int NumberOfStoriesToFetch = 5;

    static async Task Main(string[] args)
    {
        using HttpClient httpClient = new HttpClient();
        string apiUrl = "https://hacker-news.firebaseio.com/v0/";

        try
        {
            HttpResponseMessage topStoriesResponse = await httpClient.GetAsync($"{apiUrl}topstories.json");
            int[] topStoryIds = JsonConvert.DeserializeObject<int[]>(await topStoriesResponse.Content.ReadAsStringAsync());
            int storiesToProcess = Math.Min(NumberOfStoriesToFetch, topStoryIds?.Length ?? 0);

            for (int i = 0; i < NumberOfStoriesToFetch; i++)
            {
                int storyId = topStoryIds[i];
                HttpResponseMessage storyResponse = await httpClient.GetAsync($"{apiUrl}item/{storyId}.json");
                string storyJson = await storyResponse.Content.ReadAsStringAsync();
                dynamic story = JsonConvert.DeserializeObject<dynamic>(storyJson);

                if (story != null)
                {
                    string title = story.title ?? "No title available";
                    string url = story.url ?? "No URL available";

                    Console.WriteLine($"Title: {title}");
                    Console.WriteLine($"URL: {url}");
                    Console.WriteLine();
                }
            }
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
