﻿Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraReports.UI
Imports XtraReportsDemos
Imports System.IO

Namespace DevExpress.ProductsDemo.Win.Modules
    Partial Public Class ReportsModule
        Inherits BaseModule

        Shared Sub New()
            Dim path As String = DevExpress.Utils.FilesHelper.FindingFileName(AppDomain.CurrentDomain.BaseDirectory, "Data\nwind.mdb", False)
            ConnectionHelper.ApplyDataDirectory(System.IO.Path.GetDirectoryName(path))
        End Sub
        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Overrides Sub ShowModule(ByVal firstShow As Boolean)
            MyBase.ShowModule(firstShow)
            If firstShow Then
                reportDesigner1.ContainerControl = Me
                Dim report As XtraReport = New XtraReportsDemos.MasterDetailReport.Report()
                report.ReportPrintOptions.DetailCountAtDesignTime = 0
                For Each item As XtraReportBase In report.AllControls(Of XtraReportBase)()
                    item.ReportPrintOptions.DetailCountAtDesignTime = 0
                Next item
                reportDesigner1.OpenReport(report)
                MainRibbon.AutoHideEmptyItems = True
                MainRibbon.SelectedPage = MainRibbon.MergedPages.GetPageByText("VIEW")
                MainRibbon.SelectedPage = MainRibbon.MergedPages.GetPageByName(ribbonPagePreview.Name)
                Dim reportControl = TryCast(reportDesigner1.ActiveDesignPanel.GetService(GetType(DevExpress.XtraReports.Design.ReportTabControl)), DevExpress.XtraReports.Design.ReportTabControl)
                If reportControl Is Nothing OrElse reportControl.PreviewControl Is Nothing Then
                    Return
                End If
                Dim navigationDockPanel As DevExpress.XtraBars.Docking.DockPanel = reportControl.PreviewControl.DockManager.Panels(New System.Guid("6b2e64eb-afd0-4676-bc3d-eca7e99946aa"))
                If navigationDockPanel IsNot Nothing Then
                    navigationDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
                End If
                Return
            End If
            MainRibbon.SelectedPage = MainRibbon.MergedPages.GetPageByName(ribbonPagePreview.Name)
        End Sub

        Protected Overrides Property AutoMergeRibbon() As Boolean
            Get
                Return True
            End Get
            Set(ByVal value As Boolean)
                MyBase.AutoMergeRibbon = value
            End Set
        End Property
    End Class
End Namespace
