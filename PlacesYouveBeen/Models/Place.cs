using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    public string City { get; set; }
    private static List<Place> _placesList = new List<Place>{};

    public Place (string city)
    {
      City = city;
      _placesList.Add(this);
    }

    public static void ClearAll()
    {
      _placesList.Clear();
    }

    public static List<Place> GetAll()
    {
      return _placesList;
    }

  }
}