@ModelType LoginViewModel

@Code
    ViewBag.Title = "Log in"
End Code
<center><h3><span style="color:black">Neat</span><span style="color:aqua">Space</span></h3></center>
</br>
<div class="col-12">
    <h7>Sign in with your email address or mobile number.</h7>
</div>

<div class="row">
    <div class="col-12">
        <section id="loginForm">
            @Using Html.BeginForm("Login", "Account", New With { .ReturnUrl = ViewBag.ReturnUrl }, FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
                @Html.AntiForgeryToken()
                @<text>

                @Html.ValidationSummary(True)
                <div class="form-group">
                    @Html.LabelFor(Function(m) m.UserName, New With {.class = "col-md-2 control-label"})
                    <div class="col-md-10">
                        @Html.TextBoxFor(Function(m) m.UserName, New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(m) m.UserName)
                    </div>
                </div>
                <div class="form-group">
                    @Html.LabelFor(Function(m) m.Password, New With {.class = "col-md-2 control-label"})
                    <div class="col-md-10">
                        @Html.PasswordFor(Function(m) m.Password, New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(m) m.Password)
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <div class="checkbox">
                            @Html.CheckBoxFor(Function(m) m.RememberMe)
                            @Html.LabelFor(Function(m) m.RememberMe)
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-12">
                        <input type="submit" value="Log in" class="btn btn-primary" style="width:100%" />
                    </div>
                </div>
                <p>
                    New to NeatSpace ? @Html.ActionLink("Create an account", "Register")
                </p>
                </text>
            End Using
        </section>
    </div>
</div>
@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
