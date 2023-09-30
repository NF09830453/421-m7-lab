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
