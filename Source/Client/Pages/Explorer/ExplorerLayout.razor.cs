namespace Herc.Pwa.Client.Pages.Explorer
{
  using MintingUi.Client.Features.Base.Components;
  using Microsoft.AspNetCore.Components;
  using System.Collections.Generic;
  using System.Linq;

  public class ExplorerLayoutBase : BaseComponent, IComponent
  {
    public ExplorerLayoutBase()
    {
      Tabs = new List<Tab>
      {
        new Tab(this)
        {
          Label = "Currencies",
          Route = "currencies",
        },
        new Tab(this)
        {
          Label = "Dies",
          Route = "dies",
        },
        new Tab(this)
        {
          Label = "Transactions",
          Route = "transactions",
        },
        new Tab(this)
        {
          Label = "Blocks",
          Route = "blocks",
        },
        new Tab(this)
        {
          Label = "Tokens",
          Route = "tokens",
        },
        new Tab(this)
        {
          Label = "Holders",
          Route = "holders",
        },
        new Tab(this)
        {
          Label = "Melts",
          Route = "melts",
        },
        new Tab(this)
        {
          Label = "Mints",
          Route = "mints",
        },
      };
    }

    [Parameter] public RenderFragment Body { get; set; }
    public string ActiveTab => RouteState.Route.Split('/').Last();

    public List<Tab> Tabs { get; }

    public class Tab
    {

      private readonly ExplorerLayoutBase ExplorerLayoutBase;

      public Tab(ExplorerLayoutBase aExplorerLayoutBase)
      {
        ExplorerLayoutBase = aExplorerLayoutBase;
      }

      public bool IsActive => ExplorerLayoutBase.ActiveTab == Route;
      public string Label { get; set; }
      public string Route { get; set; }
      public string ClassName => IsActive ? "active" : "";
    }
  }
}