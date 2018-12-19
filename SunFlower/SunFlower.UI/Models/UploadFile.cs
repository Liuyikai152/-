using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

public class UploadFiles
{

    public static string UpLoadFile(HttpPostedFileBase getFile)
    {
        if (getFile != null)
        {
            string getPath = System.Web.HttpContext.Current.Server.MapPath("~\\imgs\\Food\\");
            if (!Directory.Exists(getPath))
            {
                Directory.CreateDirectory(getPath);
            }
            string newPath = Path.Combine(getPath, getFile.FileName);
            getFile.SaveAs(newPath);
            return "/imgs/Food/" + getFile.FileName;
        }
        else
        {
            return "";
        }
    }

    public static string ReadFile(string FName)
    {
        string FilePath = System.Web.HttpContext.Current.Server.MapPath("\\imgs\\" + FName);
        FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fs);
        string Content = sr.ReadToEnd();

        sr.Close();
        fs.Close();
        return Content;
    }
}
