using System;

namespace DraftLab.ISOrigin
{
    // Fix violation of interface segregation
    public class GuitarPlayer : IMusician
    {
        public void PlayGuitar()
        {
            Console.WriteLine("Play guitar.");
        }

        public void PlayPiano()
        {
            throw new NotImplementedException("Guitar payer, doesn't know how to play piano.");
        }
    }

    public class PianoPlayer : IMusician
    {
        public void PlayGuitar()
        {
            throw new NotImplementedException("Guitar payer, doesn't know how to play piano.");
        }

        public void PlayPiano()
        {
            Console.WriteLine("Play piano.");
        }
    }


    public interface IMusician
    {
        void PlayGuitar();
        void PlayPiano();
    }
}
