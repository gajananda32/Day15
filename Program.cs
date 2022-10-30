using HashTableUC3;

MyMapNode<string, string> a = new MyMapNode<string, string>(20);
a.Add("0", "“Paranoids");
a.Add("1", "are");
a.Add("2", "not");
a.Add("3", "paranoid");
a.Add("4", "because");
a.Add("5", "they");
a.Add("6", "are");
a.Add("7", "paranoid");
a.Add("8", "but");
a.Add("9", "because");
a.Add("10", "they");
a.Add("11", "keep");
a.Add("12", "putting");
a.Add("13", "themselves");
a.Add("14", "deliberately");
a.Add("15", "into");
a.Add("16", "paranoid");
a.Add("17", "avoidable");
a.Add("18", "situations");


//Console.WriteLine("9th index value : " + a9);
a.Remove("9");
string a9 = a.Get("9");
Console.WriteLine("9th index value : " + a9);