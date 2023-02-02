﻿//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using Aspose.BarCode.Generation;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.BarcodeGeneration
{
    internal class DotCodeEncodeModeBytes : TwoDBase
    {
        public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("DotCodeEncodeModeBytes:");

            byte[] encodedArr = { 0xFF, 0xFE, 0xFD, 0xFC, 0xFB, 0xFA, 0xF9 };

            //encode array to string
            StringBuilder strBld = new StringBuilder();
            foreach (byte bval in encodedArr)
                strBld.Append((char)bval);
            var codetext = strBld.ToString();

            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DotCode, codetext))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 10;
                //set DotCode encode mode to Bytes
                gen.Parameters.Barcode.DotCode.DotCodeEncodeMode = DotCodeEncodeMode.Bytes;
                gen.Save($"{path}DotCodeEncodeModeBytes.png", BarCodeImageFormat.Png);

            }
        }
    }
}