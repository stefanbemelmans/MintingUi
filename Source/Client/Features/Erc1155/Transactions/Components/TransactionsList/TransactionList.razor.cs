namespace Herc.Pwa.Client.Features.Erc1155.Transactions.Components.TransactionsList
{
  using Herc.Pwa.Client.Features.Erc1155.Transactions;
  using Microsoft.AspNetCore.Components;
  using System.Collections.Generic;
  using MintingUi.Client.Features.Base.Components;

  public class TransactionListBase : BaseComponent
  {
    public int TransactionCount => Transactions.Count;
    [Parameter] public IReadOnlyList<Transaction> Transactions { get; set; }

    public string hash { get; set; }
    public string TransactionDetailsUrl (string aHash) => $"/explorer/transactions/{aHash}";

    public string GetSubString(string str)
    { 
      string firstFive = str.Substring(0, 5);
      string lastFive = str.Substring((str.Length - 5));

      return (firstFive + "..." + lastFive);

    }
  }
}