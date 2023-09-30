using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421_m7_lab
{
    public class Image : ContentElement, FrameComponentIF, ColumnComponentIF
    {
        public override void Save()
        {
            Console.WriteLine("image save");
        }

        public override NovelComponentIF Retrieve()
        {
            Console.WriteLine("image retrieve");
            return null;
        }

        public override void Delete()
        {
            Console.WriteLine("image delete");
        }

        public override void View()
        {
            Console.WriteLine("image view");
        }

        public override void Edit()
        {
            Console.WriteLine("image edit");
        }
        public override void Add(Object element)
        {
            return;
        }
    }
}
