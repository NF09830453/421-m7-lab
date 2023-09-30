using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421_m7_lab
{
    public class Page: NovelComponentIF
    {
        private List<PageComponentIF> pageComps = new List<PageComponentIF>();

        private string title;

        public string GetTitle()
        {
            return title;
        }

        public void Add(Object element)
        {
            pageComps.Add((PageComponentIF)element);
        }

        public void Save()
        {
            Console.WriteLine("Page Saved");
        }

        public NovelComponentIF Retrieve()
        {
            Console.WriteLine("Page Retrieved");
            return null;
        }

        public void Delete()
        {
            Console.WriteLine("Page Deleted");
        }

        public void View()
        {
            foreach (NovelComponentIF element in pageComps)
            {
                if (element is Character)
                {
                    Character el = (Character)element;
                    Console.Write(el.GetContent());
                }
                element.View();
            }
        }

        public void Edit()
        {
            Console.WriteLine("Page Edit");
        }
    }
}
