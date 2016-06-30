using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CookBook.Models;
using System.Windows.Forms;

namespace CookBook.Managers
{
    public class TestManager
    {
        public bool CreateTestName(List<Recipe> recipes, int index)
        {
           TestName tn = new TestName(recipes[index].Image, recipes[index].Name, recipes);
            if (tn.ShowDialog() == DialogResult.OK)
            {
                if (tn.right)
                {
                    tn.Close();
                    return true;
                }
                else
                {
                    tn.Close();
                    return false;
                }
            }
            else return false;
        }

        //public bool CreateTestIngred(List<Recipe> recipes, int index)
        //{
        //    TestIngredients ti = new TestIngredients(recipes[index].Image, recipes[index].Name, recipes);
        //    if (ti.ShowDialog() == DialogResult.OK)
        //    {
        //        if (ti.right)
        //        {
        //            ti.Close();
        //            return true;
        //        }
        //        else
        //        {
        //            ti.Close();
        //            return false;
        //        }
        //    }
        //    else return false;
        //}
    }
}
