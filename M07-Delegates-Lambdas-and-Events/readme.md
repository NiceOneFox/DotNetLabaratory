## M07-Delegates-Lambdas-and-Events
# Contains class library MatrixHelper with BubbleSort method 
BubbleSort takes matrix represented as list of lists<int>, size of matrix and two delegates functions
One of them responsible for asc/desc order of sorting, another one for type of sorting.

ConsoleApp demonstrates work of BubbleSort passing as argument delegates for sorting types:
1. Order by sums of matrix row elements
2. Order by maximum element in a matrix row
3. Order by minimum element in a matrix row

# Publisher and Subcriber classes to demonstrate events in C#
Publisher have countDown timer which start work when Work() method calls.
Subscribes can subcribe on this timer and be notified when half timer passed and all time.