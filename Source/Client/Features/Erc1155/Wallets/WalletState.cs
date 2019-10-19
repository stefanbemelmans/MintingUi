namespace Herc.Pwa.Client.Features.Erc1155.Wallet
{
  using BlazorState;
  using Herc.Pwa.Client.Features.Erc1155.Currencies;
  
  using System;
  using System.Collections.Generic;

  public class Wallet
  {
    private readonly IStore Store;

    public Wallet(IStore aStore)
    {
      Store = aStore;
    }

    public IReadOnlyList<Currency> Currencies => Store.GetState<CurrencyState>().Currencies;
    public Guid Guid { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
    /// <summary>
    /// ETH Address
    /// </summary>
    public string EthAddress { get; set; }
  }

  public class WalletState : State<WalletState>
  {
    private readonly IStore Store;

    public WalletState(IStore aStore)
    {
      Store = aStore;
    }

    /// <summary>
    /// The Wallet
    /// </summary>
    /// <remarks>currently we only support one wallet we could do like Enjin and add watch wallets</remarks>
    public Wallet Wallet { get; private set; }

    public override void Initialize()
    {
      // Test Data
      Wallet = new Wallet(Store)
      {
        Name = "MyWallet",
        Guid = new Guid("29c24791-6d77-4ca6-a816-f7281637ef65")
      };
    }
  }
}