﻿namespace MintingUi.Client.Pages.Wallets
{
  using Microsoft.AspNetCore.Components;
  using MintingUi.Client.Features.Base.Components;
  using System;

  public class WalletCurrenciesPageBase : BaseComponent
  {
    public const string Route = "/WalletId/currencies";
    [Parameter] public Guid CurrencyId { get; set; }

    public string WalletDiesRoute => $"/WalletId/dies/{CurrencyId}"; 

    //public string RouteBuilder(Guid CurrencyId) => WalletDiesRoute + CurrencyId.ToString();
  }
}