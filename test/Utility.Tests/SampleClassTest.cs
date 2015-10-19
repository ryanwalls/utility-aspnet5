using Xunit;
using Utility;

namespace utilityTests {
  public class SampleClassTests {
    [Fact]
    public void passingTest() {      
      SampleClass sampleClass = new Utility.SampleClass();
      Assert.True(sampleClass.SampleMethod());
    }
  }
}
