namespace MyResume.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Table_User
    {
        [Key]
        public int userid { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Full Name")]
        public string userName { get; set; }

        [Required]
        [StringLength(200)]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Please provide a valid email address")]
        [Display(Name = "Email Address")]
        public string userEmail { get; set; }

        [StringLength(100)]
        [Display(Name = "Country")]
        public string userNationality { get; set; }

        [StringLength(100)]
        [Display(Name = "Address")]
        public string userAddress { get; set; }

        [StringLength(100)]
        [Display(Name = "Area")]
        public string userArea { get; set; }

        [StringLength(100)]
        [Display(Name = "State")]
        public string userState { get; set; }

        [StringLength(5)]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Post Code")]
        [Display(Name = "Post Code")]
        public string userPostCode { get; set; }

        [StringLength(1000)]
        [Display(Name = "Mobile Number")]
        public string userMobile { get; set; }

        [StringLength(100)]
        [Display(Name = "Job Title")]
        public string userTitle { get; set; }

        [StringLength(200)]
        [Display(Name = "Roman Name")]
        public string userRomanName { get; set; }

        [Display(Name = "Created By")]
        public int? created_by { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Creation Date")]
        public DateTime? creation_date { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Last Date of Modification Made")]
        public DateTime? last_update_date { get; set; }

        [Display(Name = "Last Person Who Modofied")]
        public DateTime? last_updated_by { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Active End Date")]
        public DateTime? user_end_date { get; set; }


    }
}
