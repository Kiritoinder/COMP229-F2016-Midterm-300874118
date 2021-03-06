﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/* Author: Inderjeet Singh
 * Student ID: 300874118
 * Date Modified: 19-Oct-2016
 * version 1.0.0.1
 * file:site.master.cs
 */
namespace COMP229_F2016_MidTerm_300874118
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetActivePage();
        }

        /**
        * This method adds a css class of "active" to list items
        * relating to the current page
        * 
        * @private
        * @method SetActivePage
        * @return {void}
        */
        private void SetActivePage()
        {
            switch (Page.Title)
            {
                case "Home Page":
                    home.Attributes.Add("class", "active");
                    break;
                case "Todo List":
                    todo.Attributes.Add("class", "active");
                    break;
                case "Add Note":
                    addNote.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}