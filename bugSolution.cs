public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize the property before accessing it
        MyProperty = 0; // Assign a default value 
        int value = MyProperty * 2; 
    }
}
// Alternative approach: Initialize in the constructor
public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize in the declaration

    public void MyMethod()
    {
        int value = MyProperty * 2;
    }
} 