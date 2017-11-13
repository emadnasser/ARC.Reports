Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing

Namespace DevExpress.RealtorWorld.Win
	Partial Public Class ucHomeDetail
		Inherits BaseModule
		Private Const photoSizePercent As Integer = 90
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Overrides ReadOnly Property AllowWaitDialog() As Boolean
			Get
				Return False
			End Get
		End Property
		Private fullLayout_Renamed As Boolean = True
		Friend Sub InitData(ByVal home As Home)
			If home Is Nothing Then
				Return
			End If
			FullLayout = True
			pnlData.Width = home.Photo.Width * photoSizePercent \ 100 + 10
			imageSlider.Height = home.Photo.Height * photoSizePercent \ 100
			lcFeatures.Text = String.Format("<size=+7>{0}<size=-5><br><b>{1}</b> bedrooms, <b>{2}</b> bathrooms<br>" & "<b>{3}</b> house size, <b>{4}</b> lot size<br><size=+1>Built in {5}<br><size=+9>{6}<br><size=-10>{7}<br><br><u>Agent:", home.Address, home.Beds, home.Baths, home.HouseSizeString, home.LotSize, home.YearBuilt, home.PriceString, home.Features)
			lcMain.FocusHelper.FocusElement(lciHome, False)
			Dim agent As Agent = DataHelper.GetAgentByHome(home)
			If agent IsNot Nothing Then
				peAgent.Image = agent.Photo
				peAgent.Tag = agent
				lcAgent.Text = String.Format("<Size=+7>{0} {1}<br><Size=-4>{2}<br><Size=-1>{3}", agent.FirstName, agent.LastName, agent.Phone, agent.Email)
			End If
			imageSlider.Images.Clear()
			peLayout.Image = home.Plan
			For Each img As Image In DataHelper.GetPhotos(home)
				imageSlider.Images.Add(img)
			Next img
			imageSlider.Refresh() 'TODO
		End Sub
		Public Property FullLayout() As Boolean
			Get
				Return fullLayout_Renamed
			End Get
			Set(ByVal value As Boolean)
				If fullLayout_Renamed = value Then
					Return
				End If
				fullLayout_Renamed = value
				pnlData.Visible = fullLayout_Renamed
			End Set
		End Property
		Private Sub peLayout_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles peLayout.DoubleClick
			FullLayout = Not FullLayout
		End Sub
		Private Sub peAgent_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles peAgent.DoubleClick, lcAgent.DoubleClick
			Dim currentAgent As Agent = TryCast(peAgent.Tag, Agent)
			If currentAgent IsNot Nothing Then
				Dim main As IMainForm = TryCast(Me.FindForm(), IMainForm)
				If main IsNot Nothing Then
					main.ShowAgent(currentAgent)
				End If
			End If
		End Sub
		Private Sub ucHomeDetail_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.VisibleChanged
			lcMain.FocusHelper.FocusElement(lciHome, False)
		End Sub
	End Class
End Namespace
