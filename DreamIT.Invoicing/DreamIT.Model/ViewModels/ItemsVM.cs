using System;
using System.Collections.Generic;
using System.Text;

namespace DreamIT.Model.ViewModels
{
    public class ItemsVM
    {
        public int ItemID { get; set; }
        public int MainCategoryID { get; set; }
        public int SubCategoryID { get; set; }
        public int MeasureUnitID { get; set; }
        public string ItemCode { get; set; }
        public string ItemDesc { get; set; }
        public decimal StockInHand { get; set; }
        public decimal ReOrderLevel { get; set; }
        public List<SubCatDetailValueVM> DetailValues { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedUser { get; set; }
    }
}
