using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inputdata;

namespace lab12zavd2
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrsize = 0;
            bool flag = true;
            
            while (flag)
            {
                double summ = 0;
                string output = "";

                if (!Input.Inint(ref arrsize, "введіть кількісь елементів массиву:"))
                    return;

                double[] arr;
                arr = new double[arrsize];

                for (int i = 0; i < arrsize; i++)
                {
                    if (!Input.Indouble(ref arr[i], $"введіть {i} елемент:"))
                        return;
                    summ += arr[i];
                }

                for (int i = 0; i < arrsize; i++)
                {
                    if (arr[i] % 2 == 0)
                        arr[i] = arr[i] * summ;

                    output += $"\n arr[{i}]={arr[i]}";
                }

                if (MessageBox.Show(output + "\n\nПовторити?", "Результат", MessageBoxButtons.YesNo) == DialogResult.No)
                    flag = false;
            }      
        }
    }
}
