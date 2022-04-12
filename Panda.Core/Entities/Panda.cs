using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities;

public class Panda
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PandaId { get; set; }

    public string Name { get; set; }

    public DateTime DateOfBirth { get; set; }

    public Guid Parent { get; set; }
}