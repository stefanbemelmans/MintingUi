namespace MintingUi.Client.Pages.Wallets
{
  using MintingUi.Client.Features.Base.Components;
  using System;

  public class WalletCurrenciesPageBase : BaseComponent
  {
    public static string Route = "/WalletId/currencies/";
    public Guid CurrencyId { get; set; }

    public string WalletCurrencyDetailsRouteBuilder(Guid CurrencyId) => Route + CurrencyId.ToString();

    public string WalletDiesRouteBuilder(Guid CurrencyId) => WalletDiesPageBase.Route + CurrencyId.ToString();

  }
}