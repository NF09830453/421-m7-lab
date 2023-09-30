/**
* SWENG 421 Lab 7 
* Composition to Hierarchy 
* 
* CompositePageElement
* - abstract parent class for objects that hold content objects (Column and Frame)
* - implements marker interface PageComponentIF
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
    public abstract class CompositePageElement : PageComponentIF
    {
        private string title;

        public string GetTitle()
        {
            return title;
        }
        public abstract void Save();
        public abstract NovelComponentIF Retrieve();
        public abstract void Delete();
        public abstract void View();
        public abstract void Edit();
        public abstract void Add(Object element);
    }
}
