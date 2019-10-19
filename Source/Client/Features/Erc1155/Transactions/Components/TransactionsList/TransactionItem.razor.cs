namespace MintingUi.Client.Features.Erc1155.Transactions.Components.TransactionsList
{
  using MintingUi.Client.Features.Base;
  using MintingUi.Client.Features.Base.Components;
  using System.Linq;
  public class TransactionItemBase : BaseComponent
    {
    public Transaction Transaction => TransactionState.TransactionList.FirstOrDefault();

      
    }
}
