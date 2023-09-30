/**
* SWENG 421 Lab 7 
* Composition to Hierarchy 
* 
* Administrator
* - uses a novel object
* - has access to all operations
*   - save, retrieve, view, edit and delete
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
    public class Administrator
    {
        private NovelIF novel;

        public Administrator(NovelIF novel)
        {
            this.novel = novel;
        }

        public NovelIF GetNovel()
        {
            return novel;
        }
    }
}
