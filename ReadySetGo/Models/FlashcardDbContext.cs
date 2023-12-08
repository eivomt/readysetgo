using System;
using Microsoft.EntityFrameworkCore;

namespace ReadySetGo.Models;

	public class FlashcardDbContext : DbContext
	{
		public FlashcardDbContext(DbContextOptions<FlashcardDbContext> options) : base(options)
		{
			Database.EnsureCreated();
		}

		public DbSet<Flashcard> Flashcards { get; set; }
	}

