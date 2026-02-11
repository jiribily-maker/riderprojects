Console.Clear();
/*
Book book1 = new Book("khm",1987,178,"formula");
Book book2 = new Book("Jira",987,78,"mlcuch");

book1.PrintInfo();
book2.PrintInfo();


List<string> booklist = new List<string>();

booklist.Add("RUR");
booklist.Add("1984");

booklist.RemoveAt(1);


Console.Write(booklist.Count);

foreach (string book  in booklist)
{
    Console.WriteLine(book);
}

for(int i = 0; i < booklist.Count; i++)
{
    Console.WriteLine(booklist[i]);
}
*/

List<Student> bookList = new List<Student>();

while (true)
{
    Console.WriteLine("napis jmeno studenta:[pro ukonceni q] ");
    string jmeno = Console.ReadLine();
    if (jmeno == "q") break;
    Console.WriteLine("napis vek studenta:");
    string vek = Console.ReadLine();
    int let = int.Parse(vek);
    
    bookList.Add(new Student(jmeno, let));
    
}

foreach (var student in bookList)
{
    student.Greet();
}

