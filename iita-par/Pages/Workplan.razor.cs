using Microsoft.AspNetCore.Components;
using PAR.Shared.DTOs;
using PAR.Shared.Enums;
using System.Net.Http.Json;
using System.Security.AccessControl;

namespace iita_par.Pages
{
    public partial class Workplan
    {
        [SupplyParameterFromQuery]
        public bool? Refresh { get; set; } = true;

        private ObjectiveReadDTO[]? objectives;
        private WorkplanStatusLogReadDTO[]? logs = [];
        private string selectedYear = "2024";
        private string comment = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            Refresh ??= true;
            if (Refresh == true)
            {
                ShowLoading(true);
                try
                {
                    objectives = await _httpClient.GetFromJsonAsync<ObjectiveReadDTO[]>($"workplans/objectives?year={selectedYear}");
                    logs = await _httpClient.GetFromJsonAsync<WorkplanStatusLogReadDTO[]>($"workplans/status/logs?year={selectedYear}");
                    await SetItemAsync("objectives", objectives);
                    await SetItemAsync("logs", logs);
                }
                catch (Exception ex)
                {
                    await Logout();
                }
                finally
                {
                    ShowLoading(false);
                }
            }
            else
            {
                objectives = await GetItemAsync<ObjectiveReadDTO[]>("objectives");
                logs = await GetItemAsync<WorkplanStatusLogReadDTO[]>("logs");
            }
        }

        public void NavigateToDetails(long id)
        {
            var objective = objectives.Where(x => x.Id == id).FirstOrDefault();
            NavigateTo($"workplan-details/{objective?.Id}");
        }

        public async Task Submit()
        {
            if (string.IsNullOrWhiteSpace(comment))
            {
                ShowError("Comment cannot be empty");
                return;
            }
            var log = new WorkplanStatusLogCreateDTO()
            {
                Action = "SUBMITTED",
                Year = int.Parse(selectedYear),
                Comment = comment
            };

            var response = await _httpClient.PostAsJsonAsync<WorkplanStatusLogCreateDTO>($"workplans/status/logs", log);

            if (response.IsSuccessStatusCode)
            {
                ShowSuccess("Comment logged");
                logs = await _httpClient.GetFromJsonAsync<WorkplanStatusLogReadDTO[]>($"workplans/status/logs?year={selectedYear}");
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                ShowError("Unauthorized. Please login again.");
                await Logout();
            }
            else
            {
                ShowError("Unable to create log. Please confirm that all required data is provided.");
            }
        }
    }
}
