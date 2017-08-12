using DreamIT.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamIT.Data.DataAcessClasses
{
    public class ItemsData
    {
        DataAgent objDa = new DataAgent();
        public List<MainCategoryVM> GetMainCategories()
        {
            List <MainCategoryVM> list= objDa.ReturnListFromNonQuery<MainCategoryVM>("spGetAllMainCategories");
            return list;
        }
    }
}
