<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frm_Registro.aspx.cs" Inherits="Sistema_Academico.frm_Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Formulario de Registro de Estudiantes </title>

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" />

</head>
<body>
    <section class="vh-100" style="background-color: #c5e0dc;">
        <div class="container py-3 h-100">
            <div class="row d-flex justify-content-center align-items-center h-100">
                <div class="col col-xl-10">
                    <div class="card" style="border-radius: 1rem;">
                        <div class="row g-0">
                            <div class="col-md-6 col-lg-5 d-none d-md-block">
                                <img src="https://images.pexels.com/photos/5088188/pexels-photo-5088188.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                                    alt="background image" class="img-fluid" style="border-radius: 1rem 0 0 1rem;" />
                            </div>
                            <div class="col-md-6 col-lg-7 d-flex align-items-center">
                                <div class="card-body p-4 p-lg-5 text-black">



                                    <h5 class="fw-normal mb-1 pb-1" style="letter-spacing: 1px;">Register Students</h5>

                                    <form id="form1" runat="server">
                                        <div class="form-outline mb-2">
                                            <asp:TextBox ID="txt_id" runat="server" class="form-control form-control-sm" placeholder="Student Code"></asp:TextBox>
                                        </div>

                                        <div class="form-outline mb-2">
                                            <asp:TextBox ID="txt_nombre" runat="server" class="form-control form-control-sm" placeholder="Name"></asp:TextBox>
                                        </div>

                                        <div class="form-outline mb-2">
                                            <asp:TextBox ID="txt_contacto" runat="server" class="form-control form-control-sm" placeholder="Contact"></asp:TextBox>
                                        </div>

                                        <div class="form-outline mb-2">
                                            <asp:TextBox ID="txt_correo" runat="server" class="form-control form-control-sm" placeholder="E-mail"></asp:TextBox>
                                        </div>

                                        <div class="form-outline mb-2">
                                            <asp:TextBox ID="txt_direccion" runat="server" class="form-control form-control-sm" placeholder="Address"></asp:TextBox>
                                        </div>

                                        <div class="form-outline mb-2">
                                            <asp:TextBox ID="txt_acudiente" runat="server" class="form-control form-control-sm" placeholder="Attendant"></asp:TextBox>
                                        </div>

                                        <div class="form-outline mb-2">
                                            <asp:DropDownList ID="ddl_estrato" runat="server" class="form-control form-control-sm" placeholder="Stratum"></asp:DropDownList>
                                        </div>

                                        <div class="form-outline mb-2">
                                            <asp:DropDownList ID="ddl_sexo" runat="server" class="form-control form-control-sm" placeholder="Gender"></asp:DropDownList>
                                        </div>

                                        <div class="form-outline mb-2">
                                            <asp:TextBox ID="txt_observacion" runat="server" class="form-control form-control-sm" placeholder="Observations"></asp:TextBox>
                                        </div>

                                        <div class="pt-1 mb-4">
                                            <div class="btn-group" role="group">
                                                <asp:Button ID="btn_guardar" class="btn btn-dark btn-md mr-2" runat="server" Text="Guardar" />
                                                <asp:Button ID="btn_consultar" class="btn btn-dark btn-md mr-2" runat="server" Text="Consultar" />
                                                <asp:Button ID="btn_actualizar" class="btn btn-dark btn-md mr-2" runat="server" Text="Actualizar" />
                                                <asp:Button ID="btn_nuevo" class="btn btn-dark btn-md" runat="server" Text="Nuevo" />
                                            </div>
                                        </div>


                                    </form>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</body>
</html>
