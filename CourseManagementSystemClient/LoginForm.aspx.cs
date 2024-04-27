using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseManagementSystemClient
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = ddlRole.SelectedValue.Trim();

            bool success = false;

            if (role == "Admin")
            {
                AdminService.AdminServiceClient client = new AdminService.AdminServiceClient("NetTcpBinding_IAdminService");
                success = client.LoginAdmin(username, password);
            }
            else if (role == "Student")
            {
                StudentService.StudentServiceClient client = new StudentService.StudentServiceClient("NetTcpBinding_IStudentService");
                success = client.LoginStudent(username, password);
            }
            else if (role == "Teacher")
            {
                TeacherService.TeacherServiceClient client = new TeacherService.TeacherServiceClient("NetTcpBinding_ITeacherService");
                success = client.LoginTeacher(username, password);
            }

            Console.WriteLine(username);
            Console.WriteLine(password);
            Console.WriteLine(role);
            Console.WriteLine(success);

            if (success)
            {
                Session["Username"] = username;
                Session["Role"] = role;

                if (role == "Admin")
                {
                    Response.Redirect("AdminPage.aspx");
                }
                else if (role == "Student")
                {
                    Response.Redirect("StudentHomePage.aspx");
                }
                else if (role == "Teacher")
                {
                    Response.Redirect("TeacherHomePage.aspx");
                }
            }
            else
            {
                errorDiv.Visible = true;
            }
        }

    }
}