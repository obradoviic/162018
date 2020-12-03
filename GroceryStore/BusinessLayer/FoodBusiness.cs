using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class FoodBusiness
    {
        private readonly FoodRepository foodRepository;

        public FoodBusiness()
        {
            this.foodRepository = new FoodRepository();
        }

        public List<Food> GetAll()
        {
            return this.foodRepository.GetAll();
        }
        public List<Food>GetAllInStockMin(int inStockMin)
        {
            return this.foodRepository.GetAll().Where(f => f.InStock > inStockMin).ToList();
        }
    }
}
