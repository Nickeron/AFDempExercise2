# Coding Bootcamp 4
# Exercise 2 – C# Stream
1.	Define an abstract class Shape with a protected member that describes the color of the shape (can be an enum). Create a public property that returns the color to the user. Also create two methods, a public method to set the color and an abstract method string GetInfo() to return the objects' info to the user.
> `Shape of color Red.`
> Example output 1- Result of Shape GetInfo() method
2.	Define a derived class Rectangle with two protected members for the width and the height of the rectangle. The Rectangle object must be immutable. Define a constructor to initialize the Rectangle object. Create two public properties that return the width and the height to the user. Create a virtual method void GetArea() that calculates the total area of the Rectangle. Also implement the abstract method string GetInfo().
> `Rectangle of color Red, width 15 and height 24.`
> Example output 2 - Result of Rectangle GetInfo() method
3.	Create a derived class Square. This class extends the Rectangle class and cannot be inherited. Implement the string `GetInfo()` method to return the rectangles’ info to the user.
> `Square of color Red and side length 20.`
> Example output 3 - Result of Square GetInfo() method.
4.	Rectangle and Square classes must have a private field of type string that stores the objects' name (eg. Rectangle, Square).
 
5.	Override the `ToString()` method for Shape, Rectangle and Square. The result of the `ToString()` method can be the same with the result of the GetInfo() method.
> `Shape of color Red.`
> `Rectangle of color Red, width 15 and height 24.`
> `Square of color Red and side length 20.`
> Example output 4 - Result of `ToString()` method when called from Shape, Rectangle and Square
6.	Each class (Rectangle and Square) should implement the `IComparable` and `IEquitable<T>` interfaces.
7.	Initialize sample objects to test the implemented functionality.  Store the objects to a `List<T>` and verify that `Sort()` method is working properly.
