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
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Collections;
using System.Text.RegularExpressions;

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
        private ArrayList words_result;

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnMoVB, "Mở văn bản");
            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip2.SetToolTip(this.btnTim, "Tìm");
            txtSoTheHe.Text = "100";
            txtXSLai.Text = "0.8";
            txtXSDotBien.Text = "0.05";
            txtHeSoA.Text = "0.7";
            txtHeSoB.Text = "0.3";
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
            dialog.Filter = "Text files | *.pdf"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                
                String path = dialog.FileName; // get name of file
                //string content;
                PdfReader reader = new PdfReader(path);
                string text = string.Empty;
                for (int page = 1; page <= reader.NumberOfPages; page++)
                {
                    text += PdfTextExtractor.GetTextFromPage(reader, page);
                }
                reader.Close();
                txtVanBan.Text = text;
                //using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) // do anything you want, e.g. read it
                //{
                txtDuongDan.Text = path;
                //    content = reader.ReadToEnd();
                //    txtVanBan.Text = content;

                //char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
                char[] delimiterChars = { ' ', '\t' };

                //    //string text = "one\ttwo three:four,five six seven";
                //    //System.Console.WriteLine("Original text: '{0}'", text);
                string[] splitText = text.Split(delimiterChars);
                List<string> result = new List<string>();
                foreach (string item in splitText)
                {
                    if (item != "")
                        result.Add(item);
                }
                words = result.ToArray();
                txtSoKyTu.Text = words.Count().ToString();
                //    //System.Console.WriteLine("{0} words in text:", words.Length);

                //    //for (int i = 0; i < words.Length; i++)
                //    //{
                //    //    txtVanBan.AppendText(words[i].ToString() + "\n");
                //    //}

                //    //txt_Result.Text = content;
                //}
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            executeSearch();
            
        }

        private void executeSearch()
        {
            if (checkInput() == "")
            {
                char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
                //char[] delimiterChars = { ' ', '\t' };
                words_search = txtTim.Text.Split(delimiterChars);

                int soTheHe = 0;
                int.TryParse(txtSoTheHe.Text, out soTheHe);
                double xacSuatLai = 0.8;
                double.TryParse(txtXSLai.Text, out xacSuatLai);
                double xacSuatDotBien = 0.05;
                double.TryParse(txtXSDotBien.Text, out xacSuatDotBien);
                double hsA = 0.7;
                double.TryParse(txtHeSoA.Text, out hsA);
                double hsB = 0.3;
                double.TryParse(txtHeSoB.Text, out hsB);

                GA ga = new GA(xacSuatLai, xacSuatDotBien, words.Length, soTheHe, hsA, hsB);

                ga.FitnessFunction = new GAFunction(theActualFunction);

                //ga.FitnessFile = @"H:\fitness.csv";
                ga.Elitism = true;
                ga.Go(words, words_search);

                //int values;
                //double fitness;
                //ga.GetBest(out values, out fitness);
                ////System.Console.WriteLine("Best ({0}):", fitness);
                ////for (int i = 0; i < values.Length; i++)
                ////    System.Console.WriteLine("{0} ", values[i]);
                ////label2.Text = fitness.ToString();
                //txtViTriXuatHien.Clear();
                //txtViTriXuatHien.AppendText("vi tri van ban " + (1 + values).ToString() + "\n");
                //txtViTriXuatHien.AppendText("do thich nghi " + fitness.ToString() + "\n");
                //string textResult = "";
                //int i = 0;
                //while (i < 20)
                //{
                //    textResult += words[values + i] + " ";
                //    i++;
                //}
                //txtResult.Text = textResult;

                this.words_result = ga.ThisGeneration;

                List<StoreResult> list = getResultPosition();


                txtViTriXuatHien.Clear();
                txtResult.Clear();
                foreach (StoreResult item in list)
                {
                    txtViTriXuatHien.AppendText(item.position + " ");
                    int tmpPos = item.position;
                    bool flag = false;
                    int i = tmpPos;
                    if (tmpPos == 0 || tmpPos == 1)
                    {
                        while (flag == false)
                        {
                            if (words[i].Contains("."))
                            {
                                txtResult.AppendText(words[i]);
                                flag = true;
                            }
                            else
                            {
                                txtResult.AppendText(words[i] + " ");
                                i++;
                            }
                        }
                    }
                    else
                    {
                        i = tmpPos;
                        int startSen = i;
                        while (flag == false)
                        {
                            if (words[i].Contains(".") || i == 0)
                            {
                                startSen = i + 1;
                                flag = true;
                            }
                            else
                            {
                                i--;
                            }
                        }
                        flag = false;
                        while (flag == false)
                        {
                            if (words[startSen].Contains("."))
                            {
                                txtResult.AppendText(words[startSen]);
                                flag = true;
                            }
                            else
                            {
                                txtResult.AppendText(words[startSen] + " ");
                                startSen++;
                            }
                        }
                    }
                    txtResult.AppendText("\n");
                     
                    //txtResult.Text = textResult;
                }
                
                
                
                //ga.GetWorst(out values, out fitness);
                //txtVanBan.AppendText(fitness.ToString() + "\n");
                //label3.Text = fitness.ToString();
                //System.Console.WriteLine("\nWorst ({0}):", fitness);
                //for (int i = 0; i < values.Length; i++)
                //    System.Console.WriteLine("{0} ", values[i]);

                //Console.ReadLine();
            }
            else
                MessageBox.Show(checkInput());
        }

        private List<StoreResult> getResultPosition()
        {
            List<StoreResult> list = new List<StoreResult>();
            int searchTextLength = words_search.Length;
            Genome g_last = ((Genome)words_result[words_result.Count - 1]);
            int position_last = int.Parse(Convert.ToInt32(g_last.S_genes, 2).ToString());
            StoreResult result_last = new StoreResult();
            result_last.position = position_last;
            result_last.fitness = g_last.Fitness;
            list.Add(result_last);
            for (int i = words_result.Count - 2; i > 0; i--)
            {
                Genome g = ((Genome)words_result[i]);
                int position = int.Parse(Convert.ToInt32(g.S_genes, 2).ToString());

                if ((list[list.Count - 1].position + searchTextLength) < position && g.Fitness > 0)
                {
                    StoreResult sr = new StoreResult();
                    sr.position = position;
                    sr.fitness = g.Fitness;
                    list.Add(sr);
                }
            }

            return list;
        }

        private string checkInput() 
        {
            string result = "";
            if (words == null)
                result += "Vui lòng chọn tệp tin văn bản\n";
            if (txtTim.Text == "")
                result += "Vui lòng nhập văn bản cần tìm\n";
            return result;
        }

        //  optimal solution for this is (0.5,0.5)
	        public static double theActualFunction(string gene, string[] S, string[] Sm, double hsA, double hsB)
	        {
                //if (values.GetLength(0) != 2)
                //    throw new ArgumentOutOfRangeException("should only have 2 args");

                //double x = values[0];
                //double y = values[1];
                //double n = 9;  //  should be an int, but I don't want to waste time casting.

                //double f1 = Math.Pow(15*x*y*(1-x)*(1-y)*Math.Sin(n*Math.PI*x)*Math.Sin(n*Math.PI*y),2);
                //return f1;
                double a = hsA;
                double b = hsB;
                //F(x) = a.G(x) + b.H(x)
                int position = int.Parse(Convert.ToInt32(gene, 2).ToString());
                double test = a * G(position, S, Sm) + b * H(position, S, Sm);
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
                //if (x == 0) 
                //    x = 1;
                for (int i = 1; i < Y.Count() && (i + x - 1) < X.Count(); i++)
                {
                    for (int j = 1; j < Y.Count(); j++)
                    {
                        string tmp = Regex.Replace(X[i + x - 1], "[^0-9a-zA-Z]+", "");
                        if (tmp == Y[j])
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
                    for (int j = positionX; j < (positionX + Sm.Length) && j < S.Length; j++)
                    {
                        string tmp = Regex.Replace(S[j], "[^0-9a-zA-Z]+", "");
                        if (Sm[i] == tmp)
                            count++;
                    }
                }
                return count;
            }

            private void txtDuongDan_TextChanged(object sender, EventArgs e)
            {

            }

            private void txtTim_KeyDown(object sender, KeyEventArgs e)
            {
                
                if (e.KeyValue == 13)
                {
                    executeSearch();
                }
            }

            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

            private void label10_Click(object sender, EventArgs e)
            {

            }

            class StoreResult {
                public int position { get; set; }
                public double fitness { get; set; }
            }
           
    }
}
