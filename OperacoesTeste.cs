using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using System.Threading.Tasks;

namespace SuperCodigo.TestesUnidade
{
    public class OperacoesTeste
    {
        //'A' ESTA NO INDEX 3
        [Theory]
        [InlineData("PAULO CESAR OLIVEIRA", "A")]
        public void ObterPosicaoCaractereTST1(string cadeia, string caractere)
        {
            var position = Operacoes.ObterPosicaoCaractere(cadeia, caractere);


            Assert.Equal(2, position);
        }

        //Não existe o caractere "J"
        [Theory]
        [InlineData("CARACTERE INVALIDO", "J")]
        public void ObterPosicaoCaractereTST2(string cadeia, string caractere)
        {
            var position = Operacoes.ObterPosicaoCaractere(cadeia, caractere);

            Assert.Equal(-1, position);
        }

        //CADEIA > 20
        [Theory]
        [InlineData("TESTE PARA SABER SOBRE A CADEIA DE CARACTERES", "J")]
        public void ObterPosicaoCaractereTST3(string cadeia, string caractere)
        {

            ArgumentException ex = Assert.Throws<ArgumentException>(() => Operacoes.ObterPosicaoCaractere(cadeia, caractere));

            Assert.Equal(ConstantesOperacoes.CADEIA_CARACTERES_CADEIA_INVALIDA, ex.Message);
        }

        //CADEIA = 1
        [Theory]
        [InlineData("Paulo Cesar", "JJ")]
        public void ObterPosicaoCaractereTST4(string cadeia, string caractere)
        {

            ArgumentException ex = Assert.Throws<ArgumentException>(() => Operacoes.ObterPosicaoCaractere(cadeia, caractere));

            Assert.Equal(ConstantesOperacoes.CADEIA_CARACTERES_CARACTERE_INVALIDO, ex.Message);
        }

        //FIBONACCI TESTE 1
        [Theory]
        [InlineData(0)]
        public void ObterElementoFibonnaciTST1(int n)
        {
            ArgumentException ex = Assert.Throws<ArgumentException>(() => Operacoes.ObterElementoFibonnaci(n));

            Assert.Equal(ConstantesOperacoes.FIBONNACI_MAIOR_QUE_ZERO, ex.Message);
        }

        //FIBONACCI TESTE 2
        [Theory]
        [InlineData(2)]
        public void ObterElementoFibonnaciTST2(int n)
        {
            var fibo = Operacoes.ObterElementoFibonnaci(n);

            Assert.Equal(1, fibo);
        }

        //FIBONACCI TESTE 3
        [Theory]
        [InlineData(8)]
        public void ObterElementoFibonnaciTST3(int n)
        {
            var fibo = Operacoes.ObterElementoFibonnaci(n);

            Assert.Equal(21, fibo);
        }

        //TRIANGULO FALSE
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(2, 1, 10)]
        public void DeterminarTipoTrianguloTST1(int a, int b, int c)
        {
            var tipo = Operacoes.DeterminarTipoTriangulo(a, b, c);

            Assert.Equal("INEXISTENTE", tipo);
        }


        //TRIANGULO EQL
        [Theory]
        [InlineData(5, 5, 5)]
        public void DeterminarTipoTrianguloTST2(int a, int b, int c)
        {
            var tipo = Operacoes.DeterminarTipoTriangulo(a, b, c);

            Assert.Equal("EQUILATERO", tipo);
        }

        //TRIANGULO FALSE ISO
        [Theory]
        [InlineData(5, 5, 2)]
        [InlineData(5, 10, 10)]
        [InlineData(10, 5, 10)]
        public void DeterminarTipoTrianguloTST3(int a, int b, int c)
        {
            var tipo = Operacoes.DeterminarTipoTriangulo(a, b, c);

            Assert.Equal("ISOSCELES", tipo);
        }

        //TRIANGULO ESC
        [Theory]
        [InlineData(10, 12, 13)]

        public void DeterminarTipoTrianguloTST4(int a, int b, int c)
        {
            var tipo = Operacoes.DeterminarTipoTriangulo(a, b, c);

            Assert.Equal("ESCALENO", tipo);
        }
    }
}
