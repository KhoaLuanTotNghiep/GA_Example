using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using btl.generic;

namespace GA_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] words;
        string[] words_search;

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnMoVB, "Mở văn bản");
            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip2.SetToolTip(this.btnTim, "Tìm");
        }

        private void btnMoVB_Click(object sender, EventArgs e)
        {
            //DialogResult result = openFileDialog1.ShowDialog();
            //if (result == DialogResult.OK) // Test result.
            //{
            //Do whatever you want
            //openFileDialog1.FileName .....
            //}
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file
                string content;
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                {
                    txtDuongDan.Text = path;
                    content = reader.ReadToEnd();

                    char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

                    //string text = "one\ttwo three:four,five six seven";
                    //System.Console.WriteLine("Original text: '{0}'", text);
                    string[] splitText = content.Split(delimiterChars);
                    List<string> result = new List<string>();
                    foreach (string item in splitText)
                    {
                        if (item != "")
                            result.Add(item);
                    }
                    words = result.ToArray();
                    //System.Console.WriteLine("{0} words in text:", words.Length);

                    for (int i = 0; i < words.Length; i++)
                    {
                        txtVanBan.AppendText(words[i].ToString() + "\n");
                    }

                    //txt_Result.Text = content;
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            words_search = txtTim.Text.Split(delimiterChars);

            GA ga = new GA(0.8, 0.05, 100, 2000, 2);

            ga.FitnessFunction = new GAFunction(theActualFunction);

            //ga.FitnessFile = @"H:\fitness.csv";
            ga.Elitism = true;
            ga.Go(words, words_search);

            double[] values;
            double fitness;
            ga.GetBest(out values, out fitness);
            //System.Console.WriteLine("Best ({0}):", fitness);
            //for (int i = 0; i < values.Length; i++)
            //    System.Console.WriteLine("{0} ", values[i]);
            //label2.Text = fitness.ToString();
            txtVanBan.AppendText(fitness.ToString() + "\n");

            ga.GetWorst(out values, out fitness);
            txtVanBan.AppendText(fitness.ToString() + "\n");
            //label3.Text = fitness.ToString();
            //System.Console.WriteLine("\nWorst ({0}):", fitness);
            //for (int i = 0; i < values.Length; i++)
            //    System.Console.WriteLine("{0} ", values[i]);

            //Console.ReadLine();
            
        }

        //  optimal solution for this is (0.5,0.5)
	        public static double theActualFunction(string gene, string[] S, string[] Sm)
	        {
                //if (values.GetLength(0) != 2)
                //    throw new ArgumentOutOfRangeException("should only have 2 args");

                //double x = values[0];
                //double y = values[1];
                //double n = 9;  //  should be an int, but I don't want to waste time casting.

                //double f1 = Math.Pow(15*x*y*(1-x)*(1-y)*Math.Sin(n*Math.PI*x)*Math.Sin(n*Math.PI*y),2);
                //return f1;
                double a = 0.7;
                double b = 0.3;
                //F(x) = a.G(x) + b.H(x)
                int position = int.Parse(Convert.ToInt32(gene, 2).ToString());
                return a * G(position, S, Sm) + b * H(position, S, Sm);
	        }

            public static int G(int x, string[] X, string[] Y)
            {
                int[,] L = new int[Y.Count(), Y.Count()];
                for (int i = 0; i < Y.Count(); i++)
                {
                    L[i, 0] = 0;
                }
                for (int j = 0; j < Y.Count(); j++)
                {
                    L[0, j] = 0;
                }
                if (x == 0)
                    x = 1;
                for (int i = x; i < Y.Count(); i++)
                {
                    for (int j = 1; j < Y.Count(); j++)
                    {
                        if (X[i] == Y[j])
                        {
                            L[i, j] = L[i - 1, j - 1] + 1;
                        }
                        else
                        {
                            L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]);
                        }
                    }
                }
                return L[Y.Count() - 1, Y.Count() - 1];
            }

            public static int H(int positionX, string[] S, string[] Sm)
            {
                int count = 0;
                for (int i = 0; i < Sm.Length; i++)
                {
                    for (int j = 0; j < Sm.Length; j++)
                    {
                        if (Sm[i] == S[j])
                            count++;
                    }
                }
                return count;
            }
           
    }
}
