﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAPPSF.Core
{
    public partial class Settings
    {
        public int OfflineImagesWindowWidth
        {
            get { return int.Parse(GetProperty("700")); }
            set { SetProperty(value.ToString()); }
        }
        public int OfflineImagesWindowHeight
        {
            get { return int.Parse(GetProperty("700")); }
            set { SetProperty(value.ToString()); }
        }
        public int OfflineImagesWindowTop
        {
            get { return int.Parse(GetProperty("100")); }
            set { SetProperty(value.ToString()); }
        }
        public int OfflineImagesWindowLeft
        {
            get { return int.Parse(GetProperty("100")); }
            set { SetProperty(value.ToString()); }
        }

        public int OfflineImagesShowLogs
        {
            get { return int.Parse(GetProperty("5")); }
            set { SetProperty(value.ToString()); }
        }

        public string OfflineImagesFolder
        {
            get { return GetProperty(null); }
            set { SetProperty(value); }
        }

        public bool OfflineImagesDownloadBeforeCreate
        {
            get { return bool.Parse(GetProperty("False")); }
            set { SetProperty(value.ToString()); }
        }

        public bool OfflineImagesOnlyInDescr
        {
            get { return bool.Parse(GetProperty("False")); }
            set { SetProperty(value.ToString()); }
        }

        public bool OfflineImagesClearFolder
        {
            get { return bool.Parse(GetProperty("False")); }
            set { SetProperty(value.ToString()); }
        }

    }
}
