namespace MintingUi.Client.Features.Erc1155.Currencies.Components
{
  using Microsoft.AspNetCore.Components;
  using MintingUi.Client.Features.Base.Components;
  using System.Collections.Generic;

  public class CurrencyListBase : BaseComponent
  {
    [Parameter] public IReadOnlyList<Currency> Currencies { get; set; }
    public int CurrencyCount => Currencies.Count;
  }
}