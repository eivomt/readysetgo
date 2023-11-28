using System;
namespace ReadySetGo.Models
{
	public class Flashcard
	{
        public int FlashcardId;
        public string Front;
        public string Back;

        public Flashcard(int FlashcardId, string Front, string Back)
        {
            this.FlashcardId = FlashcardId;
            this.Front = Front;
            this.Back = Back;
        }
    }
}

