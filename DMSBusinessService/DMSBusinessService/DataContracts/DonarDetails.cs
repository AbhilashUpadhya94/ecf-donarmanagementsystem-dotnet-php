using DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DMSBusinessService.DataContracts
{
    [DataContract]
    public class DonarDetails
    {
        private Bucket bucket;
        private Segmentation segmentation;
        private DateTime pledgeDate;
        private Double pledgeAmount;
        private String source;
        private String finacialYear;
        private Interval interval = Interval.None;

        [DataMember]
        public Interval Interval
        {
            get { return interval; }
            set { interval = value; }
        }

        public String FinalcialYear
        {
            get { return finacialYear; }
            set { finacialYear = value; }
        }

        [DataMember]
        public String Source
        {
            get { return source; }
            set { source = value; }
        }

        [DataMember]
        public Double PledgeAmount
        {
            get { return pledgeAmount; }
            set { pledgeAmount = value; }
        }

        public DateTime PledgeDate
        {
            get { return pledgeDate; }
            set { pledgeDate = value; }
        }

        [DataMember]
        public Segmentation Segmentation
        {
            get { return segmentation; }
            set { segmentation = value; }
        }

        public Bucket Bucket
        {
            get { return bucket; }
            set { bucket = value; }
        }
    }
}