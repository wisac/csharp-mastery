﻿
using EnumBasics;

Season currentSeason = Season.Harmattan;
string seasonName = Season.Rainy.ToString(); // convert to string 

// converting literal values to enum
Season anotherSeason = (Season)8;
Console.WriteLine("Another season: {0}",anotherSeason);

Console.WriteLine(currentSeason); // implicit ToString called

// Parsing literal strings to enum types
string seasonStr = "rainy";
Season nextSeason = (Season)Enum.Parse(typeof(Season), seasonStr,true);

Console.WriteLine("next season = {0}",nextSeason);






























































































































































































































































































































































































































































































































