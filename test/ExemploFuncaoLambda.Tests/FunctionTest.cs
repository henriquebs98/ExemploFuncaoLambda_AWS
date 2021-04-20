using Amazon.Lambda.TestUtilities;
using Xunit;

namespace ExemploFuncaoLambda.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestToUpperFunction()
        {
            var function = new Function();
            var context = new TestLambdaContext();
            var rua = function.FunctionHandler("01001000", context).Result;

            Assert.Equal("Pra�a da S�", rua);//01311-100
        }
    }
}
