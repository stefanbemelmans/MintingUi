namespace MintingUi.Client.Features.Base
{
  using BlazorState;
  using MintingUi.Client.Features.Application;
  using MintingUi.Client.Features.Counter;
  using MintingUi.Client.Features.EventStream;
  using MintingUi.Client.Features.WeatherForecast;

  /// <summary>
  /// Base Handler that makes it easy to access state
  /// </summary>
  /// <typeparam name="TAction"></typeparam>
  internal abstract class BaseHandler<TAction> : ActionHandler<TAction>
    where TAction : IAction
  {
    protected ApplicationState ApplicationState => Store.GetState<ApplicationState>();

    protected CounterState CounterState => Store.GetState<CounterState>();

    protected EventStreamState EventStreamState => Store.GetState<EventStreamState>();

    protected WeatherForecastsState WeatherForecastsState => Store.GetState<WeatherForecastsState>();

    public BaseHandler(IStore aStore) : base(aStore) { }
  }
}