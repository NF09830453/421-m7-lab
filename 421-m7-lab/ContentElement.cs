/**
* SWENG 421 Lab 7 
* Composition to Hierarchy 
* 
* ContentElement
* - abstract parent class for content objects (LineOfText, Character, Image)
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
    public abstract class ContentElement : PageComponentIF
    {
        public abstract void Save();
        public abstract NovelComponentIF Retrieve();
        public abstract void Delete();
        public abstract void View();
        public abstract void Edit();
        public abstract void Add(Object element);
    }
}
