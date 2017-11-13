Imports Microsoft.VisualBasic
Imports System

Imports System.Reflection
Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports System.Runtime.Remoting.Channels.Tcp
Imports System.IO
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo

Namespace LoggerRepeater
	Public Class Logger
		Inherits DataStoreLogger
		Public Sub New()
            MyBase.New(XpoDefault.GetConnectionProvider(DB.AutoCreateOption.DatabaseAndSchema), Console.Out)
			Console.WriteLine("Logger created.")
		End Sub
		Protected Overrides Sub Finalize()
			Console.WriteLine("Logger finalized.")
		End Sub
	End Class

	Friend Class Program
		Public Shared Port As Integer = 4001
		Public Shared ObjectUri As String = "Server"
		Public Shared RemotingParametersPassed As Boolean = False
		Public Shared RemotingConfigFileName As String = System.Reflection.Assembly.GetExecutingAssembly().Location & ".config"
		Shared Sub Main(ByVal args As String())
			Try
				ParseArgs(args)
				ConfigureRemoting()
				Console.WriteLine("Log requests for {0}", XpoDefault.ActiveConnectionString)
				LogUrls()
				Console.ReadLine()
			Catch e As Exception
				Console.WriteLine()
				Console.WriteLine("Exception: {0}", e)
				Console.WriteLine()
			End Try
		End Sub
		Public Shared Sub LogUrls()
			Console.WriteLine("Listen for requests on:")
			For Each wksty As WellKnownServiceTypeEntry In RemotingConfiguration.GetRegisteredWellKnownServiceTypes()
				For Each ch As IChannel In ChannelServices.RegisteredChannels
					Dim rch As IChannelReceiver = TryCast(ch, IChannelReceiver)
					If rch Is Nothing Then
						Continue For
					End If
					For Each s As String In rch.GetUrlsForUri(wksty.ObjectUri)
						Console.WriteLine(Constants.vbTab & "{0}", s)
					Next s
				Next ch
			Next wksty
		End Sub

		Public Const InvalidArgumentText As String = "command-line args" & ControlChars.CrLf & "LoggedProviderConnectionString" & ControlChars.CrLf & "/u:ObjectUri" & ControlChars.CrLf & "/p:TcpPort" & ControlChars.CrLf & ControlChars.CrLf & "LoggedProviderConnectionStrings may be something like" & ControlChars.CrLf & "tcp://localhost:4001/Server" & ControlChars.CrLf & "XpoProvider=MSSqlServer;data source=(local);integrated security=SSPI;initial catalog=MyTestDatabase" & ControlChars.CrLf & "etc..."

		Private Shared Sub ParseArgs(ByVal args As String())
			If args Is Nothing Then
				Return
			End If
			For Each arg As String In args
				If arg.StartsWith("/") Then
					If arg.Length < 2 Then
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
						Case "p"c
							Port = Int32.Parse(argValue)
							RemotingParametersPassed = True
						Case "u"c
							ObjectUri = argValue
							RemotingParametersPassed = True
						Case Else
							Throw New ApplicationException(InvalidArgumentText)
					End Select
				Else
					If Not XpoDefault.ConnectionString Is Nothing Then
						Throw New ApplicationException(InvalidArgumentText)
					End If
					XpoDefault.ConnectionString = arg
				End If
			Next arg
		End Sub

		Public Shared Sub ConfigureRemoting()
			If (Not RemotingParametersPassed) AndAlso (Not File.Exists(RemotingConfigFileName)) Then
				RemotingParametersPassed = True
			End If
			If RemotingParametersPassed Then
				ChannelServices.RegisterChannel(New TcpChannel(Port), False)
				RemotingConfiguration.RegisterWellKnownServiceType(GetType(Logger), ObjectUri, WellKnownObjectMode.Singleton)
			Else
				RemotingConfiguration.Configure(RemotingConfigFileName, False)
			End If
		End Sub

	End Class
End Namespace
