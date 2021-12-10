using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Train_project
{
    class DepotCollection
    {
        /// <summary>
        /// Словарь (хранилище) с множеством депо
        /// </summary>
        readonly Dictionary<string, Depots<Vehicle>> depotsStages;
        /// <summary>
        /// Возвращение списка названий множества депо
        /// </summary>
        public List<string> Keys => depotsStages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Разделитель для записи информации в файл
        /// </summary>
        private readonly char separator = ':';

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public DepotCollection(int pictureWidth, int pictureHeight)
        {
            depotsStages = new Dictionary<string, Depots<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        /// <summary>
        /// Добавление депо
        /// </summary>
        /// <param name="name">Название депо</param>
        public void AddDepot(string name)
        {
            if (!depotsStages.ContainsKey(name))
                depotsStages.Add(name, new Depots<Vehicle>(pictureWidth, pictureHeight));
        }
        /// <summary>
        /// Удаление депо
        /// </summary>
        /// <param name="name">Название депо</param>
        public void DelDepot(string name)
        {
            if (depotsStages.ContainsKey(name))
                depotsStages.Remove(name);
        }
        /// <summary>
        /// Доступ к депо
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Depots<Vehicle> this[string ind]
        {
            get
            {
                if (depotsStages.ContainsKey(ind))
                    return depotsStages[ind];
                return null;
            }
        }

        /// <summary>
        /// Сохранение информации по поездам в депо в файл
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter streamWriter = new StreamWriter
            (filename, false, Encoding.Default))
            {
                streamWriter.WriteLine("DepotCollection");
                foreach (var level in depotsStages)
                {
                    streamWriter.WriteLine("Depots" + separator + level.Key);
                    foreach (ITransport train in level.Value)
                    {
                        if (train.GetType().Name == "Train")
                        {
                            streamWriter.Write("Train" + separator);
                        }
                        else if (train.GetType().Name == "Electric_locomotive")
                        {
                            streamWriter.Write("Electric_locomotive" + separator);
                        }
                        streamWriter.WriteLine(train);
                    }
                }
                return true;
            }
        }

        /// <summary>
        /// Загрузка информации по поездам в депо в файл
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException("Фаил не найден");
            }
            using (StreamReader streamReader = new StreamReader
            (filename, Encoding.Default))
            {
                if (streamReader.ReadLine().Contains("DepotCollection"))
                {
                    depotsStages.Clear();
                }
                else
                {
                    throw new FileFormatException("Неверный формат файла");
                }
                Vehicle transport = null;
                string key = string.Empty;
                string line;
                for (int i = 0; (line = streamReader.ReadLine()) != null; i++)
                {
                    if (line.Contains("Depots"))
                    {
                        key = line.Split(separator)[1];
                        depotsStages.Add(key, new Depots<Vehicle>(pictureWidth, pictureHeight));
                    }
                    else if (line.Contains(separator))
                    {
                        if (line.Contains("Train"))
                        {
                            transport = new Train(line.Split(separator)[1]);
                        }
                        else if (line.Contains("Electric_locomotive"))
                        {
                            transport = new Electric_locomotive(line.Split(separator)[1]);
                        } 
                        if ((depotsStages[key] + transport) == -1)
                        {
                            throw new TypeLoadException("Не удалось загрузить поезд в депо");
                        }
                    }
                }
            }
        }
    }
}
