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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_LoadFile_Click(object sender, EventArgs e)
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
                    lb_Path.Text = path;
                    content = reader.ReadToEnd();

                    char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

                    //string text = "one\ttwo three:four,five six seven";
                    //System.Console.WriteLine("Original text: '{0}'", text);

                    string[] words = content.Split(delimiterChars);
                    //System.Console.WriteLine("{0} words in text:", words.Length);

                    for (int i = 0; i < words.Length; i++)
                    {
                        txt_Result.AppendText(words[i].ToString() + "\n");
                    }

                        //txt_Result.Text = content;
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            GA ga = new GA(0.8, 0.05, 100, 2000, 2);

            ga.FitnessFunction = new GAFunction(theActualFunction);

            //ga.FitnessFile = @"H:\fitness.csv";
            ga.Elitism = true;
            ga.Go();

            double[] values;
            double fitness;
            ga.GetBest(out values, out fitness);
            //System.Console.WriteLine("Best ({0}):", fitness);
            //for (int i = 0; i < values.Length; i++)
            //    System.Console.WriteLine("{0} ", values[i]);
            //label2.Text = fitness.ToString();
            txt_Result.AppendText(fitness.ToString() + "\n");

            ga.GetWorst(out values, out fitness);
            txt_Result.AppendText(fitness.ToString() + "\n");
            //label3.Text = fitness.ToString();
            //System.Console.WriteLine("\nWorst ({0}):", fitness);
            //for (int i = 0; i < values.Length; i++)
            //    System.Console.WriteLine("{0} ", values[i]);

            //Console.ReadLine();
            
        }

        //  optimal solution for this is (0.5,0.5)
	        public static double theActualFunction(double[] values)
	        {
		        if (values.GetLength(0) != 2)
			        throw new ArgumentOutOfRangeException("should only have 2 args");

		        double x = values[0];
		        double y = values[1];
		        double n = 9;  //  should be an int, but I don't want to waste time casting.

		        double f1 = Math.Pow(15*x*y*(1-x)*(1-y)*Math.Sin(n*Math.PI*x)*Math.Sin(n*Math.PI*y),2);
		        return f1;
	        }
    }
}
