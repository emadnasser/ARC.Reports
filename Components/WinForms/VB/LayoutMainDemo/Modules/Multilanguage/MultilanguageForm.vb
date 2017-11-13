Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing.Animation
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo.Metadata
Imports DevExpress.XtraEditors
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraLayout.Demos
	Partial Public Class MultilanguageForm
		Inherits XtraForm
		Implements ISupportXtraAnimationEx

		Private delayBeforeAnimation As Integer = 500
		Private Shared FormBoundsAnimationLength As Integer = 2000
		Private timer As Timer

		Friend ReadOnly FormBoundsAnimationId As New Object()
        Private minSizeForm, maxSizeForm, landscapeSize, portraitSize As SizeF

        Public Sub New()
            XpoDefault.DataLayer = New SimpleDataLayer(New InMemoryDataStore(AutoCreateOption.DatabaseAndSchema))
            XpoDefault.Session.Delete(New XPCollection(GetType(VideoCatalogItem)))
            CreateCatalogItems()
            InitializeComponent()
            Dim scaleFactor As SizeF = TryCast(layoutControl1, ILayoutControl).AutoScaleFactor
            minSizeForm = New SizeF(485 * scaleFactor.Width, 675 * scaleFactor.Height)
            maxSizeForm = New SizeF(1085 * scaleFactor.Width, 675 * scaleFactor.Height)
            landscapeSize = New SizeF(675 * scaleFactor.Width, 490 * scaleFactor.Height)
            portraitSize = New SizeF(460 * scaleFactor.Width, 650 * scaleFactor.Height)
            Icon = ResourceImageHelper.CreateIconFromResources("AppIcon.ico", GetType(frmMain).Assembly)
        End Sub

        Private ReadOnly Property ISupportXtraAnimation_CanAnimate() As Boolean Implements ISupportXtraAnimation.CanAnimate
            Get
                Return True
            End Get
        End Property
        Private ReadOnly Property ISupportXtraAnimation_OwnerControl() As Control Implements ISupportXtraAnimation.OwnerControl
            Get
                Return Me
            End Get
        End Property

        Public ReadOnly Property FormMaxSize() As Size
            Get
                Return maxSizeForm.ToSize()
            End Get
        End Property
        Public ReadOnly Property FormMinSize() As Size
            Get
                Return minSizeForm.ToSize()
            End Get
        End Property
        Public ReadOnly Property Landscape() As Size
            Get
                Return landscapeSize.ToSize()
            End Get
        End Property
        Public ReadOnly Property Portrait() As Size
            Get
                Return portraitSize.ToSize()
            End Get
        End Property

        Private Sub ISupportXtraAnimationEx_OnEndAnimation(ByVal info As BaseAnimationInfo) Implements ISupportXtraAnimationEx.OnEndAnimation
            If Width = maxSizeForm.Width Then
                AnimateControlBoundsMinimization()
            End If
        End Sub
        Private Sub ISupportXtraAnimationEx_OnFrameStep(ByVal info As BaseAnimationInfo) Implements ISupportXtraAnimationEx.OnFrameStep
            Width = CInt(Math.Truncate(CType(info, DoubleSplineAnimationInfo).Value))
        End Sub
        Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            RemoveHandler timer.Tick, AddressOf timer_Tick
            timer.Dispose()
            AnimateControlBoundsMaximization()
        End Sub

        Protected Friend Overridable Sub AnimateControlBoundsMaximization()
            Dim info As New DoubleSplineAnimationInfo(Me, FormBoundsAnimationId, minSizeForm.Width, maxSizeForm.Width, FormBoundsAnimationLength)
            XtraAnimator.Current.AddAnimation(info)
        End Sub
        Protected Friend Overridable Sub AnimateControlBoundsMinimization()
            Dim info As New DoubleSplineAnimationInfo(Me, FormBoundsAnimationId, maxSizeForm.Width, minSizeForm.Width, FormBoundsAnimationLength)
            XtraAnimator.Current.AddAnimation(info)
        End Sub

        Public Sub ChangedSize(ByVal scale As Single)
            labelControl1.Appearance.Font = New Font(labelControl1.Appearance.Font.FontFamily, labelControl1.Appearance.Font.Size * scale)
            labelControl8.Appearance.Font = New Font(labelControl8.Appearance.Font.FontFamily, labelControl8.Appearance.Font.Size * scale)
            layoutControlGroup1.AppearanceItemCaption.Font = New Font(layoutControlGroup1.AppearanceItemCaption.Font.FontFamily, layoutControlGroup1.AppearanceItemCaption.Font.Size * scale, FontStyle.Bold)
            AppearanceObject.DefaultFont = New Font(Appearance.Font.FontFamily, Appearance.Font.Size * scale)
        End Sub
        Public Shared Sub CreateCatalogItems()
            If System.Threading.Thread.CurrentThread.CurrentUICulture.EnglishName = "English" Then
                CType(New VideoCatalogItem(XpoDefault.Session, "The Sting", "George Roy Hill", "Crime / Comedy", "Paul Newman, Robert Redford, Robert Shaw", "USA", "In 1930s Chicago, a young con man seeking revenge for his murdered partner teams up with a master of the big con to win a fortune from a criminal banker", 1973, ResourceImageHelper.CreateBitmapFromResources("film1-en.png", GetType(frmMain).Assembly), New TimeSpan(0, 129, 0)), VideoCatalogItem).Save()

                CType(New VideoCatalogItem(XpoDefault.Session, "Die Hard", "John McTiernan", "Action / Crime / Thriller", "Bruce Willis, Reginald VelJohnson, Alan Rickman", "USA", "New York cop John McClane gives terrorists a dose of their own medicine as they hold hostages in an LA office building", 1988, ResourceImageHelper.CreateBitmapFromResources("film2-en.png", GetType(frmMain).Assembly), New TimeSpan(0, 131, 0)), VideoCatalogItem).Save()

                CType(New VideoCatalogItem(XpoDefault.Session, "Playing by heart", "Willard Carroll", "Comedy / Drama / Romance", "Angelina Jolie, Dennis Quaid, Sean Connery, Gillian Anderson", "USA", "Eleven articulate people work through affairs of the heart in L.A.", 1998, ResourceImageHelper.CreateBitmapFromResources("film3-en.png", GetType(frmMain).Assembly), New TimeSpan(0, 121, 0)), VideoCatalogItem).Save()
            End If
            If System.Threading.Thread.CurrentThread.CurrentUICulture.EnglishName = "German (Germany)" Then
                CType(New VideoCatalogItem(XpoDefault.Session, "Der Clou", "George Roy Hill", "Krimi / Komodie", "Paul Newman, Robert Redford, Robert Shaw", "USA", "Im Chicago der 30er Jahre will ein Gelegenheitsbetruger Rache fur den Tod seines Partners und verbundet sich mit einem Meister des gro?en Betrugs, um einem kriminellen Bankier ein Vermogen abzunehmen", 1973, ResourceImageHelper.CreateBitmapFromResources("film1-de.png", GetType(frmMain).Assembly), New TimeSpan(0, 129, 0)), VideoCatalogItem).Save()

                CType(New VideoCatalogItem(XpoDefault.Session, "Stirb langsam", "John McTiernan", "Action / Krimi / Thriller", "Bruce Willis, Reginald VelJohnson, Alan Rickman", "USA", "Der New Yorker Polizist John McClane gibt Terroristen eine Dosis ihrer eigenen Medizin, als sie in einem Burogebaude in Los Angeles Geiseln nehmen", 1988, ResourceImageHelper.CreateBitmapFromResources("film2-de.png", GetType(frmMain).Assembly), New TimeSpan(0, 131, 0)), VideoCatalogItem).Save()

                CType(New VideoCatalogItem(XpoDefault.Session, "Leben und Lieben in L.A.", "Willard Carroll", "Komodie / Drama / Romantik", "Angelina Jolie, Dennis Quaid, Sean Connery, Gillian Anderson", "USA", "Elf Menschen in verschiedenem Alter suchen im Nachtleben der Metropole Los Angeles nach Liebe und Zuneigung", 1998, ResourceImageHelper.CreateBitmapFromResources("film3-de.png", GetType(frmMain).Assembly), New TimeSpan(0, 121, 0)), VideoCatalogItem).Save()
            End If
        End Sub
        Public Sub SetLayout(ByVal layoutMode As Utils.LayoutMode)
            layoutModeGroup.LayoutMode = layoutMode
        End Sub
        Public Sub ShowAnimation()
            Size = FormMinSize
            timer = New Timer() With {.Interval = delayBeforeAnimation}
            AddHandler timer.Tick, AddressOf timer_Tick
            timer.Start()
        End Sub
	End Class

	<NonPersistent>
	Public Class VideoCatalogBase
		Inherits XPObject

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class

	Public Class VideoCatalogItem
		Inherits VideoCatalogBase

		Private fCaption As String
		Private fCast As String
		Private fCountry As String
		Private fDescription As String
		Private fDirector As String
		Private fGenre As String
		Private fPhoto As Image
		Private fRunTime As TimeSpan
		Private fYear As Integer

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New(ByVal session As Session, ByVal caption As String, ByVal director As String, ByVal genre As String, ByVal cast As String, ByVal country As String, ByVal description As String, ByVal year As Integer, ByVal photo As Image, ByVal runTime As TimeSpan)
			MyBase.New(session)
			fCaption = caption
			fDirector = director
			fGenre = genre
			fCast = cast
			fCountry = country
			fDescription = description
			fYear = year
			fPhoto = photo
			fRunTime = runTime
		End Sub

		<Size(254)>
		Public Property Caption() As String
			Get
				Return fCaption
			End Get
			Set(ByVal value As String)
				Dim oldValue As String = fCaption
				If oldValue = value Then
					Return
				End If
				fCaption = value
				OnChanged("Caption", oldValue, value)
			End Set
		End Property
		<Size(254)>
		Public Property Cast() As String
			Get
				Return fCast
			End Get
			Set(ByVal value As String)
				Dim oldValue As String = fCast
				If oldValue = value Then
					Return
				End If
				fCast = value
				OnChanged("Cast", oldValue, value)
			End Set
		End Property
		<Size(254)>
		Public Property Country() As String
			Get
				Return fCountry
			End Get
			Set(ByVal value As String)
				Dim oldValue As String = fCountry
				If oldValue = value Then
					Return
				End If
				fCountry = value
				OnChanged("Country", oldValue, value)
			End Set
		End Property
		<Size(1500)>
		Public Property Description() As String
			Get
				Return fDescription
			End Get
			Set(ByVal value As String)
				Dim oldValue As String = fDescription
				If oldValue = value Then
					Return
				End If
				fDescription = value
				OnChanged("Description", oldValue, value)
			End Set
		End Property
		<Size(254)>
		Public Property Director() As String
			Get
				Return fDirector
			End Get
			Set(ByVal value As String)
				Dim oldValue As String = fDirector
				If oldValue = value Then
					Return
				End If
				fDirector = value
				OnChanged("Director", oldValue, value)
			End Set
		End Property
		<Size(254)>
		Public Property Genre() As String
			Get
				Return fGenre
			End Get
			Set(ByVal value As String)
				Dim oldValue As String = fGenre
				If oldValue = value Then
					Return
				End If
				fGenre = value
				OnChanged("Genre", oldValue, value)
			End Set
		End Property
		<ValueConverter(GetType(ImageValueConverter))>
		Public Property Photo() As Image
			Get
				Return fPhoto
			End Get
			Set(ByVal value As Image)
				Dim oldValue As Image = fPhoto
				If ReferenceEquals(oldValue, value) Then
					Return
				End If
				fPhoto = value
				OnChanged("Photo", oldValue, value)
			End Set
		End Property
		Public Property RunTime() As TimeSpan
			Get
				Return fRunTime
			End Get
			Set(ByVal value As TimeSpan)
				Dim oldValue As TimeSpan = fRunTime
				If oldValue = value Then
					Return
				End If
				fRunTime = value
				OnChanged("RunTime", oldValue, value)
			End Set
		End Property
		Public Property Year() As Integer
			Get
				Return fYear
			End Get
			Set(ByVal value As Integer)
				Dim oldValue As Integer = fYear
				If oldValue = value Then
					Return
				End If
				fYear = value
				OnChanged("Year", oldValue, value)
			End Set
		End Property
	End Class
End Namespace
