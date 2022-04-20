// See https://aka.ms/new-console-template for more information
using EmployeeWage;
WageComputation google = new WageComputation("Google", 20, 2, 10);
google.TotalWageForEachCompany();
Console.WriteLine(google.ToString());
WageComputation microsoft = new WageComputation("Microsoft", 10, 4, 20);
microsoft.TotalWageForEachCompany();
Console.WriteLine(microsoft.ToString());
WageComputation deloitte = new WageComputation("Deloitte", 15, 3, 15);
deloitte.TotalWageForEachCompany();
Console.WriteLine(deloitte.ToString());
