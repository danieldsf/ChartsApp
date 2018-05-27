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
                INSTANCE.Sort();
            }

            return INSTANCE;
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
        private IDictionary<string, Tuple<int, int>> Series { get; set; }

        private CitySeriesRepository()
        {
            this.Cities = CityRepository.getInstance().Cities;
            Series = new Dictionary<string, Tuple<int, int>>();

            int times = 0;

            times = this.Cities.Where(c => c.Population <= 1000).Count();
            Series.Add("0 a 1 mil", Tuple.Create(times, 500));

            times = this.Cities.Where(c => c.Population <= 10000 && c.Population > 1000).Count();
            Series.Add("1 mil a 10 mil", Tuple.Create(times, 5500));

            times = this.Cities.Where(c => c.Population <= 20000 && c.Population > 10000).Count();
            Series.Add("10 mil a 20 mil", Tuple.Create(times, 15000));

            times = this.Cities.Where(c => c.Population <= 50000 && c.Population > 20000).Count();
            Series.Add("20 mil a 50 mil", Tuple.Create(times, 35000));

            times = this.Cities.Where(c => c.Population <= 100000 && c.Population > 50000).Count();
            Series.Add("50 mil a 100 mil", Tuple.Create(times, 75000));

            times = this.Cities.Where(c => c.Population <= 200000 && c.Population > 100000).Count();
            Series.Add("100 mil a 200 mil", Tuple.Create(times, 150000));

            times = this.Cities.Where(c => c.Population <= 500000 && c.Population > 200000).Count();
            Series.Add("200 mil a 500 mil", Tuple.Create(times, 350000));

            times = this.Cities.Where(c => c.Population <= 1000000 && c.Population > 500000).Count();
            Series.Add("500 Mil a 1 Milhao", Tuple.Create(times, 750000));

            times = this.Cities.Where(c => c.Population > 1000000).Count();
            Series.Add(String.Format("1 Milhao a {0}", this.Cities[this.Cities.Count - 1].Population), Tuple.Create(times, 6553460));

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

        public double GetMediana()
        {
            return 0;
        }

        public double Getvariancia()
        {
            return 0;
        }

        public double GetDesvioPadrao()
        {
            return 0;
        }

        public double GetCoeficienteVariacao()
        {
            return 0;
        }
    }
}
