using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests_Framework
{
    public class Assert_function
    {//Buscar text de los elementos
      
        public static bool Search_Comment(String word)
        {
            IList<IWebElement> links = Driver.Instance.FindElements(By.CssSelector("div.content > div.js-tweet-text-container"));
            IList<IWebElement> listOflinks = new List<IWebElement>();

            for (int i = 0; i < links.Count; i++)
            {
                if (links[i].Text.Contains(word))
                {
                    return true;
                 }
            }
            return false;
        }

        public static bool Buscar_text(string user)
        {
            return Driver.Instance.FindElements(By.CssSelector("a.ProfileHeaderCard-nameLink.u-textInheritColor.js-nav"))[0].Text.Contains(user);
        }

        public static bool Look_for_logout(string user)
        {
            return Driver.Instance.Url.Contains(user);
        }

    }


    
}
