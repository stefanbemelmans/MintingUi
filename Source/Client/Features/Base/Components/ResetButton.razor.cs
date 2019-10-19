namespace MintingUi.Client.Features.Base.Components
{
  using static MintingUi.Client.Features.Application.ApplicationState;

  public class ResetButtonBase : BaseComponent
  {
    internal void ButtonClick() => Mediator.Send(new ResetStoreAction());
  }
}