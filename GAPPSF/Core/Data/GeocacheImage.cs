﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAPPSF.Core.Data
{
    public class GeocacheImage : DataObject, IGeocacheImageData, INotifyPropertyChanged, IComparable
    {
        private static byte[] _buffer = new byte[2000];

        //already stored
        public GeocacheImage(Storage.RecordInfo recordInfo)
            : base(recordInfo)
        {
            _id = recordInfo.ID;
        }

        //new record to be stored
        public GeocacheImage(Storage.Database db, IGeocacheImageData data)
            : base(null)
        {
            _id = data.ID;
            using (MemoryStream ms = new MemoryStream(_buffer))
            using (BinaryWriter bw = new BinaryWriter(ms))
            {
                ms.Position = 0;
                //todo: add string length checks!!!

                ms.Position = 150;
                bw.Write(data.DataFromDate.ToFileTime()); //150
                ms.Position = 180;
                bw.Write(data.GeocacheCode??"");
                ms.Position = 220;
                bw.Write(data.Url);
                ms.Position = 420;
                bw.Write(data.MobileUrl??"");
                ms.Position = 520;
                bw.Write(data.ThumbUrl??"");
                ms.Position = 620;
                bw.Write(data.Name??"");
                ms.Position = 800;
                bw.Write(data.Description??"");

                RecordInfo = db.RequestGeocacheImageRecord(data.ID, _buffer, ms.Position, 10);
            }
            db.GeocacheImageCollection.Add(this);
        }

        public int CompareTo(object obj)
        {
            return string.Compare(this.ID, ((Log)obj).ID);
        }

        //buffered READONLY
        private string _id = "";
        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                //SetProperty(-1, ref _id, value);
            }
        }



        public DateTime DataFromDate
        {
            get
            {
                return DateTime.FromFileTime(readLong(150));
            }
            set
            {
                DateTime _dt = DataFromDate;
                SetProperty(150, ref _dt, value);
            }
        }

        public string GeocacheCode
        {
            get
            {
                return readString(180);
            }
            set
            {
                string s = GeocacheCode;
                SetProperty(180, ref s, value);
            }
        }

        public string Url
        {
            get
            {
                return readString(220);
            }
            set
            {
                string s = Url;
                SetProperty(220, ref s, value);
            }
        }

        public string Name
        {
            get
            {
                return readString(620);
            }
            set
            {
                string s = Name;
                SetProperty(620, ref s, value);
            }
        }

        public string MobileUrl
        {
            get
            {
                return readString(420);
            }
            set
            {
                string s = MobileUrl;
                SetProperty(420, ref s, value);
            }
        }

        public string ThumbUrl
        {
            get
            {
                return readString(520);
            }
            set
            {
                string s = ThumbUrl;
                SetProperty(520, ref s, value);
            }
        }

        public string Description
        {
            get
            {
                return readString(800);
            }
            set
            {
                string s = Description;
                SetProperty(800, ref s, value);
            }
        }
    }
}
