﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mkm.model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        
        public string Text { get; set; }

        [Timestamp]
        public byte[] Created { get; set; }

        [Timestamp]
        public byte[] Updated { get; set; }

        public long? UserId { get; set; }

        [ForeignKey("UserId")]
        public User Author { get; set; }

        public long? CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category ParentCategory { get; set; }

        public virtual ICollection<Category> SubCategories { get; set; } 
    }
}
