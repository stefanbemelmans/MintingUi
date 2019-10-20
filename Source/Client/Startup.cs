namespace MintingUi.Client
{
  using BlazorState;
  using MediatR;
  using Microsoft.AspNetCore.Components.Builder;
  using Microsoft.Extensions.DependencyInjection;
  using System.Reflection;
  using MintingUi.Client.Features.Application;
  using MintingUi.Client.Features.ClientLoaderFeature;
  using MintingUi.Client.Features.Counter;
  using MintingUi.Client.Features.EventStream;
  using MintingUi.Client.Features.WeatherForecast;
  using MintingUi.Client.Features.Erc1155.Currencies;
  using MintingUi.Client.Features.Erc1155.Die;
  using MintingUi.Client.Features.Erc1155.Token;
  using MintingUi.Client.Features.Erc1155.Transactions;

  public class Startup
  {
    public void Configure(IComponentsApplicationBuilder aComponentsApplicationBuilder) =>
      aComponentsApplicationBuilder.AddComponent<App>("app");

    public void ConfigureServices(IServiceCollection aServiceCollection)
    {
      aServiceCollection.AddBlazorState
      (
        (aOptions) => aOptions.Assemblies =
          new Assembly[]
          {
            typeof(Startup).GetTypeInfo().Assembly,
          }
      );

      aServiceCollection.AddScoped(typeof(IPipelineBehavior<,>), typeof(EventStreamBehavior<,>));
      aServiceCollection.AddScoped<ClientLoader>();
      aServiceCollection.AddScoped<IClientLoaderConfiguration, ClientLoaderConfiguration>();

      aServiceCollection.AddTransient<ApplicationState>();
      aServiceCollection.AddTransient<CounterState>();
      aServiceCollection.AddTransient<EventStreamState>();
      aServiceCollection.AddTransient<WeatherForecastsState>();
      aServiceCollection.AddTransient<CurrencyState>();
      aServiceCollection.AddTransient<DieState>();
      aServiceCollection.AddTransient<TokenState>();
      aServiceCollection.AddTransient<TransactionState>();
    }
  }
}