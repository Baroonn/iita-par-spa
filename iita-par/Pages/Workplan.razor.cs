using PAR.Shared.DTOs;
using System.Net.Http.Json;

namespace iita_par.Pages
{
    public partial class Workplan
    {
        private ObjectiveReadDTO[] objectives;

        protected override async Task OnInitializedAsync()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<ObjectiveReadDTO[]>("workplans/2024/objectives");
            }
            catch (Exception ex)
            {
            }
        }
    }
}
