using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using AForge;
using AForge.Neuro;
using AForge.Neuro.Learning;
using AForge.Controls;


#region GREADY_E_PERCEPTRON

namespace GreedyAlgorithm
{
    public partial class Form1 : Form
    {
        // cidades

        string[] cidades = new string[] {
            "Arad",
            "Bucharest",
            "Craiova",
            "Dobreta",
            "Eforie",
            "Fagaras",
            "Giurgiu",
            "Hirsova",
            "lasi",
            "Lugoj",
            "Mehadia",
            "Neamt",
            "Oradea",
            "Pitesti",
            "Rimnicu Vilcea",
            "Sibiu",
            "Timisoara",
            "Urziceni",
            "Vaslui",
            "Zerind"
        };

        // distancia direta entre Bucharest e as outras cidades

        int[] linhaRetaEntreCidades = new int[] { 336, 0, 160, 242, 161, 178, 77, 151, 226, 244, 241, 234, 380, 98, 193, 253, 329, 80, 199, 374 };
        int[] velocidadeMedia = new int[] { 336, 0, 160, 242, 161, 178, 77, 151, 226, 244, 241, 234, 380, 98, 193, 253, 329, 80, 199, 374 };

        //

        int[][] entreCidades = new int[][] {

            //20X20
            new int [] { 0,     999,    999,    999,    999,    999,    999,    999,    999,    999,    999,    999,    999,    999,    999,    140,    118,    999,    999,    75  },
            new int [] { 999,   0,      999,    999,    999,    211,    90,     999,    999,    999,    999,    999,    999,    101,    999,    999,    999,    85,     999,    999 },
            new int [] { 999,   999,    0,      120,    999,    999,    999,    999,    999,    999,    999,    999,    999,    138,    146,    999,    999,    999,    999,    999 },
            new int [] { 999,   999,    120,    0,      999,    999,    999,    999,    999,    999,    75,     999,    999,    999,    999,    999,    999,    999,    999,    999 },
            new int [] { 999,   999,    999,    999,    0,      999,    999,    86,     999,    999,    999,    999,    999,    999,    999,    999,    999,    999,    999,    999 },
            new int [] { 999,   211,    999,    999,    999,    0,      999,    999,    999,    999,    999,    999,    999,    999,    999,    99,     999,    999,    999,    999 },
            new int [] { 999,   90,     999,    999,    999,    999,    0,      999,    999,    999,    999,    999,    999,    999,    999,    999,    999,    999,    999,    999 },
            new int [] { 999,   999,    999,    999,    86,     999,    999,    0,      999,    999,    999,    999,    999,    999,    999,    999,    999,    98,     999,    999 },
            new int [] { 999,   999,    999,    999,    999,    999,    999,    999,    0,      999,    999,    87,     999,    999,    999,    999,    999,    999,    92,     999 },
            new int [] { 999,   999,    999,    999,    999,    999,    999,    999,    999,    0,      70 ,    999,    999,    999,    999,    999,    111,    999,    999,    999 },
            new int [] { 999,   999,    999,    75,     999,    999,    999,    999,    999,    70,     0,      999,    999,    999,    999,    999,    999,    999,    999,    999 },
            new int [] { 999,   999,    999,    999,    999,    999,    999,    999,    87,     999,    999,    0,      999,    999,    999,    999,    999,    999,    999,    999 },
            new int [] { 999,   999,    999,    999,    999,    999,    999,    999,    999,    999,    999,    999,    0,      999,    999,    151,    999,    999,    999,    71  },
            new int [] { 999,   101,    138,    999,    999,    999,    999,    999,    999,    999,    999,    999,    999,    0,      97,     999,    999,    999,    999,    999 },
            new int [] { 999,   999,    146,    999,    999,    999,    999,    999,    999,    999,    999,    999,    999,    97,     0,      80,     999,    999,    999,    999 },
            new int [] { 140,   999,    999,    999,    999,    99,     999,    999,    999,    999,    999,    999,    151,    999,    80,     0,      999,    999,    999,    999 },
            new int [] { 118,   999,    999,    999,    999,    999,    999,    999,    999,    111,    999,    999,    999,    999,    999,    999,    0,      999,    999,    999 },
            new int [] { 999,   85,     999,    999,    999,    999,    999,    98,     999,    999,    999,    999,    999,    999,    999,    999,    999,    0,      142,    999 },
            new int [] { 999,   999,    999,    999,    999,    999,    999,    999,    92,     999,    999,    999,    999,    999,    999,    999,    999,    142,    0,      999 },
            new int [] { 75,    999,    999,    999,    999,    999,    999,    999,    999,    999,    999,    999,    71,     999,    999,    999,    999,    999,    999,    0   }

        };

