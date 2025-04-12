using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleListOfBooksBL.Model;

namespace ConsoleListOfBooksBL.Controller
{
    /// <summary>
    /// Контроллер пользователя.
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// Пользователь приложения.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Создать нового пользователя.
        /// </summary>
        /// <param name="userName"> Имя. </param>
        public UserController(string userName) 
        {
            if (string.IsNullOrEmpty(userName))
            {
                throw new ArgumentNullException("Имя не может быть пустым или null", nameof(userName));
            }

            User = new User(userName);
        }
    }
}
