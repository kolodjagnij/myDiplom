﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace test
{
    public partial class ReasonForDeduction
    {
        public ReasonForDeduction()
        {
            Enrollee = new HashSet<Enrollee>();
        }

        public int IdReasonForDeduction { get; set; }
        [Required(ErrorMessage ="Не указана причина отчисления")]
        [Display(Name = "Причина отчисления")]
        public string NameReasonForDeduction { get; set; }

        public ICollection<Enrollee> Enrollee { get; set; }
    }
}
