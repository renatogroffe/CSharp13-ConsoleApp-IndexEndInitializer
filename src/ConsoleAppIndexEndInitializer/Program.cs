using ConsoleAppIndexEndInitializer.Models;
using System.Runtime.InteropServices;
using System.Text.Json;

Console.WriteLine("***** Testes com .NET 9 + C# 13 | Index from the end em initializer *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");
Console.WriteLine();

var copaFutebol = new TorneioEsportivo
{
    Nome = "Copa do Mundo de Futebol",
    UltimasEdicoes = {
        [0] = new Edicao { Ano = 2002, EquipeVencedora = "Brasil" },
        [1] = new Edicao { Ano = 2006, EquipeVencedora = "Italia" },
        [^1] = new Edicao { Ano = 2022, EquipeVencedora = "Argentina" },
        [^2] = new Edicao { Ano = 2018, EquipeVencedora = "Franca" },
        [^3] = new Edicao { Ano = 2014, EquipeVencedora = "Alemanha" },
        [^4] = new Edicao { Ano = 2010, EquipeVencedora = "Espanha" }
    }
};
Console.WriteLine($"Ultimos vencedores - {copaFutebol}");
Console.WriteLine(JsonSerializer.Serialize(copaFutebol,
    new JsonSerializerOptions { WriteIndented = true }));