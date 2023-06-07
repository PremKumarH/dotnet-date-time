//just date and time
DateTime today = DateTime.Now;
Console.WriteLine(today);
Console.WriteLine($"printing in DD-MM-YYYY : {today.ToString("dd-MM-yyyy")}");
Console.WriteLine($"printing HH-mm-ss : {today.ToString("HH-mm-ss")}");
Console.WriteLine($"is it AM or PM : {today.ToString("tt")}");
Console.WriteLine($"is it local time or utc ? :{today.Kind}");
Console.WriteLine($"currently on *{TimeZoneInfo.Local.StandardName}* time zone");
Console.WriteLine("*****************************************************************");
Console.WriteLine(Environment.NewLine);

Console.WriteLine("Converting to Local time to Coordinated Universal Time");
DateTime utcDateTime =  TimeZoneInfo.ConvertTimeToUtc(today);
Console.WriteLine($"printing in DD-MM-YYYY : {utcDateTime.ToString("dd-MM-yyyy")}");
Console.WriteLine($"printing HH-mm-ss : {utcDateTime.ToString("HH-mm-ss")}");
Console.WriteLine($"is it AM or PM : {utcDateTime.ToString("tt")}");
Console.WriteLine($"is it local time or utc ? :{utcDateTime.Kind}");
Console.WriteLine($"currently on *{TimeZoneInfo.Local.StandardName}* time zone");
Console.WriteLine("*****************************************************************");
Console.WriteLine(Environment.NewLine);

foreach (var timeZoneInfo in TimeZoneInfo.GetSystemTimeZones())
{
    Console.WriteLine($"Timezone Id : {timeZoneInfo.Id}");
    Console.WriteLine($"Standard Name : {timeZoneInfo.StandardName}");
    Console.WriteLine($"Display Name : {timeZoneInfo.DisplayName}");
    Console.WriteLine($"Offset from utc: {timeZoneInfo.BaseUtcOffset}");
    Console.WriteLine("_______________________________________________");
}