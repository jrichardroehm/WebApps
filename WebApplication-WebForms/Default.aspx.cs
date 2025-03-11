using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bogus;
using Microsoft.Ajax.Utilities;

namespace WebApplication_WebForms
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void ButtonGenerate_OnClick(object sender, EventArgs e)
        {

            if (Session["FakeUsers"]==null)
            {
                var faker = new Faker();
                var users = new Faker<WebUser>()
                    .RuleFor(x => x.FirstName, f => f.Name.FirstName())
                    .RuleFor(x => x.LastName, f => f.Name.LastName())
                    .RuleFor(x => x.CacEdipi, f => f.Random.Int(0, 99_999_999))
                    .Generate(10);

                Session["FakeUsers"] = users;
            }
            GridViewUsers.DataSource = Session["FakeUsers"];
            GridViewUsers.DataBind();
        }
    }

    public class WebUser()
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int CacEdipi { get; set; }
    }
}