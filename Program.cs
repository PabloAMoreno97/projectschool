using CoreSchool;
using CoreSchool.Util;

using static System.Console;


SchoolEngine schoolEngine = new SchoolEngine();

schoolEngine.Initialize();

Printer.drawLine(20);

WriteLine(schoolEngine.School);

Printer.drawLine(30);

Printer.writeTitle("My Title");
