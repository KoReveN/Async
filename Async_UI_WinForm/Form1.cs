using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Async_UI_WinForm
{
    public partial class Form1 : Form
    {
        private readonly SynchronizationContext synchronizationContext;
        private DateTime previousTime = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
            synchronizationContext = SynchronizationContext.Current;
        }

        private async void btnDoWorkAsync_Click(object sender, EventArgs e)
        {
            ////btnDoWorkAsync.Enabled = false;

            ////for (var i = 0; i <= 5000; i++)
            ////{
            ////    txtResult.Text = "Counter " + i;
            ////    await Task.Delay(1);
            ////}

            ////btnDoWorkAsync.Enabled = true;

            //for (var i = 0; i <= 5000; i++)
            //{
            //    txtResult.Text = @"Counter = " + i;
            //}

            btnDoWorkAsync.Enabled = false;
            var count = 0;

            await Task.Run(() =>
            {
                for (var i = 0; i <= 5000000; i++)
                {
                    UpdateUI(i);
                    count = i;
                }
            });

            txtResult.Text = @"Counter " + count;
            btnDoWorkAsync.Enabled = true;

        }


        public void UpdateUI(int value)
        {
            var timeNow = DateTime.Now;

            if ((DateTime.Now - previousTime).Milliseconds <= 50) return;

            // synchronizationContext.Send(); - ожидает ответа что метод выполнен (использовать при работе с БД)
            // synchronizationContext.Post(); - не ожидает ответа (исп. для отображения процента выполнения и т.д.)
            synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                txtResult.Text = @"Counter " + (int)o;
            }), value);

            previousTime = timeNow;
        }

    }
}
