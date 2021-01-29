<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgotPassword.aspx.cs" Inherits="Webform.forgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
        
        <!-- Outer Row -->
        <div class="row justify-content-center">

            <div class="col-xl-9 col-lg-6 col-md-8">

                <div class="card o-hidden border-0 shadow-lg my-5">
                    <div class="card-body p-0">
                        <!-- Nested Row within Card Body -->
                        <div class="row">
                            <div class="col-lg-12">
                                <div class="p-5">
                                    <div class="text-center mb-5">
                                        <img src="assets/img/logo.png" alt="Klorofil Logo" class="img-responsive logo mx-auto d-block" />
                                    </div>

                                    <div class="form-group">
                                        <asp:TextBox runat="server" ID="Email" CssClass="form-control form-control-user" TextMode="Email" placeholder="Enter Email Address..." />
                                    </div>
                                    <asp:Button ID="emailsubmit" runat="server" OnClick="submit" Text="Recover Password" CssClass="btn btn-primary btn-user btn-block" />

                                    <hr />
                                    <div class="text-center">
                                        <a class="small" href="register.aspx">Create an Account!</a>
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
