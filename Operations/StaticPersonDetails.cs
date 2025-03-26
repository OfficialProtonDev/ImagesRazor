using ImagesRazor.Model;

namespace ImagesRazor.Operations
{
    public static class StaticPersonDetails
    {
        public static List<PersonDetails> StaticAllStaff = new List<PersonDetails>
        {
            new PersonDetails {Id=1, Name ="John Window", Age= 28, Occupation="Builder", FaceImgPath = "img_1.jpg"},
            new PersonDetails {Id=2, Name = "Kelvin Wallbanger", Age = 32, Occupation="Baker", FaceImgPath = "img_2.jpg"},
            new PersonDetails {Id=3, Name = "Jessie Fenster", Age = 12, Occupation="Student", FaceImgPath = "img_3.jpg"},
            new PersonDetails {Id=4, Name = "Nancy Chao", Age = 11, Occupation="Student", FaceImgPath = "img_4.jpg"},
            new PersonDetails {Id=5, Name = "Mike Kartoffel", Age = 52, Occupation="Stuntman", FaceImgPath = "img_5.jpg"},
            new PersonDetails {Id=6, Name = "David Spiegel", Age = 61, Occupation="Accountant", FaceImgPath = "img_6.jpg"}
        };
    }
}
