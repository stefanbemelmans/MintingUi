namespace MintingUi.Client.Features.Erc1155.Token.Components
{
  using MintingUi.Client.Features.Base.Components;
  using System.Collections.Generic;

  public class TokenListBase : BaseComponent
  {
    public IReadOnlyList<Token> Tokens => TokenState.Tokens;
    public int TokenCount => Tokens.Count;
  }
}