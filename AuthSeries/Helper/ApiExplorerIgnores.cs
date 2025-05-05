using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebAPI.Helper
{
    public class ApiExplorerIgnores : IActionModelConvention
    {
        public void Apply(ActionModel action)
        {
            string[] controllerToHidInSwagger = { "QueryBuilder" , "ReportDesigner", "WebDocumentViewer" };
            if (controllerToHidInSwagger.Contains(action.Controller.ControllerName))
                action.ApiExplorer.IsVisible = false;
        }
    }
}
