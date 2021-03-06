﻿using System.Collections.ObjectModel;

namespace SampleWPFApplication.Models {

    public static class Persons {
        /// <summary>
        /// Person のコレクションを生成します。
        /// </summary>
        public static ObservableCollection<Person> Create() {
            var ret = new ObservableCollection<Person>();

            ret.Add(new Person() { Id = 1, Name = "田中", Address = "渋谷区" });
            ret.Add(new Person() { Id = 2, Name = "山田", Address = "新宿区" });
            ret.Add(new Person() { Id = 3, Name = "鈴木", Address = "豊島区" });
            ret.Add(new Person() { Id = 4, Name = "佐藤", Address = "品川区" });
            ret.Add(new Person() { Id = 5, Name = "藤原", Address = "中央区" });

            ret[0].CuttingParameters.Add(new TurningParameter() { Process = "Turning", Speed = "20" });
            ret[1].CuttingParameters.Add(new MillingParameter() { Process = "Milling", Feed = "30" });
            ret[2].CuttingParameters.Add(new TurningParameter() { Process = "Turning", Speed = "40" });
            ret[3].CuttingParameters.Add(new MillingParameter() { Process = "Milling", Feed = "50" });
            ret[4].CuttingParameters.Add(new MillingParameter() { Process = "Milling", Feed = "60" });

            return ret;
        }
    }
}
