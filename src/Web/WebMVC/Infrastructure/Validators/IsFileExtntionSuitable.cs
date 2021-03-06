using Microsoft.AspNetCore.Http;
using System.IO;
using System.Linq;
using WebMVC.Services;

namespace WebMVC.Infrastructure.Validators
{
    public class IsFileExtntionSuitable : ISpecification<IFormFile>
    {
        public bool IsSatisfiedBy(IFormFile file)
        {
            var ext = Path.GetExtension(file.FileName).ToLowerInvariant();
            string[] PermittedExtensions = { ".jpg", ".jpeg", ".png" };
            return !string.IsNullOrEmpty(ext) && PermittedExtensions.Contains(ext);
        }
    }
}
