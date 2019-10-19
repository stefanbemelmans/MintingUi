namespace Herc.Pwa.Client.Features.Erc1155.Currencies.Components
{
  using Microsoft.AspNetCore.Components;
  using MintingUi.Client.Features.Base.Components;
  using System;
  using System.Linq;

  public class CurrencyItemBase : BaseComponent
  {
    public Currency Currency => CurrencyState.Currencies.FirstOrDefault(aCurrency => aCurrency.Guid == CurrencyId);
    public int DieCount { get; set; } = 2; // TODO should derive from Dies

    [Parameter] public Guid CurrencyId { get; set; }
    public string CurrencyDetailsUrl => $"/explorer/currencies/{CurrencyId}";
  }
}