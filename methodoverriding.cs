// C# program to demonstrate the method overriding
// without using 'virtual' and 'override' modifiers
using System;

// base class name 'baseClass'
class baseClass

{
	public void show()
	{
		Console.WriteLine("Base class");
	}
}

// derived class name 'derived'
// 'baseClass' inherit here
class derived : baseClass
{
	
	// overriding
	new public void show()
	{
		Console.WriteLine("Derived class");
	}
}

class GFG {
	
	// Main Method
	public static void Main()
	{
		
		// 'obj' is the object of
		// class 'baseClass'
		baseClass obj = new baseClass();
		
		
		// invokes the method 'show()'
		// of class 'baseClass'
		obj.show();
		
		obj = new derived();
		
		// it also invokes the method
		// 'show()' of class 'baseClass'
		obj.show();
		
	}
}
