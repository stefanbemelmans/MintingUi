namespace MintingUi.Client.Features.Erc1155.Wallets
{
  using Microsoft.AspNetCore.Components;
  using MintingUi.Client.Features.Base.Components;
  using MintingUi.Client.Features.Erc1155.Die;

  public class WalletDieItemBase : BaseComponent
  {
    public string RedeemTokenRoute = "/WalletId/dies/{CurrencyId}/{DieId}";
    [Parameter] public Die Die { get; set; }
    [Parameter] public string DieId { get; set; }
  }
}