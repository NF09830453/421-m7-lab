using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _421_m7_lab
{
    public class Novel: NovelIF
    {
        private List<NovelComponentIF> novelComps = new List<NovelComponentIF>();

        private string title;

        public Novel(string novelTitle)
        {
            title = novelTitle;
        }

        public void Save()
        {
            Console.WriteLine("Saved " + title);
        }

        public NovelComponentIF Retrieve()
        {
            Console.WriteLine("Retrieved " + title);
            return null;
        }

        public void Delete()
        {
            Console.WriteLine("Deleted " + title);
        }

        public void View()
        {
            foreach (NovelComponentIF component in novelComps)
            {
                if (component is Character)
                {
                    Character c = (Character)component;
                    Console.Write(c.GetContent());
                }
                component.View();
            }
        }

        public void Edit()
        {
            Console.WriteLine("Editing " + title + "...");
        }
        public string GetTitle()
        {
            return this.title;
        }

        public void Add(object element)
        {
            novelComps.Add((NovelComponentIF)element);
        }
    }
}
