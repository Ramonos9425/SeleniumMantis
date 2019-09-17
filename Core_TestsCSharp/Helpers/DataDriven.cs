using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_TestsCSharp.Helpers
{
    class DataDriven
    {

        public  List<TestCaseData> DataDrivenImplement()
        {

                var testCases = new List<TestCaseData>();
                string[] split = { "" };
                using (var fs = File.OpenRead(@"C:\Repositorio23\MantisBase2-master\input_date.csv"))
                //using (var fs = File.OpenRead(SeleniumComum.SeleniumUteis.getPathDataDrivenFiles()))
                using (var sr = new StreamReader(fs))
                {
                    string line = string.Empty;

                    while (line != null)
                    {
                        line = sr.ReadLine();
                        if (line != null)
                        {
                            split = line.Split(new char[] { ',' }, StringSplitOptions.None);
                            string categoria = split[0].Trim();
                            string frequencia = split[1].Trim();
                            string gravidade = split[2].Trim();
                            string prioridade = split[3].Trim();
                            string resumo = split[4].Trim();
                            string descricao = split[5].Trim();

                            string ind_inserir = split[6].Trim(); //ind_inserir

                        if (ind_inserir.Equals("S"))
                            {
                                var testCase = new TestCaseData(categoria,frequencia,gravidade,prioridade,resumo,descricao);
                                testCases.Add(testCase);
                            }


                        }
                    }
                }
                return testCases;  
        }

        public static string getPathCSV()
        {
            //qq rola, pegando o patch do projeto vem junto "file:/" + "resto do patch"
            String path = (Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase))) + @"\input_date.csv");
            //retirando lixo file:\
            path = path.Remove(0, 6);
            //arquivo csv tem que estar dentro da pasta raiz do projeto!

            return path;
        }


    }
}
