using System;

namespace ConsoleListOfBooksBL.Model
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    public class User
    {
        #region Свойства
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }
        #endregion

        /// <summary>
        /// Создать пользователя.
        /// </summary>
        /// <param name="name"> Имя. </param>
        public User(string name) 
        {
            #region Проверка
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null", nameof(name));
            }
            #endregion

            Name = name;
        }

        public override string ToString()
        { 
            return Name;
        }
    }
}
