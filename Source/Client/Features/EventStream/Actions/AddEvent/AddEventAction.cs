namespace MintingUi.Client.Features.EventStream
{
  using MintingUi.Client.Features.Base;

  internal partial class EventStreamState
  {
    public class AddEventAction : BaseAction
    {
      public string Message { get; set; }
    }
  }
}