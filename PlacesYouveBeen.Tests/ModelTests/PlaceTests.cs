using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Places.Models;

namespace Places.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }
  [TestMethod]
  public void PlaceConstructor_CreateInstanceOfPlace_Place()
  {
    Place tokyo = new Place("test");
    Assert.AreEqual(typeof(Place), tokyo.GetType());
  }

    [TestMethod]
    public void GetCityName_ReturnsCity_String()
    {
      //Arrange
      string cityName = "tokyo";
      Place newCity = new Place(cityName);

      //Act
      string result = newCity.City;

      //Assert
      Assert.AreEqual(cityName, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string cityName = "Tokyo";
      Place newCity = new Place(cityName);

      //Act
      string updatedCityName = "Kyoto";
      newCity.City = updatedCityName;
      string result = newCity.City;

      //Assert
      Assert.AreEqual(updatedCityName, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_PlacesList()
    {
      //Arrange
      List<Place> placesList = new List<Place> { };

      //Act
      List<Place> result = Place.GetAll();

      //Assert
      CollectionAssert.AreEqual(placesList, result);
    }

    // [TestMethod]
    // public void GetAll_ReturnsItems_ItemList()
    // {
    //   //Arrange
    //   string description01 = "Walk the dog.";
    //   string description02 = "Wash the dishes.";
    //   Item newItem1 = new Item(description01);
    //   Item newItem2 = new Item(description02);
    //   List<Item> newList = new List<Item> { newItem1, newItem2 };

    //   //Act
    //   List<Item> result = Item.GetAll();

    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

    // [TestMethod]
    // public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";
    //   Item newItem = new Item(description);

    //   //Act
    //   int result = newItem.Id;

    //   //Assert
    //   Assert.AreEqual(1, result);
    // }

    // [TestMethod]
    // public void Find_ReturnsCorrectItem_Item()
    // {
    //   //Arrange
    //   string description01 = "Walk the dog";
    //   string description02 = "Wash the dishes";
    //   Item newItem1 = new Item(description01);
    //   Item newItem2 = new Item(description02);

    //   //Act
    //   Item result = Item.Find(2);

    //   //Assert
    //   Assert.AreEqual(newItem2, result);
    // }
  }
}