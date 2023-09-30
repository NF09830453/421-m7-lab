/**
* SWENG 421 Lab 7 
* Composition to Hierarchy 
* 
* Frame
* - contains image(s) and/or column(s)
* - inherits from abstract CompositePageElement class who implements interface PageElementIF
* - implements marker interface ColumnComponentIF
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
    public class Frame: CompositePageElement, ColumnComponentIF
    {
        private List<FrameComponentIF> frameComps = new List<FrameComponentIF>();

        public override void Save()
        {
            Console.WriteLine("frame save");
        }

        public override NovelComponentIF Retrieve()
        {
            Console.WriteLine("frame retrieve");
            return null;
        }

        public override void Delete()
        {
            Console.WriteLine("frame delete");
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
            Console.WriteLine("frame edit");
        }

        public override void Add(Object element)
        {
            frameComps.Add((FrameComponentIF)element);
        }
    }
}
