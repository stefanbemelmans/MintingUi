namespace MintingUi.Client.Features.Erc1155.Wallets
{
  using Microsoft.AspNetCore.Components;
  using MintingUi.Client.Features.Base.Components;
  using MintingUi.Client.Features.Erc1155.Die;

  public class WalletDieItemBase : BaseComponent
  {
    [Parameter] public Die Die { get; set; }
    [Parameter] public string DieId { get; set; }

    public string RedeemTokenRoute = "/WalletId/dies/{CurrencyId}/{DieId}";
  }
}