using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Enums
{
    public enum Status
    {
        Active,
        Prosoective,
        Dormant,
        None
    }

    public enum Gender
    {
        Male,
        Female,
        Transgender,
        None
    }

    public enum Segmentation
    {
        Silver,
        Gold,
        Diamond,
        Platinum
    }

    public enum Bucket
    {
        Individual,
        TrustOrFoundation,
        Group
    }

    public enum Interval
    {
        OneTime,
        Monthly,
        HalfYearly,
        Quarterly,
        Annually,
        None
    }

    public enum LoginStatus
    {
        LoggedIn,
        Expired,
        Error,
        Blocked
    }
}