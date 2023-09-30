/**
* SWENG 421 Lab 7 
* Composition to Hierarchy 
* 
* Character
* - inherits from abstract ContentElement class who implements interface PageElementIF
* - implements interface LineOfTextComponentIF
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
    public class Character : ContentElement, LineOfTextComponentIF
    {
        private char content;

        public Character(char character)
        {
            content = character;
        }

        public char GetContent()
        {
            return content;
        }

        public void SetContent(char character)
        {
            content = character;
        }

        public override void Save()
        {
            Console.WriteLine("character save");
        }

        public override NovelComponentIF Retrieve()
        {
            Console.WriteLine("character retrieve");
            return null;
        }

        public override void Delete()
        {
            Console.WriteLine("character delete");
        }

        public override void View()
        {
            Console.WriteLine("character view");
        }

        public override void Edit()
        {
            Console.WriteLine("character edit");
        }

        public override void Add(Object element)
        {
            return;
        }
    }
}
