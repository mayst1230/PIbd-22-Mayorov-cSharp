﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WindowsFormsBus
{
    public class ParkingCollection
    {
        /// <summary>
        /// Словарь (хранилище) с парковками
        /// </summary>
        private readonly Dictionary<string, Parking<Vehicle>> parkingStages;
        /// <summary>
        /// Возвращение списка названий праковок
        /// </summary>
        public List<string> Keys => parkingStages.Keys.ToList();
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
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        /// <summary>
        /// Добавление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
        }
        /// <summary>
        /// Удаление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        /// доп задание: удаление парковки, чтобы в качестве параметра передавалось число
        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }
        /// <summary>
        /// Доступ к парковке
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Parking<Vehicle> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Сохранение информации по автомобилям на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine($"ParkingCollection");
                foreach (KeyValuePair<string, Parking<Vehicle>> level in parkingStages)
                {
                    //Начинаем парковку
                    sw.WriteLine($"Parking{separator}{level.Key}");
                    foreach (ITransport bus in level.Value)
                    {
                        //если место не пустое
                        //Записываем тип машины
                        if (bus.GetType().Name == "Bus")
                        {
                            sw.Write($"Bus{separator}");
                        }
                        if (bus.GetType().Name == "AccordionBus")
                        {
                            sw.Write($"AccordionBus{separator}");
                        }
                        //Записываемые параметры
                        sw.WriteLine(bus);
                    }
                }
            }
        }
        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader streamReader = new StreamReader
            (filename, System.Text.Encoding.Default))
            {
                if (streamReader.ReadLine().Contains("ParkingCollection"))
                {
                    parkingStages.Clear();
                }
                else
                {
                    throw new FormatException("Неверный формат файла");
                }
                Vehicle bus = null;
                string key = string.Empty;
                string line;
                for (int i = 0; (line = streamReader.ReadLine()) != null; i++)
                {
                    if (line.Contains("Parking"))
                    {
                        key = line.Split(separator)[1];
                        parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                    }
                    else if (line.Contains(separator))
                    {
                        if (line.Contains("Bus"))
                        {
                            bus = new Bus(line.Split(separator)[1]);
                        }
                        else if (line.Contains("AccordionBus"))
                        {
                            bus = new AccordionBus(line.Split(separator)[1]);
                        }
                        if (!(parkingStages[key] + bus))
                        {
                            throw new TypeLoadException("Не удалось загрузить автобус на парковку");
                        }
                    }
                }
            }
        }
    }
}