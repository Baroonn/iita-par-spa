namespace iita_par.Authentication
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading;
    using System.Threading.Tasks;
    using Blazored.LocalStorage;
    using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

    public class CustomAuthorizationMessageHandler : DelegatingHandler
    {
        private readonly ILocalStorageService _localStorage;

        public CustomAuthorizationMessageHandler(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
            InnerHandler = new HttpClientHandler();
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // Retrieve the token from local storage
            var token = await _localStorage.GetItemAsync<string>("authToken");

            // If token exists, add it to the Authorization header
            if (!string.IsNullOrEmpty(token))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            
            return await base.SendAsync(request, cancellationToken);
        }
    }

}
