using System;
using System.Collections.Generic;
using System.Text;
using DreamIT.Model.ViewModels;
using DreamIT.ADO.DataAcessClasses;

namespace DreamIT.Service
{
    public class ItemService
    {
        ItemsData objData;
        public ItemService()
        {
            objData = new ItemsData();
        }
        public List<MainCategoryVM> GetMainCategories()
        {
            return objData.GetMainCategories();
        }

        public List<SubCatagoryVM> GetSubCategories()
        {
            return objData.GetSubCategories();
        }

        public List<DetailsVM> GetDetailsBySubcategory(int subCatID)
        {
            return objData.GetDetailsBySubcategory(subCatID);
        }

        public List<DetailValueVM> GetValuesByDetail(int DetailID)
        {
            return objData.GetValuesByDetail(DetailID);
        }

        public List<MeasureUnitVM> GetMeasureUnits()
        {
            return objData.GetMeasureUnits();
        }

        public string AddNewStockItem(ItemsVM obj)
        {
            return objData.AddNewStockItem(obj);
        }
    }
}
