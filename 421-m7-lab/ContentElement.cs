using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421_m7_lab
{
    public abstract class ContentElement
    {
        private string title;

        public string GetTitle()
        {
            return title;
        }
        public abstract void Save();
        public abstract NovelComponentIF Retrieve();
        public abstract void Delete();
        public abstract void View();
        public abstract void Edit();
    }
}
