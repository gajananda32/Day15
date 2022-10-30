using HashTableUC1;

MyMapNode<string, string> a = new MyMapNode<string, string>(5);
a.Add("0", "To");
a.Add("1", "be");
a.Add("2", "or");
a.Add("3", "not");
a.Add("4", "to");
a.Add("5", "be");

string a5 = a.Get("5");
Console.WriteLine("5th index value : " + a5);