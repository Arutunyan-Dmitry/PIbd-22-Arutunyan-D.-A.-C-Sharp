using System.Collections.Generic;
using System.Linq;

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
    }
}
