using System.Collections.Generic;
using System.Data.Entity;
using toishop.Models;
using WebApplication1;
using WebApplication1.models;

namespace toyshop.Models
{
    public class toyDatabaseInitializer : DropCreateDatabaseAlways<toyContext>
    {
        protected override void Seed(toyContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetToys().ForEach(p => context.Books.Add(p));
        }
        private static List<WebApplication1.models.Category> GetCategories()
        {
            var categories = new List<Category> {
 new Loaidochoi
 {
    Maloaidochoi = 1,
MaLoaidochoi = "Do choi van dong"
 },
 new Loaidochoi
 {
  Maloaidochoi = 2,
CategoryName = "Do choi tri Tue"
 },
 new  loaidochoi{
  Maloaidochoi = 3,
 loaidochoiName = "Phuong tien giao thong"
 },
 new  loaidochoi
 {
  Maloaidochoi = 4,
 loaidochoiName = "Bup be"
 }
 };
            return categories;
        }
        private static List<WebApplication1.toy> GetToy()
        {
            var toys = new List<Toy> {

 new Toy
 {
 ToyID = 1,
ToyName = "Đồ Chơi Xe Điều Khiển Monster Viper",
        ImagePath = "tritue1.jpg",
UnitPrice = 16.04f,
 LoaidochoiID = 1
        },

 new Toy
 {
 ToyID = 2,
ToyName = "Quả trứng thần kỳ",
ImagePath = "tritue2.jpg",
UnitPrice = 19.60f,
CategoryID = 2
    },

 new Toy
 {
 ToyID = 1,
 ToyName = "Obama: An Intimate Portrait",
 ImagePath="vandong1.jpg ",
UnitPrice = 26.73f,
CategoryID = 2
 },
 
 new Toy
 {
 ToyID = 4,
ToyName = "Sapiens: A Brief History of Humankind",
ImagePath="Pic4.png",
UnitPrice = 23.79f,
CategoryID = 3
 },

 new Toy
 {
 ToyID = 5,
ToyName = "The 7 Habits of Highly Effective People",
Description = "Stephen Covey’s cherished classic commemorates the
timeless wisdom and " +
 "power of the 7 Habits book, and does it in a highly readable and
understandable, infographics format.",
 ImagePath= "Pic5.png",
UnitPrice = 16.04f,
CategoryID = 4
 },
 };
 return toy;
 }
 }
}