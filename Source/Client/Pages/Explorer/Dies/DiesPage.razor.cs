namespace Herc.Pwa.Client.Pages.Explorer.Dies
{
  using MintingUi.Client.Features.Base.Components;
  using Herc.Pwa.Client.Features.Erc1155.Die;
  using System.Collections.Generic;

  public class DiesPageBase : BaseComponent
  {
    public const string Route = "/dies";

    public IReadOnlyList<Die> Dies => DieState.Dies;
  }
}