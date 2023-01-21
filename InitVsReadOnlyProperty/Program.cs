using InitVsReadOnlyProperty;

var model = new SomeModel("Test Value", "Test Value");

// you can't set init-only value like read-only property 

// model.ReadOnly = "Saeed Molaiy";
// model.Init = "Saeed Molaiy";

// so where is difference between init-only and read-only property
// here we go,with init-only properties you can use object initializer.
var model2 = new SomeModel("Test Value")
{
    Init = "Saeed Molaiy"
};

var model3 = new SomeModel
{
    //it is not possible to use readonly properties with object initializer.
    Init = "Saeed Molaiy"
};

Console.ReadKey();
