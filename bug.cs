public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a non-initialized property can lead to unexpected behavior
        int value = MyProperty * 2; // Bug: MyProperty might be 0 or contain garbage data if not initialized
    }
}