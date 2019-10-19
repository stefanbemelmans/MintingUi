namespace MintingUi.Client.Features.Erc1155.Die
{
  using Microsoft.AspNetCore.Components;
  using MintingUi.Client.Features.Base.Components;
  using System;
  using System.Linq;

  public class DieDetailsBase : BaseComponent
    {
        
    [Parameter] public Guid DieId { get; set; }
    public Die Die => DieState.Dies.FirstOrDefault(aDie => aDie.Guid == DieId);

  }
}
