namespace MintingUi.Client.Pages.Explorer.Currencies
{
  using MintingUi.Client.Features.Base.Components;
  using System.Collections.Generic;
  using MintingUi.Client.Features.Erc1155.Currencies;

  public class CurrenciesPageBase : BaseComponent
  {
    public const string Route = "explorer/currencies";

    public IReadOnlyList<Currency> Currencies => CurrencyState.Currencies;
  }
}