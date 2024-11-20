using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Criando a lista de objetos
        List<Video> videos = new List<Video>
        {
            new Video { Nome = "Filme 1", Imagem = "https://via.placeholder.com/150", UrlVideo = "https://www.youtube.com/watch?v=dQw4w9WgXcQ" },
            new Video { Nome = "Filme 2", Imagem = "https://via.placeholder.com/150", UrlVideo = "https://www.youtube.com/watch?v=3JZ_D3ELwOQ" },
            new Video { Nome = "Filme 3", Imagem = "https://via.placeholder.com/150", UrlVideo = "https://www.youtube.com/watch?v=V-_O7nl0Ii0" }
        };

        // Criando o formulário principal
        Form form = new Form
        {
            Text = "Streaming App",
            Width = 1200,
            Height = 800
        };

        // Configurando o WebView2
        WebView2 webView = new WebView2
        {
            Dock = DockStyle.Fill
        };

        form.Controls.Add(webView);

        // Montando o HTML com base na lista de vídeos
        string htmlContent = GenerateHtml(videos);

        // Inicializando o WebView2
        webView.EnsureCoreWebView2Async().ContinueWith(task =>
        {
            webView.NavigateToString(htmlContent);
        });

        Application.Run(form);
    }

    // Função para gerar o HTML
    static string GenerateHtml(List<Video> videos)
    {
        StringBuilder html = new StringBuilder();

        html.Append(@"
<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <title>Streaming App</title>
    <style>
        body {
            margin: 0;
            font-family: Arial, sans-serif;
            background-color: #141414;
            color: #fff;
        }
        .container {
            display: flex;
            flex-wrap: wrap;
            justify-content: center;
            padding: 20px;
        }
        .card {
            background-color: #222;
            border-radius: 8px;
            margin: 10px;
            overflow: hidden;
            width: 200px;
            text-align: center;
            transition: transform 0.3s;
        }
        .card:hover {
            transform: scale(1.05);
        }
        .card img {
            width: 100%;
            height: 150px;
            object-fit: cover;
        }
        .card h3 {
            margin: 10px 0;
            font-size: 1.2em;
        }
        .card a {
            display: block;
            text-decoration: none;
            color: #00aaff;
            margin-bottom: 10px;
        }
    </style>
</head>
<body>
    <div class='container'>
");

        // Adicionando os vídeos dinamicamente
        foreach (var video in videos)
        {
            html.Append($@"
        <div class='card'>
            <img src='{video.Imagem}' alt='{video.Nome}' />
            <h3>{video.Nome}</h3>
            <a href='{video.UrlVideo}' target='_blank'>Assistir Agora</a>
        </div>
");
        }

        html.Append(@"
    </div>
</body>
</html>");

        return html.ToString();
    }
}

// Classe representando o objeto Video
class Video
{
    public string Nome { get; set; }
    public string Imagem { get; set; }
    public string UrlVideo { get; set; }
}
