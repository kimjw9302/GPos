using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Pos
{
    static class  barcode_search
    {
        public static string image(string barcode)
        {
            var html = @"http://www.cvslove.com/product/product_view.asp?pcode=" + barcode;

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//center/img");

            string barcode_search_image_url = node.OuterHtml;

            Regex rxImages = new Regex("<img.+?src=[\"'](.+?)[\"'].+?>",
            RegexOptions.IgnoreCase & RegexOptions.IgnorePatternWhitespace);
            MatchCollection mc = rxImages.Matches(barcode_search_image_url);
            foreach (Match m in mc)
            {
                Console.WriteLine("이미지 주소: " + m.Groups[1].Value);
            }
            return mc[0].Groups[1].Value;
        }

        public static void info(string barcode)
        {
            var html = @"http://www.cvslove.com/product/product_view.asp?pcode=" + barcode;

            HtmlWeb web = new HtmlWeb();

            web.OverrideEncoding = Encoding.Default;

            var htmlDoc = web.Load(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//center//form");

            string[] result = Regex.Split(node.InnerText, "\r\n");
            for (int i = 0; i < result.Length; i++)
            {
                switch (i)
                {
                    case 11:
                        Console.WriteLine("상품명: " + result[i].Trim());
                        break;
                    case 27:
                        string product_price = Regex.Replace(result[i].Trim(), @"\D", "");
                        Console.WriteLine("상품 가격: " + product_price);
                        break;
                }
            }
        }
    }
}
