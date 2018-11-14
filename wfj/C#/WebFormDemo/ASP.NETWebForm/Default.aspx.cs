using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            using (var context = new StuContext.StuDBContext())
            {
                var depts = context.DepartMents.ToList();

                DropDownList1.DataSource = depts;
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataValueField = "ID";
                DropDownList1.DataBind();

                var list = context.Students
                    .Select(n => new
                    {
                        StuNo = n.StudentNo,
                        FullName = n.FullName,
                        Department = n.Department.Name,
                        Sex = n.Sex ? "男" : "女",
                        Address = n.Address,
                        Telphone = n.Phone
                    })
                    .Take(20).OrderBy(x => x.Department).ThenByDescending(x => x.StuNo).ToList();
                GridView1.DataSource = list;
                GridView1.DataBind();
            }
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        var id = Guid.Parse(DropDownList1.SelectedValue);

        using (var context = new StuContext.StuDBContext())
        {
            var list = context.Students.Where(n=>n.Department.ID==id)
                .Select(n => new
                {
                    StuNo = n.StudentNo,
                    FullName = n.FullName,
                    Department = n.Department.Name,
                    Sex = n.Sex ? "男" : "女",
                    Address = n.Address,
                    Telphone = n.Phone
                }).OrderBy(x => x.StuNo).ToList();
            GridView1.DataSource = list;
            GridView1.DataBind();
        }
    }
}