using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Categories
{
    public sealed class Category
    {
        // Properties
        private string categoryName;
        private string description;

        // Constructor
        public Category(string categoryName, string description)
        {
            this.categoryName = categoryName;
            this.description = description;
        }

        // Getters and setters
        public string GetCategoryName() { return categoryName; }
        public void SetCategoryName(string categoryName) { this.categoryName = categoryName; }

        public string GetDescription() { return description; }
        public void SetDescription(string description) { this.description = description; }
    }
}
