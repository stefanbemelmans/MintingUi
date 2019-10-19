namespace MintingUi.Client.Features.Application.Components
{
  using MintingUi.Client.Features.Base.Components;
  using static MintingUi.Client.Features.Application.ApplicationState;

  public class NavBarBase : BaseComponent
  {
    protected string NavMenuCssClass => ApplicationState.IsMenuExpanded ? null : "collapse";

    protected async void ToggleNavMenu() => await Mediator.Send(new ToggleMenuAction());
  }
}