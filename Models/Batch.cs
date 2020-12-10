using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_5___Hootch.Data
{
    public class Batch
    {

        public int ID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Date Started")]
        public string DateStarted { get; set; }
        [Display(Name = "Expected Finish Date")]
        public string ExpectedFinishDate { get; set; }
        [Display(Name = "Amount Of Wash")]
        public double AmountOfWash { get; set; }
        [Display(Name = "Expected Wash Percent")]
        public double ExpectedWashPercent { get; set; }
        [Display(Name = "Expected Yield")]
        public double ExpectedYield { get; set; }
        [Display(Name = "Actual Yield")]
        public double ActualYield { get; set; }
        [Display(Name = "Percent Difference")]
        public double PercentDiff { get; set; }
        
        public string Notes { get; set; }
        public Batch()
        {
        }

        public Batch(int iD, string name, string dateStarted, string expectedFinishDate, int amountOfWash, int expectedWashPercent, int expectedYield, int actualYield, string notes)
        {
            ID = iD;
            Name = name;
            DateStarted = dateStarted;
            ExpectedFinishDate = expectedFinishDate;
            AmountOfWash = amountOfWash;
            ExpectedWashPercent = expectedWashPercent;
            ExpectedYield = expectedYield;
            ActualYield = actualYield;
            Notes = notes;
            if (ExpectedYield > 0 && ActualYield > 0)
            {
                SetDiff();
            }
        }
        public void SetDiff()
        {
            PercentDiff = ActualYield / ExpectedYield * 100;
        }

    }
}
