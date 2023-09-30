/**
* SWENG 421 Lab 7 
* Composition to Hierarchy 
* 
* WriterNovelIF
* - interface to enforce that writers can only "view" and "edit"
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
    public interface WriterNovelIF
    {
        public void View();
        public void Edit();
    }
}
