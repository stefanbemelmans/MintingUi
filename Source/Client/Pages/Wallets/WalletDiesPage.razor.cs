namespace MintingUi.Client.Pages.Wallets
{
  using MintingUi.Client.Features.Base.Components;
  using Microsoft.AspNetCore.Components;
  using System.Collections.Generic;
  using MintingUi.Client.Features.Erc1155.Die;
  using BlazorState.Features.Routing;
  using System.Linq;
  using System;

  public class WalletDiesPageBase : BaseComponent
  {
    //public string Route = $"/WalletId/dies/{CurrencyId}";
    
   [Parameter] public string CurrencyId { get; set; }

    public string CreateDieRoute => $"/WalletId/dies/{CurrencyId}/create";
    public IReadOnlyList<Die> Dies => DieState.Dies.Where(aD => aD.CurrencyId.ToString() == CurrencyId).ToList();
  }
}