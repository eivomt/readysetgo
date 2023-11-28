using System;
namespace ReadySetGo.Models
{
	public class Flashcard
	{
        private int v1;
        private string v2;
        private string v3;

        public Flashcard(int v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public int FlashcardId { get; set; }
		public string Front { get; set; }
		public string Back { get; set; }
    }
}

