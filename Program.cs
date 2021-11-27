﻿using System;
using System.Collections.Generic;

using CursoCsharp.Fundamentos;

namespace CursoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", comenatarios.Executar},
                {"Variáveis e Constantes - Fundamentos", Variaveis.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar}
            });

            central.SelecionarEExecutar();
        }
    }
}