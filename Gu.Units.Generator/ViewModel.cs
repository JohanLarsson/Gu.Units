﻿namespace Gu.Units.Generator
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using Annotations;

    public class ViewModel : INotifyPropertyChanged
    {
        private string _nameSpace;

        private readonly Settings _settings;

        public ViewModel()
        {
            this._settings = Settings.Instance;
            NameSpace = Settings.ProjectName;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Prefix> Prefixes
        {
            get { return _settings.Prefixes; }
        }

        public ObservableCollection<SiUnit> SiUnits
        {
            get
            {
                return _settings.SiUnits;
            }
        }

        public ObservableCollection<DerivedUnit> DerivedUnits
        {
            get
            {
                return _settings.DerivedUnits;
            }
        }

        public string NameSpace
        {
            get
            {
                return this._nameSpace;
            }
            set
            {
                if (value == this._nameSpace)
                {
                    return;
                }
                this._nameSpace = value;
                this.OnPropertyChanged();
            }
        }

        public void Save()
        {
            Settings.Save(_settings, Settings.FullFileName);
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
