Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports System.IO
Imports System.Reflection
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Tcp
Imports DevExpress.Xpo.DB

Namespace DataSetServerDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Partial Class Form1
		Inherits System.Windows.Forms.Form
		<STAThread> _
		Shared Sub Main(ByVal args As String())
			Try
				ParseParameters(args)
				ReadDatabase()
				ConfigureRemoting()

				Application.Run(New Form1())
			Catch e As Exception
				MessageBox.Show(e.ToString(), "DataSetServerDemo", MessageBoxButtons.OK, MessageBoxIcon.Hand)
			End Try
		End Sub
		Public Shared DataSetFileName As String = System.Reflection.Assembly.GetExecutingAssembly().Location & ".DataSet"
		Public Shared RemotingConfigFileName As String = System.Reflection.Assembly.GetExecutingAssembly().Location & ".config"
		Public Shared Data As DataSet = New DataSet("DataSetServerDemo")
		Public Shared ObjectUri As String = "Server"
		Public Shared Port As Integer = 4001
		Public Shared RemotingParametersPassed As Boolean = False
		Public Const InvalidArgumentText As String = "command-line args" & ControlChars.CrLf & "/d:DataSetFileName" & ControlChars.CrLf & "/u:ObjectUri" & ControlChars.CrLf & "/p:TcpPort"
		Public Sub New()
			InitializeComponent()

			Dim urls As String = String.Empty
			For Each wksty As WellKnownServiceTypeEntry In RemotingConfiguration.GetRegisteredWellKnownServiceTypes()
				For Each ch As IChannel In ChannelServices.RegisteredChannels
					Dim rch As IChannelReceiver = TryCast(ch, IChannelReceiver)
					If rch Is Nothing Then
						Continue For
					End If
					For Each s As String In rch.GetUrlsForUri(wksty.ObjectUri)
						urls &= s & " "c
					Next s
				Next ch
			Next wksty

			Me.Text = urls & "- DataSetServer demo"
		End Sub

		Private Sub btnTerminate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTerminate.Click
			Me.Close()
		End Sub

		Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
			SaveDatabase()
		End Sub

		Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
			SaveDatabase()
			Me.Close()
		End Sub

		Public Shared Sub SaveDatabase()
			SyncLock Data
				Data.WriteXml(DataSetFileName, XmlWriteMode.WriteSchema)
			End SyncLock
		End Sub

		Public Shared Sub ReadDatabase()
			SyncLock Data
				Try
					Data.ReadXml(DataSetFileName, XmlReadMode.ReadSchema)
				Catch e1 As System.IO.FileNotFoundException
					'Console.Write("{0}\tFile not found, using empty DataSet", Environment.NewLine);
				End Try
				'
			'catch(Exception e) {
				'Console.WriteLine("Exception:{0}{1}", Environment.NewLine, e);
				'return;
			'}
				 '
			End SyncLock
		End Sub

		Public Shared Sub ConfigureRemoting()
			If (Not RemotingParametersPassed) AndAlso (Not File.Exists(RemotingConfigFileName)) Then
				RemotingParametersPassed = True
			End If
			If RemotingParametersPassed Then
				ChannelServices.RegisterChannel(New TcpChannel(Port), False)
				RemotingConfiguration.RegisterWellKnownServiceType(GetType(DataSetServer), ObjectUri, WellKnownObjectMode.Singleton)
			Else
				RemotingConfiguration.Configure(RemotingConfigFileName, False)
			End If
		End Sub



		Public Shared Sub ParseParameters(ByVal args As String())
			If args Is Nothing Then
				Return
			End If
			For Each arg As String In args
				If arg.Length < 2 OrElse arg.Chars(0) <> "/"c Then
					Throw New ApplicationException(InvalidArgumentText)
				End If
				Dim switcher As Char = Char.ToLower(arg.Chars(1))
				Dim argValue As String = arg.Substring(2)
				If argValue.StartsWith(":") Then
					argValue = argValue.Substring(1)
				End If
				If argValue.Length = 0 Then
					Throw New ApplicationException(InvalidArgumentText)
				End If
				Select Case switcher
					Case "d"c
						DataSetFileName = argValue
					Case "p"c
						Port = Int32.Parse(argValue)
						RemotingParametersPassed = True
					Case "u"c
						ObjectUri = argValue
						RemotingParametersPassed = True
					Case Else
						Throw New ApplicationException(InvalidArgumentText)
				End Select
			Next arg
		End Sub

	End Class

	'
	'public class DataSetServer : ConnectionProviderCacheRoot {
		'public DataSetServer()
			': base(new InMemoryConnectionProvider(Form1.Data, AutoCreateOption.SchemaOnly)) { }
	'}
	'

    Public Class DataSetServer
        Inherits DataSetDataStore
        Public Sub New()
            MyBase.New(Form1.Data, DevExpress.Xpo.DB.AutoCreateOption.SchemaOnly)
        End Sub
    End Class
End Namespace
