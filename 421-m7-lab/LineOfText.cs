/**
* SWENG 421 Lab 7 
* Composition to Hierarchy 
* 
* LineOfText
* - contains characters
* - inherits from abstract ContentElement class who implements interface PageElementIF
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
    public class LineOfText : ContentElement, ColumnComponentIF
    {
        private List<LineOfTextComponentIF> lineComps = new List<LineOfTextComponentIF>();

        public override void Save()
        {
            Console.WriteLine("line of text save");
        }

        public override NovelComponentIF Retrieve()
        {
            Console.WriteLine("line of text retrieve");
            return null;
        }

        public override void Delete()
        {
            Console.WriteLine("line of text delete");
        }

        public override void View()
        {
            foreach (NovelComponentIF comp in lineComps)
            {
                if (comp is Character)
                {
                    Character c = (Character)comp;
                    Console.Write(c.GetContent());
                }
            }
        }

        public override void Edit()
        {
            Console.WriteLine("line of text edit");
        }

        public override void Add(Object element)
        {
            lineComps.Add((LineOfTextComponentIF)element);
        }
    }
}
