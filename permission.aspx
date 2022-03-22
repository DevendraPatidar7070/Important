<%@ Page Title="permission" Language="C#" MasterPageFile="~/pages/forms.Master" AutoEventWireup="true" CodeBehind="permission.aspx.cs" Inherits="Allforms.pages.permission" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .dot {
            height: 40px;
            width: 40px;
            background-color: #dd0303;
            border-radius: 50%;
            display: inline-block;
            text-align: center;
            color: white;
            display: inline;
            padding: .2em .6em .3em;
            font-size: 125%;
            font-weight: 700;
            line-height: 2.5;
            text-align: center;
            white-space: nowrap;
            vertical-align: baseline;
            border-radius: .25em;
        }
    </style>

    <div class="col-lg-12 grid-margin stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">Application Foms</h4>
                <p class="card-description">
                    View details of <code>.Permission-forms</code>
                </p>

                <br />
                <asp:HiddenField ID="hidIds" runat="server" />
                <asp:Panel ID="pnlview" runat="server" ScrollBars="Both">
                    <asp:GridView ID="Gvdetail" runat="server" DataKeyNames="id" AutoGenerateColumns="false" CssClass="footable" Width="100%" OnRowDataBound="Gvdetail_RowDataBound">
                        <Columns>

                            <asp:TemplateField HeaderText="Sr No">
                                <ItemTemplate>
                                    <%# Container.DataItemIndex + 1 %>
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:BoundField HeaderText="APPLICATION" DataField="forms" />
                            <asp:BoundField HeaderText="MSG" DataField="msg" />


                            <asp:TemplateField HeaderText="PERMISSION">
                                <ItemTemplate>
                                    <div class="progress" style="width: 30px">
                                        <asp:Panel ID="divrates" runat="server" class="" role="progressbar" Style="width: 70%" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100"></asp:Panel>
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Edit">
                                <ItemTemplate>
                                    <asp:LinkButton ID="btnedit" runat="server" Text="Edit" OnClick="btnedit_Click" />
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

                <asp:ScriptManager runat="server" />
                <cc1:ModalPopupExtender ID="mpshiv" BehaviorID="mpe" runat="server"
                    PopupControlID="pnlPopup" TargetControlID="lnkDummy" BackgroundCssClass="modalBackground" CancelControlID="btnHide">
                </cc1:ModalPopupExtender>
                <asp:Panel ID="pnlPopup" runat="server" CssClass="modalPopup" Style="display: none;">
                    <asp:LinkButton ID="lnkDummy" runat="server"></asp:LinkButton>
                    <div class="col-lg-12 grid-margin stretch-card">
                        <div class="card" style="background: #e4e6e9">
                            <div class="card-body">

                                <asp:ImageButton ID="btnHide" ImageUrl="~/Img/Deactivate.png" runat="server" />

                                <p class="card-description">
                                    <h4 class="card-title">Update Status</h4>
                                </p>
                                <div class="table-responsive">
                                    <table class="table">
                                        <thead>
                                            <tr>
                                                <th>
                                                    <asp:Label ID="Label1" runat="server" Text="Permission Status:"></asp:Label>
                                                    <asp:CheckBox ID="chkpermission" runat="server" />

                                                </th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="txttransid" runat="server" class="form-control" BorderStyle="Solid" BorderColor="Black" BorderWidth="3px" placeholder="Enter Message" aria-label="search" aria-describedby="search" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Button ID="btnupdate" runat="server" class="btn btn-danger" data-dismiss="modal" Text="Update" OnClientClick="btnupdate_click" OnClick="btnupdate_Click1" />
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>

                </asp:Panel>


            </div>
        </div>
    </div>
</asp:Content>
