using Microsoft.AspNetCore.Components.Web;

namespace CarouselProblem.Client.Core.Components.Pages;

public partial class HomePage
{
    private bool MustShowImage { get; set; }

    private List<string> Images { get; set; } = new List<string>();

    protected async override Task OnAfterFirstRenderAsync()
    {
        await Task.Delay(5000);
        Images.Add("https://s100.divarcdn.com/static/photo/afra/real_estate/vXxzoF5JBUko_Z_2JMcWZw/96878eda-b6b0-4147-befa-5e3de140c2aa.jpg");
        Images.Add("https://s100.divarcdn.com/static/photo/afra/real_estate/J0G158aXxyi5nYWQptblGA/acb7ca35-2434-48ab-be57-745b0b8d61be.jpg");
        Images.Add("https://s100.divarcdn.com/static/photo/afra/real_estate/nyg42qNA9H0ag0wKlV8dOg/03f030d7-8266-428d-be8f-c8533cdd1d8a.jpg");
        StateHasChanged();
        await base.OnAfterFirstRenderAsync();
    }

    private void HandleImageOnLoaded(ProgressEventArgs args)
    {
        if (args.Type.Equals("load"))
        {
            MustShowImage = true;
        }

        StateHasChanged();
    }
}
