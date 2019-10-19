using MintingUi.Client.Features.Base.Components;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintingUi.Client.Pages.Explorer.Transactions
{
    public class TransactionDetailsPageBase : BaseComponent
    {

    [Parameter]
    public string TransactionHash { get; set; }

  }
}
