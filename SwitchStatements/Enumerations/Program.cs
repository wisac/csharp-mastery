
using Location;
using Calender;

Positions myPosition = Positions.north;
string? direction = Convert.ToString(myPosition);
Console.WriteLine($"direction = {direction}");

string a = string.Empty;
int[] values = (int[])Enum.GetValues(typeof(Positions));

string[] names = Enum.GetNames(typeof(Positions));

foreach (var item in names)
{
   Console.WriteLine(item);

}

// DayOfWeek d = DayOfWeek.Monday; a 
bool equalDays = (int)Weekdays.mon == (int)DayOfWeek.Monday;

Console.WriteLine(equalDays);


var v1 = Enum.GetValuesAsUnderlyingType(typeof(DayOfWeek));
var v2 = Enum.GetValuesAsUnderlyingType(typeof(Weekdays));

for (int i = 0; i < v1.Length; i++)
{
   Console.WriteLine($"v1[{i}] : {v1.GetValue(i)}");
   Console.WriteLine($"v2[{i}] : {v2.GetValue(i)}");
}

bool equalEnums = v1.GetValue(0) == v2.GetValue(0); // false even thought the underlying values of 0 and 0;

Console.WriteLine("Are they equal? {0}", equalEnums);


namespace Location
{
   enum Positions
   {
      north,
      south = 2,
      east = 3,
      west = 4

   }
}

namespace Calender
{
   public enum Weekdays
   {
      sun, mon, tue, wed, thu, fri, sat,
   }

   enum Months
   {
      Aug = 1, Sept, Oct, Nov, Dec
   }



}




