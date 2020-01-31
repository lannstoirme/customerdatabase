using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MicahCustomerManager.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Display(Name = "Customer Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Customer First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Customer Mobile Number")]
        public string MobileNumber { get; set; }
        [Display(Name = "Customer Email Address")]
        public string EmailAddress { get; set; }
        [Display(Name = "Customer Postal Address")]
        public string PostalAddress { get; set; }
        [Display(Name = "What Procedures have been Performed?")]
        public string ProceduresPerformed { get; set; }
        [Display(Name = "Procedure Information")]
        public string ProcedureDescription { get; set; }
        [Display(Name = "First Procedure Date")]
        public DateTime ProcedureDate1 { get; set; }
        [Display(Name = "Second Follow Up Procedure Date")]
        public DateTime ProcedureDate2 { get; set; }
        [Display(Name = "Any Additional Procedures Performed?")]
        public string AdditionalProceduresDates { get; set; }
        public string AllergiesNoted { get; set; }
        [Display(Name = "Please list any medical notes including medications")]
        public string MedicalNotes { get; set; }
        public string PreviousMedicalComplications { get; set; }
        [Display(Name = "Does the Customer Require Antibiotics?")]
        public Boolean AntiobioticProcedureNeeded { get; set; }
        [Display(Name = "Notes regarding the procedure")]
        public string ProcedureNotes { get; set; }
        [Display(Name = "Has the customer signed a consent form?")]
        public string ConsentGiven { get; set; }
        [Display(Name = "Is the customer under 18?")]
        public Boolean UnderEighteen { get; set; }
        [Display(Name = "Does the customer subscribe to marketing?")]
        public Boolean MarketingSubscribed { get; set; }
        [Display(Name = "Pregnant or Breastfeeding")]
        public Boolean PregnantBreastfeeding { get; set; }
        [Display(Name = "Any significant notes on customer?")]
        public string NotesOnCustomer { get; set; }
        [Display(Name = "Who referred the customer?")]
        public string ReferralInformation { get; set; }
    }
}
