using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public partial interface IItemRepository
    {
        bool Create(ItemModel model);
        ItemModel GetDatabyID(string id);
        List<ItemModel> GetDataAll();
    }
}
