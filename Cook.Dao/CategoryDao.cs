using Cook.Common;
using Cook.Data;
using Cook.DataContracts.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook.Dao
{
    public class CategoryDao
    {
        public ListResponse<CategoryContract> GetAllCategory()
        {
            var response = new ListResponse<CategoryContract>();

            try
            {
                using (var context = new CookEntities())
                {
                    response.Items = context.Categories.Select(n => new CategoryContract()
                    {
                        CategoryName = n.CategoryName,
                        CategoryIntroduction = n.CategoryIntroduction
                    }).ToList();
                }
            }
            catch (Exception)
            {
                response.Success = false;
            }

            response.Success = true;

            return response;
        }
    }
}
