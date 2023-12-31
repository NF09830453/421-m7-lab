﻿/**
* SWENG 421 Lab 7 
* Composition to Hierarchy 
* 
* Editor
* - uses an editor's novel (EditorNovelIF) for "save", "retrieve", and "delete" operations
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
    public class Editor
    {
        private EditorNovelIF novel;

        public Editor(EditorNovelIF novel)
        {
            this.novel = novel;
        }

        public EditorNovelIF GetNovel()
        {
            return novel;
        }
    }
}
