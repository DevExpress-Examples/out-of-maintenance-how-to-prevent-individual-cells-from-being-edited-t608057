Imports System.Windows
Imports System.ComponentModel
Imports System.Collections.ObjectModel
Imports DevExpress.Xpf.Grid

Namespace DevExpressGrid_Flashing

    ''' <summary>
    ''' Interaction logic for Window17.xaml
    ''' </summary>
    Public Partial Class Window17
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        End Sub

        Private Sub view_ShowingEditor(ByVal sender As Object, ByVal e As ShowingEditorEventArgs)
            If Equals(e.Column.FieldName, "Number1") Then
                e.Cancel = CType(e.Row, NewTestData).MyBool
            End If
        End Sub
    End Class

    Public Partial Class NewTestData
        Implements INotifyPropertyChanged

        Private _MyDateTime As Date

        Public Property MyDateTime As Date
            Get
                Return _MyDateTime
            End Get

            Set(ByVal value As Date)
                _MyDateTime = value
            End Set
        End Property

        Private _MyBool As Boolean

        Public Property MyBool As Boolean
            Get
                Return _MyBool
            End Get

            Set(ByVal value As Boolean)
                _MyBool = value
            End Set
        End Property

        Private _MyBool2 As Boolean

        Public Property MyBool2 As Boolean
            Get
                Return False
            End Get

            Set(ByVal value As Boolean)
                _MyBool2 = value
            End Set
        End Property

        Public Property Number1 As Decimal?

        Private _number2 As Integer

        Public Property Number2 As Integer
            Get
                Return _number2
            End Get

            Set(ByVal value As Integer)
                _number2 = value
                OnPropertyChanged("Number2")
            End Set
        End Property

        Public Property Text1 As String

        Public Property Text2 As String

'#Region "INotifyPropertyChanged Members"
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

'#End Region
        Protected Sub OnPropertyChanged(ByVal propertyName As String)
            Dim handler = PropertyChangedEvent
            If handler IsNot Nothing Then handler(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class

    Public Class MyData

        Public Shared ReadOnly Property Data As ObservableCollection(Of NewTestData)
            Get
                Dim list As ObservableCollection(Of NewTestData) = New ObservableCollection(Of NewTestData)()
                For i As Integer = 0 To 100 - 1
                    list.Add(New NewTestData() With {.MyDateTime = Date.Now, .Number1 = i, .Number2 = i * 10, .Text1 = "row fdfglkj glfdjkgl dfjglkdj flgjlfdkjdflg jdflgjd" & i, .Text2 = "ROW " & i})
                Next

                Return list
            End Get
        End Property
    End Class
End Namespace
