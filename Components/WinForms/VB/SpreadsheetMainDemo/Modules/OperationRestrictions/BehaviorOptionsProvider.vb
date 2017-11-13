Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports DevExpress.XtraSpreadsheet
Imports DevExpress.XtraSpreadsheet.Demos

Namespace DevExpress.Spreadsheet.Demos
	Public Class BehaviorOptionsProvider
		Private ReadOnly options As SpreadsheetBehaviorOptions
		Private ReadOnly clipboardOptionsProvider As SpreadsheetBehaviorClipboardOptionsProvider
		Private ReadOnly commonOptionsProvider As SpreadsheetBehaviorCommonOptionsProvider
		Private ReadOnly zoomOptionsProvider As SpreadsheetBehaviorZoomOptionsProvider
		Private ReadOnly miscellaneousOptionsProvider As SpreadsheetBehaviorMiscellaneousOptionsProvider

		Public Sub New(ByVal options As SpreadsheetBehaviorOptions)
			Me.options = options
			Me.clipboardOptionsProvider = New SpreadsheetBehaviorClipboardOptionsProvider(options)
			Me.commonOptionsProvider = New SpreadsheetBehaviorCommonOptionsProvider(options)
			Me.zoomOptionsProvider = New SpreadsheetBehaviorZoomOptionsProvider(options)
			Me.miscellaneousOptionsProvider = New SpreadsheetBehaviorMiscellaneousOptionsProvider(options)
		End Sub

		Public ReadOnly Property Clipboard() As SpreadsheetBehaviorClipboardOptionsProvider
			Get
				Return clipboardOptionsProvider
			End Get
		End Property
		Public ReadOnly Property Common() As SpreadsheetBehaviorCommonOptionsProvider
			Get
				Return commonOptionsProvider
			End Get
		End Property
		Public ReadOnly Property Zoom() As SpreadsheetBehaviorZoomOptionsProvider
			Get
				Return zoomOptionsProvider
			End Get
		End Property
		Public ReadOnly Property Worksheet() As SpreadsheetWorksheetBehaviorOptions
			Get
				Return options.Worksheet
			End Get
		End Property
		Public ReadOnly Property Comment() As SpreadsheetCommentBehaviorOptions
			Get
				Return options.Comment
			End Get
		End Property
		Public ReadOnly Property Column() As SpreadsheetColumnBehaviorOptions
			Get
				Return options.Column
			End Get
		End Property
		Public ReadOnly Property Group() As SpreadsheetGroupBehaviorOptions
			Get
				Return options.Group
			End Get
		End Property
		Public ReadOnly Property Row() As SpreadsheetRowBehaviorOptions
			Get
				Return options.Row
			End Get
		End Property
		Public ReadOnly Property Selection() As SpreadsheetSelectionOptions
			Get
				Return options.Selection
			End Get
		End Property
		Public ReadOnly Property Drawing() As SpreadsheetDrawingBehaviorOptions
			Get
				Return options.Drawing
			End Get
		End Property
		Public ReadOnly Property Miscellaneous() As SpreadsheetBehaviorMiscellaneousOptionsProvider
			Get
				Return miscellaneousOptionsProvider
			End Get
		End Property
	End Class

	<TypeConverter(GetType(ExpandableObjectConverter))> _
	Public Class SpreadsheetBehaviorClipboardOptionsProvider
		Private ReadOnly options As SpreadsheetBehaviorOptions

		Public Sub New(ByVal options As SpreadsheetBehaviorOptions)
			Me.options = options
		End Sub

		<DefaultValue(DocumentCapability.Default)> _
		Public Property Cut() As DocumentCapability
			Get
				Return options.Cut
			End Get
			Set(ByVal value As DocumentCapability)
				options.Cut = value
			End Set
		End Property
		<DefaultValue(DocumentCapability.Default)> _
		Public Property Copy() As DocumentCapability
			Get
				Return options.Copy
			End Get
			Set(ByVal value As DocumentCapability)
				options.Copy = value
			End Set
		End Property
		<DefaultValue(DocumentCapability.Default)> _
		Public Property Paste() As DocumentCapability
			Get
				Return options.Paste
			End Get
			Set(ByVal value As DocumentCapability)
				options.Paste = value
			End Set
		End Property

		Public Overrides Function ToString() As String
			Return String.Empty
		End Function
	End Class

	<TypeConverter(GetType(ExpandableObjectConverter))> _
	Public Class SpreadsheetBehaviorCommonOptionsProvider
		Private ReadOnly options As SpreadsheetBehaviorOptions

		Public Sub New(ByVal options As SpreadsheetBehaviorOptions)
			Me.options = options
		End Sub

		<DefaultValue(DocumentCapability.Default)> _
		Public Property Open() As DocumentCapability
			Get
				Return options.Open
			End Get
			Set(ByVal value As DocumentCapability)
				options.Open = value
			End Set
		End Property
		<DefaultValue(DocumentCapability.Default)> _
		Public Property Save() As DocumentCapability
			Get
				Return options.Save
			End Get
			Set(ByVal value As DocumentCapability)
				options.Save = value
			End Set
		End Property
		<DefaultValue(DocumentCapability.Default)> _
		Public Property SaveAs() As DocumentCapability
			Get
				Return options.SaveAs
			End Get
			Set(ByVal value As DocumentCapability)
				options.SaveAs = value
			End Set
		End Property
		<DefaultValue(DocumentCapability.Default)> _
		Public Property Print() As DocumentCapability
			Get
				Return options.Print
			End Get
			Set(ByVal value As DocumentCapability)
				options.Print = value
			End Set
		End Property
		<DefaultValue(DocumentCapability.Default)> _
		Public Property CreateNew() As DocumentCapability
			Get
				Return options.CreateNew
			End Get
			Set(ByVal value As DocumentCapability)
				options.CreateNew = value
			End Set
		End Property

		Public Overrides Function ToString() As String
			Return String.Empty
		End Function
	End Class

	<TypeConverter(GetType(ExpandableObjectConverter))> _
	Public Class SpreadsheetBehaviorZoomOptionsProvider
		Public Const MinZoomFactorDefault As Single = 0.5f
		Public Const MaxZoomFactorDefault As Single = 3
		Private ReadOnly options As SpreadsheetBehaviorOptions

		Public Sub New(ByVal options As SpreadsheetBehaviorOptions)
			Me.options = options
		End Sub

		<DefaultValue(DocumentCapability.Default)> _
		Public Property Zoom() As DocumentCapability
			Get
				Return options.Zooming
			End Get
			Set(ByVal value As DocumentCapability)
				options.Zooming = value
			End Set
		End Property
		<DefaultValue(MinZoomFactorDefault)> _
		Public Property MinZoomFactor() As Single
			Get
				Return options.MinZoomFactor
			End Get
			Set(ByVal value As Single)
				options.MinZoomFactor = value
			End Set
		End Property
		<DefaultValue(MaxZoomFactorDefault)> _
		Public Property MaxZoomFactor() As Single
			Get
				Return options.MaxZoomFactor
			End Get
			Set(ByVal value As Single)
				options.MaxZoomFactor = value
			End Set
		End Property

		Public Overrides Function ToString() As String
			Return String.Empty
		End Function
	End Class

	<TypeConverter(GetType(ExpandableObjectConverter))> _
	Public Class SpreadsheetBehaviorMiscellaneousOptionsProvider
		Private ReadOnly options As SpreadsheetBehaviorOptions

		Public Sub New(ByVal options As SpreadsheetBehaviorOptions)
			Me.options = options
		End Sub

		<DefaultValue(CellEditorCommitMode.Auto)> _
		Public Property CellEditorCommitMode() As CellEditorCommitMode
			Get
				Return options.CellEditor.CommitMode
			End Get
			Set(ByVal value As CellEditorCommitMode)
				options.CellEditor.CommitMode = value
			End Set
		End Property
		<DefaultValue(DocumentCapability.Default)> _
		Public Property FreezePanes() As DocumentCapability
			Get
				Return options.FreezePanes
			End Get
			Set(ByVal value As DocumentCapability)
				options.FreezePanes = value
			End Set
		End Property
		<DefaultValue(DocumentCapability.Default)> _
		Public Property ShowPopupMenu() As DocumentCapability
			Get
				Return options.ShowPopupMenu
			End Get
			Set(ByVal value As DocumentCapability)
				options.ShowPopupMenu = value
			End Set
		End Property
		<DefaultValue(DocumentCapability.Default)> _
		Public Property Touch() As DocumentCapability
			Get
				Return options.Touch
			End Get
			Set(ByVal value As DocumentCapability)
				options.Touch = value
			End Set
		End Property
		<DefaultValue(FunctionNameCulture.Auto)> _
		Public Property FunctionNameCulture() As FunctionNameCulture
			Get
				Return options.FunctionNameCulture
			End Get
			Set(ByVal value As FunctionNameCulture)
				options.FunctionNameCulture = value
			End Set
		End Property
		<DefaultValue(True)> _
		Public Property FillHandleEnabled() As Boolean
			Get
				Return options.FillHandle.Enabled
			End Get
			Set(ByVal value As Boolean)
				options.FillHandle.Enabled = value
			End Set
		End Property
		<DefaultValue(DocumentCapability.Default)> _
		Public Property Drag() As DocumentCapability
			Get
				Return options.Drag
			End Get
			Set(ByVal value As DocumentCapability)
				options.Drag = value
			End Set
		End Property
		<DefaultValue(DocumentCapability.Default)> _
		Public Property Drop() As DocumentCapability
			Get
				Return options.Drop
			End Get
			Set(ByVal value As DocumentCapability)
				options.Drop = value
			End Set
		End Property

		Public Overrides Function ToString() As String
			Return String.Empty
		End Function
	End Class
End Namespace
