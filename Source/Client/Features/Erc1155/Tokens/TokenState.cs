namespace MintingUi.Client.Features.Erc1155.Token
{
  using BlazorState;
  using System;
  using System.Collections.Generic;

  public class Token
  {
    //private readonly IStore Store;

    //public Token(IStore aStore)
    //{
    //Store = aStore ?? throw new ArgumentNullException(nameof(aStore));
    //}

    public Guid Guid { get; set; }
    public DateTime Created { get; set; }
    public string Creator { get; set; } // 0x Address
    public string Currency { get; set; } // Enjin's "Platform:"
    public int Hodlers { get; set; }

    public string ImageUrl { get; set; }
    public int MeltFee { get; set; }
    public int Melts { get; set; }
    public string Reserve { get; set; } // amount of tokens backing the asset
    public string Standard { get; set; } = "ERC-1155 (Herc)";
    public string SupplyType { get; set; }
    public string TokenAddress { get; set; }
    public int TotalSupply { get; set; }
    public int TransferFee { get; set; }
    public int Transfers { get; set; }
    // not sure what this is, tokens address i'm guessing
  }
  public class TokenState
  {
    private readonly IStore Store;

    public TokenState(IStore aStore)
    {
      _Tokens = new List<Token>();
      Store = aStore;
    }

    private List<Token> _Tokens { get; set; }
    public IReadOnlyList<Token> Tokens => _Tokens.AsReadOnly();

  }
}