        // grafo
        List<List<no>> grafo = new List<List<no>>();


        public Form1()
        {
            InitializeComponent();


            //
            chart1.AddDataSeries("Cidades", Color.Green, Chart.SeriesType.Dots, 6, false);
            chart1.AddDataSeries("Caminho", Color.Gray, Chart.SeriesType.Line, 1, false);
            chart1.RangeX = new DoubleRange(0, 1000);
            chart1.RangeY = new DoubleRange(0, 1000);

            UpdateSettings();
            GenerateMap();


        }

        /// <summary>
        /// Função que retorna o index de uma deternminada cidade
        /// </summary>
        /// <param name="cidade"></param>
        /// <returns>index</returns>
        private int RetornaIndex(string cidade)
        {
            int index = 0;

            for (int i = 0; i < cidades.Count(); i++)
            {
                if (Object.Equals(cidade, cidades[i]))
                {
                    index = i;
                }
            }
            return index;
        }

        private int RetornaMenorDisponivel(no a, no b, no c)
        {
            if (!a.Visited) return a.Index;
            if (!b.Visited) return a.Index;
            if (!c.Visited) return a.Index;

            return -1;
        }


        private void PrintDataSet()
        {
            rTb_Output.AppendText("Data Set:\n");
            for (int i = 0; i < entreCidades.Count(); i++)
            {
                for (int j = 0; j < entreCidades[i].Count(); j++)
                {
                    rTb_Output.AppendText(" " + entreCidades[i][j].ToString());
                }
                rTb_Output.AppendText("\n");
            }
        }

        private void PrintGrafo()
        {
            rTb_Output.AppendText("Dados do grafo:\n");
            for (int i = 0; i < grafo.Count(); i++)
            {
                for (int j = 0; j < grafo[i].Count(); j++)
                {
                    rTb_Output.AppendText(" " + grafo[i][j].Index);
                }
                rTb_Output.AppendText("\n");
            }
        }


        private void PrintGrafoEuristica()
        {
            rTb_Output.AppendText("Euristica do grafo:\n");
            for (int i = 0; i < grafo.Count(); i++)
            {
                for (int j = 0; j < grafo[i].Count(); j++)
                {
                    rTb_Output.AppendText(" " + linhaRetaEntreCidades[grafo[i][j].Index]);
                }
                rTb_Output.AppendText("\n");
            }
        }



        private bool EncontraCaminhoProfundidade(int inicio, int fim, int anterior, int cont)
        {

            // se encontrar retornamos true
            grafo[inicio][cont].Visited = true;
            if (inicio != fim) rTb_Output.AppendText(cidades[grafo[inicio][cont].Index] + "\n");

            if (inicio == fim)
            {
                grafo[inicio][cont].CityBool = true;
                MessageBox.Show("Encontramos a cidade");
                return true;
            }
            // Só estamos a verificar o INDEX 0 é necessário alterar o algoritmo
            else if (!grafo[grafo[inicio][cont].Index][cont].Visited) return EncontraCaminhoProfundidade(grafo[inicio][cont].Index, fim, inicio, cont);
            else return false;
        }


        private void PopularGrafoEuristica()
        {
            for (int i = 0; i < entreCidades.Count(); i++)
            {
                List<no> part = new List<no>();
                List<no> partAux = new List<no>();
                // IEnumerable<no> query;

                for (int j = 0; j < entreCidades[i].Count(); j++)
                {
                    if (entreCidades[i][j] != 999 && entreCidades[i][j] != 0) part.Add(new no() { Euristic = linhaRetaEntreCidades[j], Index = j, CityBool = false, Visited = false });
                }

                // nao esta a funcionar...
                //part.OrderBy(no => no.Euristic);
                //part.Sort((x, y) => int.(x.Euristic, y.Euristic));
                //part.Sort();
                partAux = part.OrderBy(no => no.Euristic).ToList();
                grafo.Add(partAux);
                part.Clear();
            }
        }



