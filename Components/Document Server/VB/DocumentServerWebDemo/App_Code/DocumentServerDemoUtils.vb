Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Web.Caching
Imports DevExpress.Spreadsheet
Imports DevExpress.Web.Internal

Public Class HtmlContentGenerator
	Private dstStream As Stream
	Public Sub New(ByVal dstStream As Stream)
		Me.dstStream = dstStream
	End Sub
	Public Sub Generate(ByVal book As IWorkbook, ByVal sheetIndx As Integer)
		Dim model As DevExpress.XtraSpreadsheet.Model.DocumentModel = book.Model
		Using tempStream As New MemoryStream()
			Dim options As New DevExpress.XtraSpreadsheet.Export.HtmlDocumentExporterOptions()
			options.SheetIndex = sheetIndx
			options.EmbedImages = True
			model.InternalAPI.SaveDocumentHtmlContent(tempStream, options)
			tempStream.Seek(0, SeekOrigin.Begin)
			tempStream.CopyTo(Me.dstStream)
		End Using
	End Sub
	Public Sub Generate(ByVal book As IWorkbook)
		Generate(book, 0)
	End Sub
End Class

Namespace DevExpress.Web.Demos

	Public Class Employee
		Public Property EmployeeID() As Integer
		Public Property FirstName() As String
		Public Property LastName() As String
		Public Property Address() As String
		Public Property City() As String
		Public Property PostalCode() As String
		Public Property Title() As String

		Public Sub New(ByVal employeeId As Integer, ByVal firstName As String, ByVal lastName As String, ByVal address As String, ByVal city As String, ByVal postalCode As String, ByVal title As String)
			EmployeeID = employeeId
			FirstName = firstName
			LastName = lastName
			Address = address
			City = city
			PostalCode = postalCode
			Title = title
		End Sub

		#Region "Fill with data from nwind.mdb"
		Public Shared Sub FillWithData(ByVal employees As List(Of Employee))
			employees.Add(New Employee(1, "Nancy", "Davolio", "507 - 20th Ave. E." & Constants.vbLf & "Apt. 2A", "Seattle", "98122", "Sales Representative"))
			employees.Add(New Employee(2, "Andrew", "Fuller", "908 W. Capital Way", "Tacoma", "98401", "Vice President, Sales"))
			employees.Add(New Employee(3, "Janet", "Leverling", "722 Moss Bay Blvd.", "Kirkland", "98033", "Sales Representative"))
			employees.Add(New Employee(4, "Margaret", "Peacock", "4110 Old Redmond Rd.", "Redmond", "98052", "Sales Representative"))
			employees.Add(New Employee(5, "Steven", "Buchanan", "14 Garrett Hill", "London", "SW1 8JR", "Sales Manager"))
			employees.Add(New Employee(6, "Michael", "Suyama", "Coventry House" & Constants.vbLf & "Miner Rd.", "London", "EC2 7JR", "Sales Representative"))
			employees.Add(New Employee(7, "Robert", "King", "Edgeham Hollow" & Constants.vbLf & "Winchester Way", "London", "RG1 9SP", "Sales Representative"))
			employees.Add(New Employee(8, "Laura", "Callahan", "4726 - 11th Ave. N.E.", "Seattle", "98105", "Inside Sales Coordinator"))
			employees.Add(New Employee(9, "Anne", "Dodsworth", "7 Houndstooth Rd.", "London", "WG2 7LT", "Sales Representative"))
		End Sub
		#End Region
	End Class

	Public Class Customer
		Public Property CustomerID() As String
		Public Property CompanyName() As String
		Public Property ContactName() As String
		Public Property ContactTitle() As String
		Public Property Address() As String
		Public Property City() As String
		Public Property PostalCode() As String
		Public ReadOnly Property Photo() As Byte()
			Get
				Return Nothing
			End Get
		End Property

		Public Sub New(ByVal customerId As String, ByVal companyName As String, ByVal contactName As String, ByVal contactTitle As String, ByVal address As String, ByVal city As String, ByVal postalCode As String)
			CustomerID = customerId
			CompanyName = companyName
			ContactName = contactName
			ContactTitle = contactTitle
			Address = address
			City = city
			PostalCode = postalCode
		End Sub

		#Region "Fill with data from nwind.mdb"
		Public Shared Sub FillWithData(ByVal customers As List(Of Customer))
			customers.Add(New Customer("ALFKI", "Alfreds Futterkiste", "Maria Anders", "Sales Representative", "Obere Str. 57", "Berlin", "12209"))
			customers.Add(New Customer("ANATR", "Ana Trujillo Emparedados y helados", "Ana Trujillo", "Owner", "Avda. de la Constitución 2222", "México D.F.", "5021"))
			customers.Add(New Customer("ANTON", "Antonio Moreno Taquería", "Antonio Moreno", "Owner", "Mataderos  2312", "México D.F.", "5023"))
			customers.Add(New Customer("AROUT", "Around the Horn", "Thomas Hardy", "Sales Representative", "120 Hanover Sq.", "London", "WA1 1DP"))
			customers.Add(New Customer("BERGS", "Berglunds snabbköp", "Christina Berglund", "Order Administrator", "Berguvsvägen  8", "Luleå", "S-958 22"))
			customers.Add(New Customer("BLAUS", "Blauer See Delikatessen", "Hanna Moos", "Sales Representative", "Forsterstr. 57", "Mannheim", "68306"))
			customers.Add(New Customer("BLONP", "Blondel père et fils", "Frédérique Citeaux", "Marketing Manager", "24, place Kléber", "Strasbourg", "67000"))
			customers.Add(New Customer("BOLID", "Bólido Comidas preparadas", "Martín Sommer", "Owner", "C/ Araquil, 67", "Madrid", "28023"))
			customers.Add(New Customer("BONAP", "Bon app'", "Laurence Lebihan", "Owner", "12, rue des Bouchers", "Marseille", "13008"))
			customers.Add(New Customer("BOTTM", "Bottom-Dollar Markets", "Elizabeth Lincoln", "Accounting Manager", "23 Tsawassen Blvd.", "Tsawwassen", "T2F 8M4"))
			customers.Add(New Customer("BSBEV", "B's Beverages", "Victoria Ashworth", "Sales Representative", "Fauntleroy Circus", "London", "EC2 5NT"))
			customers.Add(New Customer("CACTU", "Cactus Comidas para llevar", "Patricio Simpson", "Sales Agent", "Cerrito 333", "Buenos Aires", "1010"))
			customers.Add(New Customer("CENTC", "Centro comercial Moctezuma", "Francisco Chang", "Marketing Manager", "Sierras de Granada 9993", "México D.F.", "5022"))
			customers.Add(New Customer("CHOPS", "Chop-suey Chinese", "Yang Wang", "Owner", "Hauptstr. 29", "Bern", "3012"))
			customers.Add(New Customer("COMMI", "Comércio Mineiro", "Pedro Afonso", "Sales Associate", "Av. dos Lusíadas, 23", "São Paulo", "05432-043"))
			customers.Add(New Customer("CONSH", "Consolidated Holdings", "Elizabeth Brown", "Sales Representative", "Berkeley Garden" & Constants.vbLf & "12  Brewery ", "London", "WX1 6LT"))
			customers.Add(New Customer("DRACD", "Drachenblut Delikatessen", "Sven Ottlieb", "Order Administrator", "Walserweg 21", "Aachen", "52066"))
			customers.Add(New Customer("DUMON", "Du monde entier", "Janine Labrune", "Owner", "67, rue des Cinquante Otages", "Nantes", "44000"))
			customers.Add(New Customer("EASTC", "Eastern Connection", "Ann Devon", "Sales Agent", "35 King George", "London", "WX3 6FW"))
			customers.Add(New Customer("ERNSH", "Ernst Handel", "Roland Mendel", "Sales Manager", "Kirchgasse 6", "Graz", "8010"))
			customers.Add(New Customer("FAMIA", "Familia Arquibaldo", "Aria Cruz", "Marketing Assistant", "Rua Orós, 92", "São Paulo", "05442-030"))
			customers.Add(New Customer("FISSA", "FISSA Fabrica Inter. Salchichas S.A.", "Diego Roel", "Accounting Manager", "C/ Moralzarzal, 86", "Madrid", "28034"))
			customers.Add(New Customer("FOLIG", "Folies gourmandes", "Martine Rancé", "Assistant Sales Agent", "184, chaussée de Tournai", "Lille", "59000"))
			customers.Add(New Customer("FOLKO", "Folk och fä HB", "Maria Larsson", "Owner", "Åkergatan 24", "Bräcke", "S-844 67"))
			customers.Add(New Customer("FRANK", "Frankenversand", "Peter Franken", "Marketing Manager", "Berliner Platz 43", "München", "80805"))
			customers.Add(New Customer("FRANR", "France restauration", "Carine Schmitt", "Marketing Manager", "54, rue Royale", "Nantes", "44000"))
			customers.Add(New Customer("FRANS", "Franchi S.p.A.", "Paolo Accorti", "Sales Representative", "Via Monte Bianco 34", "Torino", "10100"))
			customers.Add(New Customer("FURIB", "Furia Bacalhau e Frutos do Mar", "Lino Rodriguez ", "Sales Manager", "Jardim das rosas n. 32", "Lisboa", "1675"))
			customers.Add(New Customer("GALED", "Galería del gastrónomo", "Eduardo Saavedra", "Marketing Manager", "Rambla de Cataluña, 23", "Barcelona", "8022"))
			customers.Add(New Customer("GODOS", "Godos Cocina Típica", "José Pedro Freyre", "Sales Manager", "C/ Romero, 33", "Sevilla", "41101"))
			customers.Add(New Customer("GOURL", "Gourmet Lanchonetes", "André Fonseca", "Sales Associate", "Av. Brasil, 442", "Campinas", "04876-786"))
			customers.Add(New Customer("GREAL", "Great Lakes Food Market", "Howard Snyder", "Marketing Manager", "2732 Baker Blvd.", "Eugene", "97403"))
			customers.Add(New Customer("GROSR", "GROSELLA-Restaurante", "Manuel Pereira", "Owner", "5ª Ave. Los Palos Grandes", "Caracas", "1081"))
			customers.Add(New Customer("HANAR", "Hanari Carnes", "Mario Pontes", "Accounting Manager", "Rua do Paço, 67", "Rio de Janeiro", "05454-876"))
			customers.Add(New Customer("HILAA", "HILARIÓN-Abastos", "Carlos Hernández", "Sales Representative", "Carrera 22 con Ave. Carlos Soublette #8-35", "San Cristóbal", "5022"))
			customers.Add(New Customer("HUNGC", "Hungry Coyote Import Store", "Yoshi Latimer", "Sales Representative", "City Center Plaza" & Constants.vbLf & "516 Main St.", "Elgin", "97827"))
			customers.Add(New Customer("HUNGO", "Hungry Owl All-Night Grocers", "Patricia McKenna", "Sales Associate", "8 Johnstown Road", "Cork", ""))
			customers.Add(New Customer("ISLAT", "Island Trading", "Helen Bennett", "Marketing Manager", "Garden House" & Constants.vbLf & "Crowther Way", "Cowes", "PO31 7PJ"))
			customers.Add(New Customer("KOENE", "Königlich Essen", "Philip Cramer", "Sales Associate", "Maubelstr. 90", "Brandenburg", "14776"))
			customers.Add(New Customer("LACOR", "La corne d'abondance", "Daniel Tonini", "Sales Representative", "67, avenue de l'Europe", "Versailles", "78000"))
			customers.Add(New Customer("LAMAI", "La maison d'Asie", "Annette Roulet", "Sales Manager", "1 rue Alsace-Lorraine", "Toulouse", "31000"))
			customers.Add(New Customer("LAUGB", "Laughing Bacchus Wine Cellars", "Yoshi Tannamuri", "Marketing Assistant", "1900 Oak St.", "Vancouver", "V3F 2K1"))
			customers.Add(New Customer("LAZYK", "Lazy K Kountry Store", "John Steel", "Marketing Manager", "12 Orchestra Terrace", "Walla Walla", "99362"))
			customers.Add(New Customer("LEHMS", "Lehmanns Marktstand", "Renate Messner", "Sales Representative", "Magazinweg 7", "Frankfurt a.M. ", "60528"))
			customers.Add(New Customer("LETSS", "Let's Stop N Shop", "Jaime Yorres", "Owner", "87 Polk St." & Constants.vbLf & "Suite 5", "San Francisco", "94117"))
			customers.Add(New Customer("LILAS", "LILA-Supermercado", "Carlos González", "Accounting Manager", "Carrera 52 con Ave. Bolívar #65-98 Llano Largo", "Barquisimeto", "3508"))
			customers.Add(New Customer("LINOD", "LINO-Delicateses", "Felipe Izquierdo", "Owner", "Ave. 5 de Mayo Porlamar", "I. de Margarita", "4980"))
			customers.Add(New Customer("LONEP", "Lonesome Pine Restaurant", "Fran Wilson", "Sales Manager", "89 Chiaroscuro Rd.", "Portland", "97219"))
			customers.Add(New Customer("MAGAA", "Magazzini Alimentari Riuniti", "Giovanni Rovelli", "Marketing Manager", "Via Ludovico il Moro 22", "Bergamo", "24100"))
			customers.Add(New Customer("MAISD", "Maison Dewey", "Catherine Dewey", "Sales Agent", "Rue Joseph-Bens 532", "Bruxelles", "B-1180"))
			customers.Add(New Customer("MEREP", "Mère Paillarde", "Jean Fresnière", "Marketing Assistant", "43 rue St. Laurent", "Montréal", "H1J 1C3"))
			customers.Add(New Customer("MORGK", "Morgenstern Gesundkost", "Alexander Feuer", "Marketing Assistant", "Heerstr. 22", "Leipzig", "4179"))
			customers.Add(New Customer("NORTS", "North/South", "Simon Crowther", "Sales Associate", "South House" & Constants.vbLf & "300 Queensbridge", "London", "SW7 1RZ"))
			customers.Add(New Customer("OCEAN", "Océano Atlántico Ltda.", "Yvonne Moncada", "Sales Agent", "Ing. Gustavo Moncada 8585" & Constants.vbLf & "Piso 20-A", "Buenos Aires", "1010"))
			customers.Add(New Customer("OLDWO", "Old World Delicatessen", "Rene Phillips", "Sales Representative", "2743 Bering St.", "Anchorage", "99508"))
			customers.Add(New Customer("OTTIK", "Ottilies Käseladen", "Henriette Pfalzheim", "Owner", "Mehrheimerstr. 369", "Köln", "50739"))
			customers.Add(New Customer("PARIS", "Paris spécialités", "Marie Bertrand", "Owner", "265, boulevard Charonne", "Paris", "75012"))
			customers.Add(New Customer("PERIC", "Pericles Comidas clásicas", "Guillermo Fernández", "Sales Representative", "Calle Dr. Jorge Cash 321", "México D.F.", "5033"))
			customers.Add(New Customer("PICCO", "Piccolo und mehr", "Georg Pipps", "Sales Manager", "Geislweg 14", "Salzburg", "5020"))
			customers.Add(New Customer("PRINI", "Princesa Isabel Vinhos", "Isabel de Castro", "Sales Representative", "Estrada da saúde n. 58", "Lisboa", "1756"))
			customers.Add(New Customer("QUEDE", "Que Delícia", "Bernardo Batista", "Accounting Manager", "Rua da Panificadora, 12", "Rio de Janeiro", "02389-673"))
			customers.Add(New Customer("QUEEN", "Queen Cozinha", "Lúcia Carvalho", "Marketing Assistant", "Alameda dos Canàrios, 891", "São Paulo", "05487-020"))
			customers.Add(New Customer("QUICK", "QUICK-Stop", "Horst Kloss", "Accounting Manager", "Taucherstraße 10", "Cunewalde", "1307"))
			customers.Add(New Customer("RANCH", "Rancho grande", "Sergio Gutiérrez", "Sales Representative", "Av. del Libertador 900", "Buenos Aires", "1010"))
			customers.Add(New Customer("RATTC", "Rattlesnake Canyon Grocery", "Paula Wilson", "Assistant Sales Representative", "2817 Milton Dr.", "Albuquerque", "87110"))
			customers.Add(New Customer("REGGC", "Reggiani Caseifici", "Maurizio Moroni", "Sales Associate", "Strada Provinciale 124", "Reggio Emilia", "42100"))
			customers.Add(New Customer("RICAR", "Ricardo Adocicados", "Janete Limeira", "Assistant Sales Agent", "Av. Copacabana, 267", "Rio de Janeiro", "02389-890"))
			customers.Add(New Customer("RICSU", "Richter Supermarkt", "Michael Holz", "Sales Manager", "Grenzacherweg 237", "Genève", "1203"))
			customers.Add(New Customer("ROMEY", "Romero y tomillo", "Alejandra Camino", "Accounting Manager", "Gran Vía, 1", "Madrid", "28001"))
			customers.Add(New Customer("SANTG", "Santé Gourmet", "Jonas Bergulfsen", "Owner", "Erling Skakkes gate 78", "Stavern", "4110"))
			customers.Add(New Customer("SAVEA", "Save-a-lot Markets", "Jose Pavarotti", "Sales Representative", "187 Suffolk Ln.", "Boise", "83720"))
			customers.Add(New Customer("SEVES", "Seven Seas Imports", "Hari Kumar", "Sales Manager", "90 Wadhurst Rd.", "London", "OX15 4NB"))
			customers.Add(New Customer("SIMOB", "Simons bistro", "Jytte Petersen", "Owner", "Vinbæltet 34", "København", "1734"))
			customers.Add(New Customer("SPECD", "Spécialités du monde", "Dominique Perrier", "Marketing Manager", "25, rue Lauriston", "Paris", "75016"))
			customers.Add(New Customer("SPLIR", "Split Rail Beer & Ale", "Art Braunschweiger", "Sales Manager", "P.O. Box 555", "Lander", "82520"))
			customers.Add(New Customer("SUPRD", "Suprêmes délices", "Pascale Cartrain", "Accounting Manager", "Boulevard Tirou, 255", "Charleroi", "B-6000"))
			customers.Add(New Customer("THEBI", "The Big Cheese", "Liz Nixon", "Marketing Manager", "89 Jefferson Way" & Constants.vbLf & "Suite 2", "Portland", "97201"))
			customers.Add(New Customer("THECR", "The Cracker Box", "Liu Wong", "Marketing Assistant", "55 Grizzly Peak Rd.", "Butte", "59801"))
			customers.Add(New Customer("TOMSP", "Toms Spezialitäten", "Karin Josephs", "Marketing Manager", "Luisenstr. 48", "Münster", "44087"))
			customers.Add(New Customer("TORTU", "Tortuga Restaurante", "Miguel Angel Paolino", "Owner", "Avda. Azteca 123", "México D.F.", "5033"))
			customers.Add(New Customer("TRADH", "Tradição Hipermercados", "Anabela Domingues", "Sales Representative", "Av. Inês de Castro, 414", "São Paulo", "05634-030"))
			customers.Add(New Customer("TRAIH", "Trail's Head Gourmet Provisioners", "Helvetius Nagy", "Sales Associate", "722 DaVinci Blvd.", "Kirkland", "98034"))
			customers.Add(New Customer("VAFFE", "Vaffeljernet", "Palle Ibsen", "Sales Manager", "Smagsløget 45", "Århus", "8200"))
			customers.Add(New Customer("VICTE", "Victuailles en stock", "Mary Saveley", "Sales Agent", "2, rue du Commerce", "Lyon", "69004"))
			customers.Add(New Customer("VINET", "Vins et alcools Chevalier", "Paul Henriot", "Accounting Manager", "59 rue de l'Abbaye", "Reims", "51100"))
			customers.Add(New Customer("WANDK", "Die Wandernde Kuh", "Rita Müller", "Sales Representative", "Adenauerallee 900", "Stuttgart", "70563"))
			customers.Add(New Customer("WARTH", "Wartian Herkku", "Pirkko Koskitalo", "Accounting Manager", "Torikatu 38", "Oulu", "90110"))
			customers.Add(New Customer("WELLI", "Wellington Importadora", "Paula Parente", "Sales Manager", "Rua do Mercado, 12", "Resende", "08737-363"))
			customers.Add(New Customer("WHITC", "White Clover Markets", "Karl Jablonski", "Owner", "305 - 14th Ave. S." & Constants.vbLf & "Suite 3B", "Seattle", "98128"))
			customers.Add(New Customer("WILMK", "Wilman Kala", "Matti Karttunen", "Owner/Marketing Assistant", "Keskuskatu 45", "Helsinki", "21240"))
			customers.Add(New Customer("WOLZA", "Wolski  Zajazd", "Zbyszek Piestrzeniewicz", "Owner", "ul. Filtrowa 68", "Warszawa", "40909"))
		End Sub
		#End Region
	End Class

	Public Class InMemoryNWindData
		Private employees_Renamed As List(Of Employee)
		Private customers_Renamed As List(Of Customer)
		Private relations As Dictionary(Of String, Integer)

		Public ReadOnly Property Employees() As List(Of Employee)
			Get
				Return employees_Renamed
			End Get
		End Property
		Public ReadOnly Property Customers() As List(Of Customer)
			Get
				Return customers_Renamed
			End Get
		End Property

		Public Sub New()
			employees_Renamed = New List(Of Employee)()
			Employee.FillWithData(employees_Renamed)
			customers_Renamed = New List(Of Customer)()
			Customer.FillWithData(customers_Renamed)
			relations = New Dictionary(Of String, Integer)()
			SetRelations()
		End Sub

		Private Sub SetRelations()
			'if(relations == null)
			'    relations = new Dictionary<string, int>();
			'else
			'relations.Clear();
			relations.Add("ALFKI", 1)
			relations.Add("ANATR", 2)
			relations.Add("ANTON", 4)
			relations.Add("AROUT", 3)
			relations.Add("BERGS", 2)
			relations.Add("BLAUS", 5)
			relations.Add("BLONP", 7)
			relations.Add("BOLID", 9)
			relations.Add("BONAP", 8)
			relations.Add("BOTTM", 5)
			relations.Add("BSBEV", 6)
			relations.Add("CACTU", 6)
			relations.Add("CENTC", 7)
			relations.Add("CHOPS", 8)
			relations.Add("COMMI", 2)
			relations.Add("CONSH", 3)
			relations.Add("DRACD", 4)
			relations.Add("DUMON", 5)
			relations.Add("EASTC", 6)
			relations.Add("ERNSH", 7)
			relations.Add("FAMIA", 8)
			relations.Add("FISSA", 9)
			relations.Add("FOLIG", 8)
			relations.Add("FOLKO", 8)
			relations.Add("FRANK", 5)
			relations.Add("FRANR", 3)
			relations.Add("FRANS", 2)
			relations.Add("FURIB", 1)
			relations.Add("GALED", 1)
			relations.Add("GODOS", 2)
			relations.Add("GOURL", 5)
			relations.Add("GREAL", 6)
			relations.Add("GROSR", 3)
			relations.Add("HANAR", 6)
			relations.Add("HILAA", 7)
			relations.Add("HUNGC", 9)
			relations.Add("HUNGO", 5)
			relations.Add("ISLAT", 4)
			relations.Add("KOENE", 3)
			relations.Add("LACOR", 4)
			relations.Add("LAMAI", 7)
			relations.Add("LAUGB", 9)
			relations.Add("LAZYK", 7)
			relations.Add("LEHMS", 8)
			relations.Add("LETSS", 4)
			relations.Add("LILAS", 4)
			relations.Add("LINOD", 3)
			relations.Add("LONEP", 2)
			relations.Add("MAGAA", 4)
			relations.Add("MAISD", 5)
			relations.Add("MEREP", 6)
			relations.Add("MORGK", 7)
			relations.Add("NORTS", 5)
			relations.Add("OCEAN", 9)
			relations.Add("OLDWO", 4)
			relations.Add("OTTIK", 3)
			relations.Add("PARIS", 2)
			relations.Add("PERIC", 1)
			relations.Add("PICCO", 1)
			relations.Add("PRINI", 2)
			relations.Add("QUEDE", 5)
			relations.Add("QUEEN", 6)
			relations.Add("QUICK", 7)
			relations.Add("RANCH", 2)
			relations.Add("RATTC", 3)
			relations.Add("REGGC", 5)
			relations.Add("RICAR", 4)
			relations.Add("RICSU", 6)
			relations.Add("ROMEY", 7)
			relations.Add("SANTG", 5)
			relations.Add("SAVEA", 6)
			relations.Add("SEVES", 4)
			relations.Add("SIMOB", 6)
			relations.Add("SPECD", 4)
			relations.Add("SPLIR", 6)
			relations.Add("SUPRD", 7)
			relations.Add("THEBI", 8)
			relations.Add("THECR", 2)
			relations.Add("TOMSP", 3)
			relations.Add("TORTU", 2)
			relations.Add("TRADH", 2)
			relations.Add("TRAIH", 1)
			relations.Add("VAFFE", 6)
			relations.Add("VICTE", 9)
			relations.Add("VINET", 8)
			relations.Add("WANDK", 5)
			relations.Add("WARTH", 5)
			relations.Add("WELLI", 5)
			relations.Add("WHITC", 4)
			relations.Add("WILMK", 3)
			relations.Add("WOLZA", 2)
		End Sub

		Public Function GetEmployee(ByVal id As Integer) As Employee
			For Each item As Employee In employees_Renamed
				If item.EmployeeID = id Then
					Return item
				End If
			Next item
			Return Nothing
		End Function

		Public Function GetCustomer(ByVal id As String) As Customer
			For Each item As Customer In customers_Renamed
				If item.CustomerID = id Then
					Return item
				End If
			Next item
			Return Nothing
		End Function

		Public Function GetEmployeeCustomers(ByVal employeeId As Integer) As List(Of String)
			Dim result As New List(Of String)()
			For Each item As KeyValuePair(Of String, Integer) In relations
				If item.Value = employeeId Then
					result.Add(item.Key)
				End If
			Next item
			Return result
		End Function

		Public Function GetCustomersList(ByVal employeeId As Integer) As List(Of Customer)
			Dim result As New List(Of Customer)()
			Dim customerList As List(Of String) = GetEmployeeCustomers(employeeId)
			For Each item As String In customerList
				Dim customer As Customer = GetCustomer(item)
				If customer IsNot Nothing Then
					result.Add(customer)
				End If
			Next item
			Return result
		End Function

	End Class
End Namespace
