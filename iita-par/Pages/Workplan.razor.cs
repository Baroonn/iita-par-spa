using PAR.Shared.DTOs;
using PAR.Shared.Enums;
using System.Net.Http.Json;

namespace iita_par.Pages
{
    public partial class Workplan
    {
        private ObjectiveReadDTO[]? objectives;
        private string selectedYear = "2024";

        protected override async Task OnInitializedAsync()
        {
            try
            {
                objectives = await _httpClient.GetFromJsonAsync<ObjectiveReadDTO[]>($"workplans/objectives?year={selectedYear}");
                
            }
            catch (Exception ex)
            {
                await Logout();
            }
        }

        public void NavigateToDetails(long id)
        {
            var objective = objectives.Where(x => x.Id == id).FirstOrDefault();
            NavigateTo($"workplan-details/{objective?.Id}");
        }
    }
}
