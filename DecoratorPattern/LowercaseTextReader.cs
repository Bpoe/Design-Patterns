using System.IO;

namespace DecoratorPattern
{
    public class LowercaseTextReader : TextReader
    {
        private TextReader reader;

        public LowercaseTextReader(TextReader reader)
            : base()
        {
            this.reader = reader;
        }

        public override string ReadLine()
        {
            string read = this.reader.ReadLine();
            return read.ToLower();
        }
    }
}
