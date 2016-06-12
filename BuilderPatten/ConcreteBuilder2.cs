using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatten
{
    class ConcreteBuilder2 : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("部件X");
        }

        public override void BuildPartB()
        {
            product.Add("部件Y");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
