﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace threeLevel
{
    static class Program
    {
        public static mainWindow mw;
        public static Stack <Form> tlevelsForm = new Stack<Form>();
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mw = new mainWindow();
            Application.Run(mw);
        }
    }
}
