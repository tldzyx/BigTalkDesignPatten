using System.Collections.Generic;

namespace CreateWebSite
{
    internal class WebSiteFactory
    {
        private readonly Dictionary<string, WebSite> _flyweights = new Dictionary<string, WebSite>();

        public WebSite GetWebSiteCategory(string key)
        {
            if (!_flyweights.ContainsKey(key))
            {
                _flyweights.Add(key, new ConcreteWebSite(key));
            }
            return _flyweights[key];
        }

        public int GetWebSiteCount()
        {
            return _flyweights.Count;
        }
    }
}