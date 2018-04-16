using System;
using System.Collections.Generic;
using System.Text;

namespace WebserverLab.Server.Common
{
    using Contracts;

    public class NotFoundView : IView
    {
        public string View()
        {
            return "<h1>404 This page does not exist :/</h1>";
        }
    }
}