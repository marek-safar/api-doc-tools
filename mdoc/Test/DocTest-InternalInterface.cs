namespace MyNamespace {
	internal interface MyInternalInterface {
		bool Foo {get;set;}
		string FooSet {set;}
		void FooMeth ();
		void BarMeth ();
	}

	public class MyClass : MyInternalInterface {
		[System.ComponentModel.DefaultValue ('\0')]
		public string Bar {get;set;}
		public void BarMeth () {} // part of the interface, but publicly implemented

		string MyInternalInterface.FooSet {set {}}
		bool MyInternalInterface.Foo {get;set;}
		void MyInternalInterface.FooMeth () {}
	}

    public static class ArrayX10 {
        public static bool IsAligned<T> (this T[] vect, int index) where T : struct 
        {
            return false;
        }
    }
}
