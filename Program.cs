﻿using System;
using System.Collections.Generic;

using CursoCsharp.Fundamentos;
using CursoCsharp.EstruturasDeControle;
using CursoCsharp.ClassesEMetodos;
using CursoCsharp.Colecoes;
using CursoCsharp.OO;

namespace CursoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                #region "Fundamentos"
                    {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                    {"Comentários - Fundamentos", comenatarios.Executar},
                    {"Variáveis e Constantes - Fundamentos", Variaveis.Executar},
                    {"Inferência - Fundamentos", Inferencia.Executar},
                    {"Interpolação - Fundamentos", Interpolacao.Executar},
                    {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                    {"Lendo dados - Fundamentos", LendoDados.Executar},
                    {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                    {"Conversões - Fundamentos", Conversoes.Executar},
                    {"Operadores Aritiméticos - Fundamentos", OperadoresAritimeticos.Executar},
                    {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                    {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                    {"Operadores de Atribuições - Fundamentos", OperadoresAtribuicao.Executar},
                    {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                    {"Operadores Ternários - Fundamentos", OperadorTernario.Executar},
                #endregion
                
                #region Estruturas de controle
                    {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                    {"Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar},
                    {"Estrutura If/Else/If - Estruturas de Controle", EstruturaIfElseIF.Executar},
                    {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                    {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                    {"Estrutura DoWhile - Estruturas de Controle", EstruturaDoWhile.Executar},
                    {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                    {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar},
                    {"Utilizando o Break - Estruturas de Controle", UtilizandoBreak.Executar},
                    {"Utilizando o Continue - Estruturas de Controle", UtilizandoContinue.Executar},
                #endregion
                
                #region Classes e métodos
                    {"Membros - Classes e Métodos", Membros.Executar},
                    {"Construtores - Classes e Métodos", Construtores.Executar},
                    {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                    {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                    {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                    {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                    {"Params - Classes e Métodos", Params.Executar},
                    {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                    {"Get and Set - Classes e Métodos", GetSet.Executar},
                    {"Props - Classes e Métodos", Props.Executar},
                    {"Readonly - Classes e Métodos", Readonly.Executar},
                    {"Enum - Classes e Métodos", ExemploEnum.Executar},
                    {"Struct - Classes e Métodos", ExemploStruct.Executar},
                    {"Struct vs Classes - Classes e Métodos", StructVsClasse.Executar},
                    {"Valor vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                    {"Parâmetros por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                    {"Parâmetro com Valor Padrão - Classes e Métodos", ParametroPadrao.Executar},
                #endregion

                #region Coleções
                    {"Array - Coleções", Colecoes.Array.Executar},
                    {"List - Coleções", ColecoesList.Executar},
                    {"Array List - Coleções", ColecoesArrayList.Executar},
                    {"Set - Coleções", ColecoesSet.Executar},
                    {"Queue - Coleções", ColecoesQueue.Executar},
                    {"Igualdade - Coleções", Igualdade.Executar},
                    {"Stack - Coleções", ColecoesStack.Executar},
                    {"Dictionary - Coleções", ColecoesDictionary.Executar},
                #endregion

                #region Orientação a Objetos
                    {"Herança - OO", Heranca.Executar},
                    {"Construtor This- OO", ConstrutorThis.Executar},
                #endregion
            });

            central.SelecionarEExecutar();
        }
    }
}