/**
* SWENG 421 Lab 7 
* Composition to Hierarchy 
* 
* Image
* - contained inside a frame
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
    public class Image : ContentElement, FrameComponentIF, LineOfTextComponentIF
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
