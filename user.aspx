<%@ Page Title="user" Language="C#" MasterPageFile="~/pages/forms.Master" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="Allforms.pages.user" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
<!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
  <title>Skydash Admin</title>
  <!-- plugins:css -->
  <link rel="stylesheet" href="../../vendors/feather/feather.css"/>
  <link rel="stylesheet" href="../../vendors/ti-icons/css/themify-icons.css"/>
  <link rel="stylesheet" href="../../vendors/css/vendor.bundle.base.css"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
  <!-- endinject -->
  <!-- Plugin css for this page -->
  <!-- End plugin css for this page -->
  <!-- inject:css -->
  <link rel="stylesheet" href="../../css/vertical-layout-light/style.css"/>
  <!-- endinject -->
  <link rel="shortcut icon" href="../../images/favicon.png" />
    <link rel="stylesheet" href="Style1.css"/>
</head>
<body>

    <div class="content-wrapper">
        <div class="row">
            <script type="text/javascript">
                //<![CDATA[
                Sys.WebForms.PageRequestManager._initialize('sm1', 'ctl00', [], [], [], 90, '');
            </script>

            <div class="col-12 stretch-card">
                <div class="card">
                    <div class="card-body" style="padding-bottom:0.25rem;">
                        <h4 class="card-title">Faculty Information</h4>
                        <p class="card-description">
                            Fill the forms<code>personal information or personally</code>  identifiable information of student.                 
                        </p>
                        <div class="form-row">
                            <div class="form-group col-md-6">
                                <div class="form-group">
                                    <label for="exampleInputUsername1">Generate UserId</label><code>*</code>
                                    <asp:TextBox ID="user_id" runat="server" CssClass="form-control" placeholder="UserID"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group col-md-6">
                                <div class="form-group">
                                    <label for="exampleInputUsername1">Generate Password</label><code>*</code>
                                    <asp:TextBox ID="password" runat="server" CssClass="form-control" placeholder="Password" type="password"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group col-md-6">
                                <div class="form-group">
                                    <label for="exampleInputUsername1">Enter Contact</label><code>*</code>
                                    <asp:TextBox ID="contact" runat="server" CssClass="form-control" placeholder="Contact"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group col-md-6">
                                <div class="form-group">
                                    <label for="exampleInputUsername1">Select Department</label><code>*</code>
                                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="UnMentioned">Select Office</asp:ListItem>
                                        <asp:ListItem>Paher</asp:ListItem>
                                        <asp:ListItem>COE</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        
                    </div>
                </div>
            </div>

            <div class="col-12 stretch-card">
                <div class="card">
                    <div class="card-body">
                        <h4 class="card-title">Faculty Permission</h4>
                        <p class="card-description">
                            Permission<code>.<b>(Permissions)</b></code>
                        </p>

                        <div class="form-inline">
                            <div class="form-check mx-sm-2">
                                <span class="form-check form-check-warning">
                                    <asp:CheckBox ID="admision" runat="server" Text=" Admission  " />
                                </span>
                            </div>
                            <div class="form-check mx-sm-2">
                                <span class="form-check form-check-warning">
                                    <asp:CheckBox ID="bed_all" runat="server" Text=" Bed_All  " />
                                </span>
                            </div>
                            <div class="form-check mx-sm-2">
                                <span class="form-check form-check-warning">
                                    <asp:CheckBox ID="login" runat="server" Text=" Login  " />
                                </span>
                            </div>
                            <div class="form-check mx-sm-2">
                                <span class="form-check form-check-warning">
                                  <asp:CheckBox ID="phd" runat="server" Text=" PHD  " />
                                </span>
                            </div>
                            <div class="form-check mx-sm-2">
                                <span class="form-check form-check-warning">
                                   <asp:CheckBox ID="isactive" runat="server" Text=" IsActive " />
                                </span>
                            </div>
                            <div class="form-check mx-sm-2">
                                <span class="form-check form-check-warning">
                                    <asp:CheckBox ID="enquiry" runat="server" Text=" Enquiry" />
                                    </span>
                            </div>
                        </div>
                    </div>
                </div>
            </div> 
            
           <asp:Button ID="btn_submit" runat="server" Text="Submit" OnClick="btn_submit_Click" Cssclass="btn btn-primary"/>
 
        </div>
    </div>



    <asp:HiddenField ID="hidIds" runat="server" />
    <asp:Panel ID="pnlview" runat="server" ScrollBars="Both">
                <asp:GridView ID="Gvdetail" runat="server" DataKeyNames="PK_id" AutoGenerateColumns="false" CssClass="footable" Width="100%" OnRowDataBound="Gvdetail_RowDataBound">

                        <Columns>
                            <asp:TemplateField HeaderText="Sr No">
                                <ItemTemplate>
                                    <%# Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="UserId" DataField="userid" />
                            <asp:BoundField HeaderText="Password" DataField="pass" />
                            <asp:BoundField HeaderText="Contact" DataField="contact" />
                            <asp:BoundField HeaderText="Office" DataField="office" />
                            <asp:BoundField HeaderText="Addmission" DataField="admission"/>
                            <asp:BoundField HeaderText="Addmission" DataField="bed_all"/>
                            <asp:BoundField HeaderText="LogIn" DataField="login"/>
                            <asp:BoundField HeaderText="PHD" DataField="phd"/>
                            <asp:BoundField HeaderText="IsActive" DataField="isActive"/>
                            <asp:BoundField HeaderText="Enquiry" DataField="enquiry"/>                    
                            <asp:TemplateField HeaderText="Edit">
                                <ItemTemplate>
                                    <asp:LinkButton ID="btndelete" runat="server" Text="Delete" OnClick="btndelete_Click" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>

                        <EmptyDataTemplate>
                            <div class="alert alert-danger" role="alert">
                                <span class="dot">This Time no record found</span>
                            </div>
                        </EmptyDataTemplate>

            </asp:GridView>
        </asp:Panel>



 <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.2/dist/umd/popper.min.js" integrity="sha384-7+zCNj/IqJ95wo16oMtfsKbZ9ccEh31eOz1HGyDuCQ6wgnyJNSYdrPa03rtR1zdB" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>
</body>
</html>

   
</asp:Content>
