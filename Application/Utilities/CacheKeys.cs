using Application.Product;
using Core.Abstract;
using Core.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Utilities
{
    public class CacheKeys
    {
        private Dictionary<string, string> _cachekeys = null;

        private static readonly Lazy<CacheKeys> _instance = new Lazy<CacheKeys>(() => new CacheKeys());

        public static CacheKeys Instance
        {
            get { return _instance.Value; }
        }

        public CacheKeys()
        {
            Initialize();
        }

        private void Initialize()
        {
            _cachekeys = new Dictionary<string, string>()
            {
                {"GetProducts","GetProductCacheKey" },
            };
        }

        public string GetCacheKey(string type)
        {
            try
            {
                if (Instance._cachekeys.ContainsKey(type))
                    return Instance._cachekeys[type];

                throw new System.Exception(string.Format("Cache key is not found.!"));
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
