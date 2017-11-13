﻿Imports System.Data.Common
Imports System.Globalization

Namespace DevExpress.Demos.SalesDBGenerator
	Public Class SqlHelper(Of T As DbConnection, Command As {DbCommand, New})
		Public Function ReadValue(ByVal connection As T, ByVal [select] As String, ParamArray ByVal pars() As DbParameter) As Object
			Using sql = CreateCommand([select], connection)
				sql.CommandTimeout = 1000
				If pars IsNot Nothing Then
					sql.Parameters.AddRange(pars)
				End If
				Try
					Return CheckDbNull(sql.ExecuteScalar())
				Catch
					Return Nothing
				End Try
			End Using
		End Function
		Private Function CheckDbNull(ByVal value As Object) As Object
			If value Is Nothing Then
				Return Nothing
			End If
			If Object.ReferenceEquals(value, DBNull.Value) Then
				Return Nothing
			End If
			Return value
		End Function
		Private Shared Function CreateCommand(ByVal [select] As String, ByVal connection As T) As DbCommand
			Return New Command() With {.CommandText = [select], .Connection = connection}
		End Function
		Public Function ReadValues(ByVal connection As T, ByVal [select] As String, ParamArray ByVal pars() As DbParameter) As List(Of Object())
			Dim res As New List(Of Object())()
			Try
				Using sql = CreateCommand([select], connection)
					sql.CommandTimeout = 5000
					If pars IsNot Nothing Then
						sql.Parameters.AddRange(pars)
					End If
					Using reader As DbDataReader = sql.ExecuteReader()
						If Not reader.HasRows Then
							Return res
						End If
						Do While reader.Read()
							Dim values(reader.FieldCount - 1) As Object
							reader.GetValues(values)
							res.Add(values)
						Loop
					End Using
				End Using
			Catch
			End Try
			Return res
		End Function
		Public Function Execute(ByVal connection As T, ByVal trans As DbTransaction, ByVal [select] As String, ParamArray ByVal pars() As DbParameter) As Integer
			Using sql = CreateCommand([select], connection)
				If trans IsNot Nothing Then
					sql.Transaction = trans
				End If
				sql.CommandTimeout = 5000
				If pars IsNot Nothing Then
					sql.Parameters.AddRange(pars)
				End If
				Return sql.ExecuteNonQuery()
			End Using
		End Function
		Public Function Execute(ByVal connection As T, ByVal [select] As String, ParamArray ByVal pars() As DbParameter) As Integer
			Return Execute(connection, Nothing, [select], pars)
		End Function
		Public Function GetString(ByVal val As Object) As String
			If val Is DBNull.Value OrElse val Is Nothing Then
				Return String.Empty
			End If
			Return val.ToString()
		End Function
		Public Function GetDateInv(ByVal val As Object) As Date
			If val Is DBNull.Value OrElse val Is Nothing Then
				Return Date.MinValue
			End If
			Return Date.ParseExact(val.ToString(), "d/M/yyyy", DateTimeFormatInfo.InvariantInfo)
		End Function
		Public Function GetInt(ByVal val As Object) As Integer
			If val Is DBNull.Value OrElse val Is Nothing Then
				Return 0
			End If
			Return Convert.ToInt32(val)
		End Function
		Public Function GetDate(ByVal value As Object) As Date
			If value Is Nothing OrElse value Is DBNull.Value Then
				Return Date.MinValue
			End If
			If TypeOf value Is Date Then
				Return CDate(value)
			End If
			Return GetDateInv(value)
		End Function
		Public Function GetDecimal(ByVal value As Object) As Decimal
			If value Is Nothing OrElse value Is DBNull.Value Then
				Return 0
			End If
			Return CDec(Convert.ChangeType(value, GetType(Decimal)))
		End Function
		Public Function GetGuid(ByVal value As Object) As Guid
			If value Is Nothing OrElse value Is DBNull.Value Then
				Return Guid.Empty
			End If
			Return New Guid(value.ToString())
		End Function
		Public Function GetBool(ByVal value As Object) As Boolean
			If value Is Nothing OrElse value Is DBNull.Value Then
				Return False
			End If
			If TypeOf value Is Boolean Then
				Return CBool(value)
			End If
			If TypeOf value Is Integer Then
				Return CInt(Fix(value)) = 1
			End If
			Return False
		End Function
	End Class
End Namespace