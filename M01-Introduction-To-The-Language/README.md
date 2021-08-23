# KulakovskiiE

## M01-Introduction-To-The-Language
Created two class libraries ArrayHelper and RectangleHelper.

ArrayHelper contains:
1. Class for bubble sorting arrays with types which implements IComparable interface
2. Class for two dimensional arrays which helps to find summ of positive elements

RectangleHelper contains
1. Rectangle class to calculate perimeter and square of some rectangle.

testaplication demonstrate work of these classes.

# .NET CLI Scripts:
1. dotnet new classlib
2. dotnet new classlib
3. dotnet new console
4. dotnet new sln 
  1. dotnet sln add ArrayHelper/Arrayhelper.csproj
  2. dotnet sln add RectangleHelper/RectangleHelper.csproj
  3. dotnet sln add testapplication/testapplication.csproj
  4. dotnet add testapplication/tespapplication.csproj reference Arrayhelper/ArrayHelper.csproj
  5. dotnet add testapplication/tespapplication.csproj reference Rectanglehelper/RectangleHelper.csproj
5. dotnet build
6. dotnet run
7. dotnet publish

P.s (for creating folders I was using mkdir <folderName>)