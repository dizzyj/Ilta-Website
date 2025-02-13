using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace IltaWebApp.Models.ViewModel
{
	public class BlogPostViewModel
	{
		[Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Username")]
		public string Text { get; set; }
		
        public string ImgUrl { get; set; }
    }
}
