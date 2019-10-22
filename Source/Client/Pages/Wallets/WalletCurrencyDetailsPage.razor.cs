namespace MintingUi.Client.Pages.Wallets
{
  using Microsoft.AspNetCore.Components;
  using MintingUi.Client.Features.Base.Components;

  public class WalletCurrencyDetailsPageBase : BaseComponent
    {
    [Parameter] public string CurrencyId { get; set; }

    }
}
