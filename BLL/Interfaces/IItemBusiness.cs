using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public partial interface IItemBusiness
    {
        bool Create(ItemModel model);
        ItemModel GetDatabyID(string id);
        List<ItemModel> GetDataAll();
    }
}
