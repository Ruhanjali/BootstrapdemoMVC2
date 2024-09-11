using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bootstrapdemo.Models
{
    public class Marksheet
    {
        public Student MyStudent { get; set; }
        public Assesment MyAssesment { get; set; }

       public int Total
        {
            get
            {
                return MyAssesment.HindiMarks + MyAssesment.Englishmarks + MyAssesment.HistoryMarks;
            }
        }
    }
}