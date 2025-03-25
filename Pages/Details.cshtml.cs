using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ImagesRazor.Pages
{
    [BindProperties]
    public class DetailsModel : PageModel
    {
        public string? SelectedImgPath { get; set; }

        public string? RandomImgPath { get; set; }

        public List<string>? ImgPaths { get; set; } = new List<string>();

        public string ImgDirectory { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\imgs");

        public void OnGet()
        {
            ImgPaths = _loadImages();
            RandomImgPath = _getRandomImage();
        }

        public void OnPost()
        {
            ImgPaths = _loadImages();
            RandomImgPath = _getRandomImage();
        }

        private List<string>? _loadImages()
        {
            if (!Directory.Exists(ImgDirectory)) return null;

            var _imgFiles = Directory.GetFiles(ImgDirectory, "*.*", SearchOption.TopDirectoryOnly).Where(s => s.EndsWith(".jpg") || s.EndsWith(".png") || s.EndsWith(".gif"));
            return _imgFiles.Select(Path.GetFileName).ToList();
        }

        private string? _getRandomImage()
        {
            if (ImgPaths == null || ImgPaths.Count == 0) return null;

            Random _random = new Random();
            int _index = _random.Next(ImgPaths.Count);
            return ImgPaths[_index];
        }
    }
}
