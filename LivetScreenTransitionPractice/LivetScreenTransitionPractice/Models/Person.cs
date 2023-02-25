using Livet;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivetScreenTransitionPractice.Models
{
    public class Person : NotificationObject, ICloneable
    {
        public Int32 Id { get; set; }

        #region Name変更通知プロパティ
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if (_Name == value)
                    return;
                _Name = value;
                RaisePropertyChanged("Name");
            }
        }

        #endregion Name変更通知プロパティ

        #region Address変更通知プロパティ

        private string _Address;

        public string Address
        {
            get
            { return _Address; }
            set
            { 
                if (_Address == value)
                    return;
                _Address = value;
                RaisePropertyChanged("Address");
            }
        }

        #endregion Address変更通知プロパティ

        /// <summary>
        /// 自身のコピーを生成します。
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Person()
            {
                Id = this.Id,
                Name = this.Name,
                Address = this.Address
            };
        }

    }

    public static class Persons
    {
        public static ObservableCollection<Person> Create()
        {
            var ret = new ObservableCollection<Person>();
            ret.Add(new Person() { Id = 1, Name = "田中", Address = "渋谷区" });
            ret.Add(new Person() { Id = 2, Name = "山田", Address = "新宿区" });
            ret.Add(new Person() { Id = 3, Name = "鈴木", Address = "豊島区" });
            ret.Add(new Person() { Id = 4, Name = "佐藤", Address = "品川区" });
            ret.Add(new Person() { Id = 5, Name = "藤原", Address = "中央区" });

            return ret;
        }
    }
}
