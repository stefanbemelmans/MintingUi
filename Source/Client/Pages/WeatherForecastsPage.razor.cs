namespace MintingUi.Client.Pages
{
  using System.Threading.Tasks;
  using MintingUi.Client.Features.Base.Components;
  using static MintingUi.Client.Features.WeatherForecast.WeatherForecastsState;

  public class WeatherForecastsPageBase : BaseComponent
  {
    public const string Route = "/weatherforecasts";

    protected override async Task OnInitializedAsync() =>
      await Mediator.Send(new FetchWeatherForecastsAction());
  }
}