namespace MintingUi.Client.Features.Erc1155.Currencies
{
  using BlazorState;
  using MintingUi.Client.Features.Erc1155.Die;
  using MintingUi.Client.Features.Erc1155.Token;
  using MintingUi.Client.Features.Erc1155.Wallet;
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public class Currency
  {
    private readonly IStore Store;

    public Currency(IStore aStore)
    {
      Store = aStore ?? throw new ArgumentNullException(nameof(aStore));
    }

    public DateTime CreationDate { get; set; }

    public string Description { get; set; }

    public IReadOnlyList<Die> Dies => DieState.Dies.Where(d => d.CurrencyId == Guid).ToList();

    public DieState DieState => Store.GetState<DieState>();

    public Guid Guid { get; set; }

    public string ImageUrl { get; set; }

    /// <summary>
    /// Derived as union of all Die Tokens
    /// </summary>
    public List<Token> MintedTokenList { get; set; }

    public string Name { get; set; }

    /// <summary>
    ///
    /// </summary>
    /// <remarks>TODO: Should be own type</remarks>
    public string OwnerAddress { get; set; }

    public Wallet Wallet => Store.GetState<WalletState>().Wallet;
    public Guid WalletId { get; set; }
    public string Website { get; set; }
  }

  public class CurrencyState : State<CurrencyState>
  {
    private readonly IStore Store;

    public CurrencyState(IStore aStore)
    {
      _Currencies = new List<Currency>();
      Store = aStore;
    }

    private List<Currency> _Currencies { get; set; }
    public IReadOnlyList<Currency> Currencies => _Currencies.AsReadOnly();

    public override void Initialize()
    {
      var walletGuid = new Guid("29c24791-6d77-4ca6-a816-f7281637ef65");
      var testCurrencys = new List<Currency>()
      {
        new Currency(Store)
        {
          Description = "Age of Rust is a dark sci-fi adventure game set in the vast expanse of the universe.",
          Guid = new Guid("d4989e90-6f73-4020-9cbb-1313f5497065"),
          ImageUrl="https://cdn.enjinx.io/assets/images/ethereum/platform/0/apps/38/3d6ee9d0d2a913c6253e13b6eaef968167cc196b.jpg?width=250",
          Name = "Age of Rust",
          WalletId = walletGuid,
          MintedTokenList = new List<Token>
          {
            AgeOfRustDummyTokens.SmokeGrenade,
            AgeOfRustDummyTokens.RustBits
          }
        },

        new Currency(Store)
        {
          Description = "War of Crypto is a player-vs-player (PvP) multiplayer game that features unique, evolvable and tradeable heroes",
          Guid = new Guid("cb776515-3023-4895-9d4a-918a779f38a0"),
          ImageUrl = "https://cdn.enjinx.io/assets/images/ethereum/platform/custom/5/ec96fc333fa60de1706fd2ab315a708defa8483d.jpg?width=250",
          Name = "War of Crypto",
          WalletId = walletGuid,
        },
        new Currency(Store)
        {
          Description = "In theoretical physics, a multiverse is an infinite array of universes where anything is possible," +
          " and every possibility exists. The various universes within the multiverse are often referred to as 'parallel' or" +
          " 'alternate' universes or 'other dimensions.' In the context of gaming, the multiverse is a network of games where" +
          " players can use their characters and items across different worlds."
          ,
          Guid = new Guid("320042ad-4358-425a-9dfb-4945208066ad"),
          ImageUrl = "https://cdn.enjinx.io/assets/images/ethereum/platform/0/apps/8/2aebae67a0393c9fbdb6124d22e9fe26d6a74bc1.jpg?width=250",
          Name = "The Multiverse",
          WalletId = walletGuid,
        },
      };

      _Currencies.AddRange(testCurrencys);
    }
  }
}