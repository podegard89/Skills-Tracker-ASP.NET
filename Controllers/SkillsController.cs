using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SkillsTracker.Controllers
{
    [Route("/skills")]
    public class SkillsController : Controller
    {
        public IActionResult Index()
        {
            string html = "<h1>Skills Tracker</h1>" +
                "<h2>Coding Skills to Learn:</h2>" +
                    "<ol>" +
                    "<li>Python</li>" +
                    "<li>Pupeteer (JavaScript)</li>" +
                    "<li>C#, ASP.NET</li>" +
                    "</ol>";

            return Content(html, "text/html");
        }

        [Route("form")]
        public IActionResult Form()
        {
            string html = "<form method='post' action='/skills/results'>" +
                "<table border='1'>" +
                "<tr>" +
                "<td>Date</td>" +
                "<td><input type='date' name='date'/></td>" +
                "</tr>" +
                "<tr>" +
                    "<td>Python level</td>" +
                    "<td>" +
                        "<select name='python'>" +
                            "<option>Not Started</option>" +
                            "<option>Learning Basics</option>" +
                            "<option>Making Apps</option>" +
                        "</select>" +
                    "</td>" +
                "</tr>" +
                "<tr>" +
                    "<td>Puppeteer level</td>" +
                    "<td>" +
                        "<select name='puppeteer'>" +
                            "<option>Not Started</option>" +
                            "<option>Learning Basics</option>" +
                            "<option>Making Apps</option>" +
                        "</select>" +
                    "</td>" +
                "</tr>" +
                "<tr>" +
                    "<td>C#, ASP.NET level</td>" +
                    "<td>" +
                        "<select name='aspNET'>" +
                            "<option>Not Started</option>" +
                            "<option>Learning Basics</option>" +
                            "<option>Making Apps</option>" +
                        "</select>" +
                    "</td>" +
                "</tr>" +
                "</table>" +
                "<p><input type='submit' value='submit'/></p>" +
                "</form>";
                //"<h2>Date:<h2>" +
                //"<input type='date' name='date'/>" +
                //"<h2>Python:</h2>" +
                //"<select name='python'>" +
                //    "<option>Not Started</option>" +
                //    "<option>Learning Basics</option>" +
                //    "<option>Making Apps</option>" +
                //"</select>" +
                //"<h2>Puppeteer</h2>" +
                //"<select name='puppeteer'>" +
                //    "<option>Not Started</option>" +
                //    "<option>Learning Basics</option>" +
                //    "<option>Making Apps</option>" +
                //"</select>" +
                //"<h2>C#, ASP.NET</h2>" +
                //"<select name='aspNET'>" +
                //    "<option>Not Started</option>" +
                //    "<option>Learning Basics</option>" +
                //    "<option>Making Apps</option>" +
                //"</select>" +
                //"<button type='submit'>Submit</button>" +
                //"</form>";

            return Content(html, "text/html");
        }

        [HttpPost("results")]
        public IActionResult FormSubmit(string date, string python, string puppeteer, string aspNET)
        {
            string html = $"<h1>{date}</h1>" +
                $"<ol>" +
                $"<li>Python: {python}</li>" +
                $"<li>Puppeteer: {puppeteer}</li>" +
                $"<li>C#, ASP.NET: {aspNET}";

            return Content(html, "text/html");
        }
    }
}
