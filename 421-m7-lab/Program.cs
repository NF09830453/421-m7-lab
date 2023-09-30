// See https://aka.ms/new-console-template for more information
using _421_m7_lab;


Novel book1 = new Novel("The Stranger");
Novel book2 = new Novel("To Kill a Mockingbird");

NovelComponentIF page = new Page();
CompositePageElement col = new Column();
CompositePageElement fr = new Frame();

book1.Add(page);
book1.Add(col);
book1.Add(fr);
ContentElement line = new LineOfText();
col.Add(line);

line.Add(new Character('S'));
line.Add(new Character('W'));
line.Add(new Character('E'));
line.Add(new Character('N'));
line.Add(new Character('G'));

Writer w = new Writer(book1);
w.GetNovel().View();

Console.ReadLine(); // keep console window open