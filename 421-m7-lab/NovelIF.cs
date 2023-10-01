/**
* SWENG 421 Lab 7 
* Composition to Hierarchy 
* 
* NovelIF
* - interface that implements WriterNovelIF and EditorNovelIF
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
    public interface NovelIF : WriterNovelIF, EditorNovelIF
    {
        void Add(Object element);
    }
}
