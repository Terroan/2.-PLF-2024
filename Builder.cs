using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLF_2___DesignPattern
{
    //var director; var builder; director.Builder = new XYBuilder();
    internal class XYBuilder : IBuilder
    {
        private Product _product = new();

        public XYBuilder() { _product = new(); }

        public void BuildPartA()
        {

        }

        public void BuildPartB()
        {

        }

        public void BuildPartC()
        {

        }
    }

    internal class Product
    {
        private List<object> _parts = new();

        public void Add(object part)
        {
            _parts.Add(part);
        }

        public void ListParts()
        {

        }
    }

    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder { set { _builder = value; } }

        public void BuildMinimalViableProduct()
        {
            _builder.BuildPartA();
        }
    }

    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
    }
}
