#nullable enable
namespace Herc.Pwa.Client.Pages.Utils
{
  using System;
  using System.Linq;

  public class Route
  {
    public static Route NewRouteFromUriString(string aUriString)
    {
      if (aUriString is null)
      {
        throw new ArgumentNullException(nameof(aUriString));
      }

      var uri = new Uri(aUriString);
      string[] uriPieces = uri.AbsolutePath.Split('/');
      return new Route(aGroup: uriPieces[1])
      {
        Entity = uriPieces.ElementAtOrDefault(2),
        Id = uriPieces.ElementAtOrDefault(3),
        List = uriPieces.ElementAtOrDefault(4),
      };
    }
    public Route(string aGroup)
    {
      Group = aGroup;
    }

    public Route(Route aRoute)
    {
      Group = aRoute.Group;
      Entity = aRoute.Entity;
      Id = aRoute.Id;
      List = aRoute.List;
    }

    public string Group { get; set; }
    public string? Entity { get; set; }
    public string? Id { get; set; }
    public string? List { get; set; }

    public override bool Equals(object aObject)
    {
      return aObject is Route route
        && Group == route.Group
        && Entity == route.Entity
        && Id == route.Id
        && List == route.List;
    }

    public override int GetHashCode()
    {
      unchecked
      {
        // Choose large primes to avoid hashing collisions
        const int HashingBase = (int)2166136261;
        const int HashingMultiplier = 16777619;

        int hash = HashingBase;
        hash = (hash * HashingMultiplier) ^ (Group?.GetHashCode() ?? 0);
        hash = (hash * HashingMultiplier) ^ (Entity?.GetHashCode() ?? 0);
        hash = (hash * HashingMultiplier) ^ (Id?.GetHashCode() ?? 0);
        hash = (hash * HashingMultiplier) ^ (List?.GetHashCode() ?? 0);
        return hash;
      }
    }

    public string BuildRelativeUriString()
    {
      string?[] array = new[] { Group, Entity, Id, List };
      string uriString = "/" + string.Join("/", array.Where(aString => !string.IsNullOrEmpty(aString)));
      return uriString;
    }
  }
}
