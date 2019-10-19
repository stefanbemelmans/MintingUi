namespace Herc.Pwa.Client.Pages.Explorer.Transactions
{
  using MintingUi.Client.Features.Base.Components;
  using Herc.Pwa.Client.Features.Erc1155.Transactions;
  using Microsoft.AspNetCore.Components;
  using System.Collections.Generic;
  using System.Linq;

  public class TransactionsPageBase : BaseComponent
  {
    public string ActiveTab => RouteState.Route.Split('/').Last();
    public string InfoTabActive => ActiveTab == "counter" ? "active" : "";

    public IReadOnlyList<Transaction> Transactions => TransactionState.TransactionList;
  }
}