using Microsoft.VisualStudio.TestTools.UnitTesting;
using CookBook.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Managers.Tests
{
	[TestClass()]
	public class UserManagerTests
	{
		[TestMethod()]
		public void GetListTest()
		{

		}

		[TestMethod()]
		public void CheckUsersTest()
		{

		}

		[TestMethod()]
		public void ChangeUserPointsTest()
		{

		}

		[TestMethod()]
		public void CreateNewUserTest()
		{

		}

		[TestMethod()]
		public void GetLevelTest_5_1Returned()
		{
			var userManager = new UserManager();

			var level = userManager.GetLevel(5);

			Assert.AreEqual(1,level);
		}

		[TestMethod()]
		public void GetLevelTest_150_4Returned()
		{
			var userManager = new UserManager();

			var level = userManager.GetLevel(150);

			Assert.AreEqual(4, level);
		}
	}
}