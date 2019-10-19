namespace MintingUi.Client.Features.Erc1155.Die
{
  using BlazorState;
  using MintingUi.Client.Features.Erc1155.Currencies;
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public enum Color { The3761A8, The993B9A, The9A3B3B, The9B6132 };

  public enum SupplyModel { Collapsing, Fixed, Infinite, Settable };

  public enum Transferable { Permanent, Temporary };

  public enum TransferFeeName { PerTransfer };

  public partial class Creator
  {
    public string Address { get; set; }
    public bool Contract { get; set; }
    public bool Miner { get; set; }
    public object Name { get; set; }
  }

  public class Die
  {
    private readonly IStore Store;

    public string Standard = "ERC-1155 (Herc)";

    public Die(IStore aStore)
    {
      Store = aStore ?? throw new ArgumentNullException(nameof(aStore));
    }

    public object BackgroundColor { get; set; }
    public object Balance { get; set; }
    public long CirculatingSupply { get; set; }
    public Color? Color { get; set; }
    public long Created { get; set; }
    public Creator Creator { get; set; }
    public Currency Currency => CurrencyState.Currencies.FirstOrDefault(aCurrency => aCurrency.Guid == CurrencyId);
    public Guid CurrencyId { get; set; }

    // TODO Problem is that accessing different states here will NOT properly set the components subscriptions
    // So should they even be in State as helper or just in the component where they will properly subscribe?
    public CurrencyState CurrencyState => Store.GetState<CurrencyState>();

    public string Description { get; set; }
    public long GroupId { get; set; }
    public Guid Guid { get; set; }

    public long Holders { get; set; }

    // Direct
    public long Id { get; set; }

    public Uri Image { get; set; }
    public object Melter { get; set; }
    public long MeltFeeMaxPercentage { get; set; }
    public long MeltFeePercentage { get; set; }
    public long Melts { get; set; }
    public object MeltType { get; set; }
    public double MeltValue { get; set; }
    public string Name { get; set; }
    public bool NonFungible { get; set; }
    public object Owner { get; set; }
    public Guid PlatformId { get; set; }
    public string Rarity { get; set; }
    public long Reserve { get; set; }
    public object SendType { get; set; }
    public SupplyModel SupplyModel { get; set; }
    public string Token { get; set; }
    public long TokenIndex { get; set; }
    public long? TotalSupply { get; set; }
    public Transferable Transferable { get; set; }
    public long Transfers { get; set; }
    public string Uri { get; set; }
  }

  public class DieState : State<DieState>
  {
    private readonly IStore Store;

    public DieState(IStore aStore)
    {
      _Dies = new List<Die>();
      Store = aStore;
    }

    public Die NewDie { get; set; } // figure it will come in handy during the "New Die Create" process
    private List<Die> _Dies { get; set; }
    public IReadOnlyList<Die> Dies => _Dies.AsReadOnly();

    public override void Initialize()
    {
      var testDies = new List<Die>()
      {
        new Die(Store)
        {
          Guid = new Guid("37409050-cd96-41a8-bb2f-372e36f82e62"),
          CurrencyId = new Guid("d4989e90-6f73-4020-9cbb-1313f5497065"),
          Creator = new Creator
          {
            Address = "0xdf9cc14f54c0148ef3d9cdd3a58fa2425bf6ce46",
          },
          CirculatingSupply = 852,
          MeltFeePercentage = 0,
          MeltValue = 5,
          Name = "Smoke Grenade",
          Description = "A black market item that creates a distraction or can provide cover.",
          SupplyModel = SupplyModel.Fixed,
          TotalSupply = 2000,
          Transferable = Transferable.Permanent,
          Image = new Uri("https://cdn.enjinx.io/metadata/raw/119287b259e096a231d3bd9dd3937716d347808f/22f8486d02c80c346122814597e2191a6367ec0f.jpg"),

        },
        new Die(Store)
        {
          Guid = new Guid("f8cf55ff-f852-4ab7-827d-78caa94ccd09"),
          CurrencyId = new Guid("d4989e90-6f73-4020-9cbb-1313f5497065"),
          Creator = new Creator
          {
            Address = "0xdf9cc14f54c0148ef3d9cdd3a58fa2425bf6ce46",
          },
          CirculatingSupply = 29330695,
          MeltFeePercentage = 0,
          MeltValue = 0.001,
          Name = "RustBits",
          Description = "Rustbits are the main token of use within the Age of Rust game universe. You need Rustbits to not only play Age of Rust, but also to purchase in-game cryptoitems as well. \n\n Rustbits are radioactive rust scraped off of hulls of abandoned ships that are in orbit around a hidden planet, which is also a gas giant. The planet is so radioactive, it damages ships and kills anyone that gets close to it. Getting bits of rust off of ships is highly rare and prized.",
          SupplyModel = SupplyModel.Fixed,
          TotalSupply = 37289210,
          Transferable = Transferable.Permanent,
          Image = new Uri("https://cdn.enjinx.io/metadata/raw/33bfa9433eda2515ac5af4c80bb59b10610df6a2/fa7f043a8e9e17be6ed4031f84c21117beb37106.png"),
        },
      };
      _Dies.AddRange(testDies);
     
    }
  }
}