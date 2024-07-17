using Practice;

ageDelegate myDelegate = Person.CalcAge;

Console.WriteLine(myDelegate.Invoke(new DateTime(1994,10,10)));
