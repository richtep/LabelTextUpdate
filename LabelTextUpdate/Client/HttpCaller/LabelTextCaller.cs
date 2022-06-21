namespace LabelTextUpdate.Client.HttpCaller;

    public class LabelTextCaller
    {
        private readonly HttpClient _httpClient;

        public LabelTextCaller(HttpClient http)
        {
            _httpClient = http;
        }

       public async Task GetLabelTextAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("labelText");

                if (!response.IsSuccessStatusCode)
                    throw new Exception("Something is wrong with the connection make sure that the server is running.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

    
        public async Task GetLabelText()
        {
            try
            {
                var response = await _httpClient.GetAsync("https://localhost:7193/api/Text/StartText");
                if (!response.IsSuccessStatusCode)
                    throw new Exception("Something is wrong with the connection so get call is not executing.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
}

