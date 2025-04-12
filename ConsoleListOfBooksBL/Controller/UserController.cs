using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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
        private string path = "../../../users.json";

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

        /// <summary>
        /// Сохранить пользователя.
        /// </summary>
        public void Save()
        {
            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, User);
                Console.WriteLine("Данные сохранены!");
            }
        }

        /// <summary>
        /// Получить пользователя.
        /// </summary>
        public void GetUser()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                User = (User)JsonSerializer.Deserialize(fs, typeof(User));
                Console.WriteLine(User);
            }
        }
    }
}
