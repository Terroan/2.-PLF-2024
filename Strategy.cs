using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLF_2___DesignPattern
{
    //var navigator; navigator.setStr; var route = navigator.buildr;
    internal class Strategy
    {
    }

    internal interface IRouteStrategy
    {
        object buildRoute();
    }

    internal class RoadStrategy
    {
        public object buildRoute() { return null; }
    }

    internal class NavigatorContext
    {
        private IRouteStrategy _route;

        public NavigatorContext() { }

        public NavigatorContext(IRouteStrategy str) { _route = str; }

        public void setRouteStrategy(IRouteStrategy str) { _route = str; }

        public object buildRoute() { return _route.buildRoute(); }
    }
}
