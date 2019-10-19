namespace MintingUi.Client.Features.Erc1155.Transactions.Components
{
  using Microsoft.AspNetCore.Components;
  using MintingUi.Client.Features.Base.Components;
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public class TransactionDetailBase : BaseComponent
  {
    [Parameter]
    public string TransactionHash { get; set; }


    public DateTime convertedTime(long seconds)
    {
      var convertedEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

      return convertedEpoch.ToLocalTime().AddSeconds(seconds);
    }

    private List<Transaction> TransactionList => TransactionState.TransactionList.ToList();

    public Transaction Transaction => TransactionList.Find(aTransaction => aTransaction.Hash == TransactionHash);

  
  }
}
