/**
* SWENG 421 Lab 7 
* Composition to Hierarchy 
* 
* Runnable Class
* 
* Sunghee Choi, Yifan Liu
*/


// See https://aka.ms/new-console-template for more information
using _421_m7_lab;

Novel book1 = new Novel("The Stranger");

NovelComponentIF page = new Page();
CompositePageElement col = new Column();


book1.Add(page);

Console.WriteLine("\n ==== Adding a Column ==== \n");
book1.Add(col);
ContentElement line = new LineOfText();
col.Add(line);

line.Add(new Character('S'));
line.Add(new Character('W'));
line.Add(new Character('E'));
line.Add(new Character('N'));
line.Add(new Character('G'));

Writer w = new Writer(book1);
Console.WriteLine("Test case 1: Column contains one LineOfText with five Characters \"SWENG\"");
Console.WriteLine("Calling writer to view novel... ");
w.GetNovel().View();
Console.WriteLine("\n"+w.GetNovel().ToString());

Console.WriteLine("\n ==== Adding a Frame ==== \n");
CompositePageElement frame = new Frame();
book1.Add(frame);
CompositePageElement columnInsideFrame = new Column();
ContentElement lineOfFrame = new LineOfText();
frame.Add(columnInsideFrame);
columnInsideFrame.Add(lineOfFrame);
lineOfFrame.Add(new Character('4'));
lineOfFrame.Add(new Character('2'));
lineOfFrame.Add(new Character('1'));

Console.WriteLine("Test case 2: Frame contains one Column which contains one LineOfText with three Characters \"421\"");
Console.WriteLine("Calling writer to view novel... ");
// For the created Novel object, a writer calls the object’s view method to see the result as “SWENG421”
w.GetNovel().View();


// Admin
Novel book2 = new Novel("To Kill a Mockingbird");
Administrator admin = new Administrator(book2);
NovelComponentIF book2Page = new Page();
CompositePageElement book2Col = new Column();
book2.Add(book2Page);
book2.Add(book2Col);
ContentElement line2 = new LineOfText();
book2Col.Add(line2);

line2.Add(new Character('T'));
line2.Add(new Character('E'));
line2.Add(new Character('S'));
line2.Add(new Character('T'));
Console.WriteLine("\n\n ==== Testing admin operations ==== ");
Console.WriteLine("Calling admin to view novel... ");
admin.GetNovel().View();
Console.WriteLine("");
admin.GetNovel().Retrieve();
admin.GetNovel().Edit();
admin.GetNovel().Save();
admin.GetNovel().Delete();

Console.ReadLine(); // keep console window open