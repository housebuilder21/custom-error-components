using Microsoft.AspNetCore.Components;

namespace CustomErrorComponents.Components.Errors
{
    public class ErrorsBase : ComponentBase
    {
        [Parameter]
        public string? Class { get; set; }

        [Parameter]
        public string? Style { get; set; }
    }
}
