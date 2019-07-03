using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests_Framework
{
    public class Logincheck
    {
        public static bool IsAt
        {
            get
            {

                var h2s = Driver.Instance.FindElements(By.ClassName("message-text"));
                if (h2s.Count > 0)
                    return h2s[0].Text == "The username and password you entered did not match our records. Please double-check and try again.";
                return false;
            }

        }
    }
}

