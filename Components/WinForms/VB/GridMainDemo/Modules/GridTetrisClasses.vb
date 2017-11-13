Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.BandedGrid

Namespace DevExpress.XtraGrid.Demos
	Public Class Row
		Private n As Integer = 0
		Public Shared ReadOnly Property RowDetermination() As Integer
			Get
				Return 1024
			End Get
		End Property
		Public Shared Function IsValue(ByVal val As Integer, ByVal pos As Integer) As Boolean
			Return (val And 1 << pos) <> 0
		End Function
		Private Function IsUnit(ByVal val As Integer, ByVal pos As Integer) As Integer
			Return If(IsValue(val, pos), 1, 0)
		End Function
		Public Sub New(ByVal val As Integer)
			n = val
		End Sub
		Public Sub SetValue(ByVal val As Integer)
			n = val
		End Sub
		Friend ReadOnly Property Val() As Integer
			Get
				Return n
			End Get
		End Property

		Public ReadOnly Property R00() As Boolean
			Get
				Return IsValue(n, 0)
			End Get
		End Property
		Public ReadOnly Property R01() As Boolean
			Get
				Return IsValue(n, 1)
			End Get
		End Property
		Public ReadOnly Property R02() As Boolean
			Get
				Return IsValue(n, 2)
			End Get
		End Property
		Public ReadOnly Property R03() As Boolean
			Get
				Return IsValue(n, 3)
			End Get
		End Property
		Public ReadOnly Property R04() As Boolean
			Get
				Return IsValue(n, 4)
			End Get
		End Property
		Public ReadOnly Property R05() As Boolean
			Get
				Return IsValue(n, 5)
			End Get
		End Property
		Public ReadOnly Property R06() As Boolean
			Get
				Return IsValue(n, 6)
			End Get
		End Property
		Public ReadOnly Property R07() As Boolean
			Get
				Return IsValue(n, 7)
			End Get
		End Property
		Public ReadOnly Property R08() As Boolean
			Get
				Return IsValue(n, 8)
			End Get
		End Property
		Public ReadOnly Property R09() As Boolean
			Get
				Return IsValue(n, 9)
			End Get
		End Property
		Public ReadOnly Property R10() As Boolean
			Get
				Return IsValue(n, 10)
			End Get
		End Property
	End Class

	Public Class MyCollection
		Inherits CollectionBase
		Implements IBindingList
		Friend Shared rows As Integer = 22
		#Region "IBindingList"
		Public Sub Add(ByVal record As Row)
			MyBase.List.Add(record)
		End Sub
		Default Public ReadOnly Property Item(ByVal idx As Integer) As Row
			Get
				Return CType(MyBase.List(idx), Row)
			End Get
		End Property

		Public Function IndexOf(ByVal record As Row) As Integer
			Return List.IndexOf(record)
		End Function

		Public Function AddNew() As Object Implements IBindingList.AddNew
			Dim record As New Row(0)
			List.Add(record)
			Return record
		End Function
		Public ReadOnly Property AllowEdit() As Boolean Implements IBindingList.AllowEdit
			Get
				Return True
			End Get
		End Property
		Public ReadOnly Property AllowNew() As Boolean Implements IBindingList.AllowNew
			Get
				Return True
			End Get
		End Property
		Public ReadOnly Property AllowRemove() As Boolean Implements IBindingList.AllowRemove
			Get
				Return True
			End Get
		End Property

		Private Event listChangedHandler As ListChangedEventHandler
		Public Custom Event ListChanged As ListChangedEventHandler Implements IBindingList.ListChanged
			AddHandler(ByVal value As ListChangedEventHandler)
				AddHandler listChangedHandler, value
			End AddHandler
			RemoveHandler(ByVal value As ListChangedEventHandler)
				RemoveHandler listChangedHandler, value
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.ComponentModel.ListChangedEventArgs)
			End RaiseEvent
		End Event
		Friend Sub OnListChanged(ByVal args As ListChangedEventArgs)
			RaiseEvent listChangedHandler(Me, args)
		End Sub
		Protected Overrides Sub OnRemoveComplete(ByVal index As Integer, ByVal value As Object)
			OnListChanged(New ListChangedEventArgs(ListChangedType.ItemDeleted, index))
		End Sub
		Protected Overrides Sub OnInsertComplete(ByVal index As Integer, ByVal value As Object)
			OnListChanged(New ListChangedEventArgs(ListChangedType.ItemAdded, index))
		End Sub

		Public Sub AddIndex(ByVal pd As PropertyDescriptor) Implements IBindingList.AddIndex
			Throw New NotSupportedException()
		End Sub
		Public Sub ApplySort(ByVal pd As PropertyDescriptor, ByVal dir As ListSortDirection) Implements IBindingList.ApplySort
			Throw New NotSupportedException()
		End Sub
		Public Function Find(ByVal [property] As PropertyDescriptor, ByVal key As Object) As Integer Implements IBindingList.Find
			Throw New NotSupportedException()
		End Function
		Public ReadOnly Property IsSorted() As Boolean Implements IBindingList.IsSorted
			Get
				Return False
			End Get
		End Property
		Public Sub RemoveIndex(ByVal pd As PropertyDescriptor) Implements IBindingList.RemoveIndex
			Throw New NotSupportedException()
		End Sub
		Public Sub RemoveSort() Implements IBindingList.RemoveSort
			Throw New NotSupportedException()
		End Sub
		Public ReadOnly Property SortDirection() As ListSortDirection Implements IBindingList.SortDirection
			Get
				Throw New NotSupportedException()
			End Get
		End Property
		Public ReadOnly Property SortProperty() As PropertyDescriptor Implements IBindingList.SortProperty
			Get
				Throw New NotSupportedException()
			End Get
		End Property
		Public ReadOnly Property SupportsChangeNotification() As Boolean Implements IBindingList.SupportsChangeNotification
			Get
				Return True
			End Get
		End Property
		Public ReadOnly Property SupportsSearching() As Boolean Implements IBindingList.SupportsSearching
			Get
				Return False
			End Get
		End Property
		Public ReadOnly Property SupportsSorting() As Boolean Implements IBindingList.SupportsSorting
			Get
				Return False
			End Get
		End Property
		#End Region
		#Region "Collection methods"
		Public Sub Assign(ByVal fCollection As MyCollection)
			Me.Init()
			For i As Integer = 0 To fCollection.Count - 1
				Me(i).SetValue(fCollection(i).Val)
			Next i
		End Sub
		Public Sub Invalidate()
			Me.OnListChanged(New ListChangedEventArgs(ListChangedType.Reset, 0))
		End Sub
		Public Sub Init()
			Me.Clear()
			For i As Integer = 0 To rows - 1
				Me.Add(New Row(0))
			Next i
		End Sub
		Public Sub RemoveAndShiftAt(ByVal i As Integer)
			For j As Integer = i To 1 Step -1
				Me(j).SetValue(Me(j - 1).Val)
			Next j
			OnRemoveRow(New EventArgs())
		End Sub
		Private Event removeRowHandler As EventHandler
		Public Custom Event RemoveRow As EventHandler
			AddHandler(ByVal value As EventHandler)
				AddHandler removeRowHandler, value
			End AddHandler
			RemoveHandler(ByVal value As EventHandler)
				RemoveHandler removeRowHandler, value
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
			End RaiseEvent
		End Event
		Friend Sub OnRemoveRow(ByVal args As EventArgs)
			RaiseEvent removeRowHandler(Me, args)
		End Sub
		#End Region
	End Class
	Public Class Figures
		#Region "Static fFigures"
		Private Shared fFigures() As Integer = { 1, 7, 0, 0, 4, 7, 0, 0, 2, 7, 0, 0, 3, 6, 0, 0, 6, 3, 0, 0, 6, 6, 0, 0, 15, 0, 0, 0, 5, 7, 0, 0, 2, 7, 2, 0, 2, 2, 7, 0, 7, 4, 4, 0, 1, 7, 4, 0, 4, 4, 6, 0, 6, 4, 4, 0, 2, 3, 2, 0, 4, 6, 2, 0, 2, 6, 4, 0, 6, 6, 0, 0, 4, 4, 4, 4, 6, 4, 6, 0, 2, 7, 2, 0, 4, 7, 4, 0, 7, 1, 1, 0, 6, 2, 3, 0, 7, 4, 0, 0, 7, 1, 0, 0, 7, 2, 0, 0, 3, 6, 0, 0, 6, 3, 0, 0, 6, 6, 0, 0, 15, 0, 0, 0, 7, 5, 0, 0, 2, 7, 2, 0, 7, 2, 2, 0, 1, 1, 7, 0, 4, 7, 1, 0, 6, 2, 2, 0, 2, 2, 6, 0, 2, 6, 2, 0, 4, 6, 2, 0, 2, 6, 4, 0, 6, 6, 0, 0, 4, 4, 4, 4, 3, 1, 3, 0, 2, 7, 2, 0, 1, 7, 1, 0, 4, 4, 7, 0, 3, 2, 6, 0}
		Public Shared ReadOnly Property FiguresNum() As Integer
			Get
				Return 12
			End Get
		End Property
		Private Shared Function GetFigure(ByVal num As Integer, ByVal fRotate As Integer) As Integer()
			Dim i As Integer = num * 4 + fRotate * FiguresNum * 4
			Return New Integer() { fFigures(i), fFigures(i + 1), fFigures(i + 2), fFigures(i + 3) }
		End Function
		Public Shared Function GetFigure(ByVal num As Integer) As Integer()
			Return GetFigure(num, 0)
		End Function
		Public Shared Function GetFigure(ByVal num As Integer, ByVal oldRotate As Integer, ByVal fRotate As Integer, ByVal first As Integer) As Integer()
            Dim dx As Integer = first \ GetFigure(num, oldRotate)(0)
			If dx = 0 Then
				dx = 1
			End If
			Dim ret() As Integer = GetFigure(num, fRotate)
			For i As Integer = 0 To ret.Length - 1
				ret(i) = ret(i) * dx
			Next i
			Return ret
		End Function
		#End Region
	End Class

	Public Class Figure
		#Region "Private fields"
		Private fRow As Integer
		Private fRotate As Integer
		Private num As Integer
		Private fEnd As Boolean = False
		Private fFigure(), oldFigure() As Integer
		Private fCollection As MyCollection
		Private master As New MyCollection()
		#End Region
		Public Sub New(ByVal num As Integer, ByVal fCollection As MyCollection)
			fRow = 0
			fRotate = 0
			oldFigure = New Integer() {0}
			Me.fCollection = fCollection
			master.Assign(fCollection)
			Me.num = num
			fFigure = Figures.GetFigure(num)
			For i As Integer = 0 To fFigure.Length - 1
				fFigure(i) = fFigure(i) * 16
			Next i
			oldFigure = fFigure
			If WrongFigure(fFigure) Then
				fEnd = True
			End If
			SetToCollection(fFigure)
		End Sub
		#Region "Checking"
		Public ReadOnly Property EndOf() As Boolean
			Get
				Return fEnd
			End Get
		End Property
		Private Function WrongFigure(ByVal a() As Integer) As Boolean
			For i As Integer = 0 To a.Length - 1
				If (fRow + (If(a(i) > 0, i, 0)) > fCollection.Count - 1) OrElse (a(i) > 0 AndAlso (a(i) And master(fRow + i).Val) <> 0) OrElse a(i) > 2 * Row.RowDetermination - 1 Then
					Return True
				End If
			Next i
			Return False
		End Function
		Private Function FirstColumn(ByVal a() As Integer) As Boolean
			For i As Integer = 0 To a.Length - 1
				If (a(i) > 0 AndAlso (a(i) And Row.RowDetermination) <> 0) OrElse (a(i) > 0 AndAlso (a(i) << 1 And master(fRow + i).Val) <> 0) Then
					Return True
				End If
			Next i
			Return False
		End Function
		Private Function LastColumn(ByVal a() As Integer) As Boolean
			For i As Integer = 0 To a.Length - 1
				If (a(i) > 0 AndAlso (a(i) And 1) <> 0) OrElse (a(i) > 0 AndAlso (a(i) >> 1 And master(fRow + i).Val) <> 0) Then
					Return True
				End If
			Next i
			Return False
		End Function
		Public Function LastRow() As Boolean
			Return LastRow(fFigure)
		End Function
		Private Function LastRow(ByVal a() As Integer) As Boolean
			For i As Integer = a.Length - 1 To 0 Step -1
				If (fRow + (If(a(i) > 0, i, 0)) > fCollection.Count - 2) OrElse (a(i) > 0 AndAlso (master(fRow + i + 1).Val And a(i)) <> 0) Then
					Return True
				End If
			Next i
			Return False
		End Function
		#End Region
		#Region "Actions"
		Private Property RotateStep() As Integer
			Get
				Return fRotate
			End Get
			Set(ByVal value As Integer)
				If value > 3 Then
					value = 0
				End If
				If value < 0 Then
					value = 3
				End If
				Dim a() As Integer = Figures.GetFigure(num, fRotate, value, fFigure(0))
				If a IsNot Nothing AndAlso (Not WrongFigure(a)) Then
					fFigure = a
					UnSetFromCollection(oldFigure)
					oldFigure = fFigure
					fRotate = value
					SetToCollection(fFigure)
				End If
			End Set
		End Property
		Public Sub GoLeft()
			If FirstColumn(fFigure) Then
				Return
			End If
			UnSetFromCollection(oldFigure)
			oldFigure = fFigure
			For i As Integer = 0 To fFigure.Length - 1
				fFigure(i) = fFigure(i) * 2
			Next i
			SetToCollection(fFigure)
		End Sub
		Public Sub GoRight()
			If LastColumn(fFigure) Then
				Return
			End If
			UnSetFromCollection(oldFigure)
			oldFigure = fFigure
			For i As Integer = 0 To fFigure.Length - 1
                fFigure(i) = fFigure(i) \ 2
			Next i
			SetToCollection(fFigure)
		End Sub
		Public Sub GoBottom(ByVal invalidate As Boolean)
			Do
				If LastRow(fFigure) Then
					Exit Do
				End If

				UnSetFromCollection(oldFigure)
				fRow += 1
				SetToCollection(fFigure, invalidate)
			Loop
			fCollection.Invalidate()
		End Sub
		Public Sub GoBottom()
			If LastRow(fFigure) Then
				Return
			End If
			UnSetFromCollection(oldFigure)
			fRow += 1
			SetToCollection(fFigure)
		End Sub
		Public Sub GoTop()
			If fRow = 0 Then
				Return
			End If
			UnSetFromCollection(oldFigure)
			fRow -= 1
			SetToCollection(fFigure)
		End Sub
		Public Sub Rotate()
			Rotate(True)
		End Sub
		Public Sub Rotate(ByVal toRight As Boolean)
			If toRight Then
				RotateStep += 1
				Else
					RotateStep -= 1
				End If
		End Sub
		#End Region
		#Region "Collection modernization"
		Public Sub DeleteTotalRows()
			For i As Integer = fCollection.Count - 1 To 0 Step -1
				If fCollection(i).Val = 2 * Row.RowDetermination - 1 Then
					fCollection.RemoveAndShiftAt(i)
					i += 1
				End If
			Next i
		End Sub
		Private Sub UnSetFromCollection(ByVal a() As Integer)
			For i As Integer = 0 To a.Length - 1
				If a(i) <> 0 Then
					fCollection(fRow + i).SetValue(fCollection(fRow + i).Val - a(i))
				End If
			Next i
		End Sub
		Private Sub SetToCollection(ByVal a() As Integer)
			SetToCollection(a, True)
		End Sub
		Private Sub SetToCollection(ByVal a() As Integer, ByVal invalidate As Boolean)
			For i As Integer = 0 To a.Length - 1
				If a(i) <> 0 Then
					fCollection(fRow + i).SetValue(fCollection(fRow + i).Val + a(i))
				End If
			Next i
			If invalidate Then
				fCollection.Invalidate()
			End If
		End Sub
		#End Region
	End Class

	Public Class ColumnHelper
		Public Shared Sub AddColumns(ByVal band As GridBand, ByVal num As Integer)
			Dim c As BandedGridColumn = Nothing
			band.View.BeginUpdate()
			Try
				For i As Integer = num To 0 Step -1
					c = TryCast(band.View.Columns.AddField(String.Format("R{0:00}", i)), BandedGridColumn)
					c.MinWidth = 10
					band.Columns.Add(c)
					c.VisibleIndex = num - i
				Next i
				Dim width As Integer = band.View.GridControl.Width \ num
				For Each col As BandedGridColumn In band.View.Columns
					col.Width = width
				Next col
			Finally
				band.View.EndUpdate()
			End Try
		End Sub
	End Class

	Public Class TetrisGame
		#Region "Private fields "
		Private fPrevCollection As ArrayList
		Private fCollection As MyCollection = Nothing
		Private fFigure As Figure = Nothing
		Private rnd As New Random(System.Environment.TickCount)
		Private fFigures As Integer = 0
		Private fRow As Integer = 0
		Private fScore As Integer = 0
		Private fLevel As Integer = 0
		Private nextFigure As Integer = 0
		Private Const oneFigure As Integer = 5
		Private Const oneRow As Integer = 100
		Private Const changeLevelCriterion As Integer = 33
		Private levelColors() As Color = {Color.SteelBlue, Color.Green, Color.Red, Color.DarkBlue, Color.DarkGoldenrod, Color.Chocolate, Color.Black}
		Private levelPens() As Pen = {Pens.SteelBlue, Pens.Green, Pens.Red, Pens.DarkBlue, Pens.DarkGoldenrod, Pens.Chocolate, Pens.Black}
		#End Region
		#Region "Init"
		Public Sub New()
			fCollection = New MyCollection()
			AddHandler fCollection.RemoveRow, AddressOf removeRow
			fPrevCollection = New ArrayList()
			For i As Integer = 0 To 3
				fPrevCollection.Add(New Row(0))
			Next i
		End Sub
		Public Sub Init()
			nextFigure = rnd.Next(FiguresCount)
			fFigures = 0
			Level = 0
			Score = 0
			TRow = 0
			Collection.Init()
		End Sub
		#End Region
		#Region "Public properties"
		Public Property TRow() As Integer
			Get
				Return fRow
			End Get
			Set(ByVal value As Integer)
				fRow = value
			End Set
		End Property
		Public ReadOnly Property Collection() As MyCollection
			Get
				Return fCollection
			End Get
		End Property
		Public ReadOnly Property PrevCollection() As ArrayList
			Get
				Return fPrevCollection
			End Get
		End Property
		Public ReadOnly Property Figure() As Figure
			Get
				Return fFigure
			End Get
		End Property
		Public Property FiguresNum() As Integer
			Get
				Return fFigures
			End Get
			Set(ByVal value As Integer)
				fFigures = value
				If fFigures > changeLevelCriterion Then
					Level += 1
				End If
			End Set
		End Property
		Public Property Score() As Integer
			Get
				Return fScore
			End Get
			Set(ByVal value As Integer)
				fScore = value
				OnChangeScore(New EventArgs())
			End Set
		End Property
		Public Property Level() As Integer
			Get
				Return fLevel
			End Get
			Set(ByVal value As Integer)
				If value < 7 AndAlso value >= 0 Then
					fLevel = value
					fFigures = 0
					OnChangeLevel(New EventArgs())
					OnCreateFigure(New EventArgs())
				End If
			End Set
		End Property
		Public ReadOnly Property LevelColor() As Color
			Get
				Return levelColors(Level)
			End Get
		End Property

		Public ReadOnly Property LevelPen() As Pen
			Get
				Return levelPens(Level)
			End Get
		End Property
		#End Region
		#Region "Functions"
		Private Sub SetPrevCollection(ByVal fFigure As Integer)
			Dim f() As Integer = Figures.GetFigure(fFigure)
			For i As Integer = 0 To 3
				CType(PrevCollection(i), Row).SetValue(f(i))
			Next i
			OnCreateFigure(New EventArgs())
		End Sub
		Private ReadOnly Property FiguresCount() As Integer
			Get
				Return Figures.FiguresNum - (If(Level < 3, 5, (If(Level < 5, 2, 0))))
			End Get
		End Property
		Public Sub CreateNewFigure()
			fFigure = New Figure(nextFigure, Collection)
			nextFigure = rnd.Next(FiguresCount)
			SetPrevCollection(nextFigure)
			FiguresNum += 1
			Score += oneFigure * (Level + 1)
		End Sub
		Public Sub FillRow()
			Collection(TRow).SetValue(2 * Row.RowDetermination - 1)
			Collection.Invalidate()
			TRow += 1
		End Sub
		#End Region
		#Region "Events"
		Private Sub removeRow(ByVal sender As Object, ByVal e As EventArgs)
			Score += oneRow * (Level + 1)
		End Sub

		Private Event changeScoreHandler As EventHandler
		Public Custom Event ChangeScore As EventHandler
			AddHandler(ByVal value As EventHandler)
				AddHandler changeScoreHandler, value
			End AddHandler
			RemoveHandler(ByVal value As EventHandler)
				RemoveHandler changeScoreHandler, value
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
			End RaiseEvent
		End Event
		Friend Sub OnChangeScore(ByVal args As EventArgs)
			RaiseEvent changeScoreHandler(Me, args)
		End Sub

		Private Event changeLevelHandler As EventHandler
		Public Custom Event ChangeLevel As EventHandler
			AddHandler(ByVal value As EventHandler)
				AddHandler changeLevelHandler, value
			End AddHandler
			RemoveHandler(ByVal value As EventHandler)
				RemoveHandler changeLevelHandler, value
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
			End RaiseEvent
		End Event
		Friend Sub OnChangeLevel(ByVal args As EventArgs)
			RaiseEvent changeLevelHandler(Me, args)
		End Sub

		Private Event createFigureHandler As EventHandler
		Public Custom Event CreateFigure As EventHandler
			AddHandler(ByVal value As EventHandler)
				AddHandler createFigureHandler, value
			End AddHandler
			RemoveHandler(ByVal value As EventHandler)
				RemoveHandler createFigureHandler, value
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)
			End RaiseEvent
		End Event
		Friend Sub OnCreateFigure(ByVal args As EventArgs)
			RaiseEvent createFigureHandler(Me, args)
		End Sub
		#End Region
	End Class
End Namespace

