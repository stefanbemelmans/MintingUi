namespace MintingUi.Client.Features.Erc1155.Currencies.Components
{
  using Microsoft.AspNetCore.Components;
  using MintingUi.Client.Features.Base.Components;
  using System.Collections.Generic;
  using System.Linq;
  using MintingUi.Client.Features.Erc1155.Die;

  public class CurrencyDetailsBase : BaseComponent
  {
    [Parameter] public string CurrencyId { get; set; }

    public float TotalValue;
    public Currency Currency => CurrencyState.Currencies.FirstOrDefault(aCurrency => aCurrency.Guid.ToString() == CurrencyId);
    public long TotalTokens;
    public List<Die> Dies => DieState.Dies.Where(aDie => aDie.CurrencyId.ToString() == CurrencyId).ToList();
    public void GetTotalTokens()
    {
      foreach(Die d in Dies)
      {
        TotalTokens += (long)d.TotalSupply;
      }
    }

    public void GetTotalValue()
    {
      foreach (Die d in Dies)
      {
        TotalValue += (float)(d.TotalSupply * d.MeltValue);
      }
    }
      
  }
    
}


