using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExeRibeiroCiprianoIV.Models
{
    public class Cliente
    {
        [DisplayName("Código do cliente")]
        [Required(ErrorMessage ="O código é obrigatório")]
        public int IdCli { get; set; }

        [DisplayName("Nome do cliente")]
        [Required(ErrorMessage ="O nome é obrigatório")]
        [StringLength(150, ErrorMessage ="O campo deve conter no máximo 150 caracteres")]
        public string NomeCli { get; set; }

        [System.Web.Mvc.Remote("CheckCPF", "Home", ErrorMessage = "O CPF já esxiste")]
        [DisplayName("CPF")]
        [Required(ErrorMessage = "Informe o CPF")]
        public long CPF { get; set; }

        [DisplayName("E-mail")]
        [RegularExpression(@"^[a - zA - Z] + (([\'\,\.\-][a-zA-Z ])?[a-zA-Z]*)*\s+<(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})>$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$",
            ErrorMessage ="Digite um e-mail válido")]
        [Required(ErrorMessage = "O e-mail é obrigatório")]
        public string Email { get; set; }

        [System.Web.Mvc.Remote("CheckLogin", "Home", ErrorMessage = "O Login já esxiste")]
        [DisplayName("Login")]
        [Required(ErrorMessage = "O login é obrigatório")]
        [StringLength(15, ErrorMessage = "O campo deve conter no máximo 15 caracteres")]
        public string Login { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Senha")]
        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [DisplayName("Confirme a senha")]
        [Compare("Senha", ErrorMessage ="As senhas são diferentes")]
        public string ConfirmSenha { get; set; }

        [DisplayName("Data do cadastro")]
        [Required(ErrorMessage = "A data é obrigatória")]
        public string DataCadastro { get; set; }
    }
}