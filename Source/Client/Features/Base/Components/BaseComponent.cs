namespace MintingUi.Client.Features.Base.Components
{
  using BlazorState.Pipeline.ReduxDevTools;
  using MintingUi.Client.Features.Application;
  using MintingUi.Client.Features.Counter;
  using MintingUi.Client.Features.WeatherForecast;
  using MintingUi.Client.Features.EventStream;
  using MintingUi.Client.Features.Erc1155.Currencies;
  using MintingUi.Client.Features.Erc1155.Die;
  using BlazorState.Features.Routing;
  using MintingUi.Client.Features.Erc1155.Token;
  using MintingUi.Client.Features.Erc1155.Transactions;

  /// <summary>
  /// Makes access to the State a little easier and by inheriting from
  /// BlazorStateDevToolsComponent it allows for ReduxDevTools operation.
  /// </summary>
  /// <remarks>
  /// In production one would NOT be required to use these base components
  /// But would be required to properly implement the required interfaces.
  /// one could conditionally inherit from BaseComponent for production build.
  /// </remarks>
  public class BaseComponent : BlazorStateDevToolsComponent
  {
    internal ApplicationState ApplicationState => GetState<ApplicationState>();
    internal CounterState CounterState => GetState<CounterState>();
    public CurrencyState CurrencyState => GetState<CurrencyState>();
    public DieState DieState => GetState<DieState>();
    internal EventStreamState EventStreamState => GetState<EventStreamState>();
    public RouteState RouteState => GetState<RouteState>();
    public TokenState TokenState => GetState<TokenState>();
    public  TransactionState TransactionState => GetState<TransactionState>();
    internal WeatherForecastsState WeatherForecastsState => GetState<WeatherForecastsState>();
  }
}