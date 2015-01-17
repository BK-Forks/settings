﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;


namespace Acr.Settings {

    public interface ISettingsDictionary : IDictionary<string, string>, INotifyCollectionChanged, INotifyPropertyChanged {}
}
