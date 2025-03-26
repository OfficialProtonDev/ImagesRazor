using ImagesRazor.Model;
using ImagesRazor.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ImagesRazor.Pages
{
    public class DetailsModel : PageModel
    {
        public string? SelectedImgPath { get; set; }

        public List<string>? ImgPaths { get; set; } = new List<string>();

        public string ImgDirectory { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\imgs");

        public PersonDetails? SelectedStaff { get; set; }

        public SelectList Staff { get; set; }

        [BindProperty]
        public int SelectedStaffId { get; set; } = 1;

        public void OnGet()
        {
            LoadData();
        }

        public void OnPost()
        {
            LoadData();
        }

        public void LoadData()
        {
            Staff = new SelectList(StaticPersonDetails.StaticAllStaff, nameof(PersonDetails.Id), nameof(PersonDetails.Name), null);
            SelectedStaff = _getPersonDetails();
            ImgPaths = _loadImages();
        }

        private List<string>? _loadImages()
        {
            if (!Directory.Exists(ImgDirectory)) return null;

            var _imgFiles = Directory.GetFiles(ImgDirectory, "*.*", SearchOption.TopDirectoryOnly).Where(s => s.EndsWith(".jpg") || s.EndsWith(".png") || s.EndsWith(".gif"));
            return _imgFiles.Select(Path.GetFileName).ToList();
        }

        private PersonDetails? _getPersonDetails()
        {
            if (!ModelState.IsValid) return null;

            PersonDetails? _selectedStaff = new PersonDetails();

            foreach (var item in StaticPersonDetails.StaticAllStaff)
            {
                if (SelectedStaffId == item.Id)
                {
                    _selectedStaff.Id = item.Id;
                    _selectedStaff.Name = item.Name;
                    _selectedStaff.Age = item.Age;
                    _selectedStaff.FaceImgPath = item.FaceImgPath;
                    _selectedStaff.Occupation = item.Occupation;
                }
            }

            return _selectedStaff;

        }
    }
}
