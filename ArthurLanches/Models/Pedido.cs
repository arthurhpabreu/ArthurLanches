﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace ArthurLanches.Models
{
    public class Pedido
    {
        [BindNever]
        public int PedidoId { get; set; }
        public List<PedidoDetalhe> PedidoItens { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [Display(Name = "Nome")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Informe o sobrenome")]
        [Display(Name ="Sobrenome")]
        [StringLength(50)]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Informe o Endereço")]
        [Display(Name ="Endereço")]
        [StringLength(100)]
        public string Endereço1 { get; set; }

        [Required(ErrorMessage = "Informe o complemento do endereço")]
        [Display(Name = "Complemento")]
        [StringLength(100)]
        public string Endereço2 { get; set; }

        [Required(ErrorMessage = "Informe o CEP")]
        [Display(Name = "CEP")]
        [StringLength(10, MinimumLength =8)]
        public string Cep { get; set; }

        [StringLength(10)]
        public string Estado { get; set; }

        [StringLength(50)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Informe o Telefone")]
        [Display(Name = "Telefone")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }


        [Required(ErrorMessage = "Informe o E-mail")]
        [Display(Name = "Email")]
        [StringLength(80)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public decimal PedidoTotal { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime PedidoEnviado { get; set; }

    }
}
