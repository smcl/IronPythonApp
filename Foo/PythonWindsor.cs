using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;

namespace Foo
{
    public class PythonWindsor
    {
        public IWindsorContainer Container { get; set; }

        public PythonWindsor()
        {
            Container = new WindsorContainer();
            Container.Install(new PythonInstaller());
        }

        public IBar GetBar()
        {
            return Container.Resolve<IBar>();
        }
    }
}
