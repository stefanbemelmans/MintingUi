namespace MintingUi.Client.Pages.Erc1155
{
  using BlazorState;
  using Microsoft.AspNetCore.Components;
  using MintingUi.Client.Features.Base.Components;
  using MintingUi.Client.Features.Erc1155.Die;
  using System;

  public class CreateDiePageBase : BaseComponent
  {
    public IStore aStore;
    public string MintDieRoute => $"/WalletId/dies/{CurrencyId}/{DieId}/mint";

    [Parameter] public string CurrencyId { get; set; }
    [Parameter] public static string DieId { get; set; }

    public long DieCount => 2; /*DieState.Dies.Where(d => d.CurrencyId.ToString() == CurrencyId).Count();*/
    public Die NewDie { get; set; }

    // this will come from the Currency that the User selects "Create a New Die" under

    public CreateDiePageBase()
    {
      NewDie = new Die(aStore);
      NewDie.Creator = new Creator();
      NewDie.Guid = new Guid();
      NewDie.Id = DieCount + 1; /*DieState.Dies.Count + 1*/;
    }
  }
}