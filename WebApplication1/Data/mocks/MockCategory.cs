using WebApplication1.Data.interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories {
            get {
                return new List<Category>() {
                    new Category() {categoryName = "Electromobile" , desc =  "Modern cars type "},
                    new Category() {categoryName = "DVS cars" , desc =  "Cars with dvs"}
                };
            }
        }

    }
}

