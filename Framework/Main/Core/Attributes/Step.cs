using System;

namespace Framework.Main.Core.Attributes
{
    [System.AttributeUsage(AttributeTargets.Method)]
    public class Step : Attribute
    {
        public readonly string dest;

        public Step(string dest) => this.dest = dest;
    }
}
