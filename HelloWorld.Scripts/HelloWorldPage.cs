// HelloWorldPage.cs
//

namespace HelloWorld.Scripts
{
    using System;
    using System.Html;
    using System.Net;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// ������ ��������.
    /// </summary>
    [GlobalMethods]
    internal static class HelloWorldPage
    {
        /// <summary>
        /// �����������.
        /// </summary>
        static HelloWorldPage()
        {
            // ���� ������ �helloButton�.
            Element helloButton = Document.GetElementById("helloButton");
            // ������ ���������� ������� ������� ���� ������.
            helloButton.AddEventListener("click", delegate
            {
                // ���� ��������� ���� �����.
                InputElement nameTextBox = Document.GetElementById("nameTextBox").As<InputElement>();
                // ������� ������ XmlHttpRequest.
                XmlHttpRequest xhr = new XmlHttpRequest();
                // ��������� ���� ������ XmlHttpRequest, ������� ��� ����� ���� 
                // URL � ������� �������� ��� ����������.
                xhr.Open(HttpVerb.Get, "/Home/World/" + nameTextBox.Value.EncodeUriComponent());
                // ������ ��������� ������� ��������� ����������.
                xhr.OnReadyStateChange = delegate
                {
                    // ��������� ��������� �������� ���������� �������.
                    if (xhr.ReadyState == ReadyState.Loaded)
                    {
                        // ������������� ���������� JSON-������ � ������ JavaScript.
                        ServerResult data = (ServerResult) Script.Eval("(" + xhr.ResponseText + ")");
                        // ��������� ������, ������������ ����������.
                        string greeting = String.Format("{0}{1}...", data.Greeting, data.TimeStamp);
                        // ���������� ���������� �����������.
                        Script.Alert(greeting);
                    }
                };
                // ��������� ������.
                xhr.Send();
            }, false);
        }
    }
}
