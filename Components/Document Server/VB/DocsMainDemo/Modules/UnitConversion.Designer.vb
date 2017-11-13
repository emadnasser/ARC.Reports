Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Docs.Demos
	Partial Public Class UnitConversion
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(UnitConversion))
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
			Me.seOunceMass = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl16 = New DevExpress.XtraEditors.LabelControl()
			Me.sePoundMass = New DevExpress.XtraEditors.SpinEdit()
			Me.seKilogram = New DevExpress.XtraEditors.SpinEdit()
			Me.seGram = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl11 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl12 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl13 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl14 = New DevExpress.XtraEditors.LabelControl()
			Me.xtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
			Me.seSquareMeter = New DevExpress.XtraEditors.SpinEdit()
			Me.seSquareFeet = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl23 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl24 = New DevExpress.XtraEditors.LabelControl()
			Me.seCentimeter = New DevExpress.XtraEditors.SpinEdit()
			Me.seCentimeterToFoot = New DevExpress.XtraEditors.SpinEdit()
			Me.seInch = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl20 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl21 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl22 = New DevExpress.XtraEditors.LabelControl()
			Me.seYard = New DevExpress.XtraEditors.SpinEdit()
			Me.seMeterToFoot = New DevExpress.XtraEditors.SpinEdit()
			Me.seMeter = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl8 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl18 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl19 = New DevExpress.XtraEditors.LabelControl()
			Me.seNauticalMile = New DevExpress.XtraEditors.SpinEdit()
			Me.seStatuteMile = New DevExpress.XtraEditors.SpinEdit()
			Me.seKilometer = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl9 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl10 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl15 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl17 = New DevExpress.XtraEditors.LabelControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.labelControl7 = New DevExpress.XtraEditors.LabelControl()
			Me.seMmOfMercury = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl6 = New DevExpress.XtraEditors.LabelControl()
			Me.seAtmosphere = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
			Me.seKilopascal = New DevExpress.XtraEditors.SpinEdit()
			Me.seKelvin = New DevExpress.XtraEditors.SpinEdit()
			Me.seFahrenheit = New DevExpress.XtraEditors.SpinEdit()
			Me.seCelsius = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.xtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
			Me.labelControl26 = New DevExpress.XtraEditors.LabelControl()
			Me.seWatt = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl27 = New DevExpress.XtraEditors.LabelControl()
			Me.seHorsepower = New DevExpress.XtraEditors.SpinEdit()
			Me.sePoundForce = New DevExpress.XtraEditors.SpinEdit()
			Me.seDyne = New DevExpress.XtraEditors.SpinEdit()
			Me.seNewton = New DevExpress.XtraEditors.SpinEdit()
			Me.labelControl28 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl29 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl30 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl31 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage2.SuspendLayout()
			CType(Me.seOunceMass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.sePoundMass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seKilogram.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seGram.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage3.SuspendLayout()
			CType(Me.seSquareMeter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seSquareFeet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seCentimeter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seCentimeterToFoot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seInch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seYard.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seMeterToFoot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seMeter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seNauticalMile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seStatuteMile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seKilometer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.seMmOfMercury.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seAtmosphere.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seKilopascal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seKelvin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seFahrenheit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seCelsius.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabPage4.SuspendLayout()
			CType(Me.seWatt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seHorsepower.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.sePoundForce.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seDyne.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.seNewton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			resources.ApplyResources(Me.xtraTabControl1, "xtraTabControl1")
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage2
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage2, Me.xtraTabPage3, Me.xtraTabPage1, Me.xtraTabPage4})
			' 
			' xtraTabPage2
			' 
			Me.xtraTabPage2.Controls.Add(Me.seOunceMass)
			Me.xtraTabPage2.Controls.Add(Me.labelControl16)
			Me.xtraTabPage2.Controls.Add(Me.sePoundMass)
			Me.xtraTabPage2.Controls.Add(Me.seKilogram)
			Me.xtraTabPage2.Controls.Add(Me.seGram)
			Me.xtraTabPage2.Controls.Add(Me.labelControl11)
			Me.xtraTabPage2.Controls.Add(Me.labelControl12)
			Me.xtraTabPage2.Controls.Add(Me.labelControl13)
			Me.xtraTabPage2.Controls.Add(Me.labelControl14)
			Me.xtraTabPage2.Name = "xtraTabPage2"
			resources.ApplyResources(Me.xtraTabPage2, "xtraTabPage2")
			' 
			' seOunceMass
			' 
			resources.ApplyResources(Me.seOunceMass, "seOunceMass")
			Me.seOunceMass.Name = "seOunceMass"
			Me.seOunceMass.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seOunceMass.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' labelControl16
			' 
			resources.ApplyResources(Me.labelControl16, "labelControl16")
			Me.labelControl16.Name = "labelControl16"
			' 
			' sePoundMass
			' 
			resources.ApplyResources(Me.sePoundMass, "sePoundMass")
			Me.sePoundMass.Name = "sePoundMass"
			Me.sePoundMass.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("sePoundMass.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' seKilogram
			' 
			resources.ApplyResources(Me.seKilogram, "seKilogram")
			Me.seKilogram.Name = "seKilogram"
			Me.seKilogram.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seKilogram.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' seGram
			' 
			resources.ApplyResources(Me.seGram, "seGram")
			Me.seGram.Name = "seGram"
			Me.seGram.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seGram.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' labelControl11
			' 
			resources.ApplyResources(Me.labelControl11, "labelControl11")
			Me.labelControl11.Name = "labelControl11"
			' 
			' labelControl12
			' 
			resources.ApplyResources(Me.labelControl12, "labelControl12")
			Me.labelControl12.Name = "labelControl12"
			' 
			' labelControl13
			' 
			resources.ApplyResources(Me.labelControl13, "labelControl13")
			Me.labelControl13.Name = "labelControl13"
			' 
			' labelControl14
			' 
			Me.labelControl14.Appearance.Font = (CType(resources.GetObject("labelControl14.Appearance.Font"), System.Drawing.Font))
			resources.ApplyResources(Me.labelControl14, "labelControl14")
			Me.labelControl14.Name = "labelControl14"
			' 
			' xtraTabPage3
			' 
			Me.xtraTabPage3.Controls.Add(Me.seSquareMeter)
			Me.xtraTabPage3.Controls.Add(Me.seSquareFeet)
			Me.xtraTabPage3.Controls.Add(Me.labelControl23)
			Me.xtraTabPage3.Controls.Add(Me.labelControl24)
			Me.xtraTabPage3.Controls.Add(Me.seCentimeter)
			Me.xtraTabPage3.Controls.Add(Me.seCentimeterToFoot)
			Me.xtraTabPage3.Controls.Add(Me.seInch)
			Me.xtraTabPage3.Controls.Add(Me.labelControl20)
			Me.xtraTabPage3.Controls.Add(Me.labelControl21)
			Me.xtraTabPage3.Controls.Add(Me.labelControl22)
			Me.xtraTabPage3.Controls.Add(Me.seYard)
			Me.xtraTabPage3.Controls.Add(Me.seMeterToFoot)
			Me.xtraTabPage3.Controls.Add(Me.seMeter)
			Me.xtraTabPage3.Controls.Add(Me.labelControl8)
			Me.xtraTabPage3.Controls.Add(Me.labelControl18)
			Me.xtraTabPage3.Controls.Add(Me.labelControl19)
			Me.xtraTabPage3.Controls.Add(Me.seNauticalMile)
			Me.xtraTabPage3.Controls.Add(Me.seStatuteMile)
			Me.xtraTabPage3.Controls.Add(Me.seKilometer)
			Me.xtraTabPage3.Controls.Add(Me.labelControl9)
			Me.xtraTabPage3.Controls.Add(Me.labelControl10)
			Me.xtraTabPage3.Controls.Add(Me.labelControl15)
			Me.xtraTabPage3.Controls.Add(Me.labelControl17)
			Me.xtraTabPage3.Name = "xtraTabPage3"
			resources.ApplyResources(Me.xtraTabPage3, "xtraTabPage3")
			' 
			' seSquareMeter
			' 
			resources.ApplyResources(Me.seSquareMeter, "seSquareMeter")
			Me.seSquareMeter.Name = "seSquareMeter"
			Me.seSquareMeter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seSquareMeter.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' seSquareFeet
			' 
			resources.ApplyResources(Me.seSquareFeet, "seSquareFeet")
			Me.seSquareFeet.Name = "seSquareFeet"
			Me.seSquareFeet.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seSquareFeet.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' labelControl23
			' 
			resources.ApplyResources(Me.labelControl23, "labelControl23")
			Me.labelControl23.Name = "labelControl23"
			' 
			' labelControl24
			' 
			resources.ApplyResources(Me.labelControl24, "labelControl24")
			Me.labelControl24.Name = "labelControl24"
			' 
			' seCentimeter
			' 
			resources.ApplyResources(Me.seCentimeter, "seCentimeter")
			Me.seCentimeter.Name = "seCentimeter"
			Me.seCentimeter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seCentimeter.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' seCentimeterToFoot
			' 
			resources.ApplyResources(Me.seCentimeterToFoot, "seCentimeterToFoot")
			Me.seCentimeterToFoot.Name = "seCentimeterToFoot"
			Me.seCentimeterToFoot.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seCentimeterToFoot.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' seInch
			' 
			resources.ApplyResources(Me.seInch, "seInch")
			Me.seInch.Name = "seInch"
			Me.seInch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seInch.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' labelControl20
			' 
			resources.ApplyResources(Me.labelControl20, "labelControl20")
			Me.labelControl20.Name = "labelControl20"
			' 
			' labelControl21
			' 
			resources.ApplyResources(Me.labelControl21, "labelControl21")
			Me.labelControl21.Name = "labelControl21"
			' 
			' labelControl22
			' 
			resources.ApplyResources(Me.labelControl22, "labelControl22")
			Me.labelControl22.Name = "labelControl22"
			' 
			' seYard
			' 
			resources.ApplyResources(Me.seYard, "seYard")
			Me.seYard.Name = "seYard"
			Me.seYard.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seYard.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' seMeterToFoot
			' 
			resources.ApplyResources(Me.seMeterToFoot, "seMeterToFoot")
			Me.seMeterToFoot.Name = "seMeterToFoot"
			Me.seMeterToFoot.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seMeterToFoot.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' seMeter
			' 
			resources.ApplyResources(Me.seMeter, "seMeter")
			Me.seMeter.Name = "seMeter"
			Me.seMeter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seMeter.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' labelControl8
			' 
			resources.ApplyResources(Me.labelControl8, "labelControl8")
			Me.labelControl8.Name = "labelControl8"
			' 
			' labelControl18
			' 
			resources.ApplyResources(Me.labelControl18, "labelControl18")
			Me.labelControl18.Name = "labelControl18"
			' 
			' labelControl19
			' 
			resources.ApplyResources(Me.labelControl19, "labelControl19")
			Me.labelControl19.Name = "labelControl19"
			' 
			' seNauticalMile
			' 
			resources.ApplyResources(Me.seNauticalMile, "seNauticalMile")
			Me.seNauticalMile.Name = "seNauticalMile"
			Me.seNauticalMile.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seNauticalMile.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' seStatuteMile
			' 
			resources.ApplyResources(Me.seStatuteMile, "seStatuteMile")
			Me.seStatuteMile.Name = "seStatuteMile"
			Me.seStatuteMile.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seStatuteMile.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' seKilometer
			' 
			resources.ApplyResources(Me.seKilometer, "seKilometer")
			Me.seKilometer.Name = "seKilometer"
			Me.seKilometer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seKilometer.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' labelControl9
			' 
			resources.ApplyResources(Me.labelControl9, "labelControl9")
			Me.labelControl9.Name = "labelControl9"
			' 
			' labelControl10
			' 
			resources.ApplyResources(Me.labelControl10, "labelControl10")
			Me.labelControl10.Name = "labelControl10"
			' 
			' labelControl15
			' 
			resources.ApplyResources(Me.labelControl15, "labelControl15")
			Me.labelControl15.Name = "labelControl15"
			' 
			' labelControl17
			' 
			Me.labelControl17.Appearance.Font = (CType(resources.GetObject("labelControl17.Appearance.Font"), System.Drawing.Font))
			resources.ApplyResources(Me.labelControl17, "labelControl17")
			Me.labelControl17.Name = "labelControl17"
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.labelControl7)
			Me.xtraTabPage1.Controls.Add(Me.seMmOfMercury)
			Me.xtraTabPage1.Controls.Add(Me.labelControl6)
			Me.xtraTabPage1.Controls.Add(Me.seAtmosphere)
			Me.xtraTabPage1.Controls.Add(Me.labelControl5)
			Me.xtraTabPage1.Controls.Add(Me.seKilopascal)
			Me.xtraTabPage1.Controls.Add(Me.seKelvin)
			Me.xtraTabPage1.Controls.Add(Me.seFahrenheit)
			Me.xtraTabPage1.Controls.Add(Me.seCelsius)
			Me.xtraTabPage1.Controls.Add(Me.labelControl4)
			Me.xtraTabPage1.Controls.Add(Me.labelControl3)
			Me.xtraTabPage1.Controls.Add(Me.labelControl2)
			Me.xtraTabPage1.Controls.Add(Me.labelControl1)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			resources.ApplyResources(Me.xtraTabPage1, "xtraTabPage1")
			' 
			' labelControl7
			' 
			resources.ApplyResources(Me.labelControl7, "labelControl7")
			Me.labelControl7.Name = "labelControl7"
			' 
			' seMmOfMercury
			' 
			resources.ApplyResources(Me.seMmOfMercury, "seMmOfMercury")
			Me.seMmOfMercury.Name = "seMmOfMercury"
			Me.seMmOfMercury.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seMmOfMercury.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' labelControl6
			' 
			resources.ApplyResources(Me.labelControl6, "labelControl6")
			Me.labelControl6.Name = "labelControl6"
			' 
			' seAtmosphere
			' 
			resources.ApplyResources(Me.seAtmosphere, "seAtmosphere")
			Me.seAtmosphere.Name = "seAtmosphere"
			Me.seAtmosphere.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seAtmosphere.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' labelControl5
			' 
			resources.ApplyResources(Me.labelControl5, "labelControl5")
			Me.labelControl5.Name = "labelControl5"
			' 
			' seKilopascal
			' 
			resources.ApplyResources(Me.seKilopascal, "seKilopascal")
			Me.seKilopascal.Name = "seKilopascal"
			Me.seKilopascal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seKilopascal.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' seKelvin
			' 
			resources.ApplyResources(Me.seKelvin, "seKelvin")
			Me.seKelvin.Name = "seKelvin"
			Me.seKelvin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seKelvin.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' seFahrenheit
			' 
			resources.ApplyResources(Me.seFahrenheit, "seFahrenheit")
			Me.seFahrenheit.Name = "seFahrenheit"
			Me.seFahrenheit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seFahrenheit.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' seCelsius
			' 
			resources.ApplyResources(Me.seCelsius, "seCelsius")
			Me.seCelsius.Name = "seCelsius"
			Me.seCelsius.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seCelsius.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' labelControl4
			' 
			resources.ApplyResources(Me.labelControl4, "labelControl4")
			Me.labelControl4.Name = "labelControl4"
			' 
			' labelControl3
			' 
			resources.ApplyResources(Me.labelControl3, "labelControl3")
			Me.labelControl3.Name = "labelControl3"
			' 
			' labelControl2
			' 
			resources.ApplyResources(Me.labelControl2, "labelControl2")
			Me.labelControl2.Name = "labelControl2"
			' 
			' labelControl1
			' 
			Me.labelControl1.Appearance.Font = (CType(resources.GetObject("labelControl1.Appearance.Font"), System.Drawing.Font))
			resources.ApplyResources(Me.labelControl1, "labelControl1")
			Me.labelControl1.Name = "labelControl1"
			' 
			' xtraTabPage4
			' 
			Me.xtraTabPage4.Controls.Add(Me.labelControl26)
			Me.xtraTabPage4.Controls.Add(Me.seWatt)
			Me.xtraTabPage4.Controls.Add(Me.labelControl27)
			Me.xtraTabPage4.Controls.Add(Me.seHorsepower)
			Me.xtraTabPage4.Controls.Add(Me.sePoundForce)
			Me.xtraTabPage4.Controls.Add(Me.seDyne)
			Me.xtraTabPage4.Controls.Add(Me.seNewton)
			Me.xtraTabPage4.Controls.Add(Me.labelControl28)
			Me.xtraTabPage4.Controls.Add(Me.labelControl29)
			Me.xtraTabPage4.Controls.Add(Me.labelControl30)
			Me.xtraTabPage4.Controls.Add(Me.labelControl31)
			Me.xtraTabPage4.Name = "xtraTabPage4"
			resources.ApplyResources(Me.xtraTabPage4, "xtraTabPage4")
			' 
			' labelControl26
			' 
			resources.ApplyResources(Me.labelControl26, "labelControl26")
			Me.labelControl26.Name = "labelControl26"
			' 
			' seWatt
			' 
			resources.ApplyResources(Me.seWatt, "seWatt")
			Me.seWatt.Name = "seWatt"
			Me.seWatt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seWatt.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' labelControl27
			' 
			resources.ApplyResources(Me.labelControl27, "labelControl27")
			Me.labelControl27.Name = "labelControl27"
			' 
			' seHorsepower
			' 
			resources.ApplyResources(Me.seHorsepower, "seHorsepower")
			Me.seHorsepower.Name = "seHorsepower"
			Me.seHorsepower.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seHorsepower.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' sePoundForce
			' 
			resources.ApplyResources(Me.sePoundForce, "sePoundForce")
			Me.sePoundForce.Name = "sePoundForce"
			Me.sePoundForce.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("sePoundForce.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' seDyne
			' 
			resources.ApplyResources(Me.seDyne, "seDyne")
			Me.seDyne.Name = "seDyne"
			Me.seDyne.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seDyne.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' seNewton
			' 
			resources.ApplyResources(Me.seNewton, "seNewton")
			Me.seNewton.Name = "seNewton"
			Me.seNewton.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("seNewton.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			' 
			' labelControl28
			' 
			resources.ApplyResources(Me.labelControl28, "labelControl28")
			Me.labelControl28.Name = "labelControl28"
			' 
			' labelControl29
			' 
			resources.ApplyResources(Me.labelControl29, "labelControl29")
			Me.labelControl29.Name = "labelControl29"
			' 
			' labelControl30
			' 
			resources.ApplyResources(Me.labelControl30, "labelControl30")
			Me.labelControl30.Name = "labelControl30"
			' 
			' labelControl31
			' 
			Me.labelControl31.Appearance.Font = (CType(resources.GetObject("labelControl31.Appearance.Font"), System.Drawing.Font))
			resources.ApplyResources(Me.labelControl31, "labelControl31")
			Me.labelControl31.Name = "labelControl31"
			' 
			' UnitConversion
			' 
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "UnitConversion"
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage2.ResumeLayout(False)
			Me.xtraTabPage2.PerformLayout()
			CType(Me.seOunceMass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.sePoundMass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seKilogram.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seGram.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage3.ResumeLayout(False)
			Me.xtraTabPage3.PerformLayout()
			CType(Me.seSquareMeter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seSquareFeet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seCentimeter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seCentimeterToFoot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seInch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seYard.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seMeterToFoot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seMeter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seNauticalMile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seStatuteMile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seKilometer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage1.ResumeLayout(False)
			Me.xtraTabPage1.PerformLayout()
			CType(Me.seMmOfMercury.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seAtmosphere.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seKilopascal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seKelvin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seFahrenheit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seCelsius.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabPage4.ResumeLayout(False)
			Me.xtraTabPage4.PerformLayout()
			CType(Me.seWatt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seHorsepower.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.sePoundForce.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seDyne.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.seNewton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private xtraTabControl1 As XtraTab.XtraTabControl
		Private xtraTabPage1 As XtraTab.XtraTabPage
		Private labelControl7 As XtraEditors.LabelControl
		Private seMmOfMercury As XtraEditors.SpinEdit
		Private labelControl6 As XtraEditors.LabelControl
		Private seAtmosphere As XtraEditors.SpinEdit
		Private labelControl5 As XtraEditors.LabelControl
		Private seKilopascal As XtraEditors.SpinEdit
		Private seKelvin As XtraEditors.SpinEdit
		Private seFahrenheit As XtraEditors.SpinEdit
		Private seCelsius As XtraEditors.SpinEdit
		Private labelControl4 As XtraEditors.LabelControl
		Private labelControl3 As XtraEditors.LabelControl
		Private labelControl2 As XtraEditors.LabelControl
		Private labelControl1 As XtraEditors.LabelControl
		Private xtraTabPage2 As XtraTab.XtraTabPage
		Private sePoundMass As XtraEditors.SpinEdit
		Private seKilogram As XtraEditors.SpinEdit
		Private seGram As XtraEditors.SpinEdit
		Private labelControl11 As XtraEditors.LabelControl
		Private labelControl12 As XtraEditors.LabelControl
		Private labelControl13 As XtraEditors.LabelControl
		Private labelControl14 As XtraEditors.LabelControl
		Private seOunceMass As XtraEditors.SpinEdit
		Private labelControl16 As XtraEditors.LabelControl
		Private xtraTabPage3 As XtraTab.XtraTabPage
		Private seNauticalMile As XtraEditors.SpinEdit
		Private seStatuteMile As XtraEditors.SpinEdit
		Private seKilometer As XtraEditors.SpinEdit
		Private labelControl9 As XtraEditors.LabelControl
		Private labelControl10 As XtraEditors.LabelControl
		Private labelControl15 As XtraEditors.LabelControl
		Private labelControl17 As XtraEditors.LabelControl
		Private xtraTabPage4 As XtraTab.XtraTabPage
		Private seSquareMeter As XtraEditors.SpinEdit
		Private seSquareFeet As XtraEditors.SpinEdit
		Private labelControl23 As XtraEditors.LabelControl
		Private labelControl24 As XtraEditors.LabelControl
		Private seCentimeter As XtraEditors.SpinEdit
		Private seCentimeterToFoot As XtraEditors.SpinEdit
		Private seInch As XtraEditors.SpinEdit
		Private labelControl20 As XtraEditors.LabelControl
		Private labelControl21 As XtraEditors.LabelControl
		Private labelControl22 As XtraEditors.LabelControl
		Private seYard As XtraEditors.SpinEdit
		Private seMeterToFoot As XtraEditors.SpinEdit
		Private seMeter As XtraEditors.SpinEdit
		Private labelControl8 As XtraEditors.LabelControl
		Private labelControl18 As XtraEditors.LabelControl
		Private labelControl19 As XtraEditors.LabelControl
		Private labelControl26 As XtraEditors.LabelControl
		Private seWatt As XtraEditors.SpinEdit
		Private labelControl27 As XtraEditors.LabelControl
		Private seHorsepower As XtraEditors.SpinEdit
		Private sePoundForce As XtraEditors.SpinEdit
		Private seDyne As XtraEditors.SpinEdit
		Private seNewton As XtraEditors.SpinEdit
		Private labelControl28 As XtraEditors.LabelControl
		Private labelControl29 As XtraEditors.LabelControl
		Private labelControl30 As XtraEditors.LabelControl
		Private labelControl31 As XtraEditors.LabelControl

	End Class
End Namespace
