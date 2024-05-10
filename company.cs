using System;
namespace Greysoft
{
class Employee{

public string EmpCode;
public string EmpName;
public double Salary;
public string DeptName;
}
class Company{
public static void Main(string[]args)
{
Employee emp1=new Employee();
Employee emp2=new Employee(); 
emp1.EmpCode="E001";
emp1.EmpName="PRIYANKA";
emp1.Salary=2133.0;
emp1.DeptName="finance";
emp2.EmpCode="E002";
emp2.EmpName="sahil";
emp2.Salary=21323.0;
emp2.DeptName="finance";
double avgSalary;
avgSalary=(emp1.Salary+emp2.Salary)/2;


Console.WriteLine("the employee avg salary{0} of the employee {1} is {2}",emp1.EmpCode,emp1.DeptName,avgSalary);

}
}
}