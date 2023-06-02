# Generics Methods
 
## Task Description

* Implement all generic methods of the class [GenericMethods.ArrayExtension](GenericMethods/ArrayExtension.cs#L10).
* Implement the [GetIeee754Format.Transform](DoubleTransformer/GetIeee754Format.cs#L16) method that results a binary representation of a real double-precision number in IEEE 754 format. **Don't use Framework's converter classes**.     
    _The detailed explanations of the task are provided in the XML-comments for the methods and in [test cases](GenericMethods.Tests/NUnitTests/ArrayExtensionTests.cs#L37) of unit tests_       
    _Hint:  Use C# structs to create a union type (similar to C unions)._     
* Implement the [ContainsDigitPredicate.IsMatch](IntegerPredicate/ContainsDigitPredicate.cs#L25) method that checks if a given number contains a given digit. **Don't use strings and arrays.**      
_The detailed explanations of the task are provided in the XML-comments for the methods and in [test cases](GenericMethods.Tests/NUnitTests/ArrayExtensionTests.cs#L14) of unit tests._
* Implement the [IntegerByAbsComparer.Compare](Comparators/IntegerByAbsComparer.cs#L9) method to compare absolute values of the two integers.  
* Implement the [StringByLengthComparer.Compare](Comparators/StringByLengthComparer.cs#L9) method to compare ompares two strings by length of the string. 

## Additional Materials
- [IEEE 754](https://www.wikiwand.com/en/IEEE_754) 
- [Math.Abs method](https://docs.microsoft.com/en-us/dotnet/api/system.math.abs) 

