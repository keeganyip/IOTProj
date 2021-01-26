<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="userProfile.aspx.cs" Inherits="Webform.userProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
          <div class="col-md-12">
            <div class="card">
              <div class="card-header">
                <h5 class="title">Edit Profile</h5>
              </div>
              <div class="card-body">
                  <div class="row">
                    <div class="col-md-12">
                      <div class="form-group">
                          <asp:Label ID="lblEmail" runat="server" Text="Email Address"></asp:Label>
                          <asp:TextBox ID="TbEmail" runat="server" CssClass="form-control" ></asp:TextBox>
                      </div>
                    </div>
                  </div>
                  <div class="row">
                    <div class="col-md-12">
                      <div class="form-group">
                          <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
                          <asp:TextBox ID="TbName" runat="server" CssClass="form-control"></asp:TextBox>
                      </div>
                    </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                          <div class="form-group">
                              <asp:Label ID="lblContact" runat="server" Text="Contact Number"></asp:Label>
                              <asp:TextBox ID="TbContact" runat="server" CssClass="form-control"></asp:TextBox>
                          </div>
                        </div>
                    </div>
                  <div class="row">
                    <div class="col-md-12">
                      <div class="form-group">
                          <asp:Label ID="lblpw" runat="server" Text="Current Password"></asp:Label>
                          <asp:TextBox ID="TBPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                      </div>
                    </div>
                  </div>
                  <div class="row">
                    <div class="col-md-12">
                      <div class="form-group">
                          <asp:Label ID="lblnewpw" runat="server" Text="Change Password"></asp:Label>
                          <asp:TextBox ID="TbNewPw" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                      </div>
                    </div>
              <div class="card-footer">
                  <asp:Button ID="updateButton" runat="server" Text="Update" CssClass="btn btn-fill btn-primary" OnClick="updateButton_Click" />
              </div>
            </div>
          </div>
        </div>
        </div>
    </div>
</asp:Content>
