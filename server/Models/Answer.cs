using System;
using System.Collections.Generic;

namespace server.Models
{
	public class Answer
	{
		public Guid Id { get; set; }
		public Guid QuestionId { get; set; }
		public string Body { get; set; }
	}
}