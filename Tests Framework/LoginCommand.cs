using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Opera;

namespace Tests_Framework
{
    public class LoginCommand
    {
        public static  Random getrandom = new Random();
        int num = getrandom.Next(0, 5000);
        private string password;
        private readonly string userName;

        public LoginCommand(string userName)
        {
            this.userName = userName;
        }
        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Loginfb()
        {
            var loginInput = Driver.Instance.FindElement(By.Id("email"));
            loginInput.SendKeys(userName);

            var passwordInput = Driver.Instance.FindElement(By.Id("pass"));
            passwordInput.SendKeys(password);

            var loginButton = Driver.Instance.FindElement(By.Id("loginbutton"));
            loginButton.Click();
            //var twdelete = Driver.Instance.FindElement(By.ClassName("_1vp5"));
            //twdelete.Click();
            //_2s25
            var Tweet = Driver.Instance.FindElement(By.ClassName("_3ixn"));
            Tweet.Click();

            //  var Tweet1 = Driver.Instance.FindElement(By.ClassName("_2s25"));
            // Tweet1.Click();
            //_2s25 
            //  Tweet.Click();
            //_1mf } 
        }



        public static void Login(string password, string userName)
        {

            var loginInput = Driver.Instance.FindElement(By.ClassName("js-username-field"));
            loginInput.SendKeys(userName);

            var passwordInput = Driver.Instance.FindElement(By.ClassName("js-password-field"));
            passwordInput.SendKeys(password);

            var loginButton = Driver.Instance.FindElement(By.TagName("button"));
            loginButton.Click();

            //  var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(2));

            /*
            var Tweet = Driver.Instance.FindElement(By.Id("tweet-box-home-timeline"));
            Tweet.SendKeys("post " + num);

            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(2));

            var twbutton = Driver.Instance.FindElement(By.ClassName("tweet-action"));
            twbutton.Click();
            var twdelete = Driver.Instance.FindElement(By.ClassName("ProfileTweet-actionButton"));
            twdelete.Click();
            //  var twdelete1 = Driver.Instance.FindElement(By.TagName("Delete Tweet"));
            //twdelete1.Click();

            var twdelete2 = Driver.Instance.FindElement(By.ClassName("ProfileCardStats-statValue"));
            twdelete2.Click();
            TimeSpan.FromSeconds(5);
            var twcomment = Driver.Instance.FindElement(By.CssSelector(".div.br"));
            twcomment.Click();

            TimeSpan.FromSeconds(2);
         //   var twcomment1 = Driver.Instance.FindElement(By.XPath("//li/div/div[2]/div"));
            //twcomment1.SendKeys("comment " + num); */

            /*
                      //  var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(2));


                        var Tweet = Driver.Instance.FindElement(By.Id("tweet-box-home-timeline"));
                        Tweet.SendKeys("Post " + num);

                        var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(2));

                        var twbutton = Driver.Instance.FindElement(By.ClassName("tweet-action"));
                        twbutton.Click();
                        var wait2 = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
                        // wait2.p
                        TimeSpan.FromSeconds(5);
                        var twdelete = Driver.Instance.FindElement(By.ClassName("ProfileCardStats-statValue"));
                        twdelete.Click();
                        TimeSpan.FromSeconds(5);

                        //  var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
                        //  wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("class") == "ProfileHeading-toggleLink");


                        //twdelete1.Click();

                        var wait1 = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
                        // var twdelete1 = Driver.Instance.FindElement(By.XPath("//div[2]/div[4]/button[2]"));
                        // twdelete1.Click();
                        //xpath=//div[2]/div[4]/button[2]
                        //   var twdelete2 = Driver.Instance.FindElement(By.TagName("Delete"));
                        //  twdelete1.Click();

                        //ProfileHeading-toggleLink
                        // loginInput.SendKeys(userName); */
        }


        public static void Posttw(int num)
        {
            

        var Tweet = Driver.Instance.FindElement(By.Id("tweet-box-home-timeline"));
            Tweet.SendKeys("post " + num);

           

            var twbutton = Driver.Instance.FindElement(By.ClassName("tweet-action"));
            twbutton.Click();

            //  var twdelete1 = Driver.Instance.FindElement(By.TagName("Delete Tweet"));
            //twdelete1.Click();

            Driver.Wait(TimeSpan.FromSeconds(2));

           
        }

        public static void Search() {
            //search-input

            var Searchb = Driver.Instance.FindElement(By.ClassName("search-input"));
            Searchb.SendKeys("Donald trump");
            var Searchpush = Driver.Instance.FindElement(By.CssSelector("button.Icon"));
            Searchpush.Click();

            
        }
        public static void Go_to_Profile()
        {
            //AdaptiveRelatedSearches-item
            Driver.Wait(TimeSpan.FromSeconds(5));
            var Seapush = Driver.Instance.FindElements(By.CssSelector("a.ProfileCard-bg.js-nav"))[0];
            Seapush.Click();

            var tendencia = Driver.Instance.FindElements(By.CssSelector("span.u-linkComplex-target.trend-name"))[0];
            tendencia.Click();
            //span.u-linkComplex-target.trend-name
            //visuallyhidden





        }

        public static void Postcomment(int num) {
            
            //span.Icon.Icon--medium.Icon--reply
            var comment = Driver.Instance.FindElement(By.CssSelector("span.Icon.Icon--medium.Icon--reply"));
            comment.Click();

            var comment2 = Driver.Instance.FindElement(By.Id("tweet-box-global"));
            //comment2.Click();
            comment2.SendKeys("comment " + num);

            //button-text replying-text
            var clickbutton = Driver.Instance.FindElements(By.CssSelector("button.tweet-action.EdgeButton.EdgeButton--primary.js-tweet-btn"))[1];
            clickbutton.Click();

            



        }


        public static void Deletecommnet() {

            Driver.Wait(TimeSpan.FromSeconds(8));
            var twdelete = Driver.Instance.FindElement(By.CssSelector("button.new-tweets-bar.js-new-tweets-bar"));
            twdelete.Click();
            Driver.Wait(TimeSpan.FromSeconds(1));


            var comment1 = Driver.Instance.FindElements(By.CssSelector("button.ProfileTweet-actionButton.u-textUserColorHover.dropdown-toggle.js-dropdown-toggle"))[0];
            comment1.Click();

            var comment3 = Driver.Instance.FindElements(By.CssSelector("li.js-actionDelete"))[0];
            comment3.Click();

            Driver.Wait(TimeSpan.FromSeconds(3));

            var comment4 = Driver.Instance.FindElements(By.CssSelector("button.EdgeButton.EdgeButton--danger.delete-action"))[0];
            comment4.Click();
            //original-tweet-item last-navigable-stream-item
            //Icon Icon--caretDownLight Icon--smal
            //  var commentbutton = Driver.Instance.FindElements(By.ClassName("Icon.Icon--caretDownLight.Icon--small"))[0];
            // commentbutton.Click();

        }

        public static void logout() {

            //user-dropdown-toggle
            var push = Driver.Instance.FindElement(By.Id("user-dropdown-toggle"));
            push.Click();
            var Searchpush = Driver.Instance.FindElement(By.CssSelector("button.dropdown-link.js-logout-button"));
            Searchpush.Click();

        }

        //trend-item
        public static void tendencia()
        {
            TimeSpan.FromSeconds(5);
            var push = Driver.Instance.FindElement(By.ClassName("u-linkComplex-target.trend-name"));
            push.Click();
            
        }
        }
}
