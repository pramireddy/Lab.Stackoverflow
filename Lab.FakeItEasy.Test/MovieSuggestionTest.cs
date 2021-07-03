using FakeItEasy;
using System;
using Xunit;

// reference: https://blog.elmah.io/moq-vs-nsubstitute-vs-fakeiteasy-which-one-to-choose/

namespace Lab.FakeItEasy.Test
{
    public class MovieSuggestionTest
    {
        [Theory]
        [InlineData(false, 0)]
        [InlineData(false, 7.99)]
        [InlineData(true, 8)]
        [InlineData(true, 10)]
        public void Suggest(bool expected, double score)
        {
            // Arrange
            var movieScore = A.Fake<IMovieScore>();
            A.CallTo(() => movieScore.Score(A<string>.Ignored)).Returns(score);
            var movieSuggestion = new MovieSuggestion(movieScore);
            var title = Guid.NewGuid().ToString();

            // Act
            var isGood = movieSuggestion.IsGoodMovie(title);

            // Assert
            Assert.Equal(expected, isGood);
            A.CallTo(() => movieScore.Score(title)).MustHaveHappened();
        }

        [Theory]
        [InlineData(false, 0)]
        [InlineData(false, 7.99)]
        [InlineData(true, 8)]
        [InlineData(true, 10)]
        public void Suggest1(bool expected, double score)
        {
            // Arrange
            var movieScore = A.Fake<IMovieScore>();
            A.CallTo(() => movieScore.Score(A<string>.Ignored)).Returns(score);
            var movieSuggestion = new MovieSuggestion(movieScore);
            var title = Guid.NewGuid().ToString();

            // Act
            var isGood = movieSuggestion.IsGoodMovie(title);

            //Assert
            Assert.Equal(expected, isGood);
            A.CallTo(() => movieScore.Score(title)).MustHaveHappened();        }
    }
}
