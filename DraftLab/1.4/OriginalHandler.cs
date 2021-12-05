using System;

namespace DraftLab.OriginalHandler
{
    public class Handler 
    {
        public void Handle()
        {
            DoHandle();
        }

        private void DoHandle()
        {
            Console.WriteLine("Handle");
        }
    }
}
