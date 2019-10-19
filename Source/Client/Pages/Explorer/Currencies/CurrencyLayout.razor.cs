namespace MintingUi.Client.Pages.Explorer
{
  using MintingUi.Client.Features.Base.Components;
  using MintingUi.Client.Pages.Utils;
  using Microsoft.AspNetCore.Components;
  using System.Collections.Generic;
  using System.Linq;
  using System.Threading.Tasks;

  public class CurrencyLayoutBase : BaseComponent, IComponent
  {

    [Parameter] public RenderFragment Body { get; set; }
    public string ActiveTab => RouteState.Route.Split('/').Last();

    public List<Tab> Tabs { get; private set; }
    public Route Route { get; private set; }
    public class Tab
    {

      private readonly CurrencyLayoutBase CurrencyLayoutBase;

      public Tab(CurrencyLayoutBase aCurrencyLayoutBase)
      {
        CurrencyLayoutBase = aCurrencyLayoutBase;
      }

      public bool IsActive => CurrencyLayoutBase.Route.Equals(Route);
      public string Label { get; set; }
      public Route Route { get; set; }
      public string ClassName => IsActive ? "active" : "";
    }

    protected override Task OnInitializedAsync()
    {
      Route = Route.NewRouteFromUriString(RouteState.Route);
      Tabs = new List<Tab>
      {
        new Tab(this)
        {
          Label = "Details",
          Route = new Route(Route)
          {
            List = null,
          }
        },
        new Tab(this)
        {
          Label = "Dies",
          Route = new Route(Route)
          {
            List = "dies",
          }
        },
        new Tab(this)
        {
          Label = "Holders",
          Route = new Route(Route)
          {
            List = "holders",
          }
        },
        new Tab(this)
        {
          Label = "Transactions",
          Route = new Route(Route)
          {
            List = "transactions",
          }
        },
        new Tab(this)
        {
          Label = "Mints",
          Route = new Route(Route)
          {
            List = "mints",
          }
        },
        new Tab(this)
        {
          Label = "Melts",
          Route = new Route(Route)
          {
            List = "melts",
          }
        },

      };
      return base.OnInitializedAsync();
    }
  }
}

//@page "/explorer/currencies/{CurrencyId}"
//@page "/explorer/currencies/{CurrencyId}/tokens"
//@page "/explorer/currencies/{CurrencyId}/holders"
//@page "/explorer/currencies/{CurrencyId}/transactions"
//@page "/explorer/currencies/{CurrencyId}/melts"
//@page "/explorer/currencies/{CurrencyId}/mints"