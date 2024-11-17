using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //В SOLID це принцип єдиного обов’язку (SRP) (The Single Responsibility Principle)
    //Божественний об'єкт //треба уточнити чи можна їх вважати синонімами
    class Item
    {

    }
    class Order
    {
        private List<Item> itemList = new List<Item>();

        public List<Item> ItemList => itemList;

        public void AddItem(Item item) { /* ... */ }
        public void DeleteItem(Item item) { /* ... */ }
        public void GetItemCount() { /* ... */ }
        public void CalculateTotalSum() { /* ... */ }
    }

    class OrderShow
    {
        public void PrintOrder(Order order) { /* ... */ }
        public void ShowOrder(Order order) { /* ... */ }
    }

    class OrderData
    {
        public void Load(int orderId) { /* ... */ }
        public void Save(Order order) { /* ... */ }
        public void Update(Order order) { /* ... */ }
        public void Delete(int orderId) { /* ... */ }
    }

    class Program
    {
        static void Main()
        {
        }
    }
}
