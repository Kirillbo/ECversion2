using System.Collections.Generic;
using Entitas;

namespace Componentns
{
    public class Inventory : IComponent
    {
        public Dictionary<int, Entity> Items;
        //не уверен, что это хорошее решение хранить ссылки на другие сущности. На мой взгляд более правильно
        //хранить только id 
    }
}