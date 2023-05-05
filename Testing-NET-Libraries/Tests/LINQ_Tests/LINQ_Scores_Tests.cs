using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_NET_Libraries.LINQ;
using Xunit;

namespace Testing_NET_Libraries.Tests.LINQ_Tests
{
    public class LINQ_Scores_Tests
    {
        private readonly LINQScoresOperations _sut = new LINQScoresOperations();

        [Fact]
        public void GetScoresGreaterThan50_ShouldReturnAllElementsGreaterThan50()
        {
            // Arrange
            _sut.Scores = new() { 22, 58, 56, 50, 100, 86, 33 };

            // Act
            List<int> scoresGreaterThan50 = _sut.getScoresGreaterThanFifty();


            // Assert
            foreach (var score in scoresGreaterThan50)
            {
                Assert.True(score > 50);
            }
        }

        [Fact]
        public void CheckThatBothScoresListAreTheSame_ShouldReturnTrueIfBothScoresListAreTheSame()
        {
            // Arrange
            _sut.Scores = new() { 22, 58, 56, 50, 100, 86, 33 };
            _sut.SecondaryScores = new() { 58, 25, 100 };

            // Act
            List<int> sameScores = _sut.compareSameNumbers();

            // Assert
            Assert.Equal(sameScores, new List<int>() {58, 100 });

        }

        [Fact]
        public void CheckThatScoresAreOrderedAscending_ShouldReturnTrueIfTheListWasOrderedAscending()
        {
            // Arrange
            _sut.Scores = new() { 22, 58, 56, 50, 100, 86, 33 };

            // Act
            List<int> scoresAscendingOrder = _sut.orderNumbersAsc();

            // Assert
            Assert.Equal(scoresAscendingOrder, new List<int> { 22, 33, 50, 56, 58, 86, 100 });
        }

        [Fact]
        public void CheckThatScoresAreOrderedDescending_ShouldReturnTrueIfTheListWasOrderedDescending()
        {
            // Arrange
            _sut.Scores = new() { 22, 58, 56, 50, 100, 86, 33 };

            // Act
            List<int> scoresDescendingOrder = _sut.orderNumbersDesc();

            // Assert
            Assert.Equal(scoresDescendingOrder, new List<int> { 100, 86, 58, 56, 50, 33, 22 });
        }
    }
}
