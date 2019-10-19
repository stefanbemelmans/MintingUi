namespace MintingUi.Client.Pages.Explorer.Dies
{
  using MintingUi.Client.Features.Base.Components;
  using MintingUi.Client.Features.Erc1155.Die;
  using System.Collections.Generic;

  public class DiesPageBase : BaseComponent
  {
    public const string Route = "/dies";

    public IReadOnlyList<Die> Dies => DieState.Dies;
  }
}