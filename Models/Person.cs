using Livet;
using System;

namespace SampleWPFApplication.Models {
    public class TurningParameter : NotificationObject
    {
        private string _speed;
        public string Speed 
        {
            get { return _speed; }
            set 
            {
                if (_speed != value)
                {
                    _speed = value;
                    RaisePropertyChanged("Speed");
                }
            }
        }
    }

    public class MillingParameter : NotificationObject
    {
        private string _feed;
        public string Feed
        {
            get { return _feed; }
            set
            {
                if (_feed != value)
                {
                    _feed = value;
                    RaisePropertyChanged("Feed");
                }
            }
        }
    }

    public class MillingParameter : NotificationObject
    { }

    public class Person : NotificationObject, ICloneable {

        #region Id変更通知プロパティ
        private Int32 _Id;

        public Int32 Id {
            get { return _Id; }
            set { 
                if (_Id == value)
                    return;
                _Id = value;
                RaisePropertyChanged("Id");
            }
        }
        #endregion

        #region Name変更通知プロパティ
        private string _Name;

        public string Name {
            get { return _Name; }
            set { 
                if (_Name == value)
                    return;
                _Name = value;
                RaisePropertyChanged("Name");
            }
        }
        #endregion

        #region Address変更通知プロパティ
        private string _Address;

        public string Address {
            get { return _Address; }
            set { 
                if (_Address == value)
                    return;
                _Address = value;
                RaisePropertyChanged("Address");
            }
        }
        #endregion

        /// <summary>
        /// 自身のコピーを生成します。
        /// </summary>
        public object Clone() {
            return new Person() {
                Id = this.Id,
                Name = this.Name,
                Address = this.Address
            };
        }
    }
}
