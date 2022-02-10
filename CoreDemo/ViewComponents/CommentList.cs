using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.VİewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var values = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    Username="Murat"
                }
            };
            return View(values);
        }

    }
}
