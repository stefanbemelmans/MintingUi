namespace Herc.Pwa.Client.Features.Erc1155.Die.Components
{
  using Microsoft.AspNetCore.Components;
  using MintingUi.Client.Features.Base.Components;
  using System.Collections.Generic;

  public class DieListBase : BaseComponent
  {
    [Parameter] public IReadOnlyList<Die> Dies { get; set; }
    public int DiesCount => Dies.Count;
  }
}