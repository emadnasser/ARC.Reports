Namespace XtraReportsDemos.SideBySideReports
    Partial Public Class EmployeeComparisonReport
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim customSqlQuery1 As New DevExpress.DataAccess.Sql.CustomSqlQuery()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(EmployeeComparisonReport))
            Dim dynamicListLookUpSettings1 As New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
            Dim dynamicListLookUpSettings2 As New DevExpress.XtraReports.Parameters.DynamicListLookUpSettings()
            Me.dsEmployee1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrSubreport2 = New DevExpress.XtraReports.UI.XRSubreport()
            Me.rightSideParameter = New DevExpress.XtraReports.Parameters.Parameter()
            Me.xrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
            Me.leftSideParameter = New DevExpress.XtraReports.Parameters.Parameter()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.lbCaption = New DevExpress.XtraReports.UI.XRLabel()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrPictureBox4 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' dsEmployee1
            ' 
            Me.dsEmployee1.ConnectionName = "NWindConnectionString"
            Me.dsEmployee1.Name = "dsEmployee1"
            customSqlQuery1.Name = "SimpleEmployees"
            customSqlQuery1.Sql = "SELECT EmployeeID, FirstName || ' ' || LastName AS FullName FROM Employees"
            Me.dsEmployee1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { customSqlQuery1})
            Me.dsEmployee1.ResultSchemaSerializable = resources.GetString("dsEmployee1.ResultSchemaSerializable")
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrSubreport2, Me.xrSubreport1})
            Me.Detail.HeightF = 375F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrSubreport2
            ' 
            Me.xrSubreport2.LocationFloat = New DevExpress.Utils.PointFloat(332F, 0F)
            Me.xrSubreport2.Name = "xrSubreport2"
            Me.xrSubreport2.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramEmployeeID", Me.rightSideParameter))
            Me.xrSubreport2.ReportSource = New XtraReportsDemos.SideBySideReports.EmployeeOrdersReport()
            Me.xrSubreport2.SizeF = New System.Drawing.SizeF(318F, 375F)
            ' 
            ' rightSideParameter
            ' 
            Me.rightSideParameter.Description = "Right Side:"
            dynamicListLookUpSettings1.DataAdapter = Nothing
            dynamicListLookUpSettings1.DataMember = "SimpleEmployees"
            dynamicListLookUpSettings1.DataSource = Me.dsEmployee1
            dynamicListLookUpSettings1.DisplayMember = "FullName"
            dynamicListLookUpSettings1.FilterString = "[EmployeeID] <> ?leftSideParameter"
            dynamicListLookUpSettings1.ValueMember = "EmployeeID"
            Me.rightSideParameter.LookUpSettings = dynamicListLookUpSettings1
            Me.rightSideParameter.Name = "rightSideParameter"
            Me.rightSideParameter.Type = GetType(Long)
            Me.rightSideParameter.ValueInfo = "9"
            ' 
            ' xrSubreport1
            ' 
            Me.xrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrSubreport1.Name = "xrSubreport1"
            Me.xrSubreport1.ParameterBindings.Add(New DevExpress.XtraReports.UI.ParameterBinding("paramEmployeeID", Me.leftSideParameter))
            Me.xrSubreport1.ReportSource = New XtraReportsDemos.SideBySideReports.EmployeeOrdersReport()
            Me.xrSubreport1.SizeF = New System.Drawing.SizeF(318F, 375F)
            ' 
            ' leftSideParameter
            ' 
            Me.leftSideParameter.Description = "Left Side:"
            dynamicListLookUpSettings2.DataAdapter = Nothing
            dynamicListLookUpSettings2.DataMember = "SimpleEmployees"
            dynamicListLookUpSettings2.DataSource = Me.dsEmployee1
            dynamicListLookUpSettings2.DisplayMember = "FullName"
            dynamicListLookUpSettings2.FilterString = Nothing
            dynamicListLookUpSettings2.ValueMember = "EmployeeID"
            Me.leftSideParameter.LookUpSettings = dynamicListLookUpSettings2
            Me.leftSideParameter.Name = "leftSideParameter"
            Me.leftSideParameter.Type = GetType(Long)
            Me.leftSideParameter.ValueInfo = "5"
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbCaption})
            Me.ReportHeader.HeightF = 75F
            Me.ReportHeader.Name = "ReportHeader"
            Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' lbCaption
            ' 
            Me.lbCaption.BackColor = System.Drawing.Color.Transparent
            Me.lbCaption.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.lbCaption.BorderWidth = 2F
            Me.lbCaption.Font = New System.Drawing.Font("Tahoma", 20.25F)
            Me.lbCaption.ForeColor = System.Drawing.Color.Black
            Me.lbCaption.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.lbCaption.Name = "lbCaption"
            Me.lbCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.lbCaption.SizeF = New System.Drawing.SizeF(650F, 50F)
            Me.lbCaption.Text = "Employee Comparison"
            Me.lbCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBox4})
            Me.BottomMargin.HeightF = 75F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPictureBox4
            ' 
            Me.xrPictureBox4.Image = (CType(resources.GetObject("xrPictureBox4.Image"), System.Drawing.Image))
            Me.xrPictureBox4.LocationFloat = New DevExpress.Utils.PointFloat(249F, 22F)
            Me.xrPictureBox4.Name = "xrPictureBox4"
            Me.xrPictureBox4.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/"
            Me.xrPictureBox4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrPictureBox4.SizeF = New System.Drawing.SizeF(165.625F, 30.20833F)
            Me.xrPictureBox4.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 100F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' EmployeeComparisonReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.ReportHeader, Me.BottomMargin, Me.topMarginBand1})
            Me.Margins = New System.Drawing.Printing.Margins(100, 100, 100, 75)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.leftSideParameter, Me.rightSideParameter})
            Me.RequestParameters = False
            Me.Version = "16.1"
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Public xrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
        Public xrSubreport2 As DevExpress.XtraReports.UI.XRSubreport
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Friend xrPictureBox4 As DevExpress.XtraReports.UI.XRPictureBox
        Private lbCaption As DevExpress.XtraReports.UI.XRLabel
        Private leftSideParameter As DevExpress.XtraReports.Parameters.Parameter
        Private rightSideParameter As DevExpress.XtraReports.Parameters.Parameter
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
        Private dsEmployee1 As DevExpress.DataAccess.Sql.SqlDataSource
    End Class
End Namespace
