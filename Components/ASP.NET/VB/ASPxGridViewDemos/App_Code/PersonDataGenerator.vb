﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Text

Namespace DevExpress.Web.Demos

	Public NotInheritable Class PersonDataGenerator
		Private Shared table_Renamed As DatabaseGenerator.TableData
		Private Shared ReadOnly firstNames() As String = { "Aaron", "Abby", "Abigail", "Adam", "Adriana", "Aimee", "Alan", "Albert", "Alberto", "Alejandro", "Alex", "Alexander", "Alexandra", "Alexandria", "Alexia", "Alfredo", "Alicia", "Alisha", "Alison", "Allison", "Alvin", "Alyssa", "Amanda", "Amy", "Ana", "Andrea", "Andres", "Andy", "Angela", "Angelica", "Ann", "Anna", "April", "Ariana", "Arianna", "Armando", "Arthur", "Arturo", "Ashlee", "Ashley", "Audrey", "Austin", "Bailey", "Barbara", "Beth", "Bethany", "Bianca", "Billy", "Blake", "Bob", "Bobby", "Bonnie", "Brandi", "Brandon", "Brandy", "Brenda", "Brendan", "Brett", "Brian", "Briana", "Brianna", "Bridget", "Brittany", "Brittney", "Brooke", "Bruce", "Bryan", "Bryce", "Caitlin", "Caleb", "Cameron", "Candace", "Candice", "Cara", "Carl", "Carmen", "Carol", "Caroline", "Carrie", "Casey", "Cassandra", "Cassidy", "Cedric", "Chad", "Charles", "Cheryl", "Chloe", "Christina", "Christopher", "Christy", "Clayton", "Clifford", "Clinton", "Cody", "Cole", "Colin", "Colleen", "Connor", "Cory", "Courtney", "Crystal", "Cynthia", "Daisy", "Dakota", "Dale", "Dalton", "Damien", "Dan", "Dana", "Danielle", "Danny", "Darren", "David", "Dawn", "Deanna", "Deborah", "Debra", "Denean", "Dennis", "Derrick", "Desiree", "Destiny", "Devin", "Devon", "Diana", "Diane", "Dominique", "Don", "Donald", "Donna", "Douglas", "Drew", "Dustin", "Dwayne", "Dylan", "Ebony", "Eddie", "Edgar", "Eduardo", "Edward", "Edwin", "Elena", "Elijah", "Elsa", "Emily", "Emma", "Emmanuel", "Erica", "Erika", "Erin", "Ethan", "Evan", "Evelyn", "Faith", "Fernando", "Francisco", "Frank", "Franklin", "Fred", "Frederick", "Gabriel", "Gabrielle", "Garrett", "Gary", "George", "Gerald", "Gilbert", "Glenn", "Grant", "Greg", "Gregory", "Hailey", "Haley", "Hannah", "Heather", "Hector", "Heidi", "Henry", "Holly", "Hunter", "Ian", "Imtiaz", "Isabel", "Isabella", "Isabelle", "Isaiah", "Jack", "Jackie", "Jackson", "Jaclyn", "Jacob", "Jacqueline", "Jada", "Jae", "Jaime", "Jake", "James", "Jamie", "Jan", "Janet", "Jarrod", "Jasmine", "Jason", "Javier", "Jay", "Jean", "Jeffery", "Jenna", "Jennifer", "Jeremiah", "Jeremy", "Jermaine", "Jerome", "Jerry", "Jesse", "Jessica", "Jessie", "Jesus", "Jill", "Jillian", "Jimmy", "Jo", "Joan", "Joanna", "Jocelyn", "Joel", "John", "Johnny", "Jon", "Jonathan", "Jonathon", "Jordan", "Jordyn", "Jorge", "Jose", "Joseph", "Joshua", "Joy", "Juan", "Julia", "Julio", "Justin", "Kaitlin", "Kaitlyn", "Kara", "Karen", "Kari", "Karla", "Kate", "Katelyn", "Katherine", "Kathie", "Kathryn", "Katrina", "Kayla", "Kaylee", "Keith", "Kelli", "Kelly", "Kelsey", "Kelvin", "Ken", "Kendra", "Kenneth", "Kevin", "Kimberly", "Krishna", "Krista", "Kristen", "Kristi", "Kristine", "Krystal", "Kurt", "Kyle", "Lacey", "Lance", "Larry", "Latasha", "Latoya", "Laura", "Lauren", "Leah", "Leonard", "Leslie", "Levi", "Linda", "Lindsay", "Lindsey", "Lisa", "Logan", "Lori", "Louis", "Lucas", "Luis", "Luke", "Lydia", "Maciej", "Mackenzie", "Madison", "Magnus", "Makayla", "Mandy", "Manuel", "Marco", "Marcus", "Margaret", "Maria", "Mariah", "Marie", "Marissa", "Marshall", "Martin", "Marvin", "Mary", "Mason", "Mathew", "Maurice", "Megan", "Meghan", "Melanie", "Melissa", "Meredith", "Michael", "Micheal", "Michele", "Miguel", "Mindy", "Misty", "Mitchell", "Molly", "Monica", "Monique", "Morgan", "Mya", "Nancy", "Naomi", "Natalie", "Natasha", "Nathan", "Neil", "Nichole", "Nicolas", "Nicole", "Nina", "Noah", "Olivia", "Omar", "Oscar", "Paige", "Pamela", "Patricia", "Patrick", "Paula", "Peter", "Phillip", "Phyllis", "Priscilla", "Rachel", "Rafael", "Ramon", "Randy", "Raquel", "Raymond", "Rebecca", "Rebekah", "Reginald", "Renee", "Renee", "Ricardo", "Richard", "Ricky", "Riley", "Robert", "Roberto", "Robin", "Robyn", "Roger", "Rolando", "Rosa", "Ross", "Rossane", "Roy", "Ruben", "Russell", "Ryan", "Sairaj", "Samantha", "Samuel", "Sandra", "Sara", "Sarah", "Scott", "Sebastian", "Sergio", "Seth", "Shane", "Shannon", "Sharon", "Shawn", "Sheila", "Shelby", "Shyamalan", "Sierra", "Stacey", "Stacy", "Stefan", "Stephanie", "Summer", "Suzanne", "Sydney", "Tabitha", "Tamara", "Tammy", "Tara", "Tasha", "Taylor", "Teresa", "Terry", "Theodore", "Thomas", "Tiffany", "Tina", "Todd", "Tommy", "Tonya", "Tracy", "Trinity", "Tristan", "Troy", "Tyler", "Valerie", "Vanessa", "Veronica", "Victor", "Victoria", "Vincent", "Virginia", "Walter", "Wesley", "Whitney", "William", "Willie", "Wyatt", "Xavier", "Yolanda", "Zachary", "Zheng" }
		Private Shared ReadOnly lastNames() As String = { "Adams", "Alexander", "Allen", "Alonso", "Alvarez", "Anand", "Andersen", "Anderson", "Arthur", "Arun", "Bailey", "Baker", "Barnes", "Beck", "Becker", "Bell", "Belli", "Bennett", "Black", "Blackwell", "Blanco", "Blue", "Bradley", "Brooks", "Brown", "Bryant", "Butler", "Byrnes", "Cai", "Campbell", "Carlson", "Carothers", "Carter", "Chande", "Chander", "Chandra", "Chapman", "Chen", "Chisholm", "Chow", "Clark", "Coleman", "Collins", "Cook", "Cooper", "Cox", "Creasey", "Davis", "Delmarco", "Deng", "Diaz", "Dominguez", "Dusza", "Edwards", "Evans", "Fernandez", "Ferrier", "Fine", "Flood", "Flores", "Foster", "Gao", "Garcia", "German", "Gill", "Glimp", "Goel", "Goldberg", "Gomez", "Gonzales", "Gonzalez", "Gray", "Green", "Griffin", "Groncki", "Guo", "Gutierrez", "Guzik", "Hagens", "Hall", "Harris", "Haugh", "Hayes", "He", "Hedlund", "Hee", "Henderson", "Hernandez", "Hill", "Hite", "Hohman", "Howard", "Hu", "Huang", "Huff", "Hughes", "Ison", "Jackson", "Jai", "James", "Jenkins", "Jimenez", "Jimenez", "Johnsen", "Johnson", "Johnston", "Jones", "Kaffer", "Kapoor", "Keiser", "Kelly", "Khan", "King", "Kumar", "Kwok", "Lal", "Leavitt", "Lee", "Lewis", "Li", "Liang", "Lin", "Liu", "Logan", "Long", "Lopez", "Lu", "Luo", "Ma", "Madan", "Malhotra", "Margheim", "Markwood", "Martin", "McDonald", "McKinley", "McPhearson", "McSharry Jensen", "Mehta", "Michaels", "Miller", "Mitchell", "Mitzner", "Moore", "Moreno", "Morgan", "Morris", "Mu", "Munoz", "Munoz", "Murphy", "Nara", "Nath", "Navarro", "Nelsen", "Nelson", "Ngoh", "Ortega", "Pak", "Pal", "Parker", "Patel", "Pather", "Patterson", "Perez", "Perry", "Peterson", "Phillips", "Powell", "Prasad", "Preston", "Price", "Rai", "Raje", "Raji", "Raman", "Ramirez", "Ramos", "Rana", "Randall", "Reategui Alayo", "Reed", "Richardson", "Richmeier", "Rivera", "Roberts", "Robinson", "Rodriguez", "Rogers", "Romero", "Ross", "Rowe", "Rubio", "Ruiz", "Russell", "Sai", "Salavaria", "Sanchez", "Sanchez", "Sanders", "Sandoval", "Sanz", "Sara", "Schmidt", "Scott", "Serrano", "Several", "Severino", "Shan", "Sharma", "She", "Shen", "Simmons", "Smith", "Srini", "Steele", "Stewart", "Stone", "Suarez", "Subram", "Sullivan", "Sun", "Sunkammurali", "Suri", "Tanara", "Tang", "Taylor", "Thomas", "Thompson", "Thoreson", "Torres", "Townsend", "Trenary", "Turner", "Uddin", "Van", "Vance", "Vazquez", "Velez Amezaga", "Vicknair", "Walker", "Walton", "Wang", "Ward", "Washington", "Watkins", "Watson", "West", "White", "Whitworth", "Williams", "Wilson", "Winston", "Wood", "Wright", "Wu", "Xie", "Xu", "Yang", "Ye", "Young", "Yuan", "Zeng", "Zhang", "Zhao", "Zheng", "Zhou", "Zhu", "Zimmerman" }
		Private Sub New()
		End Sub
		Public Shared ReadOnly Property Table() As DatabaseGenerator.TableData
			Get
				Return table_Renamed
			End Get
		End Property
		Public Shared Sub Register()
			table_Renamed = New DatabaseGenerator.TableData()
			table_Renamed.Name = "Persons"
			table_Renamed.ConnectionStringName = "LargeDatabaseConnectionString"
			table_Renamed.Fields.Add(New DatabaseGenerator.FieldData("FirstName", firstNames))
			table_Renamed.Fields.Add(New DatabaseGenerator.FieldData("LastName", lastNames))
			table_Renamed.Fields.Add(New DatabaseGenerator.FieldData("Phone", AddressOf GeneratePhone))
			table_Renamed.RecordCount = 20000
			DatabaseGenerator.RegisterTable("GeneratedPersonTable", table_Renamed)
		End Sub
		Private Shared Function GeneratePhone(ByVal rnd As Random) As Object
			Dim builder As New StringBuilder("1 (")
			builder.Append(rnd.Next(523, 529))
			builder.Append(") ")
			builder.Append(rnd.Next(100, 999))
			builder.Append("-")
			builder.AppendFormat("{0:0000}", rnd.Next(0, 9999))
			Return builder.ToString()
		End Function
	End Class
End Namespace