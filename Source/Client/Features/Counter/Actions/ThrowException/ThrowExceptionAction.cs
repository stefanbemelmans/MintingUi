namespace MintingUi.Client.Features.Counter
{
  using MintingUi.Client.Features.Base;

  internal partial class CounterState
  {
    public class ThrowExceptionAction : BaseAction
    {
      public string Message { get; set; }
    }
  }
}