namespace Herc.Pwa.Client.Pages.Erc1155
{ 
  using MintingUi.Client.Features.Base.Components;
  using Herc.Pwa.Client.Features.Erc1155.Die;
  using Microsoft.AspNetCore.Components;
  using System;
  using System.Linq;

  public class MintDiePageBase : BaseComponent
    {
    public string Route = "/dies/mintAndCreate";
    [Parameter] public Guid DieId { get; set; }
    public Die Die => DieState.Dies.FirstOrDefault(aDie => aDie.Guid == DieId);


  }
}
