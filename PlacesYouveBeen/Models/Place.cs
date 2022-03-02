using System.Collections.Generic;

namespace Places.Models
{
  public class Place
  {
    public string City { get; set; }
    private static List<Place> _placeList = new List<Place>{};

    public Place (string city)
    {
      City = city;
      _placeList.Add(this);
    }

    public static void ClearAll()
    {
      _placeList.Clear();
    }

    public static List<Place> GetAll()
    {
      return _placeList;
    }

  }
}