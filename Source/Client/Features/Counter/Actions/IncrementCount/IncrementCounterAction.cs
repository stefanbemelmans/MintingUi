namespace MintingUi.Client.Features.Counter
{
  using MintingUi.Client.Features.Base;

  internal partial class CounterState
  {
    public class IncrementCounterAction : BaseAction
    {
      public int Amount { get; set; }
    }
  }
}