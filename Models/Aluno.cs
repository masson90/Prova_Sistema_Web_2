using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Prova_Sistema_Web_Ex6.Models
{
    [Table("Aluno")]
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Curso: ")]
        public string Curso { get; set; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Endereço: ")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Telefone: ")]
        public string Telefone { get; set; }        

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "E-mail: ")]
        [EmailAddress(ErrorMessage = "E-mail Invalido")]
        public string Email { get; set; }  

        [Required(ErrorMessage = "Obrigatorio")]
        [Display(Name = "Filiação: ")]
        public string Filiacao { get; set; }
        
    }
}