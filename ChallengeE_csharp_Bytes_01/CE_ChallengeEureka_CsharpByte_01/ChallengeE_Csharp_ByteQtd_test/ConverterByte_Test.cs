using ChallengeE_Csharp_ByteQtd;

namespace ChallengeE_Csharp_ByteQtd_test
 

{
    public class ConverterByte_Test
    {
        [Theory]
        [InlineData(new string[] { "10", "300", "bbb", "20", "30", "--", "/", "50", "1000" },4)]
        [InlineData(new string[] { "10", "/50", "11", "20","1000","13", "[]" }, 4)]
        [InlineData(new string[] { "254", "200", "1"}, 3)]
        [InlineData(new string[] { "///", "$%", "#@#"}, 0)]
        [InlineData(new string[] { "255" }, 1)]
        public void CenarioTeste01Retorna(string[] valoresEntrada, int esperado)
        {
            //Arrange
            //passando via inlineData

            //Act
            ConversorBytes converter = new ConversorBytes();
            int resultado = converter.getQuantidade(valoresEntrada);

            //Asser
            Assert.Equal(esperado, resultado);
        }
   
    }

    public class ConverterByteFormatosErrados_Test
    {
        [Theory]
        [InlineData(new string[] { "10", "300", "bbb", "20", "30", "--", "/", "50", "1000" }, 3)]
        [InlineData(new string[] { "10", "/50", "11", "20", "1000", "13", "[]" }, 2)]
        [InlineData(new string[] { "254", "200", "1" }, 0)]
        [InlineData(new string[] { "///", "$%", "#@#" }, 3)]
        [InlineData(new string[] { "255" }, 0)]
        public void CenarioTeste01Retorna(string[] valoresEntrada, int esperado)
        {
            //Arrange
            //passando via inlineData

            //Act
            ConversorBytes converter = new ConversorBytes();
            int resultado = converter.getQuantidadeFormato(valoresEntrada);

            //Asser
            Assert.Equal(esperado, resultado);
        }

    }


    public class ConverterByteForaDaFaixa_Test
    {
        [Theory]
        [InlineData(new string[] { "10", "300", "bbb", "20", "30", "--", "/", "50", "1000" }, 2)]
        [InlineData(new string[] { "10", "/50", "11", "20", "1000", "13", "[]" }, 1)]
        [InlineData(new string[] { "254", "200", "1" }, 0)]
        [InlineData(new string[] { "///", "$%", "#@#" }, 0)]
        [InlineData(new string[] { "100000" }, 1)]
        public void CenarioTeste01Retorna(string[] valoresEntrada, int esperado)
        {
            //Arrange
            //passando via inlineData

            //Act
            ConversorBytes converter = new ConversorBytes();
            int resultado = converter.getQuantidadeForaDaFaixa(valoresEntrada);

            //Asser
            Assert.Equal(esperado, resultado);
        }

    }
}