using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyDemoMVC.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo ttulo eh obrigatório")]
        [StringLength(60,MinimumLength = 3, ErrorMessage = "O titulo precisa ter entre 3 ou 60 caracteres")]
        public string Titulo { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "O campo Data de Lancamento eh obrigatorio")]
        [Display(Name = "Data de Lançamento")]
        public DateTime Datalancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF**'\w-]*$", ErrorMessage = "Genero em formato inválido")] //Primeira letra tem que ser de A a Z maiuscula e as outras podem ser de a a z minusculas ou maiusculas e aceitando as acentuações
        [StringLength(30, ErrorMessage = "Maximo de 30 caracteres"), Required(ErrorMessage ="O campo genero eh requerido")] //no maximo 30 caracteres
        public string Genero { get; set; }

        [Range(1,1000, ErrorMessage = "Valor de 1 a 1000")]
        [Required(ErrorMessage = "Preencha o campo Valor" )]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Valor { get; set; }

        
        [Required(ErrorMessage = "Preencha o campo Avaliação")]
        [Display(Name ="Avaliação")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente números")] //numero de 0 a 5
        public int Avaliacao { get; set; }
    }
}
