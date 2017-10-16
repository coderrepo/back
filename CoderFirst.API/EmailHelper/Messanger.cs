using Cenmetrix.Cemex.Message;
using System.Collections.Generic;


public static class Email
{
    public static Messanger Body()
    {
        return new Messanger();
    }
}

namespace Cenmetrix.Cemex.Message
{
    public class Messanger
    {
        private string _title;
        private string _subTitle;
        private List<Button> _buttonSection;
      
        public Messanger Button(Button button)
        {
            _buttonSection.Add(button);
            return this;
        }

        public Messanger Title(string title)
        {
            _title = title;
            return this;
        }
        public Messanger SubTitle(string subTitle)
        {
            _subTitle = subTitle;
            return this;
        }


        public Messanger AddButton(Microsoft.AspNetCore.Mvc.Routing.UrlHelper url , Button button)
        {
            _buttonSection.Add(button);
            return this;
        }

        public string Build()
        {
            return Utiltiy.GenerateTemplate(_title, _buttonSection);
        }
    }
}