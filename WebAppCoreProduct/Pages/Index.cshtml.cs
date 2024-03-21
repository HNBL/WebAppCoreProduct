using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreProduct.Model;

namespace WebAppCoreProduct.Pages
{
    public class IndexModel : PageModel
    {
		public string? MessageRezult { get; private set; }

        public Product Product { get; set; }
		public void OnGet()
		{
			
		}



	


	}
}
