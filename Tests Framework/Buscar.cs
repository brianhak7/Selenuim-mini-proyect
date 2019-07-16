using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests_Framework
{
    public class Buscar
    {//Buscar text de los elementos
        public static bool Search_Comment(String b)
        {
            IList<IWebElement> links = Driver.Instance.FindElements(By.CssSelector("div.content > div.js-tweet-text-container"));
            IList<IWebElement> listOflinks = new List<IWebElement>();

            for (int i = 0; i < links.Count; i++)
            {
                if (links[i].Text.Contains(b))
                {

                    return true;

                }


            }
            return false;
        }


    }

}
