/**
* SWENG 421 Lab 7 
* Composition to Hierarchy 
* 
* EditorNovelIF
* - interface to enforce that editors can "save", "retrieve", and "delete"
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
    public interface EditorNovelIF
    {
        public void Save();
        public NovelComponentIF Retrieve();
        public void Delete();
    }
}
