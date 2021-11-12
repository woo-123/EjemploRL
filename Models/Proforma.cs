using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EjemploRL.Models
{

    [Table("t_proforma")]
    public class Proforma{

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]

        public int Id {get;set;}

        public String UserId {get;set;}

        public Catalogo Producto {get; set;}

        public int Quantity {get; set;}

        public Decimal Price {get; set; }



    }



}