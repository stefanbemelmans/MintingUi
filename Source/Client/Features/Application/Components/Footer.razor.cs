namespace MintingUi.Client.Features.Application.Components
{
  using MintingUi.Client.Features.Base.Components;

  public class FooterBase: BaseComponent
  {
    protected string Version => ApplicationState.Version;
  }
}
