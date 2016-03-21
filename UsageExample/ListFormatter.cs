using System.Collections.Generic;

namespace UsageExample
{
    public class ListFormatter<T>
    {
        private bool _isFirstItem = true;
        private readonly string _itemTypeName;
        private readonly IEnumerable<T> _list;

        public ListFormatter(IEnumerable<T> list)
        {
            _list = list;
            _itemTypeName = typeof(T).Name;
        }

        public string GetFormattedList()
        {
            var returnString = $"IEnumerable<{_itemTypeName}> {{";
            foreach (var item in _list)
            {
                if (_isFirstItem) _isFirstItem = false;
                else returnString += ", ";
                returnString += item.ToString();
            }
            return returnString;
        }
    }
}