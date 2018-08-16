Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
        lbAvailable.EnableItemsVirtualRendering = DevExpress.Utils.DefaultBoolean.False
        lbChosen.EnableItemsVirtualRendering = DevExpress.Utils.DefaultBoolean.False
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
End Class