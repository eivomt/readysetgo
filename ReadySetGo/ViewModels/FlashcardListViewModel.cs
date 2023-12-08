using System;
using System.Collections.Generic;
using ReadySetGo.Models;

namespace ReadySetGo.ViewModels
{
	public class FlashcardListViewModel
	{
		public IEnumerable<Flashcard> Flashcards;
        public string? CurrentViewName;

		public FlashcardListViewModel(IEnumerable<Flashcard> flashcards, string? currentViewName)
		{
			Flashcards = flashcards;
			CurrentViewName = currentViewName;
        }
	}
}

