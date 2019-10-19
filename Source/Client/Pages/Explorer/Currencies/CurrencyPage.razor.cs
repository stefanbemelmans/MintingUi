namespace Herc.Pwa.Client.Pages.Explorer.Currencies
{
  using MintingUi.Client.Features.Base.Components;
  using Herc.Pwa.Client.Features.Erc1155.Die;
  using Herc.Pwa.Client.Features.Erc1155.Token;
  using Microsoft.AspNetCore.Components;
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public class CurrencyPageBase : BaseComponent
  {
    public string ActiveTab => RouteState.Route.Split('/').Last();
    public string BaseRoute => $"/explorer/{CurrencyId}";
    [Parameter] public string CurrencyId { get; set; }

    public IReadOnlyList<Die> Dies => DieState.Dies.Where(aDie => aDie.CurrencyId == new Guid(CurrencyId)).ToList();

    // TODO lists for other tabs.
    //public IReadOnlyList<Token> Token => TokenState.Tokens.Where(aToken => aToken.CurrencyId == new Guid(CurrencyId)).ToList();

    public class Tab
    {
      private readonly ExplorerLayoutBase ExplorerLayoutBase;

      public Tab(ExplorerLayoutBase aExplorerLayoutBase)
      {
        ExplorerLayoutBase = aExplorerLayoutBase;
      }

      public string ClassName => IsActive ? "active" : "";
      public bool IsActive => ExplorerLayoutBase.ActiveTab == Route;
      public string Label { get; set; }
      public string Route { get; set; }
    }
  }
}