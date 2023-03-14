using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsServiceStationApp
{
    public static class ExtensionMethods // Для использования двойного буфера, чтобы не мерцал экран
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }


        public static void MouseDownSelectRow_UserOverride(this DataGridView dgv, MouseEventArgs e, ref int indexForShowDGV, ref int curMouseOverRow)
        {
            if (e.Button == MouseButtons.Right && dgv.Rows.Count > 0)
            {
                curMouseOverRow = dgv.HitTest(e.X, e.Y).RowIndex;
                if (curMouseOverRow >= 0)
                {
                    dgv.Rows[curMouseOverRow].Selected = true;
                    indexForShowDGV = curMouseOverRow;
                }
            }
        }

        public static void RowPrePait_UserOverride(this DataGridView dgv, DataGridViewRowPrePaintEventArgs e)
        {
            object head = dgv.Rows[e.RowIndex].HeaderCell.Value;
            if (head == null ||
                !head.Equals((e.RowIndex + 1).ToString()))
                dgv.Rows[e.RowIndex].HeaderCell.Value =
                    (e.RowIndex + 1).ToString();
        }

        public static Expression<Func<T, bool>> And<T>(
        this Expression<Func<T, bool>> expr1, Expression<Func<T, bool>> expr2)
        {

            //////////////////////////////////////////////////
                // сделал чтоб применять AND к инициализированному null обьекту и когда второй для добавления нулевой
           
            if (expr1 == null)
            {
                if (expr2 == null)
                    return null;
                else
                    return expr2;
            }
            else
            {
                if (expr2 == null)
                    return expr1;
            }


            ////////////////////////////////////////////////  

                var invokedExpr = Expression.Invoke(expr2,
            expr1.Parameters.Cast<Expression>());
            return Expression.Lambda<Func<T, bool>>(
            Expression.AndAlso(expr1.Body, invokedExpr), expr1.Parameters);
        }

        public static List<T> AsList<T>(this T elem)
        {
            List<T> List = new List<T>();
            List.Add(elem);
            return List;
        }

        public static void UniverseInvoke(this Control control, Action action)
        {
            if (control.InvokeRequired)
                control.Invoke(action);
            else
                action();     
        }
    }

    public static class JsonExtensions
    {
        public static string SerializeToJson(this object SourseObject) => Newtonsoft.Json.JsonConvert.SerializeObject(SourseObject);
        public static T JsonToObject<T>(this string JsonString) => (T)Newtonsoft.Json.JsonConvert.DeserializeObject<T>(JsonString);      
    }
}
