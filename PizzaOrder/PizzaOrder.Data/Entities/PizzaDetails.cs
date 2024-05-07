﻿using PizzaOrder.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrder.Data.Entities;
internal class PizzaDetails
{
    #region Fields
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [StringLength(40)]
    [Column(TypeName = "nvarchar(40)")]
    public string Name { get; set; }
    [Required]
    public Toppings Toppings { get; set; }
    [Column(TypeName = "decimal(18,4)")]
    public decimal Price { get; set; }
    [Required]
    [MinLength(1)]
    [Column(TypeName = "int")]
    public int Size { get; set; }
    [Required]
    [Column(TypeName = "int")]
    public int OrderDetailsId { get; set; }
    #endregion
    #region ctor
    internal PizzaDetails(
        string name,
        decimal price,
        int size,
        int orderDetailsId,
        Toppings toppings = Toppings.NONE
        )
    {
        Name = name;
        Toppings = toppings;
        Price = price;
        Size = size;
        OrderDetailsId = orderDetailsId;
    }
    #endregion
}
