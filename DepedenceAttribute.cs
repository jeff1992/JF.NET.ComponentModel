using System;

namespace JF.NET.ComponentModel
{
    public class DepedenceAttribute
    {
        public DepedenceAttribute(params string[] properties)
        {
            this.Properties = properties;
        }
        public string[] Properties { get; private set; }
    }
}
