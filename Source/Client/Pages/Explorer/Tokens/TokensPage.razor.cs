namespace Herc.Pwa.Client.Pages.Explorer.Tokens
{
  using MintingUi.Client.Features.Base.Components;
  using Herc.Pwa.Client.Features.Erc1155.Token;
  using System.Collections.Generic;

  public class TokensPageBase : BaseComponent
  {
    public const string Route = "/tokens";

    public IReadOnlyList<Token> Tokens => TokenState.Tokens;
  }
}