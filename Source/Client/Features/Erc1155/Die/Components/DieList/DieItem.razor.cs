namespace Herc.Pwa.Client.Features.Erc1155.Die.Components
{
  using Microsoft.AspNetCore.Components;
  using MintingUi.Client.Features.Base.Components;
  using System;
  using System.Linq;

  public class DieItemBase : BaseComponent
  {
    public Die Die => DieState.Dies.FirstOrDefault(aDie => aDie.Guid == DieId);
    public int TokenCount { get; set; } = 3; // TODO should derive from sum of Dies.Tokens
    [Parameter] public Guid DieId { get; set; }
    public string DieDetailsUrl => $"/explorer/dies/{DieId}/";
  }
}