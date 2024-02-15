using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Authors
{
    public class Author
    {
        private string name;
        private string biography;

        public Author(string name, string biography)
        {
            this.name = name;
            this.biography = biography;
        }
        public string GetName() { return name; }
        public void SetName(string name) { this.name = name; }
        public string GetBiography() { return biography; }
        public void SetBiography(string biography) { this.biography = biography; }
    }
}