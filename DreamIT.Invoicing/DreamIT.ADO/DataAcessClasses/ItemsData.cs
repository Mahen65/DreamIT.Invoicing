using DreamIT.Data;
using DreamIT.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamIT.ADO.DataAcessClasses
{
    public class ItemsData
    {
        DataAgent obj;
        SqlParameter[] para;
        public ItemsData()
        {
            obj = new DataAgent();
        }
        public List<MainCategoryVM> GetMainCategories()
        {
            return obj.ReturnListFromNonQuery<MainCategoryVM>("spGetAllMainCategories");
        }

        public List<SubCatagoryVM> GetSubCategories()
        {
            return obj.ReturnListFromNonQuery<SubCatagoryVM>("spGetAllSubCategories");
        }

        public List<DetailsVM> GetDetailsBySubcategory(int subCatID)
        {
            para = new SqlParameter[]
                {
                    new SqlParameter("@SubCategoryID", subCatID)
                };
            return obj.ReturnListFromParameters<DetailsVM>("spGetDetailsBySubcategory", para);
        }

        public List<MeasureUnitVM> GetMeasureUnits()
        {
            return obj.ReturnListFromNonQuery<MeasureUnitVM>("spGetMeasureUnits");
        }

        public string AddNewStockItem(ItemsVM objItem)
        {
            para = new SqlParameter[]
                {
                    new SqlParameter("@MainCategoryID", objItem.MainCategoryID),
                    new SqlParameter("@SubCategoryID", objItem.SubCategoryID),
                    new SqlParameter("@MeasureUnitID",objItem.MeasureUnitID),
                    new SqlParameter("@DetailValues",Comman.ConvertList(objItem.DetailValues))
                };
            int i=obj.InsertInTo("spAddNewStockItem", para);
            string msg = string.Empty;
            if (i>0)
            {
                msg = "Item Added Succesfullylllll";
            }
            else
            {
                msg = "ItemNotAdded";
            }
            return msg;
        }

        public List<DetailValueVM> GetValuesByDetail(int DetailID)
        {
            para = new SqlParameter[]
            {
                    new SqlParameter("@DetailID", DetailID)
            };
            return obj.ReturnListFromParameters<DetailValueVM>("spGetDetailValuesByID", para);
        }
    }
}
