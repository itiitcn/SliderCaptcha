using System;
using System.Collections.Generic;
using System.Drawing.Imaging;

namespace SliderCaptcha.NET
{
    public class ImgFormat
    {

        private static Dictionary<string, string> Formats = new Dictionary<string, string>() {
                            {"b96b3caa-0728-11d3-9d7b-0000f81ef32e","MemoryBmp"},
                            {"b96b3cab-0728-11d3-9d7b-0000f81ef32e","Bmp"},
                            {"b96b3cac-0728-11d3-9d7b-0000f81ef32e","Emf"},
                            {"b96b3cad-0728-11d3-9d7b-0000f81ef32e","Wmf"},
                            {"b96b3cae-0728-11d3-9d7b-0000f81ef32e","Jpeg"},
                            {"b96b3caf-0728-11d3-9d7b-0000f81ef32e","Png"},
                            {"b96b3cb0-0728-11d3-9d7b-0000f81ef32e","Gif"},
                            {"b96b3cb1-0728-11d3-9d7b-0000f81ef32e","Tiff"},
                            {"b96b3cb2-0728-11d3-9d7b-0000f81ef32e","Exif"},
                            {"b96b3cb5-0728-11d3-9d7b-0000f81ef32e","Icon"}
        };

        public static ImageFormat FormatFromGuid(ImageFormat format)
        {
            return FormatFromGuid(format.Guid);
        }
        public static ImageFormat FormatFromGuid(Guid guid)
        {
            return FormatFromGuid(guid.ToString());
        }
        public static ImageFormat FormatFromGuid(string guid)
        {
            if (Formats.ContainsKey(guid))
            {
                string name = Formats[guid];
                ImageFormat format = null;
                switch (name)
                {
                    case "MemoryBmp":
                        format = ImageFormat.MemoryBmp;
                        break;
                    case "Bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case "Emf":
                        format = ImageFormat.Emf;
                        break;
                    case "Wmf":
                        format = ImageFormat.Wmf;
                        break;
                    case "Gif":
                        format = ImageFormat.Gif;
                        break;
                    case "Jpeg":
                        format = ImageFormat.Jpeg;
                        break;
                    case "Png":
                        format = ImageFormat.Png;
                        break;
                    case "Tiff":
                        format = ImageFormat.Tiff;
                        break;
                    case "Exif":
                        format = ImageFormat.Exif;
                        break;
                    case "Icon":
                        format = ImageFormat.Icon;
                        break;
                }
                return format;
            }
            else
            {
                return null;
            }
            
        }



        public static string NameFromGuid(ImageFormat format)
        {
            return NameFromGuid(format.Guid);
        }
        public static string NameFromGuid(Guid guid)
        {
            return NameFromGuid(guid.ToString());
        }
        public static string NameFromGuid(string guid)
        {
            if (Formats.ContainsKey(guid))
            {
                return Formats[guid];
            }
            else
            {
                return string.Empty;
            }

        }

    }
}
