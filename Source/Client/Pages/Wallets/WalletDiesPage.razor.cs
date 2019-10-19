namespace Herc.Pwa.Client.Pages.Wallets
{
  using MintingUi.Client.Features.Base.Components;
  using Microsoft.AspNetCore.Components;
  using System.Collections.Generic;
  using Herc.Pwa.Client.Features.Erc1155.Die;
  public class WalletDiesPageBase : BaseComponent
  {
    public const string Route = "/{WalletId}/dies/{CurrencyId}";
    [Parameter]
    public string CurrencyId { get; set; }

   
  }
}