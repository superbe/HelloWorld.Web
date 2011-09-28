namespace HelloWorld.Web.Models
{
    using System;

    /// <summary>
    /// Наша модель реализует бизнес-логику приложения: 
    /// она формирует строку приветствия и дату.
    /// </summary>
    public class Hello
    {
        /// <summary>
        /// Строка приветствия.
        /// </summary>
        public string Greeting { get; set; }
        
        /// <summary>
        /// Дата обращения.
        /// </summary>
        public string TimeStamp { get; set; }

        /// <summary>
        /// Конструктор. Получает имя пользователя и формирует строку приветствия.
        /// </summary>
        /// <param name="name">Имя пользователя.</param>
        public Hello(string name)
        {
            // Формируем строку приветствия.
            Greeting = string.Format("Здравствуйте, {0}! Сегодня ", name);
            
            // Задаем дату обращения пользователя.
            TimeStamp = DateTime.Now.ToString("D");
        }
    }
}