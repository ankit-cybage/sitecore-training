using SC91Training.Foundation.Assets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SC91Training.Foundation.Assets.Services
{
    public interface IRenderAssetsService
    {
        HtmlString RenderScript(ScriptLocation location);

        HtmlString RenderStyles();
    }
}
