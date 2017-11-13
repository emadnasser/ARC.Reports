Namespace XtraReportsDemos.CharacterComb
    Partial Public Class Report
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
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrPanel2 = New DevExpress.XtraReports.UI.XRPanel()
            Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrCheckBox2 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.xrCheckBox1 = New DevExpress.XtraReports.UI.XRCheckBox()
            Me.ccBirthYear = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.ccBirthMonth = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ccBirthDay = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.ccVisaNo = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ccPassportNo = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ccFlightNo = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.ccNationality = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ccFirstName = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ccLastName = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ccAddress = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLine2 = New DevExpress.XtraReports.UI.XRLine()
            Me.ccDay = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.ccMonth = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.ccYear = New DevExpress.XtraReports.UI.XRCharacterComb()
            Me.xrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.labelStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.characterCombStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.xrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPanel2, Me.xrLabel16, Me.xrLabel15, Me.xrLabel14, Me.xrCheckBox2, Me.xrCheckBox1, Me.ccBirthYear, Me.ccBirthMonth, Me.xrLabel11, Me.ccBirthDay, Me.ccVisaNo, Me.xrLabel9, Me.ccPassportNo, Me.xrLabel8, Me.ccFlightNo, Me.ccNationality, Me.xrLabel7, Me.xrLabel5, Me.ccFirstName, Me.xrLabel4, Me.ccLastName, Me.xrLabel3, Me.ccAddress, Me.xrLabel6, Me.xrLabel2, Me.xrLine2})
            Me.Detail.Dpi = 100F
            Me.Detail.HeightF = 253.3149F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPanel2
            ' 
            Me.xrPanel2.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(87)))), (CInt((CByte(141)))))
            Me.xrPanel2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel10})
            Me.xrPanel2.Dpi = 100F
            Me.xrPanel2.LocationFloat = New DevExpress.Utils.PointFloat(666.2203F, 76.07526F)
            Me.xrPanel2.Name = "xrPanel2"
            Me.xrPanel2.SizeF = New System.Drawing.SizeF(183.7795F, 177.2396F)
            Me.xrPanel2.StyleName = "characterCombStyle"
            Me.xrPanel2.StylePriority.UseBorderColor = False
            ' 
            ' xrLabel10
            ' 
            Me.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.xrLabel10.Dpi = 100F
            Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(2.000072F, 1.999996F)
            Me.xrLabel10.Name = "xrLabel10"
            Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel10.SizeF = New System.Drawing.SizeF(179.5F, 22.00007F)
            Me.xrLabel10.StyleName = "labelStyle"
            Me.xrLabel10.StylePriority.UseBorders = False
            Me.xrLabel10.StylePriority.UseFont = False
            Me.xrLabel10.StylePriority.UseForeColor = False
            Me.xrLabel10.StylePriority.UseTextAlignment = False
            Me.xrLabel10.Text = "For official use"
            Me.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            ' 
            ' xrLabel16
            ' 
            Me.xrLabel16.Dpi = 100F
            Me.xrLabel16.Font = New System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(470.5003F, 149F)
            Me.xrLabel16.Name = "xrLabel16"
            Me.xrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F)
            Me.xrLabel16.SizeF = New System.Drawing.SizeF(40.49988F, 14.00011F)
            Me.xrLabel16.StyleName = "labelStyle"
            Me.xrLabel16.StylePriority.UseFont = False
            Me.xrLabel16.StylePriority.UsePadding = False
            Me.xrLabel16.StylePriority.UseTextAlignment = False
            Me.xrLabel16.Text = "Day"
            Me.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrLabel15
            ' 
            Me.xrLabel15.Dpi = 100F
            Me.xrLabel15.Font = New System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(518.0001F, 149F)
            Me.xrLabel15.Name = "xrLabel15"
            Me.xrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F)
            Me.xrLabel15.SizeF = New System.Drawing.SizeF(40.99997F, 14.00012F)
            Me.xrLabel15.StyleName = "labelStyle"
            Me.xrLabel15.StylePriority.UseFont = False
            Me.xrLabel15.StylePriority.UsePadding = False
            Me.xrLabel15.StylePriority.UseTextAlignment = False
            Me.xrLabel15.Text = "Month"
            Me.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrLabel14
            ' 
            Me.xrLabel14.Dpi = 100F
            Me.xrLabel14.Font = New System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(566.0001F, 149F)
            Me.xrLabel14.Name = "xrLabel14"
            Me.xrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F)
            Me.xrLabel14.SizeF = New System.Drawing.SizeF(82.99988F, 14.00014F)
            Me.xrLabel14.StyleName = "labelStyle"
            Me.xrLabel14.StylePriority.UseFont = False
            Me.xrLabel14.StylePriority.UsePadding = False
            Me.xrLabel14.StylePriority.UseTextAlignment = False
            Me.xrLabel14.Text = "Year"
            Me.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            ' 
            ' xrCheckBox2
            ' 
            Me.xrCheckBox2.Dpi = 100F
            Me.xrCheckBox2.EditOptions.Enabled = True
            Me.xrCheckBox2.EditOptions.GroupID = "Gender"
            Me.xrCheckBox2.LocationFloat = New DevExpress.Utils.PointFloat(494F, 95.00008F)
            Me.xrCheckBox2.Name = "xrCheckBox2"
            Me.xrCheckBox2.SizeF = New System.Drawing.SizeF(58F, 21.99998F)
            Me.xrCheckBox2.StyleName = "labelStyle"
            Me.xrCheckBox2.StylePriority.UseFont = False
            Me.xrCheckBox2.StylePriority.UseTextAlignment = False
            Me.xrCheckBox2.Text = "Female"
            ' 
            ' xrCheckBox1
            ' 
            Me.xrCheckBox1.Dpi = 100F
            Me.xrCheckBox1.EditOptions.Enabled = True
            Me.xrCheckBox1.EditOptions.GroupID = "Gender"
            Me.xrCheckBox1.LocationFloat = New DevExpress.Utils.PointFloat(439.5F, 95.00006F)
            Me.xrCheckBox1.Name = "xrCheckBox1"
            Me.xrCheckBox1.SizeF = New System.Drawing.SizeF(51.49997F, 22F)
            Me.xrCheckBox1.StyleName = "labelStyle"
            Me.xrCheckBox1.StylePriority.UseFont = False
            Me.xrCheckBox1.StylePriority.UseTextAlignment = False
            Me.xrCheckBox1.Text = "Male"
            ' 
            ' ccBirthYear
            ' 
            Me.ccBirthYear.CanShrink = True
            Me.ccBirthYear.CellHeight = 22F
            Me.ccBirthYear.CellHorizontalSpacing = 1F
            Me.ccBirthYear.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccBirthYear.CellWidth = 20F
            Me.ccBirthYear.Dpi = 100F
            Me.ccBirthYear.EditOptions.EditorName = "IntegerPositive"
            Me.ccBirthYear.EditOptions.Enabled = True
            Me.ccBirthYear.LocationFloat = New DevExpress.Utils.PointFloat(566F, 127F)
            Me.ccBirthYear.Name = "ccBirthYear"
            Me.ccBirthYear.SizeF = New System.Drawing.SizeF(83F, 22.00002F)
            Me.ccBirthYear.StyleName = "characterCombStyle"
            Me.ccBirthYear.StylePriority.UseBackColor = False
            Me.ccBirthYear.WordWrap = False
            ' 
            ' ccBirthMonth
            ' 
            Me.ccBirthMonth.CanShrink = True
            Me.ccBirthMonth.CellHeight = 22F
            Me.ccBirthMonth.CellHorizontalSpacing = 1F
            Me.ccBirthMonth.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccBirthMonth.CellWidth = 20F
            Me.ccBirthMonth.Dpi = 100F
            Me.ccBirthMonth.EditOptions.EditorName = "IntegerPositive"
            Me.ccBirthMonth.EditOptions.Enabled = True
            Me.ccBirthMonth.LocationFloat = New DevExpress.Utils.PointFloat(518.0001F, 127F)
            Me.ccBirthMonth.Name = "ccBirthMonth"
            Me.ccBirthMonth.SizeF = New System.Drawing.SizeF(40.99997F, 22.00002F)
            Me.ccBirthMonth.StyleName = "characterCombStyle"
            Me.ccBirthMonth.StylePriority.UseBackColor = False
            Me.ccBirthMonth.WordWrap = False
            ' 
            ' xrLabel11
            ' 
            Me.xrLabel11.Dpi = 100F
            Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(399.5001F, 127F)
            Me.xrLabel11.Name = "xrLabel11"
            Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel11.SizeF = New System.Drawing.SizeF(67.5F, 21.99998F)
            Me.xrLabel11.StyleName = "labelStyle"
            Me.xrLabel11.Text = "Date of Birth"
            ' 
            ' ccBirthDay
            ' 
            Me.ccBirthDay.CanShrink = True
            Me.ccBirthDay.CellHeight = 22F
            Me.ccBirthDay.CellHorizontalSpacing = 1F
            Me.ccBirthDay.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccBirthDay.CellWidth = 20F
            Me.ccBirthDay.Dpi = 100F
            Me.ccBirthDay.EditOptions.EditorName = "IntegerPositive"
            Me.ccBirthDay.EditOptions.Enabled = True
            Me.ccBirthDay.LocationFloat = New DevExpress.Utils.PointFloat(470.0002F, 127F)
            Me.ccBirthDay.Name = "ccBirthDay"
            Me.ccBirthDay.SizeF = New System.Drawing.SizeF(41F, 22.00002F)
            Me.ccBirthDay.StyleName = "characterCombStyle"
            Me.ccBirthDay.StylePriority.UseBackColor = False
            Me.ccBirthDay.WordWrap = False
            ' 
            ' ccVisaNo
            ' 
            Me.ccVisaNo.CanShrink = True
            Me.ccVisaNo.CellHeight = 22F
            Me.ccVisaNo.CellHorizontalSpacing = 1F
            Me.ccVisaNo.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccVisaNo.CellWidth = 20F
            Me.ccVisaNo.Dpi = 100F
            Me.ccVisaNo.EditOptions.EditorName = "IntegerPositive"
            Me.ccVisaNo.EditOptions.Enabled = True
            Me.ccVisaNo.LocationFloat = New DevExpress.Utils.PointFloat(82.5F, 159F)
            Me.ccVisaNo.Name = "ccVisaNo"
            Me.ccVisaNo.SizeF = New System.Drawing.SizeF(314.5F, 21.99998F)
            Me.ccVisaNo.StyleName = "characterCombStyle"
            Me.ccVisaNo.StylePriority.UseBackColor = False
            Me.ccVisaNo.StylePriority.UseBorders = False
            Me.ccVisaNo.WordWrap = False
            ' 
            ' xrLabel9
            ' 
            Me.xrLabel9.Dpi = 100F
            Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(10.3657F, 159F)
            Me.xrLabel9.Name = "xrLabel9"
            Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel9.SizeF = New System.Drawing.SizeF(68.63419F, 22.00003F)
            Me.xrLabel9.StyleName = "labelStyle"
            Me.xrLabel9.Text = "Visa No."
            ' 
            ' ccPassportNo
            ' 
            Me.ccPassportNo.CanShrink = True
            Me.ccPassportNo.CellHeight = 22F
            Me.ccPassportNo.CellHorizontalSpacing = 1F
            Me.ccPassportNo.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccPassportNo.CellWidth = 20F
            Me.ccPassportNo.Dpi = 100F
            Me.ccPassportNo.EditOptions.EditorName = "IntegerPositive"
            Me.ccPassportNo.EditOptions.Enabled = True
            Me.ccPassportNo.LocationFloat = New DevExpress.Utils.PointFloat(82.50001F, 127F)
            Me.ccPassportNo.Name = "ccPassportNo"
            Me.ccPassportNo.SizeF = New System.Drawing.SizeF(272.5001F, 22F)
            Me.ccPassportNo.StyleName = "characterCombStyle"
            Me.ccPassportNo.StylePriority.UseBackColor = False
            Me.ccPassportNo.WordWrap = False
            ' 
            ' xrLabel8
            ' 
            Me.xrLabel8.Dpi = 100F
            Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(10.3657F, 127F)
            Me.xrLabel8.Name = "xrLabel8"
            Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel8.SizeF = New System.Drawing.SizeF(68.63428F, 22.00002F)
            Me.xrLabel8.StyleName = "labelStyle"
            Me.xrLabel8.Text = "Passport No."
            ' 
            ' ccFlightNo
            ' 
            Me.ccFlightNo.CanShrink = True
            Me.ccFlightNo.CellHeight = 22F
            Me.ccFlightNo.CellHorizontalSpacing = 1F
            Me.ccFlightNo.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccFlightNo.CellWidth = 20F
            Me.ccFlightNo.Dpi = 100F
            Me.ccFlightNo.EditOptions.EditorName = "NumbersAndUppercaseLetters"
            Me.ccFlightNo.EditOptions.Enabled = True
            Me.ccFlightNo.LocationFloat = New DevExpress.Utils.PointFloat(574.5F, 33.00013F)
            Me.ccFlightNo.Name = "ccFlightNo"
            Me.ccFlightNo.SizeF = New System.Drawing.SizeF(251.5001F, 22F)
            Me.ccFlightNo.StyleName = "characterCombStyle"
            Me.ccFlightNo.StylePriority.UseBackColor = False
            Me.ccFlightNo.WordWrap = False
            ' 
            ' ccNationality
            ' 
            Me.ccNationality.CanShrink = True
            Me.ccNationality.CellHeight = 22F
            Me.ccNationality.CellHorizontalSpacing = 1F
            Me.ccNationality.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccNationality.CellWidth = 20F
            Me.ccNationality.Dpi = 100F
            Me.ccNationality.EditOptions.EditorName = "OnlyUppercaseLetters"
            Me.ccNationality.EditOptions.Enabled = True
            Me.ccNationality.LocationFloat = New DevExpress.Utils.PointFloat(82.5F, 95.00001F)
            Me.ccNationality.Name = "ccNationality"
            Me.ccNationality.SizeF = New System.Drawing.SizeF(314.5F, 21.99997F)
            Me.ccNationality.StyleName = "characterCombStyle"
            Me.ccNationality.StylePriority.UseBackColor = False
            Me.ccNationality.WordWrap = False
            ' 
            ' xrLabel7
            ' 
            Me.xrLabel7.Dpi = 100F
            Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(515.5F, 33.00004F)
            Me.xrLabel7.Name = "xrLabel7"
            Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel7.SizeF = New System.Drawing.SizeF(56.13419F, 22.00008F)
            Me.xrLabel7.StyleName = "labelStyle"
            Me.xrLabel7.Text = "Flight No."
            ' 
            ' xrLabel5
            ' 
            Me.xrLabel5.Dpi = 100F
            Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(9.999914F, 95F)
            Me.xrLabel5.Name = "xrLabel5"
            Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel5.SizeF = New System.Drawing.SizeF(68.99998F, 22.00006F)
            Me.xrLabel5.StyleName = "labelStyle"
            Me.xrLabel5.Text = "Nationality"
            ' 
            ' ccFirstName
            ' 
            Me.ccFirstName.CanShrink = True
            Me.ccFirstName.CellHeight = 22F
            Me.ccFirstName.CellHorizontalSpacing = 1F
            Me.ccFirstName.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccFirstName.CellWidth = 20F
            Me.ccFirstName.Dpi = 100F
            Me.ccFirstName.EditOptions.EditorName = "Name"
            Me.ccFirstName.EditOptions.Enabled = True
            Me.ccFirstName.LocationFloat = New DevExpress.Utils.PointFloat(82.49992F, 65F)
            Me.ccFirstName.Name = "ccFirstName"
            Me.ccFirstName.SizeF = New System.Drawing.SizeF(419.6342F, 22F)
            Me.ccFirstName.StyleName = "characterCombStyle"
            Me.ccFirstName.StylePriority.UseBackColor = False
            Me.ccFirstName.WordWrap = False
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.Dpi = 100F
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 65F)
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(68.99997F, 22.00006F)
            Me.xrLabel4.StyleName = "labelStyle"
            Me.xrLabel4.Text = "First Name"
            ' 
            ' ccLastName
            ' 
            Me.ccLastName.CanShrink = True
            Me.ccLastName.CellHeight = 22F
            Me.ccLastName.CellHorizontalSpacing = 1F
            Me.ccLastName.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccLastName.CellWidth = 20F
            Me.ccLastName.Dpi = 100F
            Me.ccLastName.EditOptions.EditorName = "Name"
            Me.ccLastName.EditOptions.Enabled = True
            Me.ccLastName.LocationFloat = New DevExpress.Utils.PointFloat(82.49992F, 33.00013F)
            Me.ccLastName.Name = "ccLastName"
            Me.ccLastName.SizeF = New System.Drawing.SizeF(419.6342F, 22F)
            Me.ccLastName.StyleName = "characterCombStyle"
            Me.ccLastName.StylePriority.UseBackColor = False
            Me.ccLastName.WordWrap = False
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.Dpi = 100F
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(9.999973F, 33.0001F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(68.99998F, 22.00002F)
            Me.xrLabel3.StyleName = "labelStyle"
            Me.xrLabel3.Text = "Last Name"
            ' 
            ' ccAddress
            ' 
            Me.ccAddress.CellHeight = 22F
            Me.ccAddress.CellHorizontalSpacing = 1F
            Me.ccAddress.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccAddress.CellVerticalSpacing = 3F
            Me.ccAddress.CellWidth = 20F
            Me.ccAddress.Dpi = 100F
            Me.ccAddress.EditOptions.EditorName = "UppercaseText"
            Me.ccAddress.EditOptions.Enabled = True
            Me.ccAddress.LocationFloat = New DevExpress.Utils.PointFloat(82.5F, 191F)
            Me.ccAddress.Multiline = True
            Me.ccAddress.Name = "ccAddress"
            Me.ccAddress.SizeF = New System.Drawing.SizeF(566.5F, 47.00002F)
            Me.ccAddress.StyleName = "characterCombStyle"
            Me.ccAddress.StylePriority.UseBackColor = False
            Me.ccAddress.StylePriority.UseBorders = False
            Me.ccAddress.StylePriority.UseTextAlignment = False
            Me.ccAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel6
            ' 
            Me.xrLabel6.Dpi = 100F
            Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(9.999996F, 191F)
            Me.xrLabel6.Name = "xrLabel6"
            Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel6.SizeF = New System.Drawing.SizeF(68.99989F, 22.00006F)
            Me.xrLabel6.StyleName = "labelStyle"
            Me.xrLabel6.Text = "Address"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.AnchorHorizontal = (CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles))
            Me.xrLabel2.Dpi = 100F
            Me.xrLabel2.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(9.99981F, 0F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(830.0002F, 22.5F)
            Me.xrLabel2.StyleName = "labelStyle"
            Me.xrLabel2.StylePriority.UseFont = False
            Me.xrLabel2.StylePriority.UsePadding = False
            Me.xrLabel2.StylePriority.UseTextAlignment = False
            Me.xrLabel2.Text = "PLEASE WRITE CLEARLY IN BLOCK CAPITAL LETTERS AND USE TICK BOXES WHERE APPLICABLE" & ""
            Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrLine2
            ' 
            Me.xrLine2.AnchorHorizontal = (CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles))
            Me.xrLine2.Dpi = 100F
            Me.xrLine2.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(87)))), (CInt((CByte(141)))))
            Me.xrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 251F)
            Me.xrLine2.Name = "xrLine2"
            Me.xrLine2.SizeF = New System.Drawing.SizeF(666.2203F, 2.314865F)
            Me.xrLine2.StylePriority.UseForeColor = False
            ' 
            ' ccDay
            ' 
            Me.ccDay.CanShrink = True
            Me.ccDay.CellHeight = 22F
            Me.ccDay.CellHorizontalSpacing = 1F
            Me.ccDay.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccDay.CellWidth = 20F
            Me.ccDay.Dpi = 100F
            Me.ccDay.LocationFloat = New DevExpress.Utils.PointFloat(584.0001F, 13.00003F)
            Me.ccDay.Name = "ccDay"
            Me.ccDay.SizeF = New System.Drawing.SizeF(41F, 22.00005F)
            Me.ccDay.StyleName = "characterCombStyle"
            Me.ccDay.StylePriority.UseBackColor = False
            Me.ccDay.StylePriority.UseBorders = False
            Me.ccDay.WordWrap = False
            ' 
            ' ccMonth
            ' 
            Me.ccMonth.CanShrink = True
            Me.ccMonth.CellHeight = 22F
            Me.ccMonth.CellHorizontalSpacing = 1F
            Me.ccMonth.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccMonth.CellWidth = 20F
            Me.ccMonth.Dpi = 100F
            Me.ccMonth.LocationFloat = New DevExpress.Utils.PointFloat(668.0002F, 13.00007F)
            Me.ccMonth.Name = "ccMonth"
            Me.ccMonth.SizeF = New System.Drawing.SizeF(41F, 22.00002F)
            Me.ccMonth.StyleName = "characterCombStyle"
            Me.ccMonth.StylePriority.UseBackColor = False
            Me.ccMonth.WordWrap = False
            ' 
            ' ccYear
            ' 
            Me.ccYear.CanShrink = True
            Me.ccYear.CellHeight = 22F
            Me.ccYear.CellHorizontalSpacing = 1F
            Me.ccYear.CellSizeMode = DevExpress.XtraPrinting.SizeMode.Custom
            Me.ccYear.CellWidth = 20F
            Me.ccYear.Dpi = 100F
            Me.ccYear.LocationFloat = New DevExpress.Utils.PointFloat(743.0001F, 13.00007F)
            Me.ccYear.Name = "ccYear"
            Me.ccYear.SizeF = New System.Drawing.SizeF(83F, 22.00002F)
            Me.ccYear.StyleName = "characterCombStyle"
            Me.ccYear.StylePriority.UseBackColor = False
            Me.ccYear.WordWrap = False
            ' 
            ' xrLabel13
            ' 
            Me.xrLabel13.Dpi = 100F
            Me.xrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(715F, 13.00007F)
            Me.xrLabel13.Name = "xrLabel13"
            Me.xrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F)
            Me.xrLabel13.SizeF = New System.Drawing.SizeF(28.00006F, 22.00002F)
            Me.xrLabel13.StyleName = "labelStyle"
            Me.xrLabel13.StylePriority.UsePadding = False
            Me.xrLabel13.StylePriority.UseTextAlignment = False
            Me.xrLabel13.Text = "Year"
            Me.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' xrLabel17
            ' 
            Me.xrLabel17.Dpi = 100F
            Me.xrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(630.4999F, 13.00007F)
            Me.xrLabel17.Name = "xrLabel17"
            Me.xrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F)
            Me.xrLabel17.SizeF = New System.Drawing.SizeF(37.50006F, 22.00002F)
            Me.xrLabel17.StyleName = "labelStyle"
            Me.xrLabel17.StylePriority.UsePadding = False
            Me.xrLabel17.StylePriority.UseTextAlignment = False
            Me.xrLabel17.Text = "Month"
            Me.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' xrLabel18
            ' 
            Me.xrLabel18.Dpi = 100F
            Me.xrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(559.5001F, 13.00023F)
            Me.xrLabel18.Name = "xrLabel18"
            Me.xrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100F)
            Me.xrLabel18.SizeF = New System.Drawing.SizeF(24.50006F, 21.99984F)
            Me.xrLabel18.StyleName = "labelStyle"
            Me.xrLabel18.StylePriority.UsePadding = False
            Me.xrLabel18.StylePriority.UseTextAlignment = False
            Me.xrLabel18.Text = "Day"
            Me.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' xrLabel12
            ' 
            Me.xrLabel12.Dpi = 100F
            Me.xrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(9.999811F, 13F)
            Me.xrLabel12.Name = "xrLabel12"
            Me.xrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel12.SizeF = New System.Drawing.SizeF(71.00008F, 22.00008F)
            Me.xrLabel12.StyleName = "labelStyle"
            Me.xrLabel12.StylePriority.UseBorders = False
            Me.xrLabel12.StylePriority.UseFont = False
            Me.xrLabel12.StylePriority.UseForeColor = False
            Me.xrLabel12.StylePriority.UseTextAlignment = False
            Me.xrLabel12.Text = "Signature"
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Dpi = 100F
            Me.TopMargin.HeightF = 0F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.StylePriority.UseTextAlignment = False
            Me.TopMargin.Visible = False
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Dpi = 100F
            Me.BottomMargin.HeightF = 0F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.AnchorHorizontal = (CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles))
            Me.xrLabel1.Dpi = 100F
            Me.xrLabel1.Font = New System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrLabel1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(87)))), (CInt((CByte(141)))))
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(9.999811F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(830.0002F, 51.5F)
            Me.xrLabel1.StylePriority.UseBackColor = False
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.StylePriority.UsePadding = False
            Me.xrLabel1.StylePriority.UseTextAlignment = False
            Me.xrLabel1.Text = "Arrival Card"
            Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
            ' 
            ' ReportHeader
            ' 
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine1, Me.xrLabel1})
            Me.ReportHeader.Dpi = 100F
            Me.ReportHeader.HeightF = 58.99997F
            Me.ReportHeader.Name = "ReportHeader"
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.AnchorHorizontal = (CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles))
            Me.xrLine1.Dpi = 100F
            Me.xrLine1.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(87)))), (CInt((CByte(141)))))
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 51.5F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.SizeF = New System.Drawing.SizeF(849.9999F, 7.499977F)
            Me.xrLine1.StylePriority.UseForeColor = False
            ' 
            ' labelStyle
            ' 
            Me.labelStyle.Font = New System.Drawing.Font("Tahoma", 7.25F)
            Me.labelStyle.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(87)))), (CInt((CByte(141)))))
            Me.labelStyle.Name = "labelStyle"
            Me.labelStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            ' 
            ' characterCombStyle
            ' 
            Me.characterCombStyle.BorderColor = System.Drawing.SystemColors.ActiveCaption
            Me.characterCombStyle.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.characterCombStyle.BorderWidth = 1F
            Me.characterCombStyle.Font = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.characterCombStyle.ForeColor = System.Drawing.Color.Black
            Me.characterCombStyle.Name = "characterCombStyle"
            ' 
            ' ReportFooter
            ' 
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel18, Me.xrLabel17, Me.xrLabel13, Me.ccYear, Me.ccMonth, Me.ccDay, Me.xrLabel12, Me.xrLabel19})
            Me.ReportFooter.Dpi = 100F
            Me.ReportFooter.HeightF = 47.49902F
            Me.ReportFooter.Name = "ReportFooter"
            ' 
            ' xrLabel19
            ' 
            Me.xrLabel19.BackColor = System.Drawing.Color.White
            Me.xrLabel19.Dpi = 100F
            Me.xrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(84.49992F, 10F)
            Me.xrLabel19.Name = "xrLabel19"
            Me.xrLabel19.SizeF = New System.Drawing.SizeF(443.5F, 30.00006F)
            Me.xrLabel19.StyleName = "characterCombStyle"
            Me.xrLabel19.StylePriority.UseBackColor = False
            Me.xrLabel19.StylePriority.UseBorderColor = False
            Me.xrLabel19.StylePriority.UseBorders = False
            Me.xrLabel19.StylePriority.UseBorderWidth = False
            ' 
            ' Report
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter})
            Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
            Me.PageHeight = 366
            Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
            Me.SnappingMode = (CType((DevExpress.XtraReports.UI.SnappingMode.SnapLines Or DevExpress.XtraReports.UI.SnappingMode.SnapToGrid), DevExpress.XtraReports.UI.SnappingMode))
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.labelStyle, Me.characterCombStyle})
            Me.Version = "16.2"
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private ccLastName As DevExpress.XtraReports.UI.XRCharacterComb
        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
        Private labelStyle As DevExpress.XtraReports.UI.XRControlStyle
        Private xrCheckBox2 As DevExpress.XtraReports.UI.XRCheckBox
        Private xrCheckBox1 As DevExpress.XtraReports.UI.XRCheckBox
        Private ccBirthYear As DevExpress.XtraReports.UI.XRCharacterComb
        Private ccBirthMonth As DevExpress.XtraReports.UI.XRCharacterComb
        Private xrLabel11 As DevExpress.XtraReports.UI.XRLabel
        Private ccBirthDay As DevExpress.XtraReports.UI.XRCharacterComb
        Private ccVisaNo As DevExpress.XtraReports.UI.XRCharacterComb
        Private xrLabel9 As DevExpress.XtraReports.UI.XRLabel
        Private ccPassportNo As DevExpress.XtraReports.UI.XRCharacterComb
        Private xrLabel8 As DevExpress.XtraReports.UI.XRLabel
        Private ccFlightNo As DevExpress.XtraReports.UI.XRCharacterComb
        Private ccAddress As DevExpress.XtraReports.UI.XRCharacterComb
        Private ccNationality As DevExpress.XtraReports.UI.XRCharacterComb
        Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
        Private ccFirstName As DevExpress.XtraReports.UI.XRCharacterComb
        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel12 As DevExpress.XtraReports.UI.XRLabel
        Private ccDay As DevExpress.XtraReports.UI.XRCharacterComb
        Private ccMonth As DevExpress.XtraReports.UI.XRCharacterComb
        Private ccYear As DevExpress.XtraReports.UI.XRCharacterComb
        Private xrLabel13 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel17 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel18 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel16 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel15 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel14 As DevExpress.XtraReports.UI.XRLabel
        Private characterCombStyle As DevExpress.XtraReports.UI.XRControlStyle
        Private WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
        Private xrLabel19 As DevExpress.XtraReports.UI.XRLabel
        Private xrLine1 As DevExpress.XtraReports.UI.XRLine
        Private xrPanel2 As DevExpress.XtraReports.UI.XRPanel
        Private xrLabel10 As DevExpress.XtraReports.UI.XRLabel
        Private xrLine2 As DevExpress.XtraReports.UI.XRLine
    End Class
End Namespace
