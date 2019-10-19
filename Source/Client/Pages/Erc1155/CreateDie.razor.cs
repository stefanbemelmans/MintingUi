namespace MintingUi.Client.Pages.Erc1155
{
  using BlazorState;
  using MintingUi.Client.Features.Base.Components;
  using MintingUi.Client.Features.Erc1155.Die;
  using Microsoft.AspNetCore.Components;
  using System;

  public class CreateDieBase : BaseComponent
    {
     public Die NewDie { get; set; }
   
    [Parameter]
    public Guid CurrencyId { get; set; } // this will come from the Currency that the User selects "Create a New Die" under

    public CreateDieBase(Guid aGuid, IStore aStore)
    {
      NewDie = new Die(aStore);
      NewDie.Id = DieState.Dies.Count + 1; 
    }
    }
}
