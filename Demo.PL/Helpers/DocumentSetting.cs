using Microsoft.AspNetCore.Http;
using System;
using System.IO;


namespace Demo.PL.Helpers
{
    public static class DocumentSetting
    {
        //this Method takes from me 2 parameters the first 1 is the file it self
        //and the second 1 is the folder that i want to save thsi file in it 
        public static string UploadFile(IFormFile file,string FolderName)
        {
            //1. Get located folder path
            //string folderPath = "E:\\TAAZZ\\ASP.NET\\Eng Ahmed Nasr\\07 ASP.NET MVC\\Session 02\\ThreeTierLayerSolution\\Demo.PL\\wwwroot\\files\\images\\";
            //Not recomended cuz it is static
            //string folderPath = Directory.GetCurrentDirectory() + "\\wwwroot\\files\\" + FolderName;
            // This one is dynamic but it has a problem that is string concatination is not Da best Solution.
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files" , FolderName);

            //2. Get File name and make it UNIQUE && Guid is the method that i use to make it unique.
            string fileName = $"{Guid.NewGuid()}{file.FileName}";

            //3.Get File Path
            string filePath = Path.Combine(folderPath, fileName);

            //4.Save file as streams (Stream : is Data per Time)
            using var fs = new FileStream(filePath , FileMode.Create);

            file.CopyTo(fs);
            return fileName;
        }

        public static void DeleteFile(string fileName,string folderName)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", folderName, fileName);
            if (File.Exists(filePath))
                File.Delete(filePath);
             
        }
    }
}
