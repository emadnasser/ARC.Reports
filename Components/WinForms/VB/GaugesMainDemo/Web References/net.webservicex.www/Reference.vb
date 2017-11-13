﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18033
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18033.
'
Namespace net.webservicex.www
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="WeatherForecastSoap", [Namespace]:="http://www.webservicex.net")>  _
    Partial Public Class WeatherForecast
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private GetWeatherByZipCodeOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetWeatherByPlaceNameOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.Settings.Default.GaugesMainDemo_net_webservicex_www_WeatherForecast
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event GetWeatherByZipCodeCompleted As GetWeatherByZipCodeCompletedEventHandler
        
        '''<remarks/>
        Public Event GetWeatherByPlaceNameCompleted As GetWeatherByPlaceNameCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.webservicex.net/GetWeatherByZipCode", RequestNamespace:="http://www.webservicex.net", ResponseNamespace:="http://www.webservicex.net", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetWeatherByZipCode(ByVal ZipCode As String) As WeatherForecasts
            Dim results() As Object = Me.Invoke("GetWeatherByZipCode", New Object() {ZipCode})
            Return CType(results(0),WeatherForecasts)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetWeatherByZipCodeAsync(ByVal ZipCode As String)
            Me.GetWeatherByZipCodeAsync(ZipCode, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetWeatherByZipCodeAsync(ByVal ZipCode As String, ByVal userState As Object)
            If (Me.GetWeatherByZipCodeOperationCompleted Is Nothing) Then
                Me.GetWeatherByZipCodeOperationCompleted = AddressOf Me.OnGetWeatherByZipCodeOperationCompleted
            End If
            Me.InvokeAsync("GetWeatherByZipCode", New Object() {ZipCode}, Me.GetWeatherByZipCodeOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetWeatherByZipCodeOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetWeatherByZipCodeCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetWeatherByZipCodeCompleted(Me, New GetWeatherByZipCodeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.webservicex.net/GetWeatherByPlaceName", RequestNamespace:="http://www.webservicex.net", ResponseNamespace:="http://www.webservicex.net", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetWeatherByPlaceName(ByVal PlaceName As String) As WeatherForecasts
            Dim results() As Object = Me.Invoke("GetWeatherByPlaceName", New Object() {PlaceName})
            Return CType(results(0),WeatherForecasts)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetWeatherByPlaceNameAsync(ByVal PlaceName As String)
            Me.GetWeatherByPlaceNameAsync(PlaceName, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetWeatherByPlaceNameAsync(ByVal PlaceName As String, ByVal userState As Object)
            If (Me.GetWeatherByPlaceNameOperationCompleted Is Nothing) Then
                Me.GetWeatherByPlaceNameOperationCompleted = AddressOf Me.OnGetWeatherByPlaceNameOperationCompleted
            End If
            Me.InvokeAsync("GetWeatherByPlaceName", New Object() {PlaceName}, Me.GetWeatherByPlaceNameOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetWeatherByPlaceNameOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetWeatherByPlaceNameCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetWeatherByPlaceNameCompleted(Me, New GetWeatherByPlaceNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.webservicex.net")>  _
    Partial Public Class WeatherForecasts
        
        Private latitudeField As Single
        
        Private longitudeField As Single
        
        Private allocationFactorField As Single
        
        Private fipsCodeField As String
        
        Private placeNameField As String
        
        Private stateCodeField As String
        
        Private statusField As String
        
        Private detailsField() As WeatherData
        
        '''<remarks/>
        Public Property Latitude() As Single
            Get
                Return Me.latitudeField
            End Get
            Set
                Me.latitudeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Longitude() As Single
            Get
                Return Me.longitudeField
            End Get
            Set
                Me.longitudeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property AllocationFactor() As Single
            Get
                Return Me.allocationFactorField
            End Get
            Set
                Me.allocationFactorField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property FipsCode() As String
            Get
                Return Me.fipsCodeField
            End Get
            Set
                Me.fipsCodeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property PlaceName() As String
            Get
                Return Me.placeNameField
            End Get
            Set
                Me.placeNameField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property StateCode() As String
            Get
                Return Me.stateCodeField
            End Get
            Set
                Me.stateCodeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property Status() As String
            Get
                Return Me.statusField
            End Get
            Set
                Me.statusField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlArrayItemAttribute(IsNullable:=false)>  _
        Public Property Details() As WeatherData()
            Get
                Return Me.detailsField
            End Get
            Set
                Me.detailsField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.webservicex.net")>  _
    Partial Public Class WeatherData
        
        Private dayField As String
        
        Private weatherImageField As String
        
        Private maxTemperatureFField As String
        
        Private minTemperatureFField As String
        
        Private maxTemperatureCField As String
        
        Private minTemperatureCField As String
        
        '''<remarks/>
        Public Property Day() As String
            Get
                Return Me.dayField
            End Get
            Set
                Me.dayField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property WeatherImage() As String
            Get
                Return Me.weatherImageField
            End Get
            Set
                Me.weatherImageField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property MaxTemperatureF() As String
            Get
                Return Me.maxTemperatureFField
            End Get
            Set
                Me.maxTemperatureFField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property MinTemperatureF() As String
            Get
                Return Me.minTemperatureFField
            End Get
            Set
                Me.minTemperatureFField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property MaxTemperatureC() As String
            Get
                Return Me.maxTemperatureCField
            End Get
            Set
                Me.maxTemperatureCField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property MinTemperatureC() As String
            Get
                Return Me.minTemperatureCField
            End Get
            Set
                Me.minTemperatureCField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")>  _
    Public Delegate Sub GetWeatherByZipCodeCompletedEventHandler(ByVal sender As Object, ByVal e As GetWeatherByZipCodeCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetWeatherByZipCodeCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As WeatherForecasts
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),WeatherForecasts)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")>  _
    Public Delegate Sub GetWeatherByPlaceNameCompletedEventHandler(ByVal sender As Object, ByVal e As GetWeatherByPlaceNameCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetWeatherByPlaceNameCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As WeatherForecasts
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),WeatherForecasts)
            End Get
        End Property
    End Class
End Namespace