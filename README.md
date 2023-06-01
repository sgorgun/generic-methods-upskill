# Generics Methods
 
## Task Description

* Implement generic methods of the class [ArrayExtension](GenericMethods/ArrayExtension.cs).
* Put a solution of the **IEEE 754 format** task into [DoubleExtension](IEEE754FormatTask/DoubleExtension.cs#L13) class.
    <details><summary>IEEE 754 format.</summary>        
    Implement the GetIEEE754Format method that obtains a binary representation of a real double-precision number in IEEE 754 format as the extension method. Don't use Framework's converter classes. The task definition is given in the  XML-comments for this method.        
    
    Hint:  Use C# structs to create a union type (similar to C unions).
    </details>      
* Put a solution of the **Contains Digit Validator** task into the [ContainsDigitValidator](ContainsDigitPredicate/ContainsDigitValidator.cs#L3) class.
    <details><summary>Contains Digit Validator.</summary>    
    Implement an Verify method that checks if a given number contains a given digit. Don't use strings and arrays.      
    </details>
* Put into the [Adapters](Adapters/) project the [GetIEEE754FormatAdapter](Adapters/GetIEEE754FormatAdapter.cs#L5) adapter class for [DoubleExtension](IEEE754FormatTask/DoubleExtension.cs#L13) that implement the required interfaces.
* Put into the [Adapters](Adapters/) project the [ContainsDigitPredicateAdapter](Adapters/ContainsDigitPredicateAdapter.cs#L6) adapter class for [ContainsDigitValidator](ContainsDigitPredicate/ContainsDigitValidator.cs#L3) that implement the required interfaces. 

The detailed explanations of the task are provided in the XML-comments for the methods and in test cases of unit tests.

## Checklist

* Build a solution in [Visual Studio](https://docs.microsoft.com/en-us/visualstudio/ide/building-and-cleaning-projects-and-solutions-in-visual-studio?view=vs-2019). Make sure there are **no compiler errors and warnings**, fix these issues and rebuild the solution. 
* Run all unit tests with [Visual Studio](https://docs.microsoft.com/en-us/visualstudio/test/run-unit-tests-with-test-explorer?view=vs-2019) and make sure there are **no failed unit tests**. Fix your code to [make all tests GREEN](https://stackoverflow.com/questions/276813/what-is-red-green-testing). 
* Review all your changes in the codebase **before** [staging the changes and creating a commit](https://docs.microsoft.com/en-us/azure/devops/repos/git/commits?view=azure-devops&tabs=visual-studio). 
* [Stage your changes, create a commit](https://docs.microsoft.com/en-us/azure/devops/repos/git/commits?view=azure-devops&tabs=visual-studio), and publish your changes to the remote repository. 


## Additional Materials

Feel welcome to check out a set of supplementary articles from C# Programming Guide: 

- [C# extension methods](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods)  
- [Math.Abs method](https://docs.microsoft.com/en-us/dotnet/api/system.math.abs?view=net-5.0) 

### C# reference  

* [ArgumentNullException class](https://docs.microsoft.com/en-us/dotnet/api/system.argumentnullexception?view=net-5.0#:~:text=An%20ArgumentNullException%20exception%20is%20thrown,but%20should%20never%20be%20null%20.&text=An%20object%20returned%20from%20a,original%20returned%20object%20is%20null%20.) 
* [ArgumentException class](https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception?view=net-5.0)
