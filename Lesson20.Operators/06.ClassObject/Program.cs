﻿Object obj1 = new Object();
Object obj2 = new Object();

Console.WriteLine(ReferenceEquals(obj1, obj2));

obj1 = obj2;

Console.WriteLine(ReferenceEquals(obj1, obj2));

// Delay.
Console.ReadKey();