        private void PopularGrafoA()
        {
            for (int i = 0; i < entreCidades.Count(); i++)
            {
                List<no> part = new List<no>();
                List<no> partAux = new List<no>();
                // IEnumerable<no> query;

                for (int j = 0; j < entreCidades[i].Count(); j++)
                {
                    if (entreCidades[i][j] != 999 && entreCidades[i][j] != 0) part.Add(new no() { Euristic = linhaRetaEntreCidades[j] + entreCidades[i][j], Index = j, CityBool = false, Visited = false });
                }

                // nao esta a funcionar...
                //part.OrderBy(no => no.Euristic);
                //part.Sort((x, y) => int.(x.Euristic, y.Euristic));
                //part.Sort();
                partAux = part.OrderBy(no => no.Euristic).ToList();
                grafo.Add(partAux);
                part.Clear();
            }
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="cidades"></param>
        /// <param name="linhaRetaEntreCidades"></param>
        /// <param name="cidadeInicio"></param>
        private void GreedySearch(string[] cidades, int[] linhaRetaEntreCidades, string cidadeInicio)
        {

            string cidadeInicial = "";
            int index = 0;
            // lista temporaria para guardar index dos nos
            List<int> listTemp = new List<int>();


            //Popular o grafo




            /*
             percorrer a lista e expandir os grafos e seguir sempre pelo de menor euristica.
             A euristica é lida do array linhaRetaEntreCidades
             
             */

            // inicio, vamos escolher a cidade de inicio
            for (int i = 0; i < cidades.Count(); i++)
            {
                if (Object.Equals(cidadeInicio, cidades[i]))
                {
                    cidadeInicial = String.Copy(cidades[i]);
                    index = i;
                }
            }

            if (Object.Equals(cidadeInicial, ""))
            {

                rTb_Output.AppendText("A cidade pretendida não existe...");
            }
            else
            {
                // efectuar o algoritmo de pesquisa

                /*
                for (int i = 0; i < entreCidades[index].Count(); i++)
                {
                    if (entreCidades[index][i] != 0 || entreCidades[index][i] != 999)
                    {
                        List<no> part = new List<no>();
                        part.Add(new no() { Euristic = i, CityBool = false });
                        grafo.Add(part);
                    }
                }
                */


                rTb_Output.AppendText("Resultado da pesquisa, Destino: " + cidades[1].ToString() + "\n");
                Stopwatch sw = Stopwatch.StartNew();
                sw.Start();
                rTb_Output.AppendText(EncontraCaminhoProfundidade(index, 1, -1, 0).ToString() + "\n");
                sw.Stop();
                TimeSpan ts = sw.Elapsed;

                // Format and display the TimeSpan value.
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);

                rTb_Output.AppendText("\nDuração : " + elapsedTime.ToString() + "\n");








            }

        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            
            rTb_Output.Clear();

            grafo.Clear();
            if(cB_Gready.Checked) PopularGrafoEuristica();
            //estrategia A*
            if(cBA.Checked) PopularGrafoA();

            PrintDataSet();

            rTb_Output.AppendText("-----------------------------------\n");

            PrintGrafo();

            rTb_Output.AppendText("-----------------------------------\n");

            PrintGrafoEuristica();

            rTb_Output.AppendText("-----------------------------------\n");

            GreedySearch(cidades, linhaRetaEntreCidades, tB_cidade.Text);
        }

        private void cB_Gready_CheckedChanged(object sender, EventArgs e)
        {
            cBA.Checked = false;

        }

        private void cBA_CheckedChanged(object sender, EventArgs e)
        {
            cB_Gready.Checked = false;

        }
        */
        private void button1_Click_1(object sender, EventArgs e)
        {
            rTb_Output.Clear();

            grafo.Clear();
            if (cB_Gready.Checked) PopularGrafoEuristica();
            //estrategia A*
            if (cBA.Checked) PopularGrafoA();

            if (cB_Gready.Checked || cBA.Checked)
            {
                PrintDataSet();

                rTb_Output.AppendText("-----------------------------------\n");

                PrintGrafo();

                rTb_Output.AppendText("-----------------------------------\n");

                PrintGrafoEuristica();

                rTb_Output.AppendText("-----------------------------------\n");

                GreedySearch(cidades, linhaRetaEntreCidades, tB_cidade.Text);
            }
            else MessageBox.Show("É Necessário selecionar uma opção de pesquisa!");
        }

        private void cB_Gready_CheckedChanged_1(object sender, EventArgs e)
        {
            cBA.Checked = false;
        }

