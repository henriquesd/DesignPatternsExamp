# SOLID

S - SRP - Single Responsability Principle
O - OCP - Open/Closed Principle
L - LSP - Liskov Substitution Principle
I - ISP - Interface Segregation Principle
D - DIP - Dependency Inversion Principle


### Single Responsability Principle
"A class should have one, and only one, reason to change"

Separation of concerns - different classes handling different, independent task/problems.


### Open-Closed Principle
"Software entities (classes, modules, functions, etc) should be open for extension, but closed for modification."

If you've already got a class and this class has been written, it's been tested, you know that it works, it is
really a bad ideia to come back to this class and to add additional functionality to the sourcecode of this class
if you can avoid it, if you can can somehow extend this class by using inheritance and interfaces, or dependency 
injection for example, then it may be worth not touching the original.


### Liskov Substitution Principle
"Let q(x) be a property provable about objects x of type T. Then q(y) should be provable for objects y of type S,
where S is a subtype of T." (A base class must be able to be replaced by its derived class).

You should be able to substitute a base type for a subtype.


### Interface Segregation Principle
"States that no client should be forced to depend on methods it does no use."

Don't put too much into an interface; split into separate interfaces.
YAGNI - You Ain't Going to Need It (YAGNI principle).


### Dependency Inversion Principle
"High-level modules should not depend on low-level modules. Both should depende on abstractions.
Abstractions should not depende on details. Details should depend on abstractions."



-------------------------------------------------------------------------------------------------------------
Fonts:

https://www.udemy.com/design-patterns-csharp-dotnet/
https://www.youtube.com/watch?v=Q2QdkiX6p_Y
https://www.eduardopires.net.br/2015/01/solid-teoria-e-pratica/