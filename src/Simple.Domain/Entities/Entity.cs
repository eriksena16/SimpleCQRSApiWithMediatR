﻿using System.ComponentModel.DataAnnotations;

namespace Simple.Domain
{
    public class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
    }
}
