using NUnit.Framework;
//[TestFixture]
public class ProgramTests
{
    public ProgramTests()
    {
    }
    [SetUp]
    public void Setup()
    {
    }
    [Test]
    public void UniqueLettersAreUniqueLettersTest()
    {
        //var test1 = "abcdefghjiklmnopqrstuvwxyz"; // Expect True because all letters unique
        //Console.WriteLine(AreUniqueLetters(test1));
        Assert.That(UniqueLetters.TestAreUniqueLetters("abcdefghjiklmnopqrstuvwxyz"), Is.True);
        //var test2 = "abcdefghjiklanopqrstuvwxyz"; // Expect False because 'a' is repeated
        //Console.WriteLine(AreUniqueLetters(test2));
        Assert.That(UniqueLetters.TestAreUniqueLetters("abcdefghjiklanopqrstuvwxyz"), Is.False);
        //var test3 = "";
        //Console.WriteLine(AreUniqueLetters(test3)); // Expect True because its an empty string
        Assert.That(UniqueLetters.TestAreUniqueLetters(""), Is.True);
    }
    [Test]
    public void DisplaySumsDisplaySumPairsTest()
    {
        // DisplaySumPairs([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
        // Should show something like (order does not matter):
        // 6 4
        // 7 3
        // 8 2
        // 9 1 
        String[] expectedOutputs = [
            "6 4" + Environment.NewLine,
            "7 3" + Environment.NewLine,
            "8 2" + Environment.NewLine,
            "9 1" + Environment.NewLine];
        String[] expectedOutputsNotPresent = ["5"];
        using StringWriter firstStringWriter = new();
        Console.SetOut(firstStringWriter);
        Assert.DoesNotThrow(() => DisplaySums.TestDisplaySumPairs([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]));
        foreach (String expectedOutput in expectedOutputs)
            Assert.That(firstStringWriter.ToString(), Is.SupersetOf(expectedOutput));
        foreach (String expectedOutputNotPresent in expectedOutputsNotPresent)
            Assert.That(firstStringWriter.ToString(), Is.Not.SupersetOf(expectedOutputNotPresent));
        //DisplaySumPairs([-20, -15, -10, -5, 0, 5, 10, 15, 20]);
        // Should show something like (order does not matter):
        // 10 0
        // 15 -5
        // 20 -10
        expectedOutputs = [
            "10 0" + Environment.NewLine,
            "15 -5" + Environment.NewLine,
            "20 -10" + Environment.NewLine];
        expectedOutputsNotPresent = ["-20", "-15", "5"];
        using StringWriter secondStringWriter = new();
        Console.SetOut(secondStringWriter);
        Assert.DoesNotThrow(() => DisplaySums.TestDisplaySumPairs([-20, -15, -10, -5, 0, 5, 10, 15, 20]));
        foreach (String expectedOutput in expectedOutputs)
            Assert.That(secondStringWriter.ToString(), Is.SupersetOf(expectedOutput));
        foreach (String expectedOutputNotPresent in expectedOutputsNotPresent)
            Assert.That(secondStringWriter.ToString(), Is.Not.SupersetOf(expectedOutputNotPresent));
        //DisplaySumPairs([5, 11, 2, -4, 6, 8, -1]);
        // Should show something like (order does not matter):
        // 8 2
        // -1 11
        expectedOutputs = [
            "8 2" + Environment.NewLine,
            "-1 11" + Environment.NewLine];
        expectedOutputsNotPresent = ["5", "-4", "6"];
        using StringWriter thirdStringWriter = new();
        Console.SetOut(thirdStringWriter);
        Assert.DoesNotThrow(() => DisplaySums.TestDisplaySumPairs([5, 11, 2, -4, 6, 8, -1]));
        foreach (String expectedOutput in expectedOutputs)
            Assert.That(thirdStringWriter.ToString(), Is.SupersetOf(expectedOutput));
        foreach (String expectedOutputNotPresent in expectedOutputsNotPresent)
            Assert.That(thirdStringWriter.ToString(), Is.Not.SupersetOf(expectedOutputNotPresent));
    }
    [Test]
    public void BasketballTest()
    {
        String[] expectedOutputs = [
            "abramjo01" /*+ Environment.NewLine*/,
            "aubucch01",
            "bakerno01",
            "baltihe01",
            "barrjo01",
            "baumhfr01",
            "beckemo01",
            "beendha01",
            "biasaha01",
            "brighal01"];
        String[] expectedOutputsNotPresent = ["brindau01", "brownha01"];
        using StringWriter firstStringWriter = new();
        Console.SetOut(firstStringWriter);
        Assert.DoesNotThrow(() => Basketball.Run());
        foreach (String expectedOutput in expectedOutputs)
            Assert.That(firstStringWriter.ToString(), Is.SupersetOf(expectedOutput));
        foreach (String expectedOutputNotPresent in expectedOutputsNotPresent)
            Assert.That(firstStringWriter.ToString(), Is.Not.SupersetOf(expectedOutputNotPresent));
    }
    [Test]
    public void SolutionsUniqueLettersAreUniqueLettersTest()
    {
        //var test1 = "abcdefghjiklmnopqrstuvwxyz"; // Expect True because all letters unique
        //Console.WriteLine(AreUniqueLetters(test1));
        Assert.That(UniqueLettersSolution.TestAreUniqueLetters("abcdefghjiklmnopqrstuvwxyz"), Is.True);
        //var test2 = "abcdefghjiklanopqrstuvwxyz"; // Expect False because 'a' is repeated
        //Console.WriteLine(AreUniqueLetters(test2));
        Assert.That(UniqueLettersSolution.TestAreUniqueLetters("abcdefghjiklanopqrstuvwxyz"), Is.False);
        //var test3 = "";
        //Console.WriteLine(AreUniqueLetters(test3)); // Expect True because its an empty string
        Assert.That(UniqueLettersSolution.TestAreUniqueLetters(""), Is.True);
    }
    [Test]
    public void SolutionsDisplaySumsDisplaySumPairsTest()
    {
        // DisplaySumPairs([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
        // Should show something like (order does not matter):
        // 6 4
        // 7 3
        // 8 2
        // 9 1 
        String[] expectedOutputs = [
            "6 4" + Environment.NewLine,
            "7 3" + Environment.NewLine,
            "8 2" + Environment.NewLine,
            "9 1" + Environment.NewLine];
        String[] expectedOutputsNotPresent = ["5"];
        using StringWriter firstStringWriter = new();
        Console.SetOut(firstStringWriter);
        Assert.DoesNotThrow(() => DisplaySumsSolution.TestDisplaySumPairs([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]));
        foreach (String expectedOutput in expectedOutputs)
            Assert.That(firstStringWriter.ToString(), Is.SupersetOf(expectedOutput));
        foreach (String expectedOutputNotPresent in expectedOutputsNotPresent)
            Assert.That(firstStringWriter.ToString(), Is.Not.SupersetOf(expectedOutputNotPresent));
        //DisplaySumPairs([-20, -15, -10, -5, 0, 5, 10, 15, 20]);
        // Should show something like (order does not matter):
        // 10 0
        // 15 -5
        // 20 -10
        expectedOutputs = [
            "10 0" + Environment.NewLine,
            "15 -5" + Environment.NewLine,
            "20 -10" + Environment.NewLine];
        expectedOutputsNotPresent = ["-20", "-15", "5"];
        using StringWriter secondStringWriter = new();
        Console.SetOut(secondStringWriter);
        Assert.DoesNotThrow(() => DisplaySumsSolution.TestDisplaySumPairs([-20, -15, -10, -5, 0, 5, 10, 15, 20]));
        foreach (String expectedOutput in expectedOutputs)
            Assert.That(secondStringWriter.ToString(), Is.SupersetOf(expectedOutput));
        foreach (String expectedOutputNotPresent in expectedOutputsNotPresent)
            Assert.That(secondStringWriter.ToString(), Is.Not.SupersetOf(expectedOutputNotPresent));
        //DisplaySumPairs([5, 11, 2, -4, 6, 8, -1]);
        // Should show something like (order does not matter):
        // 8 2
        // -1 11
        expectedOutputs = [
            "8 2" + Environment.NewLine,
            "-1 11" + Environment.NewLine];
        expectedOutputsNotPresent = ["5", "-4", "6"];
        using StringWriter thirdStringWriter = new();
        Console.SetOut(thirdStringWriter);
        Assert.DoesNotThrow(() => DisplaySumsSolution.TestDisplaySumPairs([5, 11, 2, -4, 6, 8, -1]));
        foreach (String expectedOutput in expectedOutputs)
            Assert.That(thirdStringWriter.ToString(), Is.SupersetOf(expectedOutput));
        foreach (String expectedOutputNotPresent in expectedOutputsNotPresent)
            Assert.That(thirdStringWriter.ToString(), Is.Not.SupersetOf(expectedOutputNotPresent));
    }
    [Test]
    public void SolutionsBasketballTest()
    {
        String[] expectedOutputs = [
            "abramjo01" /*+ Environment.NewLine*/,
            "aubucch01",
            "bakerno01",
            "baltihe01",
            "barrjo01",
            "baumhfr01",
            "beckemo01",
            "beendha01",
            "biasaha01",
            "brighal01"];
        String[] expectedOutputsNotPresent = ["brindau01", "brownha01"];
        using StringWriter firstStringWriter = new();
        Console.SetOut(firstStringWriter);
        Assert.DoesNotThrow(() => BasketballSolution.Run());
        foreach (String expectedOutput in expectedOutputs)
            Assert.That(firstStringWriter.ToString(), Is.SupersetOf(expectedOutput));
        foreach (String expectedOutputNotPresent in expectedOutputsNotPresent)
            Assert.That(firstStringWriter.ToString(), Is.Not.SupersetOf(expectedOutputNotPresent));
    }
    [Test]
    public void TRMUniqueLettersAreUniqueLettersTest()
    {
        //var test1 = "abcdefghjiklmnopqrstuvwxyz"; // Expect True because all letters unique
        //Console.WriteLine(AreUniqueLetters(test1));
        Assert.That(UniqueLettersTRM.TestAreUniqueLetters("abcdefghjiklmnopqrstuvwxyz"), Is.True);
        //var test2 = "abcdefghjiklanopqrstuvwxyz"; // Expect False because 'a' is repeated
        //Console.WriteLine(AreUniqueLetters(test2));
        Assert.That(UniqueLettersTRM.TestAreUniqueLetters("abcdefghjiklanopqrstuvwxyz"), Is.False);
        //var test3 = "";
        //Console.WriteLine(AreUniqueLetters(test3)); // Expect True because its an empty string
        Assert.That(UniqueLettersTRM.TestAreUniqueLetters(""), Is.True);
    }
    [Test]
    public void TRMDisplaySumsDisplaySumPairsTest()
    {
        // DisplaySumPairs([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
        // Should show something like (order does not matter):
        // 6 4
        // 7 3
        // 8 2
        // 9 1 
        String[] expectedOutputs = [
            "6 4" + Environment.NewLine,
            "7 3" + Environment.NewLine,
            "8 2" + Environment.NewLine,
            "9 1" + Environment.NewLine];
        String[] expectedOutputsNotPresent = ["5"];
        using StringWriter firstStringWriter = new();
        Console.SetOut(firstStringWriter);
        Assert.DoesNotThrow(() => DisplaySumsTRM.TestDisplaySumPairs([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]));
        foreach (String expectedOutput in expectedOutputs)
            Assert.That(firstStringWriter.ToString(), Is.SupersetOf(expectedOutput));
        foreach (String expectedOutputNotPresent in expectedOutputsNotPresent)
            Assert.That(firstStringWriter.ToString(), Is.Not.SupersetOf(expectedOutputNotPresent));
        //DisplaySumPairs([-20, -15, -10, -5, 0, 5, 10, 15, 20]);
        // Should show something like (order does not matter):
        // 10 0
        // 15 -5
        // 20 -10
        expectedOutputs = [
            "10 0" + Environment.NewLine,
            "15 -5" + Environment.NewLine,
            "20 -10" + Environment.NewLine];
        expectedOutputsNotPresent = ["-20", "-15", "5"];
        using StringWriter secondStringWriter = new();
        Console.SetOut(secondStringWriter);
        Assert.DoesNotThrow(() => DisplaySumsTRM.TestDisplaySumPairs([-20, -15, -10, -5, 0, 5, 10, 15, 20]));
        foreach (String expectedOutput in expectedOutputs)
            Assert.That(secondStringWriter.ToString(), Is.SupersetOf(expectedOutput));
        foreach (String expectedOutputNotPresent in expectedOutputsNotPresent)
            Assert.That(secondStringWriter.ToString(), Is.Not.SupersetOf(expectedOutputNotPresent));
        //DisplaySumPairs([5, 11, 2, -4, 6, 8, -1]);
        // Should show something like (order does not matter):
        // 8 2
        // -1 11
        expectedOutputs = [
            "8 2" + Environment.NewLine,
            "-1 11" + Environment.NewLine];
        expectedOutputsNotPresent = ["5", "-4", "6"];
        using StringWriter thirdStringWriter = new();
        Console.SetOut(thirdStringWriter);
        Assert.DoesNotThrow(() => DisplaySumsTRM.TestDisplaySumPairs([5, 11, 2, -4, 6, 8, -1]));
        foreach (String expectedOutput in expectedOutputs)
            Assert.That(thirdStringWriter.ToString(), Is.SupersetOf(expectedOutput));
        foreach (String expectedOutputNotPresent in expectedOutputsNotPresent)
            Assert.That(thirdStringWriter.ToString(), Is.Not.SupersetOf(expectedOutputNotPresent));
    }
    [Test]
    public void TRMBasketballTest()
    {
        String[] expectedOutputs = [
            "abramjo01" /*+ Environment.NewLine*/,
            "aubucch01",
            "bakerno01",
            "baltihe01",
            "barrjo01",
            "baumhfr01",
            "beckemo01",
            "beendha01",
            "biasaha01",
            "brighal01"];
        String[] expectedOutputsNotPresent = ["brindau01", "brownha01"];
        using StringWriter firstStringWriter = new();
        Console.SetOut(firstStringWriter);
        Assert.DoesNotThrow(() => BasketballTRM.Run());
        foreach (String expectedOutput in expectedOutputs)
            Assert.That(firstStringWriter.ToString(), Is.SupersetOf(expectedOutput));
        foreach (String expectedOutputNotPresent in expectedOutputsNotPresent)
            Assert.That(firstStringWriter.ToString(), Is.Not.SupersetOf(expectedOutputNotPresent));
    }
}