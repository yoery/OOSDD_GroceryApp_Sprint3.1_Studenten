﻿using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Repositories
{
    public interface IGroceryListItemsRepository
    {
        public List<GroceryListItem> GetAll();

        public List<GroceryListItem> GetAllOnGroceryListId(int id);

        public GroceryListItem Add(GroceryListItem item);

        public GroceryListItem? Delete(GroceryListItem item);

        public GroceryListItem? Get(int id);

        public GroceryListItem? Update(GroceryListItem item);
    }
}
