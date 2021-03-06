﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

[assembly: CollectionBehavior(MaxParallelThreads = 6)]
//Esta decoração seta a quantidade maxima de threads que será usada para executar os testes.
//Por default o valor dela é igual a quantidade de cores virtuais que o processador da sua máquina possui. Que significa
//a potência máxima para execução
namespace ParallelFixtureTests.ComParalelismo
{
    //9 classes de teste diferentes, ou seja, 9 collections diferentes
    public class RandomTests
    {
        [Fact]
        public void RandomTest1()
        {
            Task.Delay(1000).GetAwaiter();
        }
    }
    public class OtherTest
    {
        [Fact]
        public void RandomTest2()
        {
            Task.Delay(1000).GetAwaiter();
        }
    }
    public class AnotherOneTest
    {
        [Fact]
        public void RandomTest3()
        {
            Task.Delay(1000).GetAwaiter();
        }
    }
    public class MoreRandomTest
    {
        [Fact]
        public void RandomTest4()
        {
            Thread.Sleep(1000);
        }
    }
    public class AnotherRandomTest
    {
        [Fact]
        public void RandomTest5()
        {
            Thread.Sleep(1000);
        }
    }
    public class TheLastOneTest
    {
        [Fact]
        public void RandomTest6()
        {
            Thread.Sleep(1000);
        }
    }
    public class TheLastOneTest1
    {
        [Fact]
        public void RandomTest6()
        {
            Thread.Sleep(1000);
        }
    }
    public class TheLastOneTest2
    {
        [Fact]
        public void RandomTest6()
        {
            Thread.Sleep(1000);
        }
    }
    public class TheLastOneTest3
    {
        [Fact]
        public void RandomTest6()
        {
            Thread.Sleep(1000);
        }
    }
}
