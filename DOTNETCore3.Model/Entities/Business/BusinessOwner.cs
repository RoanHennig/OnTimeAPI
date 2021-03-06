﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DOTNETCore3.Model.Entities
{
    public class BusinessOwner : IEntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }
        public Business Business { get; set; }
        public int BusinessId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
