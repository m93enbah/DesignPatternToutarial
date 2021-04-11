using DoFactoryProtoType02.Interfaces;
using System.Collections.Generic;

namespace DoFactoryProtoType02.Models
{
    public class ColorManager
    {
        private Dictionary<string, IColorPrototype> _colors = new Dictionary<string, IColorPrototype>();

        // Indexer
        public IColorPrototype this[string key]
        {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }
}
