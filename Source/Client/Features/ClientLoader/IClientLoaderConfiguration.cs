namespace MintingUi.Client.Features.ClientLoaderFeature
{
  using System;

  public interface IClientLoaderConfiguration
  {
    TimeSpan DelayTimeSpan { get; }
  }
}
