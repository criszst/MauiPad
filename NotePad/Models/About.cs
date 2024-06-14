using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad.Models
{
    class About
    {
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;

        public string Description => "Esse app tem como objetivo servir como um bloco de notas.";
        public string MoreInfoURL => "https://github.com/criszst/";

        //public About()
        //{
        //    this.Title = AppInfo.Name;
        //    this.Version = AppInfo.VersionString;

        //    this.Description = "Esse app tem como objetivo servir como um bloco de notas.";
        //    this.MoreInfoURL = "https://github.com/sst.cristian/";
        //}
    }
}
