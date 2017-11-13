Imports DevExpress.Mvvm
Imports System.Collections.Generic
Imports System

Namespace DevExpress.DevAV.Services
'    using IServiceContainer = DevExpress.Mvvm.IServiceContainer

    Public Interface IModuleLocator
        Function IsModuleLoaded(ByVal moduleType As ModuleType) As Boolean
        Function GetModule(ByVal moduleType As ModuleType) As Object
        Function CreateModule(ByVal moduleType As ModuleType) As Object
        Function GetModule(ByVal moduleType As ModuleType, ByVal viewModel As Object) As Object
        Function GetModule(ByVal moduleType As ModuleType, ByVal keyParameter As Long) As Object
        Sub ReleaseModule(ByVal [module] As Object)
    End Interface
    Public Interface IReportLocator
        Function GetReport(ByVal reportKey As Object) As Object
        Sub ReleaseReport(ByVal reportKey As Object)
    End Interface
    Friend Class ModuleLocator
        Implements IModuleLocator

        Private serviceContainer As DevExpress.Mvvm.IServiceContainer
        Private modulesCache As IDictionary(Of ModuleType, WeakReference)
        Private modulesIdentityCache As IDictionary(Of ModuleType, IDictionary(Of Long, WeakReference))
        Public Sub New(ByVal serviceContainer As DevExpress.Mvvm.IServiceContainer)
            Me.serviceContainer = serviceContainer
            Me.modulesCache = New Dictionary(Of ModuleType, WeakReference)()
            Me.modulesIdentityCache = New Dictionary(Of ModuleType, IDictionary(Of Long, WeakReference))()
        End Sub
        Public Function IsModuleLoaded(ByVal moduleType As ModuleType) As Boolean Implements IModuleLocator.IsModuleLoaded
            Return modulesCache.ContainsKey(moduleType)
        End Function
        Public Function CreateModule(ByVal moduleType As ModuleType) As Object Implements IModuleLocator.CreateModule
            Dim activator = serviceContainer.GetService(Of IModuleActivator)()
            Dim resolver = serviceContainer.GetService(Of IModuleTypesResolver)()
            Return activator.CreateModule(resolver.GetTypeName(moduleType))
        End Function
        Public Function GetModule(ByVal moduleType As ModuleType, ByVal keyParameter As Long) As Object Implements IModuleLocator.GetModule
            If moduleType = DevExpress.DevAV.ModuleType.Unknown Then
                Return Nothing
            End If
            Dim activator = serviceContainer.GetService(Of IModuleActivator)()
            Dim identityCache As IDictionary(Of Long, WeakReference) = Nothing
            If Not modulesIdentityCache.TryGetValue(moduleType, identityCache) Then
                identityCache = New Dictionary(Of Long, WeakReference)()
                modulesIdentityCache.Add(moduleType, identityCache)
            End If
            Return GetModuleCore(identityCache, keyParameter, moduleType, Function(moduleTypeName, parameter) activator.CreateModule(moduleTypeName), Nothing)
        End Function
        Public Function GetModule(ByVal moduleType As ModuleType, ByVal viewModel As Object) As Object Implements IModuleLocator.GetModule
            If moduleType = DevExpress.DevAV.ModuleType.Unknown Then
                Return Nothing
            End If
            Dim activator = serviceContainer.GetService(Of IModuleActivator)()
            Return GetModuleCore(modulesCache, moduleType, Function(moduleTypeName, parameter) activator.CreateModule(moduleTypeName, parameter), viewModel)
        End Function
        Public Function GetModule(ByVal moduleType As ModuleType) As Object Implements IModuleLocator.GetModule
            If moduleType = DevExpress.DevAV.ModuleType.Unknown Then
                Return Nothing
            End If
            Dim activator = serviceContainer.GetService(Of IModuleActivator)()
            Return GetModuleCore(modulesCache, moduleType, Function(moduleTypeName, parameter) activator.CreateModule(moduleTypeName), Nothing)
        End Function
        Public Sub ReleaseModule(ByVal [module] As Object) Implements IModuleLocator.ReleaseModule
            ClearCore(modulesCache, [module])
            For Each item In modulesIdentityCache
                ClearCore(item.Value, [module])
            Next item
        End Sub
        Private Function GetModuleCore(ByVal cache As IDictionary(Of ModuleType, WeakReference), ByVal moduleType As ModuleType, ByVal activatorRoutine As Func(Of String, Object, Object), ByVal parameter As Object) As Object
            Return GetModuleCore(cache, moduleType, moduleType, activatorRoutine, parameter)
        End Function
        Private Function GetModuleCore(Of TKey)(ByVal cache As IDictionary(Of TKey, WeakReference), ByVal key As TKey, ByVal moduleType As ModuleType, ByVal activatorRoutine As Func(Of String, Object, Object), ByVal parameter As Object) As Object
            Dim moduleReference As WeakReference = Nothing
            If (Not cache.TryGetValue(key, moduleReference)) OrElse moduleReference.Target Is Nothing Then
                Dim resolver = serviceContainer.GetService(Of IModuleTypesResolver)()
                Dim [module] = activatorRoutine(resolver.GetTypeName(moduleType), parameter)
                If moduleReference Is Nothing Then
                    moduleReference = New WeakReference([module])
                    cache.Add(key, moduleReference)
                Else
                    moduleReference.Target = [module]
                End If
            End If
            Return moduleReference.Target
        End Function
        Private Sub ClearCore(Of TKey)(ByVal cache As IDictionary(Of TKey, WeakReference), ByVal [module] As Object)
            Dim key As TKey = Nothing
            For Each item In cache
                If Not Object.Equals(item.Value.Target, [module]) Then
                    Continue For
                End If
                key = item.Key
                Exit For
            Next item
            cache.Remove(key)
        End Sub
    End Class
    Friend Class ReportLocator
        Implements IReportLocator

        Private serviceContainer As DevExpress.Mvvm.IServiceContainer
        Private reportsCache As IDictionary(Of Object, WeakReference)
        Public Sub New(ByVal serviceContainer As DevExpress.Mvvm.IServiceContainer)
            Me.serviceContainer = serviceContainer
            Me.reportsCache = New Dictionary(Of Object, WeakReference)()
        End Sub
        Public Function GetReport(ByVal reportKey As Object) As Object Implements IReportLocator.GetReport
            If Object.ReferenceEquals(reportKey, Nothing) Then
                Return Nothing
            End If
            Dim reportReference As WeakReference = Nothing
            If (Not reportsCache.TryGetValue(reportKey, reportReference)) OrElse reportReference.Target Is Nothing Then
                Dim activator = serviceContainer.GetService(Of IReportActivator)()
                Dim report = activator.CreateReport(reportKey)
                If reportReference Is Nothing Then
                    reportReference = New WeakReference(report)
                    reportsCache.Add(reportKey, reportReference)
                Else
                    reportReference.Target = report
                End If
            End If
            Return reportReference.Target
        End Function
        Public Sub ReleaseReport(ByVal reportKey As Object) Implements IReportLocator.ReleaseReport
            If Object.ReferenceEquals(reportKey, Nothing) Then
                Return
            End If
            Dim report As WeakReference = Nothing
            If reportsCache.TryGetValue(reportKey, report) Then
                reportsCache.Remove(reportKey)
                Dim disposable As IDisposable = TryCast(report.Target, IDisposable)
                If disposable IsNot Nothing Then
                    disposable.Dispose()
                End If
            End If
        End Sub
    End Class
End Namespace
