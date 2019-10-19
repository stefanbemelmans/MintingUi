namespace MintingUi.Server.Features.WeatherForecast
{
  using System.Threading.Tasks;
  using MintingUi.Server.Features.Base;
  using MintingUi.Api.Features.WeatherForecast;
  using Microsoft.AspNetCore.Mvc;

  [Route(GetWeatherForecastsRequest.Route)]
  public class GetWeatherForecastsController : BaseController<GetWeatherForecastsRequest, GetWeatherForecastsResponse>
  {
    public async Task<IActionResult> Process(GetWeatherForecastsRequest aRequest) => await Send(aRequest);
  }
}