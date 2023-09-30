/**
* SWENG 421 Lab 7 
* Composition to Hierarchy 
* 
* Page
* - contains objects that implement PageComponentIF (abstract classes CompositePageElement and ContentElement)
* - implements marker interface NovelComponentIF
* 
* Sunghee Choi, Yifan Liu
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421_m7_lab
{
    public class Page : NovelComponentIF
    {
        private List<PageComponentIF> pageComps = new List<PageComponentIF>();

        private string title;

        public string GetTitle()
        {
            return title;
        }

        public void Save()
        {
            Console.WriteLine("page saved");
        }

        public NovelComponentIF Retrieve()
        {
            Console.WriteLine("page retrieved");
            return null;
        }

        public void Delete()
        {
            Console.WriteLine("page deleted");
        }

        public void View()
        {
            foreach (NovelComponentIF comp in pageComps)
            {
                if (comp is Character)
                {
                    Character c = (Character)comp;
                    Console.Write(c.GetContent());
                }
                comp.View();
            }
        }

        public void Edit()
        {
            Console.WriteLine("page edit");
        }

        public void Add(Object element)
        {
            pageComps.Add((PageComponentIF)element);
        }
    }
}
