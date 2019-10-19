using BlazorState;
using System;
using System.Collections.Generic;

namespace Herc.Pwa.Client.Features.Erc1155.Transactions
{
  public class Transaction
  {
    private readonly IStore Store;

    public Transaction(IStore aStore)
    {
      Store = aStore ?? throw new ArgumentNullException(nameof(aStore));
    }

    public int AssetQuantity { get; set; }
    public int Blocknumber { get; set; }
    public string ContractAddress { get; set; }
    public bool ErrorMessage { get; set; }
    public double Fee { get; set; }
    public TxParty From { get; set; }
    public int GasLimit { get; set; }
    public int GasPrice { get; set; }
    public string Hash { get; set; }
    public int Id { get; set; }
    public int Nonce { get; set; }
    // If Asset Transfer

    public bool Status { get; set; }
    public int Timestamp { get; set; } // Epoch
    public TxParty To { get; set; }
    public int TransactionIndex { get; set; }
    public string Type { get; set; } = "Call"; // or Create??? transfer type
    public string Value { get; set; }
  }

  public class TransactionState : State<TransactionState>
  {
    private readonly IStore Store;

    public TransactionState(IStore aStore)
    {
      Store = aStore ?? throw new ArgumentNullException(nameof(aStore));
    }

    private List<Transaction> _TransactionList { get; set; }
    public IReadOnlyList<Transaction> TransactionList => _TransactionList.AsReadOnly();

    public override void Initialize()
    {
      _TransactionList = new List<Transaction>();
      var testTransactions = new List<Transaction>
      {
        new Transaction(Store)
        {
          Id = 392020,
          Blocknumber = 32844232,
          Timestamp = 03094482,
          Hash = "0xdf8f0af0g09sf7hgs8fg957689f98gas0f98gs9f65gs89965d",
          From = new TxParty
          {
            Address = "0x2342s9d8f8sd5fs9d7f9a8dfadaedertqve87r7sdi",
            Name = "From Side Test Transaction",
            Contract = false,
            Miner = false
          },

          To = new TxParty
          {
            Address = "0x2342s9d8f8sd5fs9d7f9a8dfadaedertqve87r7sdi",
            Name = "To Side Test Transaction",
            Contract = false,
            Miner = false,
          },
          Value = "42",
          Status = true,
          ErrorMessage = false,
          ContractAddress = null,
          TransactionIndex = 133,
          Fee = .9993,
          GasLimit = 100000,
          GasPrice = 44,
          Nonce = 42,
          AssetQuantity = 11
        },
        new Transaction(Store)
        {
          Id = 392021,
          Blocknumber = 32943232,
          Timestamp = 08094482,
          Hash = "0xdf8f0af0g09sf7hgs8fg957689f98gas0f98gs9f65gs89965d",
          From = new TxParty
          {
            Address = "0x2342s9d8f8sd5fs9d7f9a8dfadaedertqve87r7sdi",
            Name = "From Side Test Transaction",
            Contract = false,
            Miner = false
          },

          To = new TxParty
          {
            Address = "0x2342s9d8f8sd5fs9d7f9a8dfadaedertqve87r7sdi",
            Name = "To Side Test Transaction",
            Contract = false,
            Miner = false,
          },
          Value = "42",
          Status = true,
          ErrorMessage = false,
          ContractAddress = null,
          TransactionIndex = 133,
          Fee = .9993,
           GasLimit = 100000,
          GasPrice = 20,
          Nonce = 42,
          AssetQuantity = 11
        },
        new Transaction(Store)
        {
          Id = 392020,
          Blocknumber = 32844232,
          Timestamp = 03094482,
          Hash = "0xdf8f0af0g09sf7hgs8fg957689f98gas0f98gs9f65gs89965d",
          From = new TxParty
          {
            Address = "0x2342s9d8f8sd5fs9d7f9a8dfadaedertqve87r7sdi",
            Name = "From Side Test Transaction",
            Contract = false,
            Miner = false
          },

          To = new TxParty
          {
            Address = "0x2342s9d8f8sd5fs9d7f9a8dfadaedertqve87r7sdi",
            Name = "To Side Test Transaction",
            Contract = false,
            Miner = false,
          },
          Value = "42",
          Status = true,
          ErrorMessage = false,
          ContractAddress = null,
          TransactionIndex = 133,
          Fee = .9993,
           GasLimit = 100000,
          GasPrice = 35,
          Nonce = 42,
          AssetQuantity = 11
        },
        new Transaction(Store)
        {
          Id = 392020,
          Blocknumber = 32844232,
          Timestamp = 03094482,
          Hash = "0xdf8f0af0g09sf7hgs8fg957689f98gas0f98gs9f65gs89965d",
          From = new TxParty
          {
            Address = "0x2342s9d8f8sd5fs9d7f9a8dfadaedertqve87r7sdi",
            Name = "From Side Test Transaction",
            Contract = false,
            Miner = false
          },

          To = new TxParty
          {
            Address = "0x2342s9d8f8sd5fs9d7f9a8dfadaedertqve87r7sdi",
            Name = "To Side Test Transaction",
            Contract = false,
            Miner = false,
          },
          Value = "42",
          Status = true,
          ErrorMessage = false,
          ContractAddress = null,
          TransactionIndex = 133,
          Fee = .9993,
           GasLimit = 100000,
          GasPrice = 35
        },
        new Transaction(Store)
        {
          Id = 392020,
          Blocknumber = 32844232,
          Timestamp = 03094482,
          Hash = "0xdf8f0af0g09sf7hgs8fg957689f98gas0f98gs9f65gs89965d",
          From = new TxParty
          {
            Address = "0x2342s9d8f8sd5fs9d7f9a8dfadaedertqve87r7sdi",
            Name = "From Side Test Transaction",
            Contract = false,
            Miner = false
          },

          To = new TxParty
          {
            Address = "0x2342s9d8f8sd5fs9d7f9a8dfadaedertqve87r7sdi",
            Name = "To Side Test Transaction",
            Contract = false,
            Miner = false,
          },
          Value = "42",
          Status = true,
          ErrorMessage = false,
          ContractAddress = null,
          TransactionIndex = 133,
          Fee = .9993,
          GasLimit = 100000,
          GasPrice = 35,
          Nonce = 42,
          AssetQuantity = 11
        }
      };

      _TransactionList.AddRange(testTransactions);
    }
  }

  public class TxParty
  {
    public string Address { get; set; }
    public bool Contract { get; set; }
    public bool Miner { get; set; }
    public string Name { get; set; }
  }
}