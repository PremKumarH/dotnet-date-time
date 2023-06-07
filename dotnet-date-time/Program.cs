//just date and time

DateTime today = DateTime.Now;
Console.WriteLine(today);
Console.WriteLine($"printing in DD-MM-YYYY : {today.ToString("dd-MM-yyyy")}");
Console.WriteLine($"printing AM or PM : {today.ToString("tt")}");
