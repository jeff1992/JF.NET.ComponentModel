using System;

namespace JF.NET.ComponentModel
{
    public class DepedenceAttribute
    {
        public DepedenceAttribute(string propertyPath)
        {
            this.PropertyPath = propertyPath;
        }
        public string PropertyPath { get; private set; }
    }
}
