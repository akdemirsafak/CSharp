
//DateTime and String Methods

System.Console.WriteLine(DateTime.Now);
System.Console.WriteLine(DateTime.Now.Date);
System.Console.WriteLine(DateTime.Now.Year);
System.Console.WriteLine(DateTime.Now.Month);
System.Console.WriteLine(DateTime.Now.Day);
System.Console.WriteLine(DateTime.Now.Hour);
System.Console.WriteLine(DateTime.Now.Minute);
System.Console.WriteLine(DateTime.Now.DayOfWeek);
System.Console.WriteLine(DateTime.Now.DayOfYear);

System.Console.WriteLine(DateTime.Now.ToLongDateString()); //month and day are string
System.Console.WriteLine(DateTime.Now.ToShortDateString()); //only integer date

System.Console.WriteLine(DateTime.Now.ToLongTimeString()); //saniye de içerir
System.Console.WriteLine(DateTime.Now.ToShortTimeString()); //saat dakika

System.Console.WriteLine(DateTime.Now.AddDays(3));
System.Console.WriteLine(DateTime.Now.AddMonths(2));
System.Console.WriteLine(DateTime.Now.AddHours(5));
System.Console.WriteLine(DateTime.Now.AddYears(10));
//add ticks

//dateTime Formats

System.Console.WriteLine(DateTime.Now.ToString("dd"));
System.Console.WriteLine(DateTime.Now.ToString("ddd"));
System.Console.WriteLine(DateTime.Now.ToString("dddd"));
System.Console.WriteLine(DateTime.Now.ToString("MM"));
System.Console.WriteLine(DateTime.Now.ToString("MMM"));
System.Console.WriteLine(DateTime.Now.ToString("MMMM"));
System.Console.WriteLine(DateTime.Now.ToString("yy"));
System.Console.WriteLine(DateTime.Now.ToString("yyyy"));

//Math Library

System.Console.WriteLine(Math.Abs(-25));
System.Console.WriteLine(Math.Sin(10));
System.Console.WriteLine(Math.Cos(10));
System.Console.WriteLine(Math.Tan(10));

System.Console.WriteLine(Math.Ceiling(22.3));
System.Console.WriteLine(Math.Round(22.3));
System.Console.WriteLine(Math.Round(22.7));
System.Console.WriteLine(Math.Floor(22.3));

System.Console.WriteLine(Math.Max(22,5));
System.Console.WriteLine(Math.Min(3,5));
System.Console.WriteLine(Math.Sqrt(25));//karekök alır
System.Console.WriteLine(Math.Log(9));//9 un e tabanındaki logaritmik karşılığı
System.Console.WriteLine(Math.Exp(3));//e üzeri 3
System.Console.WriteLine(Math.Log10(10));