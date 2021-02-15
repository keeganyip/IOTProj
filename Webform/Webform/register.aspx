<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="Webform.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <meta charset="utf-8" />
	<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
	<meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0" />
	<!-- MAIN CSS -->
	<link rel="stylesheet" href="assets/css/sb-admin-2.min.css" />
	<!-- GOOGLE FONTS -->
	<link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700" rel="stylesheet" />
	<!-- ICONS -->
	<link rel="apple-touch-icon" sizes="76x76" href="assets/img/apple-icon.png" />
	<link rel="icon" type="image/png" sizes="96x96" href="assets/img/favicon.png" />
</head>
<body class="bg-gradient-primary">
    <form id="form1" runat="server">
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-xl-6 col-lg-6 col-md-6">
                <div class="card o-hidden border-0 shadow-lg my-5">
                    <div class="card-body p-0">
                        <!-- Nested Row within Card Body -->
                        <div class="row">
                            <div class="col-lg-12">
                                <div class="p-5">
                                    <div class="text-center mb-5">
                                        <img src="assets/img/logo.png" alt="Klorofil Logo" class="img-responsive logo mx-auto d-block" />
                                    </div>

                                    <div class="form-group row">
                                        <div class="col-sm-6 mb-3 mb-sm-0">
                                            <asp:TextBox runat="server" ID="Name" CssClass="form-control form-control-user" placeholder="Name" />
                                        </div>
                                        <div class="col-sm-6">
                                            <asp:TextBox runat="server" ID="Contact" CssClass="form-control form-control-user" placeholder="Contact Number" />
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <asp:TextBox runat="server" ID="Email" CssClass="form-control form-control-user" TextMode="Email" placeholder="Email Address" />
                                    </div>
                                    <div class="form-group row">
                                        <div class="col-sm-6 mb-3 mb-sm-0">
                                            <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control form-control-user" placeholder="Password" />
                                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Must have at least 8 characters"
                                                 ControlToValidate="Password" ValidationExpression="^.{8,}$" ForeColor="Red" Display="Dynamic" Font-Size="X-Small"></asp:RegularExpressionValidator>
                                        </div>
                                        <div class="col-sm-6">
                                            <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control form-control-user" placeholder="Confirm Password" />
                                            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password does not match" ForeColor="Red" Font-Size="X-Small" ControlToValidate="ConfirmPassword" ControlToCompare="Password" Display="Dynamic"></asp:CompareValidator>
                                        </div>
                                    </div>
                                    <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register Account" CssClass="btn btn-primary btn-user btn-block" />

                                    <hr />

                                    <hr />
                                    <div class="text-center">
                                        <a class="small" href="forgotPassword.aspx">Forgot Password?</a>
                                    </div>
                                    <div class="text-center">
                                        <a class="small" href="login.aspx">Already have an account? Login!</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        
    </div>
    </form>
</body>
</html>
