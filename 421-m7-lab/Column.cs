using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421_m7_lab
{
    public class Column: CompositePageElement, FrameComponentIF
    {
        private List<ColumnComponentIF> frameComps = new List<ColumnComponentIF>();

        public override void Save()
        {
            Console.WriteLine("column save");
        }

        public override NovelComponentIF Retrieve()
        {
            Console.WriteLine("column retrieve");
            return null;
        }

        public override void Delete()
        {
            Console.WriteLine("column delete");
        }

        public override void View()
        {
            foreach (NovelComponentIF comp in frameComps)
            {
                if (comp is Character)
                {
                    Character el = (Character)comp;
                    Console.Write(el.GetContent());
                }
                comp.View();
            }
        }

        public override void Edit()
        {
            Console.WriteLine("column edit");
        }

        public override void Add(Object element)
        {
            frameComps.Add((ColumnComponentIF)element);
        }
    }
}
