using System;

namespace Herc.Pwa.Client.Features.Erc1155.Token
{
  public class AgeOfRustDummyTokens
  {

    public static Token SmokeGrenade = new Token()
    {
      Created = new DateTime(),
      Creator = "the EDGE Eth Address",
      Currency = "Age Of Rust",
      Hodlers = 42,
      ImageUrl = "https://cdn.enjinx.io/metadata/raw/119287b259e096a231d3bd9dd3937716d347808f/22f8486d02c80c346122814597e2191a6367ec0f.jpg?width=600&height=700",
      MeltFee = 0,
      Melts = 14,
      Reserve = "10 AGLD",
      Standard = "ERC-1155 (Herc)",
      SupplyType = "Fixed",
      TokenAddress = "0x000000000000000000000",
      TotalSupply = 10,
      TransferFee = 0,
      Transfers = 5,
    };

    public static Token RustBits = new Token()
    {
      Created = new DateTime(),
      Creator = "the EDGE Eth Address",
      Currency = "Age Of Rust",
      Hodlers = 4242,
      ImageUrl = "https://cdn.enjinx.io/metadata/raw/33bfa9433eda2515ac5af4c80bb59b10610df6a2/fa7f043a8e9e17be6ed4031f84c21117beb37106.png?width=600&height=700",
      MeltFee = 0,
      Melts = 34859,
      Reserve = "10 AGLD",
      Standard = "ERC-1155 (Herc)",
      SupplyType = "Limited",
      TokenAddress = "0x000000000000000000000",
      TotalSupply = 25089993,
      TransferFee = 1,
      Transfers = 69393,
    };

  }
}


