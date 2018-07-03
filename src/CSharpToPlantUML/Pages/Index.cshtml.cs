using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using CSharpToPlantUML.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CSharpToPlantUML.Pages
{
    public class IndexModel : PageModel
    {
        [Required]
        [BindProperty]
        public string CSharpSource { get; set; }

        [Required]
        [BindProperty]
        public DiagramOutputFormat OutputFormat { get; set; }

        [BindProperty]
        public byte[] Data { get; set; }
        
        public async Task<IActionResult> OnPostAsync()
        {
            Data = Encoding.Default.GetBytes($"FORMAT={OutputFormat}");
            return Page();
        }
    }
}