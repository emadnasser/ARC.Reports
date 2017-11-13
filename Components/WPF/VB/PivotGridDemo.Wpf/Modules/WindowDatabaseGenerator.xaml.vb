Imports DevExpress.Xpf.Core
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports PivotGridDemo.PivotGrid.Helpers
Imports System
Imports System.Globalization
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Input

Namespace PivotGridDemo.PivotGrid
    Partial Public Class WindowDatabaseGenerator
        Inherits DXWindow

        Private windowWasClosed As Boolean

        Public Sub New()
            Me.New(Nothing, "Start Demo")
        End Sub
        Public Sub New(ByVal control As UserControl, ByVal demoString As String)
            InitializeComponent()
            Me.DemoString = demoString
            If control IsNot Nothing Then
                Owner = Window.GetWindow(control)
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            Else
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            End If
            ShowInTaskbar = False
            btnGenerateDatabase.Content = CStr(btnGenerateDatabase.Content) & Me.DemoString
            pbPassword.Password = ServerParameters.Password
            AddHandler pbPassword.PasswordChanged, Sub(s, e) ServerParameters.Password = pbPassword.Password
            AddHandler Closed, Sub(s, e)
                windowWasClosed = True
                If DatabaseHelper.IsGenerating Then
                    DatabaseHelper.CancelDatabaseGenerationAsync()
                End If
                ServerParameters.SaveParameters()
                Mouse.OverrideCursor = Nothing
            End Sub
        End Sub
        Protected Property DemoString() As String
        Private Sub rdWindowsAuthentication_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If tbLogin IsNot Nothing Then
                pbPassword.IsEnabled = False
                tbLogin.IsEnabled = pbPassword.IsEnabled
            End If
        End Sub
        Private Sub rdSqlServerAuthentication_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            pbPassword.IsEnabled = True
            tbLogin.IsEnabled = pbPassword.IsEnabled
        End Sub
        Private Sub tbRecordsCount_TextChanged(ByVal sender As Object, ByVal e As System.Windows.Controls.TextChangedEventArgs)
            Dim temp As Integer = Nothing
            If Not Integer.TryParse(tbRecordsCount.Text, temp) Then
                tbRecordsCount.Text = "250000"
            End If
        End Sub
        Private Sub btnExit_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            DialogResult = DatabaseHelper.IsGenerating
            Close()
        End Sub
        Private Sub btnGenerateDatabase_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            GenerateRecords()
        End Sub
        Private Sub DisableControls()
            btnGenerateDatabase.IsEnabled = False
            btnTestConfiguration.IsEnabled = False
            rdWindowsAuthentication.IsEnabled = False
            rdSqlServerAuthentication.IsEnabled = rdWindowsAuthentication.IsEnabled
            tbLogin.IsEnabled = False
            pbPassword.IsEnabled = False
            tbServer.IsEnabled = False
            tbRecordsCount.IsEnabled = False
        End Sub
        Private Sub GenerateRecords()
            Mouse.OverrideCursor = Cursors.Wait
            If Not DatabaseHelper.CreateDataLayer() Then
                Mouse.OverrideCursor = Nothing
                DXMessageBox.Show("Failed to connect to the server.", "Connection Error", MessageBoxButton.OK, MessageBoxImage.Error)
                Return
            End If
            Title = "Generating records..."
            Dim rowsTotal As Integer = Integer.Parse(tbRecordsCount.Text)
            progressBar1.Maximum = rowsTotal
            progressBar1.Value = 0
            DisableControls()
            DatabaseHelper.GenerateDatabaseAsync(rowsTotal, AddressOf UpdateProgress, AddressOf OnDatabaseGenerated)
        End Sub
        Private Sub UpdateProgress(ByVal rowsGenerated As Integer)
            progressBar1.Value = rowsGenerated
            btnExit.Content = String.Format("{0} rows is enough. {1}", rowsGenerated, DemoString)
        End Sub
        Private Sub OnDatabaseGenerated()
            If Not windowWasClosed Then
                DialogResult = True
            End If
            Close()
        End Sub
        Private Sub btnTestConfiguration_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            lblRecordsCount.Content = String.Empty
            Dim recordsCount As Integer = DatabaseHelper.CalculateRecordCount()
            If recordsCount <> -1 Then
                lblRecordsCount.Content = String.Format("Current record count = {0}", recordsCount)
            Else
                DXMessageBox.Show(String.Format("Unable to connect to the database. Make sure that connection parameters are correct or use the '{0}' button to generate a sample database.", btnGenerateDatabase.Content), "Connection Error", MessageBoxButton.OK, MessageBoxImage.Error)
            End If
        End Sub
    End Class

    <ValueConversion(GetType(Boolean), GetType(Boolean))>
    Public Class BooleanInverterConverter
        Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            If targetType IsNot GetType(Boolean) AndAlso targetType IsNot GetType(Boolean?) Then
                Throw New InvalidOperationException("The target must be a boolean")
            End If
            Return Not DirectCast(value, Boolean)
        End Function
        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
            Return Convert(value, targetType, parameter, culture)
        End Function
    End Class
End Namespace
