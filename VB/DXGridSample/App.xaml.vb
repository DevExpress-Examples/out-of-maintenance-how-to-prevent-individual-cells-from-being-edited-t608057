Imports System
Imports System.Windows
Imports System.Threading

Namespace DXGrid_AssignComboBoxToColumn

    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    Public Partial Class App
        Inherits Application

        Private Sub Application_Startup(ByVal sender As Object, ByVal e As StartupEventArgs)
            Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("pt-BR")
            Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("pt-BR")
        End Sub
    End Class
End Namespace
