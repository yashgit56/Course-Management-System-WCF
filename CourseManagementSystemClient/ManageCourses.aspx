﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageCourses.aspx.cs" Inherits="CourseManagementSystemClient.ManageCourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" />
    <script src="https://cdn.tailwindcss.com"></script>
</head>
<body>
    <form id="form1" runat="server">
    <nav class="bg-gradient-to-r from-blue-500 to-blue-700 shadow-lg h-16">
        <div class="container mx-auto px-4 py-2 flex justify-between items-center h-full">
            <a href="#" class="text-xl font-bold text-white hover:text-gray-100 transition duration-300">Course Management System</a>
            <ul class="flex space-x-4">
                <li>
                    <a href="#" runat="server" class="bg-blue-500 text-white px-4 py-2 rounded-lg hover:bg-blue-600 transition duration-300">Manage Courses</a>
                </li>
                <li>
                    <a href="ManageStudents.aspx" runat="server" class="bg-blue-500 text-white px-4 py-2 rounded-lg hover:bg-blue-600 transition duration-300">Manage Students</a>
                </li>
                <li>
                    <a href="ManageTeachers.aspx" runat="server" class="bg-blue-500 text-white px-4 py-2 rounded-lg hover:bg-blue-600 transition duration-300">Manage Teachers</a>
                </li>
                <li>
                        <asp:LinkButton ID="lnkLogout" runat="server" Text="Logout" CssClass="bg-blue-500 text-white px-4 py-2 rounded-lg hover:bg-blue-600 transition duration-300" OnClick="Logout" />
                </li>
            </ul>
        </div>
    </nav>

    <div class="shadow-md rounded-lg overflow-hidden mt-12 mx-4">
        <asp:GridView ID="grdCourses" runat="server" AutoGenerateColumns="False" DataKeyNames="CourseId"
            OnRowEditing="grdCourses_RowEditing" OnRowDeleting="grdCourses_RowDeleting"
            CssClass="border-collapse w-full text-center">
            <Columns>
                <asp:BoundField DataField="CourseId" HeaderText="Course ID" ReadOnly="true" ItemStyle-CssClass="py-3 px-6 text-left" />
                <asp:BoundField DataField="Name" HeaderText="Name" ItemStyle-CssClass="py-3 px-6" />
                <asp:BoundField DataField="Description" HeaderText="Description" ItemStyle-CssClass="py-3 px-6" />
                <asp:BoundField DataField="CourseScope" HeaderText="Scope" ItemStyle-CssClass="py-3 px-6" />
                <asp:BoundField DataField="Payment" HeaderText="Payment" ItemStyle-CssClass="py-3 px-6" />
                <asp:BoundField DataField="TeacherId" HeaderText="Teacher ID" ItemStyle-CssClass="py-3 px-6" />
                <asp:TemplateField HeaderText="Actions" ItemStyle-CssClass="py-3 px-6">
                    <ItemTemplate>
                        <asp:Button ID="btnEdit" runat="server" Text="Edit" CommandName="Edit" CssClass="inline-block bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline mr-2" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" CommandName="Delete" CssClass="inline-block bg-red-500 hover:bg-red-700 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline" OnClientClick="return confirm('Are you sure you want to delete this course?');" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <HeaderStyle CssClass="bg-gray-200 text-gray-600 uppercase" />
            <RowStyle CssClass="hover:bg-gray-100" />
            <AlternatingRowStyle CssClass="bg-gray-50 hover:bg-gray-100" />
        </asp:GridView>
    </div>

    </form>


    <footer class="bg-gradient-to-r from-blue-500 to-blue-700 py-4 mt-4">
        <div class="container mx-auto px-4">
            <div class="flex justify-between items-center">
                <p class="text-white">Course Management System &copy; 2024</p>
                <ul class="flex space-x-4">
                    <li>
                        <a href="#" class="text-white hover:text-gray-300 transition duration-300">Privacy Policy</a>
                    </li>
                    <li>
                        <a href="#" class="text-white hover:text-gray-300 transition duration-300">Terms of Service</a>
                    </li>
                    <li>
                        <a href="#" class="text-white hover:text-gray-300 transition duration-300">Contact Us</a>
                    </li>
                </ul>
            </div>
        </div>
    </footer>
</body>
</html>
