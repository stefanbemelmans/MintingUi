namespace MintingUi.Client.Features.Application.Components
{
  using MintingUi.Client.Features.Base.Components;

  public class SideBarBase: BaseComponent
  {
    protected string NavMenuCssClass => ApplicationState.IsMenuExpanded ? null : "collapse";
  }
}
  