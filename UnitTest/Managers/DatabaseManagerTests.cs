using Microsoft.VisualStudio.TestTools.UnitTesting;
using CookBook.Managers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Managers.Tests
{
	[TestClass()]
	public class DatabaseManagerTests
	{
		[TestMethod()]
		public void DatabaseManagerTest_ObjectNotNull()
		{
			var db = new DatabaseManager();

			Assert.IsNotNull(db);
		}

		[TestMethod()]
		public void CreateDataBaseTest_FileExist()
		{
			if (!File.Exists(@"Database.qlite"))
			{
				var db = new DatabaseManager();

				db.CreateDataBase();

				Assert.IsTrue(File.Exists(@"Database.sqlite"));
			}
		}

		[TestMethod()]
		public void GetFullListTest()
		{

		}

		[TestMethod()]
		public void AddUserTest()
		{

		}

		[TestMethod()]
		public void AddCategoryTest()
		{

		}

		[TestMethod()]
		public void AddIngredTest()
		{

		}

		[TestMethod()]
		public void AddRecipeTest()
		{

		}

		[TestMethod()]
		public void DeleteTest()
		{

		}

		[TestMethod()]
		public void UpdateTest()
		{

		}

		[TestMethod()]
		public void RequestTest()
		{

		}

		[TestMethod()]
		public void CheckIdTest()
		{

		}
	}
}