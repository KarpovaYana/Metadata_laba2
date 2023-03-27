using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Метаданные_ТиМП_Лаб2
{
    internal class Dispatcher
    {
        public delegate void Action(object sender, EventArgs e);
        public static Action GetMethod(string methodName)
        {
            bool flag = true;
            Action action = null;
            switch (methodName)
            {
                case "Other":
                    action = Other;
                    break;
                case "Stuff":
                    action = Stuff;
                    break;
                case "Orders":
                    action = Orders;
                    break;
                case "Docs":
                    action = Docs;
                    break;
                case "Departs":
                    action = Departs;
                    break;
                case "Towns":
                    action = Towns;
                    break;
                case "Posts":
                    action = Posts;
                    break;
                case "Window":
                    action = Window;
                    break;
                case "Help":
                    action = Help;
                    break;
                case "Content":
                    action = Content;
                    break;
                case "About":
                    action = About;
                    break;
                case "Prog":
                    action = Prog;
                    break;
                default:
                    flag = false;
                    break;
            }
            if (flag == false)
                throw new Exception();
            return action;

        }
        private static void Other(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнился метод Other");
        }
        private static void Stuff(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнился метод Stuff");
        }
        private static void Orders(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнился метод Orders");
        }
        private static void Docs(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнился метод Docs");
        }
        private static void Departs(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнился метод Departs");
        }
        private static void Towns(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнился метод Towns");
        }
        private static void Posts(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнился метод Posts");
        }
        private static void Window(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнился метод Window");
        }
        private static void Help(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнился метод Help");
        }
        private static void Content(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнился метод Content");
        }
        private static void About(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнился метод About");
        }
        private static void Prog(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнился метод Prog");
        }
    }
}
