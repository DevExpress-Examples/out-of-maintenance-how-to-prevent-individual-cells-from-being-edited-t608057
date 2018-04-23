Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data
Imports System.Linq
Imports System.Windows
Imports System.Threading

Namespace DXGrid_AssignComboBoxToColumn
    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    Partial Public Class App
        Inherits Application

        Private Sub Application_Startup(ByVal sender As Object, ByVal e As StartupEventArgs)
            Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("pt-BR")
            Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo("pt-BR")
        End Sub
    End Class
End Namespace
