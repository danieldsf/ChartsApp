using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace ChartsApp
{
    public class City
    {
        public string Name { get; set; }
        public string State { get; set; }
        public int    Population { get; set; }
    }

    public class CityRepository
    {
        private static CityRepository INSTANCE;
        public List<City> Cities { get; set; }

        private CityRepository(){}

        public static CityRepository getInstance()
        {
            if(INSTANCE is null)
            {
                string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\municipios.json");
                string content = String.Join("", File.ReadAllLines(path));
                INSTANCE = JsonConvert.DeserializeObject<CityRepository>(content);
                INSTANCE.Filter();
                INSTANCE.Sort();
            }

            return INSTANCE;
        }

        private void Filter()
        {
            Cities = Cities.Where(x => new List<string> { "Bahia", "Ceará", "Pernambuco", "Maranhão", "Sergipe", "Paraíba", "Rio Grande do Norte", "Alagoas", "Piauí" }.Contains(x.State)).ToList();
        }

        private void Sort()
        {
            City tempCity;
            int size = this.Cities.Count;
            for (int i = 0; i < size-1; i++)
            {
                for (int j = 0; j < size-i-1; j++)
                {
                    if(this.Cities[j].Population > this.Cities[j + 1].Population)
                    {
                        tempCity = this.Cities[j];
                        this.Cities[j] = this.Cities[j + 1];
                        this.Cities[j + 1] = tempCity;
                    }
                }
            }
        }

        // Data For Continuous:
        public double GetAverage()
        {
            double amount = 0;

            int size = this.GetCount();

            for (int i = 0; i < size; i++)
            {
                amount += this.Cities[i].Population;
            }

            return amount / size;
        }

        public City GetMax()
        {
            int index = this.GetCount() - 1;
            return this.Cities[index];
        }

        public City GetMin()
        {
            int index = 0;
            return this.Cities[index];
        }

        public int GetCount()
        {
            return this.Cities.Count;
        }
        // Data For Series:
        public int GetModa()
        {
            int maxTimes = 0, moda = 0, size = this.GetCount();
            
            for (int i = 0; i < size; i++)
            {
                var currentTimes = this.Cities.Where(c => c.Population == this.Cities[i].Population);

                if (i == 0 || maxTimes < currentTimes.Count())
                {
                    maxTimes = currentTimes.Count();
                    moda = this.Cities[i].Population;
                }
            }
            
            return moda;
        }

        public double GetMediana()
        {
            int size = GetCount();
            double mediana = 0;
            if (size % 2 == 0)
            {
                mediana = (this.Cities[size / 2].Population + this.Cities[(size / 2) + 1].Population) / 2.0;
            }
            else
            {
                mediana = this.Cities[(size / 2) + 1].Population;
            }

            return mediana;
        }

        public int GetAmplitude()
        {
            return GetMax().Population - GetMin().Population;
        }

        public double GetVariancia()
        {
            double average = GetAverage();
            double variancia = 0;
            int size = GetCount();

            for (int i = 0; i < size; i++)
            {
                variancia += Math.Pow((this.Cities[i].Population - average), 2) / size;
            }

            return Math.Sqrt(variancia);
        }

        public double GetDesvioPadrao()
        {
            double average = GetAverage();
            double variancia = 0;
            int size = GetCount();

            for (int i = 0; i < size; i++)
            {
                variancia += Math.Pow((this.Cities[i].Population - average), 2) / (size-1);
            }

            return Math.Sqrt(variancia);
        }

        public double GetCoeficienteVariacao()
        {
            return GetDesvioPadrao()/GetAverage();
        }
    }

    public class CitySeriesRepository
    {
        private static CitySeriesRepository INSTANCE;
        private List<City> Cities { get; set; }
        public IDictionary<string, Tuple<int, int>> Series { get; set; }

        private CitySeriesRepository()
        {
            this.Cities = CityRepository.getInstance().Cities;
            Series = new Dictionary<string, Tuple<int, int>>();
            int times = 0;

            times = this.Cities.Where(c => c.Population <= 200000).Count();
            Series.Add("0 a 200 mil", Tuple.Create(times, 100000));

            times = this.Cities.Where(c => c.Population <= 400000 && c.Population > 200000).Count();
            Series.Add("200 mil a 400 mil", Tuple.Create(times, 300000));

            times = this.Cities.Where(c => c.Population <= 600000 && c.Population > 400000).Count();
            Series.Add("400 mil a 600 mil", Tuple.Create(times, 500000));

            times = this.Cities.Where(c => c.Population <= 800000 && c.Population > 600000).Count();
            Series.Add("600 mil a 800 mil", Tuple.Create(times, 700000));

            times = this.Cities.Where(c => c.Population <= 1000000 && c.Population > 800000).Count();
            Series.Add("800 mil a 1 milhao", Tuple.Create(times, 900000));

            times = this.Cities.Where(c => c.Population <= 1200000 && c.Population > 1000000).Count();
            Series.Add("1 milhao a 1,2 millhoes", Tuple.Create(times, 1100000));

            times = this.Cities.Where(c => c.Population <= 1400000 && c.Population > 1200000).Count();
            Series.Add("1,2 milhoes a 1,4 milhoes", Tuple.Create(times, 1300000));

            times = this.Cities.Where(c => c.Population <= 1600000 && c.Population > 1400000).Count();
            Series.Add("1,4 Milhoes a 1,6 Milhoes", Tuple.Create(times, 1500000));
            //
            times = this.Cities.Where(c => c.Population <= 1800000 && c.Population > 1600000).Count();
            Series.Add("1,6 milhoes a 1,8 milhoes", Tuple.Create(times, 1700000));

            times = this.Cities.Where(c => c.Population <= 2000000 && c.Population > 1800000).Count();
            Series.Add("1,8 milhoes a 2 milhoes", Tuple.Create(times, 1900000));

            times = this.Cities.Where(c => c.Population <= 2200000 && c.Population > 2000000).Count();
            Series.Add("2 milhoes a 2,2 milhoes", Tuple.Create(times, 2100000));

            times = this.Cities.Where(c => c.Population <= 2400000 && c.Population > 2200000).Count();
            Series.Add("2,2 milhoes a 2,4 milhoes", Tuple.Create(times, 2300000));

            times = this.Cities.Where(c => c.Population <= 2600000 && c.Population > 2400000).Count();
            Series.Add("2,4 milhoes a 2,6 milhoes", Tuple.Create(times, 2500000));

            times = this.Cities.Where(c => c.Population <= 2800000 && c.Population > 2600000).Count();
            Series.Add("2,6 Milhoes a 2,8 Milhoes", Tuple.Create(times, 2700000));
            //
            times = this.Cities.Where(c => c.Population > 2800000).Count();
            Series.Add("2,8 Milhoes a 3 Milhoes", Tuple.Create(times, 2900000));

            foreach (var entry in Series)
            {
                Console.WriteLine(String.Format("{0} - {1}", entry.Key, entry.Value));
            }
        }

        public static CitySeriesRepository getInstance()
        {
            if (INSTANCE is null)
            {
                INSTANCE = new CitySeriesRepository();
            }
            return INSTANCE;
        }

        public double GetMedia()
        {
            double amountFrequency = 0;
            double amountAverage = 0;
            foreach (var entry in Series)
            {
                amountAverage += entry.Value.Item1 * entry.Value.Item2;
                amountFrequency += entry.Value.Item1;
            }

            return amountAverage / amountFrequency;
        }

        public int GetModa()
        {
            return (from x in Series where x.Value.Item1 == Series.Max(y => y.Value.Item1) select x).Max().Value.Item2;
        }

        public int SomatorioFrequencia()
        {
            int total = 0;

            foreach (var entry in Series)
            {
                total += entry.Value.Item1;
            }

            return total;
        }

        public double GetMediana()
        {
            const float INTERVALO = 200000f;

            //float data = 0 + (((SomatorioFrequencia() / 2) - 0) / Series["0 a 200 mil"].Item1) * 200;
            float data = (SomatorioFrequencia() / 2f)  * INTERVALO / (float) Series["0 a 200 mil"].Item1;
            return data;
        }

        public double GetFrequenciaVsMedia()
        {
            double freqVsMedia = 0;

            foreach (var entry in Series)
            {
                freqVsMedia += entry.Value.Item1 * entry.Value.Item2;
            }

            return freqVsMedia;
        }

        public double GetFrequenciaVsMediaQuadrada()
        {
            double freqVsMedia = 0;

            foreach (var entry in Series)
            {
                freqVsMedia += entry.Value.Item1 * (entry.Value.Item2 * entry.Value.Item2);
            }

            return freqVsMedia;
        }

        public double GetDiferencaSomadaMedia()
        {
            double freqVsMedia = 0;

            foreach (var entry in Series)
            {
                freqVsMedia += (entry.Value.Item2 - GetMedia()) * (entry.Value.Item2 - GetMedia());
            }

            return freqVsMedia;
        }

        public double GetVariancia()
        {
            double freqVsMedia = GetFrequenciaVsMedia(); 
            double freqVsMediaQuadrada = GetFrequenciaVsMediaQuadrada();

            var ammount = (freqVsMediaQuadrada - ((freqVsMedia * freqVsMedia / (float)SomatorioFrequencia())) / ((float)SomatorioFrequencia() - 1));

            return Math.Sqrt(Math.Abs(ammount));
        }

        public double GetDesvioPadrao()
        {
            return Math.Sqrt(GetDiferencaSomadaMedia()/((float)SomatorioFrequencia()-1));
        }

        public double GetCoeficienteVariacao()
        {
            return GetDesvioPadrao()/GetMedia();
        }
    }
}
