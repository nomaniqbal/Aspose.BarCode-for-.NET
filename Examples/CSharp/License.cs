//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

namespace Aspose.BarCode.Examples.CSharp
{
    internal class License
    {
        //path to the license file
        //private static string licensePath = @"{path}Aspose.Total.NET.lic";
        private static string licensePath = @"I:\Aspose\License.txt";

        //set license for appropriate products
        internal static void SetLicense()
        {
            (new Aspose.BarCode.License()).SetLicense(licensePath);
            (new Aspose.Pdf.License()).SetLicense(licensePath);
            (new Aspose.Words.License()).SetLicense(licensePath);
            (new Aspose.Cells.License()).SetLicense(licensePath);
            (new Aspose.Imaging.License()).SetLicense(licensePath);
        }
    }
}