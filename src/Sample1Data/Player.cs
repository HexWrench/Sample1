using System;

namespace Sample1Data
{
    public class Player
    {
        public Player()
        {
            Id = new Guid();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}