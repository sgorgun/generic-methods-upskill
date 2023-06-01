# Generics Methods
 
## Task Description

* Implement generic methods of the class [ArrayExtension](GenericMethods/ArrayExtension.cs).
* Implement the [GetIeee754Format.Transform](DoubleTransformer/GetIeee754Format.cs#L16) method that results a binary representation of a real double-precision number in IEEE 754 format. Don't use Framework's converter classes. The task definition is given in the  XML-comments for this method.        
    Hint:  Use C# structs to create a union type (similar to C unions).     
* Implement an [ContainsDigitPredicate.IsMatch](IntegerPredicate/ContainsDigitPredicate.cs#L25) method that checks if a given number contains a given digit. Don't use strings and arrays.      

The detailed explanations of the task are provided in the XML-comments for the methods and in test cases of unit tests.

## Additional Materials

Feel welcome to check out a set of supplementary articles from C# Programming Guide: 

- [C# extension methods](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods)  
- [Math.Abs method](https://docs.microsoft.com/en-us/dotnet/api/system.math.abs?view=net-5.0) 

### C# reference  

* [ArgumentNullException class](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception?view=net-5.0#:~:text=An%20ArgumentNullException%20exception%20is%20thrown,but%20should%20never%20be%20null%20.&text=An%20object%20returned%20from%20a,original%20returned%20object%20is%20null%20.) 
* [ArgumentException class](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception?view=net-5.0)
