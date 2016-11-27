# IronPythonApp
Test playing with IronPython and Castle.Windsor using Visual Studio. Basically a solution composed of two projects.

Foo (C#), has the following classes
- `Bar`: exposes a single method `Dork()`, implements interface `IBar`
- `PythonInstaller`: registers a `IBar` and its implementation `Bar`
- `PythonWindsor`: wrapper for `PythonInstaller`, to having to muck around with importing castle.windsor.dll in py

IronPythonApp (Python)
- uses `PythonWindsor` and `Castle.Windsor` to resolve an `IBar` and returns the object to python - calls it
