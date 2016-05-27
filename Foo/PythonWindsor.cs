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
    }
}
