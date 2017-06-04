using Livet;
using System;

using System.Collections.ObjectModel;

namespace SampleWPFApplication.Models {

    public class CuttingParameter : NotificationObject
    {
        private string _process;
        public string Process
        {
            get { return _process; }
            set
            {
                if (_process != value)
                {
                    _process = value;
                    RaisePropertyChanged("Process");
                }
            }
        }
        //private string _speed;
        //public string Speed
        //{
        //    get { return _speed; }
        //    set
        //    {
        //        if (_speed != value)
        //        {
        //            _speed = value;
        //            RaisePropertyChanged("Speed");
        //        }
        //    }
        //}
        //private string _feed;
        //public string Feed
        //{
        //    get { return _feed; }
        //    set
        //    {
        //        if (_feed != value)
        //        {
        //            _feed = value;
        //            RaisePropertyChanged("Feed");
        //        }
        //    }
        //}
    }


    public class TurningParameter : CuttingParameter
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

    public class MillingParameter : CuttingParameter
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

        private System.Windows.Visibility _idVisibility = System.Windows.Visibility.Visible;

        public System.Windows.Visibility IdVisibility
        {
            get { return _idVisibility; }
            set
            {
                if (_idVisibility == value)
                    return;
                _idVisibility = value;
                RaisePropertyChanged("IdVisibiliity");
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

        #region CuttingParameters
        private ObservableCollection<CuttingParameter> _cuttingParmeters = new ObservableCollection<CuttingParameter>();

        public ObservableCollection<CuttingParameter> CuttingParameters
        {
            get { return _cuttingParmeters; }
            set
            {
                if (_cuttingParmeters == value)
                    return;
                _cuttingParmeters = value;
                RaisePropertyChanged("CuttingParameters");
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
