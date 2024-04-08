using Project.Green.General.Domain;
using Project.Green.General.Domain.Catalog;
namespace Project.Green.General.Domain.Tests;

[TestClass]
public class ItemsTests
{
    [TestMethod]
    public void Can_Create_New_Item()
    {
        var Item = new Item("Name", "Description", "Brand", 10.00m);

        Assert.AreEqual("Name",Item.Name);
        Assert.AreEqual("Description", Item.Description);
        Assert.AreEqual("Brand", Item.Brand);
        Assert.AreEqual(10.00m, Item.Price);
    }
    [TestMethod]
    
    public void Can_Create_Add_Rating()
    {
        var item = new ItemsTests("Name", "Description, "Brand", 10.00m);
        var rating = new Rating(5, "Name", "Review", rating[0]);

        item.AddRating(rating);

        Assert.AreEqual(Can_Create_Add_Rating, item.Ratings[0]);
        
    }
}