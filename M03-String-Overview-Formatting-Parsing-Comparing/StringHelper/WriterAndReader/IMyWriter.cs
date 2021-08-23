using System.Collections.Generic;

namespace StringHelper
{
    public interface IMyWriter
    {
        public void Write(IEnumerable<string> text);
    }
}