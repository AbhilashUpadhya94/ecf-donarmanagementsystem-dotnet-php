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
        private String name = String.Empty;
        private String donationTo = String.Empty;
        private String nationality = String.Empty;
        private String currencyType = String.Empty;

        [DataMember]
        public String CurrencyType
        {
            get { return currencyType; }
            set { currencyType = value; }
        }

        [DataMember]
        public String Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }

        [DataMember]
        public String DonationTo
        {
            get { return donationTo; }
            set { donationTo = value; }
        }

        [DataMember]
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

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