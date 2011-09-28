// HelloWorldPage.cs
//

namespace HelloWorld.Scripts
{
    using System;
    using System.Html;
    using System.Net;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Скрипт загрузки.
    /// </summary>
    [GlobalMethods]
    internal static class HelloWorldPage
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        static HelloWorldPage()
        {
            // Ищем кнопку «helloButton».
            Element helloButton = Document.GetElementById("helloButton");
            // Задаем обработчик события нажатия этой кнопки.
            helloButton.AddEventListener("click", delegate
            {
                // Ищем текстовое поле ввода.
                InputElement nameTextBox = Document.GetElementById("nameTextBox").As<InputElement>();
                // Создаем объект XmlHttpRequest.
                XmlHttpRequest xhr = new XmlHttpRequest();
                // Открываем этот объект XmlHttpRequest, передав ему часть пути 
                // URL в который включили имя посетителя.
                xhr.Open(HttpVerb.Get, "/Home/World/" + nameTextBox.Value.EncodeUriComponent());
                // Задаем обработку события получения результата.
                xhr.OnReadyStateChange = delegate
                {
                    // Проверяем состояние загрузки результата запроса.
                    if (xhr.ReadyState == ReadyState.Loaded)
                    {
                        // Десериализуем полученную JSON-строку в объект JavaScript.
                        ServerResult data = (ServerResult) Script.Eval("(" + xhr.ResponseText + ")");
                        // Формируем строку, отображаемую посетителю.
                        string greeting = String.Format("{0}{1}...", data.Greeting, data.TimeStamp);
                        // Отображаем посетителю приветствие.
                        Script.Alert(greeting);
                    }
                };
                // Выполняем запрос.
                xhr.Send();
            }, false);
        }
    }
}
