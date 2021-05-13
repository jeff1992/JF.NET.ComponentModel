using System;

namespace JF.NET.ComponentModel
{
    public class DependenceAttribute : Attribute
    {
        public DependenceAttribute(params string[] properties)
        {
            this.Properties = properties;
        }
        public string[] Properties { get; private set; }
    }
}
