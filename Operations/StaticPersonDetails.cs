using ImagesRazor.Model;

namespace ImagesRazor.Operations
{
    public static class StaticPersonDetails
    {
        public static List<PersonDetails> StaticAllStaff = new List<PersonDetails>
        {
            new PersonDetails {Id=1, Name ="John Window", Age= 28, Occupation="Builder", FaceImgPath = "photo1.jpg"},
            new PersonDetails {Id=2, Name = "Kelvin Wallbanger", Age = 32, Occupation="Baker", FaceImgPath = "photo2.jpg"},
            new PersonDetails {Id=3, Name = "Jessie Fenster", Age = 12, Occupation="Student", FaceImgPath = "photo3.jpg"},
            new PersonDetails {Id=4, Name = "Nancy Chao", Age = 11, Occupation="Student", FaceImgPath = "photo4.jpg"},
            new PersonDetails {Id=5, Name = "Mike Kartoffel", Age = 52, Occupation="Stuntman", FaceImgPath = "photo5.jpg"},
            new PersonDetails {Id=6, Name = "David Spiegel", Age = 61, Occupation="Accountant", FaceImgPath = "photo6.jpg"}
        };
    }
}
