using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cenmetrix.Cemex.Message
{
    public static class Utiltiy
    {
        public static string GenerateTemplate(string title, List<Button> buttons)
        {
            var body = BaseTemplate.Get();
            return body.Replace("#title#", title).Replace("#button#", BuiltButton(buttons));
        }

       static string BuiltButton(List<Button> button)
       {
           if (button.Any())
           {
                StringBuilder buttons = new StringBuilder();

                buttons.AppendFormat("<tr>");
                buttons.AppendFormat("    <td>");
                buttons.AppendFormat("        <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"600\" align=\"center\" style=\"margin:0 auto;background: #ffffff;\">");
                buttons.AppendFormat("            <tbody>");
                buttons.AppendFormat("                <tr>");
                foreach (var item in button)
                {
                    if (item.Type == ButtonType.Accept)
                    {
                        buttons.AppendFormat("                    <td bgcolor=\"#ffffff\" align=\"center\" class=\"x_mobile-side-padding-10 x_buttonblck\" style=\"padding: 12px;\">");
                        buttons.AppendFormat("                        <a href=\""+ item.Url +"\" target=\"_blank\" style=\"color:#ffffff; text-decoration:none\">");
                        buttons.AppendFormat("                            <table cellspacing=\"0\" cellpadding=\"0\" border=\"0\" width=\"100%\">");
                        buttons.AppendFormat("                                <tbody>");
                        buttons.AppendFormat("                                    <tr>");
                        buttons.AppendFormat("                                        <td class=\"x_mobile-side-padding-15\" bgcolor=\"#4ea75d\" align=\"center\" style=\"font-family:'Segoe UI Semibold',SUWSB,'Segoe UI',Verdana,sans-serif;font-size:14px;line-height:20px;color:#727272;padding-top:12px;padding-left:24px;padding-right:24px;padding-bottom:12px;background-color: #4ea75d;\">");
                        buttons.AppendFormat("                                            <a href=\""+ item.Url +"\" target=\"_blank\" style=\"color:#ffffff; text-decoration:none\"><span style=\"color:#ffffff; text-decoration:none\">" + item.Title+"</span></a>");
                        buttons.AppendFormat("                                        </td>");
                        buttons.AppendFormat("                                    </tr>");
                        buttons.AppendFormat("                                </tbody>");
                        buttons.AppendFormat("                            </table>");
                        buttons.AppendFormat("                        </a>");
                        buttons.AppendFormat("                    </td>");
                    }
                    if (item.Type == ButtonType.Reject)
                    {
                        buttons.AppendFormat("                    <td bgcolor=\"#ffffff\" align=\"center\" class=\"x_mobile-side-padding-10 x_buttonblck\" style=\"padding: 17px;\">");
                        buttons.AppendFormat("                        <a href=\"" + item.Url  + " target=\"_blank\" style=\"color:#ffffff; text-decoration:none\">");
                        buttons.AppendFormat("                            <table cellspacing=\"0\" cellpadding=\"0\" border=\"0\" width=\"100%\">");
                        buttons.AppendFormat("                                <tbody>");
                        buttons.AppendFormat("                                    <tr>");
                        buttons.AppendFormat("                                        <td class=\"x_mobile-side-padding-15\" bgcolor=\"#d0554b\" align=\"center\" style=\"font-family:'Segoe UI Semibold',SUWSB,'Segoe UI',Verdana,sans-serif;font-size:14px;line-height:20px;color:#727272;padding-top:12px;padding-left:24px;padding-right:24px;padding-bottom:12px;background-color: #d0554b;\">");
                        buttons.AppendFormat("                                            <a href=\"" + item.Url + "\" target=\"_blank\" style=\"color:#ffffff; text-decoration:none\"><span style=\"color:#ffffff; text-decoration:none\">" + item.Title +"</span></a>");
                        buttons.AppendFormat("                                        </td>");
                        buttons.AppendFormat("                                    </tr>");
                        buttons.AppendFormat("                                </tbody>");
                        buttons.AppendFormat("                            </table>");
                        buttons.AppendFormat("                        </a>");
                        buttons.AppendFormat("                    </td>");
                    }
                }

                buttons.AppendFormat("                </tr>");
                buttons.AppendFormat("            </tbody>");
                buttons.AppendFormat("        </table>");
                buttons.AppendFormat("    </td>");
                buttons.AppendFormat("</tr>");
               
               return buttons.ToString();
           }

           return string.Empty;
       }
    }
}
