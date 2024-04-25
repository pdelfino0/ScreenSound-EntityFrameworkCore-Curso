﻿using ScreenSound.Menus;
using ScreenSound.Banco;
using ScreenSound.Modelos;

try
{
    var context = new ScreenSoundContext();
    var musicaDal = new MusicaDAL(context);

    Musica outraMusica = new Musica("Currents");

    musicaDal.Adicionar(outraMusica);

    Musica musicaRecuperada = musicaDal.RecuperarPeloNome("Currents");
    Console.WriteLine(musicaRecuperada);

    // var musicas = musicaDal.Listar();

    // foreach (Musica musica in musicas)
    // {
    //     Console.WriteLine(musica);
    // }
}

catch (Exception e)
{
    Console.WriteLine("Erro inesperado: " + e.Message);
}

// var context = new ScreenSoundContext();
// var artistaDal = new ArtistaDAL(context);
//
// Dictionary<int, Menu> opcoes = new();
// opcoes.Add(1, new MenuRegistrarArtista());
// opcoes.Add(2, new MenuRegistrarMusica());
// opcoes.Add(3, new MenuMostrarArtistas());
// opcoes.Add(4, new MenuMostrarMusicas());
// opcoes.Add(-1, new MenuSair());
//
// void ExibirLogo()
// {
//     Console.WriteLine(@"
//
// ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
// ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
// ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
// ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
// ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
// ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
// ");
//     Console.WriteLine("Boas vindas ao Screen Sound 3.0!");
// }
//
// void ExibirOpcoesDoMenu()
// {
//     ExibirLogo();
//     Console.WriteLine("\nDigite 1 para registrar um artista");
//     Console.WriteLine("Digite 2 para registrar a música de um artista");
//     Console.WriteLine("Digite 3 para mostrar todos os artistas");
//     Console.WriteLine("Digite 4 para exibir todas as músicas de um artista");
//     Console.WriteLine("Digite -1 para sair");
//
//     Console.Write("\nDigite a sua opção: ");
//     string opcaoEscolhida = Console.ReadLine()!;
//     int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
//
//     if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
//     {
//         Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
//         menuASerExibido.Executar(artistaDal);
//         if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
//     }
//     else
//     {
//         Console.WriteLine("Opção inválida");
//     }
// }
//
// ExibirOpcoesDoMenu();