        private void cBA_CheckedChanged_1(object sender, EventArgs e)
        {
            cB_Gready.Checked = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PrintDados(List<List<double>> dados)
        {

            rT_Board.AppendText("Dados :\n");
            for (int i = 0; i < dados.Count(); i++)
            {
                for (int j = 0; j < dados[i].Count(); j++)
                {
                    rT_Board.AppendText(" " + dados[i][j]);
                }
                rT_Board.AppendText("\n");
            }

        }
        // Algoritmo IA Perceptron

        private void CalculaPerceptron()
        {
            // dados (X0, X1, X2, t)
            List<List<double>> dados = new List<List<double>>();
            int nDeEntradas;
            double w0, w1, w2;
            double u1 = 0.0, u2 = 0.0, u3 = 0.0, u4 = 0.0;
            double n = 0.5;
            bool existMudancaPeso = false;
            double erro;
            int contCicle = 0;

            rT_Board.Clear();

            // carregar dados para a lista :

            foreach (DataGridViewRow row in dG_dados.Rows)
                if (row.Cells[0].Value != null) dados.Add(new List<double> { double.Parse(row.Cells[0].Value.ToString()), double.Parse(row.Cells[1].Value.ToString()), double.Parse(row.Cells[2].Value.ToString()), double.Parse(row.Cells[4].Value.ToString()) });

            nDeEntradas = dados.Count();
            PrintDados(dados);

            // pesos
            w0 = 0; w1 = 0; w2 = 0;
            rT_Board.AppendText("Pesos : w0 =" + w0 + ", w1 = " + w1 + " w2 = " + w2 + "\n\n");
            // claculo do erro

            for (int i = 0; i < nDeEntradas; i++)
            {
                // passo 1
                // calculo da entrada n
                rT_Board.AppendText("Entrada " + (i + 1) + "\n");
                double u = w0 * dados[i][0] + w1 * dados[i][1] + w2 * dados[i][2];
                rT_Board.AppendText("u" + i + " = " + w0 + " x " + dados[i][0] + " + " + w1 + " x " + dados[i][1] + " + " + w2 + " x " + dados[i][2] + "\n");
                int s;

                if (i == 0) u1 = u;
                if (i == 1) u2 = u;
                if (i == 2) u3 = u;
                if (i == 3) u4 = u;

                // passo 2
                if (u > 0) s = 1;
                else s = 0;

                // passo 3
                erro = dados[i][3] - s;
                rT_Board.AppendText("Erro = " + dados[i][3] + " - " + s + "\n\n");

                if (s != dados[i][3])
                {
                    // Atualizar pesos
                    rT_Board.AppendText("Atialização de pesos.\n");
                    w0 = w0 + n * erro * dados[i][0];
                    w1 = w1 + n * erro * dados[i][1];
                    w2 = w2 + n * erro * dados[i][2];
                    existMudancaPeso = true;
                    contCicle = 0;
                    rT_Board.AppendText("Pesos : w0 =" + w0 + ", w1 = " + w1 + " w2 = " + w2 + "\n");

                }


                if (i == nDeEntradas - 1 && existMudancaPeso == true && contCicle < 7) i = -1;

                contCicle++;

            }

            rT_Board.AppendText("\nResultado Final : u1 = " + u1 + ", u2 = " + u2 + ", u3 = " + u3 + ", u4 = " + u4 + "\n");


        }

        private void bt_Calcular_Click(object sender, EventArgs e)
        {

            CalculaPerceptron();

        }

        #endregion


        #region REDE NEURONAL
        //// Rede Neuronal Mapa de Kohonen com thread handeling
        //Inicio





        delegate void SetTextCallback(string text);

        private int citiesCount = 10;
        private int neurons = 20;
        private int iterations = 500;
        private double learningRate = 0.5;
        private double learningRadius = 0.5;

        private double[,] map = null;
        private Random rand = new Random();

        private Thread workerThread = null;
        private bool needToStop = false;



        private void UpdateSettings()
        {
            tBPontos.Text = citiesCount.ToString();
            tBNeuronios.Text = neurons.ToString();
            tBInteraccoes.Text = iterations.ToString();
            tBPerc.Text = learningRate.ToString();
            tBRaio.Text = learningRadius.ToString();
        }

        
        private void GenerateMap()
        {
            Random rand = new Random((int)DateTime.Now.Ticks);

            map = new double[citiesCount, 2];

            for (int i = 0; i < citiesCount; i++)
            {
                map[i, 0] = rand.Next(1001);
                map[i, 1] = rand.Next(1001);
            }

            chart1.UpdateDataSeries("Cidades", map);

            chart1.UpdateDataSeries("Caminho", null);
        }


        #region Controlo de threads

        Thread ThreadSafeEnableControls(bool val)
        {
            var t = new Thread(() => ThreadProcSafe(val));
            t.Start();
            return t;
        }

        private void ThreadProcSafe(bool valor)
        {
            EnableControls(valor);
        }

    

        private void EnableControls(bool enable)
        {
            tBNeuronios.Enabled = enable;
            tBInteraccoes.Enabled = enable;
            tBPerc.Enabled = enable;
            tBRaio.Enabled = enable;

            //bTIniciar.Enabled = enable;
        }

        // Worker thread


        private void SetText(string valor)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.tBinteraccao.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { valor.ToString() });
            }
            else
            {
                this.tBinteraccao.Text = valor; ;
            }
        }

        #endregion

        //http://www.aforgenet.com/framework/docs/

        void SearchSolution()
        {
            // set random generators range
            Neuron.RandRange = new DoubleRange(0, 1000);

            // create network
            DistanceNetwork network = new DistanceNetwork(2, neurons);

            // create learning algorithm
            ElasticNetworkLearning trainer = new ElasticNetworkLearning(network);


            double fixedLearningRate = learningRate / 20;
            double driftingLearningRate = fixedLearningRate * 19;

            // path
            double[,] path = new double[neurons + 1, 2];

            // input
            double[] input = new double[2];

            // iterations
            int i = 0;

            // loop
            while (!needToStop)
            {
                // update learning speed & radius
                trainer.LearningRate = driftingLearningRate * (iterations - i) / iterations + fixedLearningRate;
                trainer.LearningRadius = learningRadius * (iterations - i) / iterations;

                // set network input
                int currentCity = rand.Next(citiesCount);
                input[0] = map[currentCity, 0];
                input[1] = map[currentCity, 1];

                // run one training iteration
                trainer.Run(input);

                // show current path
                for (int j = 0; j < neurons; j++)
                {
                    path[j, 0] = network[0][j][0];
                    path[j, 1] = network[0][j][1];
                }
                path[neurons, 0] = network[0][0][0];
                path[neurons, 1] = network[0][0][1];

                chart1.UpdateDataSeries("Caminho", path);
                i++;


                SetText(i.ToString());

                // stop ?
                if (i >= iterations)
                    break;
            }

 
        }

        private void bTIniciar_Click(object sender, EventArgs e)
        {
            // get network size
            try
            {
                neurons = Math.Max(5, Math.Min(50, int.Parse(tBNeuronios.Text)));
            }
            catch
            {
                neurons = 20;
            }
            // get iterations count
            try
            {
                iterations = Math.Max(10, Math.Min(1000000, int.Parse(tBInteraccoes.Text)));
            }
            catch
            {
                iterations = 500;
            }
            // get learning rate
            try
            {
                learningRate = Math.Max(0.00001, Math.Min(1.0, double.Parse(tBPerc.Text)));
            }
            catch
            {
                learningRate = 0.5;
            }
            // get learning radius
            try
            {
                learningRadius = Math.Max(0.00001, Math.Min(1.0, double.Parse(tBRaio.Text)));
            }
            catch
            {
                learningRadius = 0.5;
            }
            // update settings controls
            UpdateSettings();

            // disable all settings controls except "Stop" button
            //ThreadSafeEnableControls(false);
            EnableControls(false);


            // run worker thread
            needToStop = false;
            workerThread = new Thread(new ThreadStart(SearchSolution));
            workerThread.Start();

        }

        private void tBParar_Click(object sender, EventArgs e)
        {

        }

        private void tBPontos_TextChanged(object sender, EventArgs e)
        {

        }



        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if ((workerThread != null) && (workerThread.IsAlive))
            {
                needToStop = true;
                workerThread.Join();
            }
        }

        private void bTAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                citiesCount = Math.Max(5, Math.Min(50, int.Parse(tBPontos.Text)));
            }
            catch
            {
                citiesCount = 20;
            }
            tBPontos.Text = citiesCount.ToString();

            GenerateMap();
            EnableControls(true);
        }

        #endregion

        private void bTAlterar_Click(object sender, EventArgs e)
        {
            EnableControls(true);
        }
    }
}
