namespace MintingUi.Client.Features.Erc1155.Token.Components
{
  using MintingUi.Client.Features.Erc1155.Token;
  using Microsoft.AspNetCore.Components;
  using MintingUi.Client.Features.Base.Components;
  using System;
  using System.Linq;

  public class TokenItemBase : BaseComponent
  {
    public Token Token => TokenState.Tokens.FirstOrDefault(aToken => aToken.Guid == TokenId);
    public int TokenCount { get; set; } = 3; // TODO should derive from sum of Dies.Tokens
    [Parameter] public Guid TokenId { get; set; }
  }
}