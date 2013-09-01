using System.ComponentModel.DataAnnotations;

namespace VirtualAssistant.Web.Models
{
	public class UserTaskModel
	{
		[Key]
		public int TaskId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
	}
}
