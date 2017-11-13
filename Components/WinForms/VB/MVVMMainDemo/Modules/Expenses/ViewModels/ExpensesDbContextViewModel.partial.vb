Option Infer On

Imports DevExpress.Mvvm
Namespace DevExpress.MVVM.Demos.ViewModels
	Partial Public Class ExpensesDbContextViewModel
		Public Overrides Sub OnLoaded(ByVal [module] As ExpensesDbContextModuleDescription)
			Messenger.Default.Register(Of AmountMessage)(Me, AddressOf OnAmountMessage)
			MyBase.OnLoaded([module])
		End Sub
		Private Sub OnAmountMessage(ByVal message As AmountMessage)
			Dim uow = CreateUnitOfWork()
			Dim account = uow.Accounts.Find(message.ID)
			If account IsNot Nothing Then
				account.Amount += message.Change
			End If
			uow.SaveChanges()
		End Sub
	End Class
End Namespace
