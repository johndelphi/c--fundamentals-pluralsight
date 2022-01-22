// See https://aka.ms/new-console-template for more information
//create an arrat of numbers
using System.Collections.Generic;
//sum variable
var sum= 0.0;
double Average=0.0;
var numbers = new[]
{1,2,3,4};
var grades = new List<double>(){
    12.2,10.5
};
grades.Add(56.2);
//get the sum of numbers in the  list
foreach (var score in grades)
{  
    //get sum 
    sum +=score;

    //lets get the average
  
}
//average
Average =sum/grades.Count;

Console.WriteLine( $"Average is :  {Average:N4} \n sum is {sum}  "  );

