﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421_m7_lab
{
    public interface NovelIF : WriterNovelIF, EditorNovelIF
    {
        string GetTitle();
        void Add(Object element);
    }
}
