using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421_m7_lab
{
    public class Writer
    {
        private WriterNovelIF novel;

        public Writer(WriterNovelIF novel)
        {
            this.novel = novel;
        }

        public WriterNovelIF GetNovel()
        {
            return novel;
        }
    }
}
