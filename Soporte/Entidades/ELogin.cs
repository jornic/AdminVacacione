using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Soporte.Entidades
{
    public class ELogin
    {
        private string users;
        private string password;

        [Required(ErrorMessage = "Ingresar nombre de usuario")]
        [StringLength(maximumLength:50,MinimumLength =3)]
        public string Users { get => users; set => users = value; }
        [Required(ErrorMessage ="Ingresar constraseña")]
        public string Password { get => password; set => password = value; }    
    }
}
