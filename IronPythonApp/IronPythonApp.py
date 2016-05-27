import sys
import unittest
import clr
import os

sys.path.Add(os.getcwd() + '\\' + '..\\bin') # solution bin directory
clr.AddReferenceToFile('Foo.dll')

from Foo import *

castle = PythonWindsor()

#b = Bar()
b = castle.Container.Resolve[IBar]()

print('Hello world')
print(b.Dork())