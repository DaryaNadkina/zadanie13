using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Create(int[] array)
        {
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = r.Next(0, 31);
            Array.Sort(array);
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            textBox17.Clear();
            textBoxResult.Clear();
            int[] array10 = new int[10], array17 = new int[17], arrayResult = new int[27];
            int k = 0, i, j;
            Create(array10);
            Create(array17);
            Array.Reverse(array17);
            i = 0; j = 16;
            arrayResult[k++] = array10[i] < array17[j] ? array10[i++] : array17[j--];
            int x;
            for (; i < 10 && j >= 0;)
            {
                x = array10[i] < array17[j] ? array10[i++] : array17[j--];
                if (arrayResult[k - 1] != x)
                {
                    arrayResult[k++] = x;
                }
            }

            if (i == 10)
                for (; j >= 0; j--)
                {
                    x = array17[j];
                    if (arrayResult[k - 1] != x)
                        arrayResult[k++] = x;
                }
            else
                for (; i < 10; i++)
                {
                    x = array10[i];
                    if (arrayResult[k - 1] != x)
                        arrayResult[k++] = x;
                }
            Show(textBox10, array10, 10);
            Show(textBox17, array17, 17);
            Show(textBoxResult, arrayResult, k);
        }
        private void Show(TextBox textBox,int[] array,int k)
        {
            for (int i = 0; i < k; i++)
                textBox.Text += array[i].ToString() + " ";
        }
    }
}
