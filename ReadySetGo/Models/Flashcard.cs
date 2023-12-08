using System;
namespace ReadySetGo.Models
{
	public class Flashcard
	{
        public int FlashcardId { get; set; }
		public string Name { get; set; } = string.Empty;
        public string Front { get; set; } = string.Empty;
        public string Back { get; set; } = string.Empty;
		// public decimal Price { get; set; }
		// public string? Description { get; set; }
		// public string? ImageUrl { get; set; }

        // public int FlashcardId;
        // public string Front;
        // public string Back;

        // public Flashcard(int FlashcardId, string Front, string Back)
        // {
        //     this.FlashcardId = FlashcardId;
        //     this.Front = Front;
        //     this.Back = Back;
        // }
    }
}

