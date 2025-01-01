public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize the property before accessing it.
        MyProperty = 10; // Solution: Initialize the property
        int value = MyProperty;
        Console.WriteLine(value); // Now prints 10
    }
    public void MyMethod2(){
        //Alternative solution using null-coalescing operator
        int value = MyProperty ?? 0; 
        Console.WriteLine(value); //Prints 0 if MyProperty is not initialized
    }
} 
