using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421_m7_lab
{
    public class Character : ContentAbs, LineOfTextComponentIF
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
            Console.WriteLine("Character saved");
        }

        public override NovelComponentIF Retrieve()
        {
            Console.WriteLine("Character retrieved");
            return null;
        }

        public override void Delete()
        {
            Console.WriteLine("Character deleted");
        }

        public override void View()
        {
            Console.WriteLine("Viewing Character...");
        }

        public override void Edit()
        {
            Console.WriteLine("Editing Character...");
        }
    }
}
